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

        private void FormModifier_Load(object sender, EventArgs e)
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

        private void btnModifLigne_Click(object sender, EventArgs e)
        {
            FormModifierLigne modifierLigne = new FormModifierLigne();
            modifierLigne.Show();
            Close();
        }

        private void btnModifStation_Click(object sender, EventArgs e)
        {
            FormModifierStation modifierStation = new FormModifierStation();
            modifierStation.Show();
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
