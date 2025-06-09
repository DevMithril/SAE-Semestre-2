using Base_de_données;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormSupprimerLigne : Form
    {
        private List<Ligne> lignes;

        public FormSupprimerLigne()
        {
            InitializeComponent();
        }

        private void FormSupprimerLigne_Load(object sender, EventArgs e)
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

            BD.connexion();

            lignes = BD.LectureLignes();

            cbxNomLigneSuppr.DataSource = lignes;
            cbxNomLigneSuppr.DisplayMember = "NomLigne";
            cbxNomLigneSuppr.ValueMember = "IdLigne";
            cbxNomLigneSuppr.SelectedIndex = -1;

            cbxNomLigneSuppr.SelectedIndexChanged += cbxNomLigneSuppr_SelectedIndexChanged;
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

        private void cbxNomLigneSuppr_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupprimerLigne.Enabled = cbxNomLigneSuppr.SelectedItem != null;
        }

        private void btnSupprimerLigne_Click(object sender, EventArgs e)
        {
            if (cbxNomLigneSuppr.SelectedItem is Ligne ligneASupprimer)
            {
                var confirmation = MessageBox.Show(
                    $"Êtes-vous sûr de vouloir supprimer la ligne '{ligneASupprimer.NomLigne}' ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        BD.SupprimerLigne(ligneASupprimer.IdLigne);
                        MessageBox.Show("Ligne supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lignes = BD.LectureLignes();
                        cbxNomLigneSuppr.DataSource = null;
                        cbxNomLigneSuppr.DataSource = lignes;
                        cbxNomLigneSuppr.DisplayMember = "NomLigne";
                        cbxNomLigneSuppr.ValueMember = "IdLigne";
                        cbxNomLigneSuppr.SelectedIndex = -1;

                        btnSupprimerLigne.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
