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

        // méthode appelée à chaque changement dans les champs de saisie départ/arrivée
        private void InputChanged(object sender, EventArgs e)
        {
            bool departRempli = !string.IsNullOrWhiteSpace(txtDepartItin.Text);
            bool arriveeRemplie = !string.IsNullOrWhiteSpace(txtArriveeItin.Text);


            btnRechercheItin.Enabled = departRempli && arriveeRemplie;
        }

        //fonction de recherche pour le bouton itinéraire
        private void btnRechercheItin_Click(object sender, EventArgs e)
        {
            string nomDepart = txtDepartItin.Text.Trim();
            string nomArrivee = txtArriveeItin.Text.Trim();

            //on vérifie la connexion à la base et les champs
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

            //charge les données depuis la base
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

            //On crée un dictionnaire qui contient les durées des correspondances entre les stations
            Dictionary<(int, int), int> dureesCorrespondances = new Dictionary<(int, int), int>();
            foreach (var c in correspondances)
            {
                //conversion des horaires en chaîne au format Heures:Minutes et calcul de la durée entre départ et arrivée
                string heureDepStr = $"{c.HoraireDep.Hours}h{c.HoraireDep.Minutes:D2}";
                string heureArrStr = $"{c.HoraireArr.Hours}h{c.HoraireArr.Minutes:D2}";
                CalculTemps calcul = new CalculTemps(heureDepStr, heureArrStr);
                int duree = calcul.CalculerDifference();

                if (duree > 0)
                {
                    dureesCorrespondances[(c.StationA.IdStation, c.StationB.IdStation)] = duree;
                    dureesCorrespondances[(c.StationB.IdStation, c.StationA.IdStation)] = duree;
                }
            }

            //On crée d'autres dictionnaires de correspondances entre les id de stations et les indices utilisés dans le graphe
            Dictionary<int, int> idToIndex = new Dictionary<int, int>();
            Dictionary<int, int> indexToId = new Dictionary<int, int>();
            for (int i = 0; i < stations.Count; i++)
            {
                idToIndex[stations[i].IdStation] = i;
                indexToId[i] = stations[i].IdStation;
            }

            //On crée un graphe sous forme d'une liste de noeuds avec les voisins et les distances
            List<Algo_Dijkstra_Station> graphStations = new List<Algo_Dijkstra_Station>();

            //Fonction pour chercher les voisins avec les durées correspondantes
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

            //On crée la matrice de distance et l'initialisation de l'algo de Dijkstra
            Matrice_de_station matrice = new Matrice_de_station(graphStations);
            Algo_Dijkstra dijkstra = new Algo_Dijkstra(matrice.Matrice);

            int indexDepart = idToIndex[stationDepart.IdStation];
            int indexArrivee = idToIndex[stationArrivee.IdStation];

            Algo_Dijkstra_Station algoDepart = graphStations[indexDepart];
            dijkstra.CalculerCheminMin(algoDepart);

            var previous = typeof(Algo_Dijkstra)
                .GetField("previous", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.GetValue(dijkstra) as int[];

            // On vérifie si un chemin existe
            if (previous == null || previous[indexArrivee] == -1)
            {
                MessageBox.Show("Aucun chemin trouvé entre les deux stations.");
                return;
            }

            //on reconstruit le chemin des stations à partir du tableau previous
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

            //Boucle pour parcourir les stations du chemin afin d'afficher les étapes avec horaires de départ et d'arrivée
            for (int i = 0; i < cheminStations.Count - 1; i++)
            {
                Station station = cheminStations[i];
                Station prochaineStation = cheminStations[i + 1];

                //Ici on recherche les correspondances possibles entre la station courante et la suivante
                var correspondancesPossibles = correspondances
                    .Where(c =>
                        (c.StationA.IdStation == station.IdStation && c.StationB.IdStation == prochaineStation.IdStation) ||
                        (c.StationB.IdStation == station.IdStation && c.StationA.IdStation == prochaineStation.IdStation))
                    .Where(c => c.HoraireDep >= heureActuelle)
                    .OrderBy(c => c.HoraireDep)
                    .ToList();

                //Messages d'erreurs en cas de non résultat
                if (correspondancesPossibles.Count == 0)
                {
                    if (i == 0)
                    {
                        MessageBox.Show($"Aucun train ne part de {station.NomStation} vers {prochaineStation.NomStation} après {heureActuelle:hh\\:mm}. Veuillez choisir une heure plus tôt ou vérifier les horaires.");
                    }
                    else
                    {
                        MessageBox.Show($"Aucune correspondance trouvée après {heureActuelle:hh\\:mm} entre {station.NomStation} et {prochaineStation.NomStation}.");
                    }
                    return;
                }


                var correspondanceChoisie = correspondancesPossibles.First();

                //On affiche l'heure de départ de la correspondance et la station actuelle
                flpAffichageItin.Controls.Add(new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.DarkBlue,
                    Text = $"{correspondanceChoisie.HoraireDep:hh\\:mm} - {station.NomStation}"
                });

                //On affiche les horaires de départ et d'arrivée du train
                flpAffichageItin.Controls.Add(new Label
                {
                    Text = $"Train de {correspondanceChoisie.HoraireDep:hh\\:mm} à {correspondanceChoisie.HoraireArr:hh\\:mm}",
                    AutoSize = true,
                    ForeColor = Color.DarkGreen,
                    Font = new Font("Segoe UI", 9, FontStyle.Italic)
                });

                //Ajout d'une flèche
                Label arrow = new Label
                {
                    AutoSize = true,
                    Text = "->",
                    Font = new Font("Segoe UI", 14),
                    ForeColor = Color.Gray
                };
                flpAffichageItin.Controls.Add(arrow);

                heureActuelle = correspondanceChoisie.HoraireArr;
            }

            // Affiche la dernière station avec l'heure d'arrivée finale
            Station derniereStation = cheminStations.Last();
            flpAffichageItin.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Text = $"{heureActuelle:hh\\:mm} - {derniereStation.NomStation}"
            });
        }
    }
}