using Base_de_données;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormSupprimerStation : Form
    {
        private List<Station> stations;

        public FormSupprimerStation()
        {
            InitializeComponent();
        }

        private void FormSupprimerStation_Load(object sender, EventArgs e)
        {
            btnConsultation.Enabled = true;
            btnConsultation.BackColor = SystemColors.Control;
            btnConsultation.ForeColor = SystemColors.ControlText;
            btnConsultation.FlatStyle = FlatStyle.Standard;

            btnItineraire.Enabled = true;
            btnItineraire.BackColor = SystemColors.Control;
            btnItineraire.ForeColor = SystemColors.ControlText;
            btnItineraire.FlatStyle = FlatStyle.Standard;

            btnConnexionAdmin.Enabled = false;
            btnConnexionAdmin.BackColor = Color.DodgerBlue;
            btnConnexionAdmin.ForeColor = Color.White;
            btnConnexionAdmin.FlatStyle = FlatStyle.Flat;
            btnConnexionAdmin.FlatAppearance.BorderSize = 0;

            btnSupprimer.Enabled = false;
            btnSupprimer.BackColor = Color.DodgerBlue;
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            btnSupprimer.FlatAppearance.BorderSize = 0;

            btnModifier.Enabled = true;
            btnModifier.BackColor = SystemColors.Control;
            btnModifier.ForeColor = SystemColors.ControlText;
            btnModifier.FlatStyle = FlatStyle.Standard;

            btnAjouter.Enabled = true;
            btnAjouter.BackColor = SystemColors.Control;
            btnAjouter.ForeColor = SystemColors.ControlText;
            btnAjouter.FlatStyle = FlatStyle.Standard;

            txtNomStationSuppr.Text = "";
            btnSupprimerStation.Enabled = false;

            if (BD.connexion())
            {
                stations = BD.LectureStations();
                BD.fermeture();
            }
            else
            {
                MessageBox.Show("Connexion à la base de données échouée.");
                stations = new List<Station>();
            }
        }

        private void btnItineraire_Click(object sender, EventArgs e)
        {
            new FormItineraire().Show();
            Close();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            new FormConsultation().Show();
            Close();
        }

        private void btnConnexionAdmin_Click(object sender, EventArgs e)
        {
            new FormConnexionAdmin().Show();
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new FormAjouter().Show();
            Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            new FormModifier().Show();
            Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            new FormSupprimer().Show();
            Close();
        }

        private void txtNomStationSuppr_TextChanged(object sender, EventArgs e)
        {
            btnSupprimerStation.Enabled = !string.IsNullOrWhiteSpace(txtNomStationSuppr.Text);
        }

        private void btnSupprimerStation_Click(object sender, EventArgs e)
        {
            if (!BD.connexion())
            {
                MessageBox.Show("Impossible de se connecter à la base de données");
                return;
            }

            string nomStation = txtNomStationSuppr.Text.Trim();

            var stations = BD.LectureStations();
            var lignes = BD.LectureLignes();
            var correspondances = BD.LectureCorrespondances(stations, lignes);

            Station stationASupprimer = stations
                .Find(s => s.NomStation.Equals(nomStation, StringComparison.OrdinalIgnoreCase));

            if (stationASupprimer != null)
            {
                foreach (var c in correspondances.Where(c => c.StationA.IdStation == stationASupprimer.IdStation || c.StationB.IdStation == stationASupprimer.IdStation).ToList())
                {
                    BD.SupprimerCorrespondance(c);
                }

                BD.SupprimerStation(stationASupprimer.IdStation);
                MessageBox.Show("Suppression réussie");
            }
            else
            {
                MessageBox.Show("Station non trouvée");
            }

            BD.fermeture();
        }

    }
}
