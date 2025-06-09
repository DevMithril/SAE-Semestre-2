using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormModifier : Form
    {
        public FormModifier()
        {
            InitializeComponent();
        }

        // Formulaire de modification - gestion des boutons de navigation et état visuel
        private void FormModifier_Load(object sender, EventArgs e)
        {
            // Configuration des boutons (activation, couleurs)
            btnConsultation.Enabled = true; btnConsultation.FlatStyle = FlatStyle.Standard;
            btnItineraire.Enabled = true; btnItineraire.FlatStyle = FlatStyle.Standard;

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

            btnAjouter.Enabled = true; btnAjouter.FlatStyle = FlatStyle.Standard;
            btnSupprimer.Enabled = true; btnSupprimer.FlatStyle = FlatStyle.Standard;
        }

        // Navigation vers les autres formulaires
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

        private void btnModifLigne_Click(object sender, EventArgs e)
        {
            new FormModifierLigne().Show();
            Close();
        }

        private void btnModifStation_Click(object sender, EventArgs e)
        {
            new FormModifierStation().Show();
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
    }
}
