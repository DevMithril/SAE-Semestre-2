using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormAjouter : Form
    {
        public FormAjouter()
        {
            InitializeComponent();
        }

        private void FormAjouter_Load(object sender, EventArgs e)
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

        private void btnAjouterLigne_Click(object sender, EventArgs e)
        {
            FormAjouterLigne ajouterLigne = new FormAjouterLigne();
            ajouterLigne.Show();
            Close();
        }

        private void btnAjouterStation_Click(object sender, EventArgs e)
        {
            FormAjouterStation ajouterStation = new FormAjouterStation();
            ajouterStation.Show();
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
