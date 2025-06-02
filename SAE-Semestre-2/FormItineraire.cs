using Base_de_données;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormItineraire : Form
    {
        private List<Station> stations;
        private List<Ligne> lignes;
        private List<Correspondance> correspondances;
        public FormItineraire()
        {
            InitializeComponent();
            btnRechercheItin.Enabled = false;
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            FormConsultation formConsultation = new FormConsultation();
            formConsultation.Show();
            this.Hide();
        }

        private void btnConnexionAdmin_Click(object sender, EventArgs e)
        {
            FormConnexionAdmin formConnexionAdmin = new FormConnexionAdmin();
            formConnexionAdmin.Show();
            this.Hide();
        }

        private void FormItineraire_Load(object sender, EventArgs e)
        {
            BD.connexion();
            btnItineraire.Enabled = false;
            btnItineraire.BackColor = Color.DodgerBlue;
            btnItineraire.ForeColor = Color.White;
            btnItineraire.FlatStyle = FlatStyle.Flat;
            btnItineraire.FlatAppearance.BorderSize = 0;

            btnConsultation.Enabled = true;
            btnConsultation.BackColor = SystemColors.Control;
            btnConsultation.ForeColor = SystemColors.ControlText;
            btnConsultation.FlatStyle = FlatStyle.Standard;

            btnConnexionAdmin.Enabled = true;
            btnConnexionAdmin.BackColor = SystemColors.Control;
            btnConnexionAdmin.ForeColor = SystemColors.ControlText;
            btnConnexionAdmin.FlatStyle = FlatStyle.Standard;
        }

        private void InputChanged(object sender, EventArgs e)
        {
            bool departRempli = !string.IsNullOrWhiteSpace(txtDepartItin.Text);
            bool arriveeRemplie = !string.IsNullOrWhiteSpace(txtArriveeItin.Text);

            btnRechercheItin.Enabled = departRempli && arriveeRemplie;
        }

        private void btnRechercheItin_Click(object sender, EventArgs e)
        {
            string nomDepart = txtDepartItin.Text.Trim();
            string nomArrivee = txtArriveeItin.Text.Trim();

            if (string.IsNullOrEmpty(nomDepart) || string.IsNullOrEmpty(nomArrivee))
            {
                MessageBox.Show("Veuillez renseigner les deux stations.");
                return;
            }

            if (!BD.connexion())
            {
                MessageBox.Show("Erreur de connexion à la base de données.");
                return;
            }

            stations = BD.LectureStations();
            lignes = BD.LectureLignes();
            correspondances = BD.LectureCorrespondances(stations, lignes);
            BD.fermeture();

            Station? stationDepart = stations.FirstOrDefault(s => s.NomStation.Equals(nomDepart, StringComparison.OrdinalIgnoreCase));
            Station? stationArrivee = stations.FirstOrDefault(s => s.NomStation.Equals(nomArrivee, StringComparison.OrdinalIgnoreCase));

            if (stationDepart == null || stationArrivee == null)
            {
                MessageBox.Show("Station de départ ou d’arrivée introuvable.");
                return;
            }

            Dictionary<(int, int), int> dureesCorrespondances = new Dictionary<(int, int), int>();
            foreach (var c in correspondances)
            {
                int duree = (int)(c.HoraireArr - c.HoraireDep).TotalMinutes;
                if (duree > 0)
                {
                    dureesCorrespondances[(c.StationA.IdStation, c.StationB.IdStation)] = duree;
                    dureesCorrespondances[(c.StationB.IdStation, c.StationA.IdStation)] = duree;
                }
            }

            Dictionary<int, int> idToIndex = new Dictionary<int, int>();
            Dictionary<int, int> indexToId = new Dictionary<int, int>();
            for (int i = 0; i < stations.Count; i++)
            {
                idToIndex[stations[i].IdStation] = i;
                indexToId[i] = stations[i].IdStation;
            }

            List<Algo_Dijkstra_Station> graphStations = new List<Algo_Dijkstra_Station>();
            foreach (Station s in stations)
            {
                Dictionary<int, int> voisins = new Dictionary<int, int>();

                foreach (var autreStation in stations)
                {
                    if (s.IdStation != autreStation.IdStation &&
                        dureesCorrespondances.TryGetValue((s.IdStation, autreStation.IdStation), out int duree))
                    {
                        int voisinIndex = idToIndex[autreStation.IdStation];
                        voisins[voisinIndex] = duree;
                    }
                }

                graphStations.Add(new Algo_Dijkstra_Station(idToIndex[s.IdStation], s.NomStation, voisins));
            }

            Matrice_de_station matrice = new Matrice_de_station(graphStations);
            Algo_Dijkstra dijkstra = new Algo_Dijkstra(matrice.Matrice);

            int indexDepart = idToIndex[stationDepart.IdStation];
            int indexArrivee = idToIndex[stationArrivee.IdStation];

            Algo_Dijkstra_Station algoDepart = graphStations[indexDepart];
            dijkstra.CalculerCheminMin(algoDepart);

            var previous = typeof(Algo_Dijkstra)
                .GetField("previous", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.GetValue(dijkstra) as int[];

            if (previous == null || previous[indexArrivee] == -1)
            {
                MessageBox.Show("Aucun chemin trouvé entre les deux stations.");
                return;
            }

            List<Station> cheminStations = new List<Station>();
            int current = indexArrivee;
            while (current != -1)
            {
                int realId = indexToId[current];
                cheminStations.Insert(0, stations.First(s => s.IdStation == realId));
                current = previous[current];
            }

            int heure = (int)numHeureDepItin.Value;
            int minute = (int)numMinuteDepItin.Value;

            TimeSpan heureActuelle = new TimeSpan(heure, minute, 0);

            flpAffichageItin.Controls.Clear();

            for (int i = 0; i < cheminStations.Count; i++)
            {
                Station station = cheminStations[i];

                Label label = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.DarkBlue,
                    Text = $"{heureActuelle:hh\\:mm} - {station.NomStation}"
                };
                flpAffichageItin.Controls.Add(label);

                if (i < cheminStations.Count - 1)
                {
                    var corresp = correspondances.FirstOrDefault(c =>
                        (c.StationA.IdStation == station.IdStation && c.StationB.IdStation == cheminStations[i + 1].IdStation) ||
                        (c.StationB.IdStation == station.IdStation && c.StationA.IdStation == cheminStations[i + 1].IdStation));

                    if (corresp != null)
                    {
                        TimeSpan duree = corresp.HoraireArr - corresp.HoraireDep;
                        heureActuelle += duree;

                        Label arrow = new Label
                        {
                            AutoSize = true,
                            Text = "->",
                            Font = new Font("Segoe UI", 14)
                        };
                        flpAffichageItin.Controls.Add(arrow);
                    }
                }
            }
        }
    }
}


