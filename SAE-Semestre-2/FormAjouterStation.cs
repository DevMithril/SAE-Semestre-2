using Base_de_données;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormAjouterStation : Form
    {
        private List<Station> stations;

        private List<Station> stationsAdjacentes = new List<Station>();

        public FormAjouterStation()
        {
            InitializeComponent();
        }

        private void FormAjouterStation_Load(object sender, EventArgs e)
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

            btnAjouter.Enabled = false;
            btnAjouter.BackColor = Color.DodgerBlue;
            btnAjouter.ForeColor = Color.White;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.FlatAppearance.BorderSize = 0;

            btnModifier.Enabled = true;
            btnModifier.BackColor = SystemColors.Control;
            btnModifier.ForeColor = SystemColors.ControlText;
            btnModifier.FlatStyle = FlatStyle.Standard;

            btnSupprimer.Enabled = true;
            btnSupprimer.BackColor = SystemColors.Control;
            btnSupprimer.ForeColor = SystemColors.ControlText;
            btnSupprimer.FlatStyle = FlatStyle.Standard;

            txtNomNouvelleStation.Text = "";
            btnEnregistrerNouvelleStation.Enabled = false;
            btnValiderStationAdjacente.Enabled = false;

            if (BD.connexion())
            {
                stations = BD.LectureStations();
                BD.fermeture();

                cbxStationAdjacente.DataSource = stations;
                cbxStationAdjacente.DisplayMember = "NomStation";
                cbxStationAdjacente.SelectedIndex = -1;
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

        private void txtNomNouvelleStation_TextChanged(object sender, EventArgs e)
        {
            btnEnregistrerNouvelleStation.Enabled = !string.IsNullOrWhiteSpace(txtNomNouvelleStation.Text);
        }

        private void cbxStationAdjacente_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnValiderStationAdjacente.Enabled = cbxStationAdjacente.SelectedIndex != -1 && stationsAdjacentes.Count < 2;
        }

        private void btnValiderStationAdjacente_Click(object sender, EventArgs e)
        {
            if (cbxStationAdjacente.SelectedIndex == -1)
                return;

            Station selected = (Station)cbxStationAdjacente.SelectedItem;

            if (stationsAdjacentes.Contains(selected))
            {
                MessageBox.Show("Cette station est déjà ajoutée en station adjacente.");
                return;
            }

            if (stationsAdjacentes.Count >= 2)
            {
                MessageBox.Show("Vous ne pouvez ajouter que 2 stations adjacentes.");
                btnValiderStationAdjacente.Enabled = false;
                return;
            }

            stationsAdjacentes.Add(selected);
            cbxStationAdjacente.SelectedIndex = -1;

            btnValiderStationAdjacente.Enabled = stationsAdjacentes.Count < 2;
        }

        private void btnEnregistrerNouvelleStation_Click(object sender, EventArgs e)
        {
            string nomStation = txtNomNouvelleStation.Text.Trim();

            if (stations.Any(s => s.NomStation.Equals(nomStation, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Une station avec ce nom existe déjà.");
                return;
            }

            Station nouvelleStation = new Station(0, nomStation);

            if (BD.connexion())
            {
                BD.AjouterStation(nouvelleStation);
                stations = BD.LectureStations();

                Station stationAjoutee = stations.FirstOrDefault(s => s.NomStation.Equals(nomStation, StringComparison.OrdinalIgnoreCase));

                if (stationAjoutee != null)
                {
                    foreach (var adj in stationsAdjacentes)
                    {
                        BD.AjouterCorrespondance(
                            new Correspondance(
                                stationAjoutee,
                                adj,
                                TimeSpan.Zero,
                                TimeSpan.Zero,
                                new Ligne(1, "Noire", "Ligne par défaut")
                            )
                        );
                    }
                }

                BD.fermeture();

                MessageBox.Show($"La station \"{nomStation}\" a bien été ajoutée.");

                txtNomNouvelleStation.Text = "";
                stationsAdjacentes.Clear();
                btnValiderStationAdjacente.Enabled = false;
            }
            else
            {
                MessageBox.Show("Erreur de connexion à la base de données.");
            }
        }
    }
}
