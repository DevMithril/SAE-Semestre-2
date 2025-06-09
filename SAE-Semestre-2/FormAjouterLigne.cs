using Base_de_données;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormAjouterLigne : Form
    {
        private List<Station> stations;
        private List<Ligne> lignes;
        private List<Correspondance> correspondances;

        public FormAjouterLigne()
        {
            InitializeComponent();
            this.FormClosed += FormAjouterLigne_FormClosed;
        }

        private void FormAjouterLigne_Load(object sender, EventArgs e)
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

            if (!BD.connexion())
            {
                MessageBox.Show("Impossible de se connecter à la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            btnEnregistrerNouvelleLigne.Enabled = false;

            stations = BD.LectureStations();
            lignes = BD.LectureLignes();
            correspondances = BD.LectureCorrespondances(stations, lignes);

            cbxNomStationNouvelleLigne.DataSource = stations;
            cbxNomStationNouvelleLigne.DisplayMember = "NomStation";
            cbxNomStationNouvelleLigne.ValueMember = "IdStation";
            cbxNomStationNouvelleLigne.SelectedIndex = -1;

            cbxNomStationNouvelleLigne.SelectedIndexChanged += CbxNomStationNouvelleLigne_SelectedIndexChanged;
            cbxNomStationNouvelleLigne.SelectedIndexChanged += Champs_TextChanged;
            txtNomNouvelleLigne.TextChanged += Champs_TextChanged;
            txtCouleurNouvelleLigne.TextChanged += Champs_TextChanged;
        }

        private void FormAjouterLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            BD.fermeture();
        }

        private void CbxNomStationNouvelleLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHorairesStationNouvelleLigne.Items.Clear();

            if (cbxNomStationNouvelleLigne.SelectedItem is Station station)
            {
                var horaires = correspondances
                    .Where(c => c.StationA.IdStation == station.IdStation)
                    .Select(c => c.HoraireDep)
                    .Distinct()
                    .OrderBy(t => t);

                foreach (var horaire in horaires)
                {
                    lstHorairesStationNouvelleLigne.Items.Add(horaire.ToString(@"hh\:mm"));
                }
            }

            ActiverBoutonEnregistrer();
        }

        private void Champs_TextChanged(object sender, EventArgs e)
        {
            ActiverBoutonEnregistrer();
        }

        private void ActiverBoutonEnregistrer()
        {
            btnEnregistrerNouvelleLigne.Enabled =
                !string.IsNullOrWhiteSpace(txtNomNouvelleLigne.Text) &&
                !string.IsNullOrWhiteSpace(txtCouleurNouvelleLigne.Text) &&
                cbxNomStationNouvelleLigne.SelectedIndex != -1;
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

        private void btnEnregistrerNouvelleLigne_Click(object sender, EventArgs e)
        {
            string nom = txtNomNouvelleLigne.Text.Trim();
            string couleur = txtCouleurNouvelleLigne.Text.Trim();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(couleur) || cbxNomStationNouvelleLigne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs et sélectionner une station.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ligne nouvelleLigne = new Ligne(0, couleur, nom);

            try
            {
                BD.AjouterLigne(nouvelleLigne);
                MessageBox.Show("Ligne ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomNouvelleLigne.Clear();
                txtCouleurNouvelleLigne.Clear();
                cbxNomStationNouvelleLigne.SelectedIndex = -1;
                lstHorairesStationNouvelleLigne.Items.Clear();
                btnEnregistrerNouvelleLigne.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la ligne : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
