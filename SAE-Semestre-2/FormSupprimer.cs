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
    public partial class FormSupprimer : Form
    {
        public FormSupprimer()
        {
            InitializeComponent();
        }

        private void FormSupprimer_Load(object sender, EventArgs e)
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
        }

        private void btnItineraire_Click(object sender, EventArgs e)
        {
            FormItineraire itineraire = new FormItineraire();
            itineraire.Show();
            Close();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            FormConsultation consultation = new FormConsultation();
            consultation.Show();
            Close();
        }

        private void btnConnexionAdmin_Click(object sender, EventArgs e)
        {
            FormConnexionAdmin admin = new FormConnexionAdmin();
            admin.Show();
            Close();
        }

        private void btnSupprLigne_Click(object sender, EventArgs e)
        {
            FormSupprimerLigne supprimerLigne = new FormSupprimerLigne();
            supprimerLigne.Show();
            Close();
        }

        private void btnSupprStation_Click(object sender, EventArgs e)
        {
            FormSupprimerStation supprimerStation = new FormSupprimerStation();
            supprimerStation.Show();
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormAjouter ajouter = new FormAjouter();
            ajouter.Show();
            Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            FormModifier modifier = new FormModifier();
            modifier.Show();
            Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            FormSupprimer supprimer = new FormSupprimer();
            supprimer.Show();
            Close();
        }
    }
}
