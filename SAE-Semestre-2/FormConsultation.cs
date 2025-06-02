using Base_de_données;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormConsultation : Form
    {
        private List<Station> stations;
        private List<Ligne> lignes;
        private List<Correspondance> correspondances;
        private Ligne ligneSelectionnee = null;

        public FormConsultation()
        {
            InitializeComponent();
        }

        private void FormConsultation_Load(object sender, EventArgs e)
        {
            if (!BD.connexion())
            {
                MessageBox.Show("Erreur de connexion à la base de données.");
                return;
            }

            stations = BD.LectureStations();
            lignes = BD.LectureLignes();
            correspondances = BD.LectureCorrespondances(stations, lignes);

            BD.fermeture();

            cbxStationConsult.Items.Clear();
            foreach (var station in stations)
            {
                cbxStationConsult.Items.Add(station.NomStation);
            }

            cbxLigneConsult.Items.Clear();
            cbxLigneConsult.Items.Add("Toutes les lignes");
            foreach (var ligne in lignes)
            {
                cbxLigneConsult.Items.Add(ligne.NomLigne);
            }
            cbxLigneConsult.SelectedIndex = 0;

            if (cbxStationConsult.Items.Count > 0)
            {
                cbxStationConsult.SelectedIndex = 0;
            }

            btnConsultation.Enabled = false;
            btnConsultation.BackColor = Color.DodgerBlue;
            btnConsultation.ForeColor = Color.White;
            btnConsultation.FlatStyle = FlatStyle.Flat;
            btnConsultation.FlatAppearance.BorderSize = 0;

            btnItineraire.Enabled = true;
            btnItineraire.BackColor = SystemColors.Control;
            btnItineraire.ForeColor = SystemColors.ControlText;
            btnItineraire.FlatStyle = FlatStyle.Standard;

            btnConnexionAdmin.Enabled = true;
            btnConnexionAdmin.BackColor = SystemColors.Control;
            btnConnexionAdmin.ForeColor = SystemColors.ControlText;
            btnConnexionAdmin.FlatStyle = FlatStyle.Standard;

        }

        private void cbxLigneConsult_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ligneChoisie = cbxLigneConsult.SelectedItem.ToString();

            if (ligneChoisie == "Toutes les lignes")
            {
                ligneSelectionnee = null;
            }
            else
            {
                ligneSelectionnee = lignes.FirstOrDefault(l => l.NomLigne == ligneChoisie);
            }

            if (cbxStationConsult.SelectedItem != null)
                cbxStationConsult_SelectedIndexChanged(sender, e);
        }

        private void cbxStationConsult_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHorairesConsult.Items.Clear();

            if (cbxStationConsult.SelectedItem == null)
                return;

            string nomStation = cbxStationConsult.SelectedItem.ToString();
            Station stationChoisie = stations.FirstOrDefault(s => s.NomStation == nomStation);

            if (stationChoisie == null)
                return;

            if (!BD.connexion())
            {
                MessageBox.Show("Erreur de connexion à la base de données.");
                return;
            }

            correspondances = BD.LectureCorrespondances(stations, lignes);
            BD.fermeture();

            var resultats = correspondances
                .Where(c => c.StationA.IdStation == stationChoisie.IdStation &&
                            (ligneSelectionnee == null || c.Ligne.IdLigne == ligneSelectionnee.IdLigne))
                .OrderBy(c => c.HoraireDep)
                .ToList();

            if (resultats.Count == 0)
            {
                lstHorairesConsult.Items.Add("Aucun départ trouvé pour cette station.");
                return;
            }

            foreach (var c in resultats)
            {
                string ligneNom = c.Ligne.NomLigne;
                string destination = c.StationB.NomStation;
                string horaire = c.HoraireDep.ToString(@"hh\:mm");

                lstHorairesConsult.Items.Add($"{horaire} → {destination} ({ligneNom})");
            }
        }

        private void btnItineraire_Click(object sender, EventArgs e)
        {
            FormItineraire form = new FormItineraire();
            form.Show();
            this.Hide();
        }

        private void btnConnexionAdmin_Click(object sender, EventArgs e)
        {
            FormConnexionAdmin form = new FormConnexionAdmin();
            form.Show();
            this.Hide();
        }
    }
}
