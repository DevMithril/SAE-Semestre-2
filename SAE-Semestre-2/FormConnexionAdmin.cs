using Base_de_données;
using SAE_Semestre_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormConnexionAdmin : Form
    {
        public FormConnexionAdmin()
        {
            InitializeComponent();

        }

        private void FormConnexionAdmin_Load(object sender, EventArgs e)
        {
            btnConnexion.Click += BtnConnexion_Click;
            btnItineraire.Click += BtnItineraire_Click;
            btnConsultation.Click += BtnConsultation_Click;
            btnConnexion.Enabled = false;

            textBox1.TextChanged += Fields_TextChanged;
            textBox2.TextChanged += Fields_TextChanged;

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
        }

        private void Fields_TextChanged(object sender, EventArgs e)
        {
            btnConnexion.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text);
        }

        private void BtnItineraire_Click(object sender, EventArgs e)
        {
            FormItineraire formItineraire = new FormItineraire();
            formItineraire.Show();
            this.Hide();
        }

        private void BtnConsultation_Click(object sender, EventArgs e)
        {
            FormConsultation formConsultation = new FormConsultation();
            formConsultation.Show();
            this.Hide();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string mdp = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Veuillez remplir les deux champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!BD.connexion())
            {
                MessageBox.Show("Impossible de se connecter à la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Admin> admins = BD.LectureAdmins();
            BD.fermeture();

            bool utilisateurValide = admins.Any(admin =>
                string.Equals(admin.Login, login, StringComparison.OrdinalIgnoreCase)
                && admin.MotDePasse == mdp);

            if (utilisateurValide)
            {
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAjouter formAjouter = new FormAjouter();
                formAjouter.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
