using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Base_de_données;

namespace SAE_Semestre_2
{
    public partial class FormModifierStation : Form
    {
        private List<Station> stations = new List<Station>();

        private class StationItem
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public Station ObjetStation { get; set; }

            public override string ToString() => Nom;
        }

        public FormModifierStation()
        {
            InitializeComponent();
        }

        private void FormModifierStation_Load(object sender, EventArgs e)
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

            btnModifier.Enabled = false;
            btnModifier.BackColor = Color.DodgerBlue;
            btnModifier.ForeColor = Color.White;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.FlatAppearance.BorderSize = 0;

            btnAjouter.Enabled = true;
            btnAjouter.BackColor = SystemColors.Control;
            btnAjouter.ForeColor = SystemColors.ControlText;
            btnAjouter.FlatStyle = FlatStyle.Standard;

            btnSupprimer.Enabled = true;
            btnSupprimer.BackColor = SystemColors.Control;
            btnSupprimer.ForeColor = SystemColors.ControlText;
            btnSupprimer.FlatStyle = FlatStyle.Standard;

            btnRenommerStation.Enabled = false;

            ChargerStations();

            txtNouveauNomStation.Text = "";
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

        private void ChargerStations()
        {
            if (BD.connexion())
            {
                cbxNomStation.DataSource = null;
                List<Station> stations = BD.LectureStations();

                var bindingList = stations.Select(s => new StationItem
                {
                    Id = s.IdStation,
                    Nom = s.NomStation,
                    ObjetStation = s
                }).ToList();

                cbxNomStation.DataSource = bindingList;
                cbxNomStation.DisplayMember = "Nom";
                cbxNomStation.ValueMember = "Id";

                BD.fermeture();
            }
        }

        private void VerifierChamps()
        {
            btnRenommerStation.Enabled = (cbxNomStation.SelectedItem != null && !string.IsNullOrWhiteSpace(txtNouveauNomStation.Text));
        }

        private void cbxNomStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNomStation.SelectedItem is StationItem selectedItem)
            {
                txtNouveauNomStation.Text = selectedItem.Nom;
                btnRenommerStation.Enabled = !string.IsNullOrWhiteSpace(txtNouveauNomStation.Text);
            }

            VerifierChamps();
        }

        private void txtNouveauNomStation_TextChanged(object sender, EventArgs e)
        {
            VerifierChamps();
        }

        private void btnRenommerStation_Click(object sender, EventArgs e)
        {
            if (cbxNomStation.SelectedItem is not StationItem selectedItem)
            {
                MessageBox.Show("Veuillez sélectionner une station.");
                return;
            }

            string nouveauNom = txtNouveauNomStation.Text.Trim();
            if (string.IsNullOrEmpty(nouveauNom))
            {
                MessageBox.Show("Veuillez entrer un nouveau nom.");
                return;
            }

            Station stationSelectionnee = selectedItem.ObjetStation;
            Station stationModifiee = new Station(stationSelectionnee.IdStation, nouveauNom);

            if (BD.connexion())
            {
                BD.ModifierStation(stationModifiee);
                BD.fermeture();

                MessageBox.Show("Station renommée avec succès.");
                ChargerStations();
                txtNouveauNomStation.Clear();
            }
            else
            {
                MessageBox.Show("Connexion à la base de données échouée.");
            }
        }
    }
}
