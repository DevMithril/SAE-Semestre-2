namespace SAE_Semestre_2
{
    partial class FormConnexionAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnexionAdmin = new Button();
            btnConsultation = new Button();
            btnItineraire = new Button();
            lblConnexionTitre = new Label();
            lblLoginAdmin = new Label();
            lblPasswordAdmin = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnConnexion = new Button();
            SuspendLayout();
            // 
            // btnConnexionAdmin
            // 
            btnConnexionAdmin.Location = new Point(566, 39);
            btnConnexionAdmin.Margin = new Padding(3, 4, 3, 4);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(194, 31);
            btnConnexionAdmin.TabIndex = 5;
            btnConnexionAdmin.Text = "Espace Administrateur";
            btnConnexionAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(365, 39);
            btnConsultation.Margin = new Padding(3, 4, 3, 4);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(194, 31);
            btnConsultation.TabIndex = 4;
            btnConsultation.Text = "Consulter les horaires";
            btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnItineraire
            // 
            btnItineraire.Location = new Point(163, 39);
            btnItineraire.Margin = new Padding(3, 4, 3, 4);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(194, 31);
            btnItineraire.TabIndex = 3;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            // 
            // lblConnexionTitre
            // 
            lblConnexionTitre.AutoSize = true;
            lblConnexionTitre.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblConnexionTitre.Location = new Point(281, 113);
            lblConnexionTitre.Name = "lblConnexionTitre";
            lblConnexionTitre.Size = new Size(398, 60);
            lblConnexionTitre.TabIndex = 6;
            lblConnexionTitre.Text = "Connexion Admin";
            // 
            // lblLoginAdmin
            // 
            lblLoginAdmin.AutoSize = true;
            lblLoginAdmin.Location = new Point(317, 232);
            lblLoginAdmin.Name = "lblLoginAdmin";
            lblLoginAdmin.Size = new Size(77, 20);
            lblLoginAdmin.TabIndex = 7;
            lblLoginAdmin.Text = "Identifiant";
            // 
            // lblPasswordAdmin
            // 
            lblPasswordAdmin.AutoSize = true;
            lblPasswordAdmin.Location = new Point(317, 313);
            lblPasswordAdmin.Name = "lblPasswordAdmin";
            lblPasswordAdmin.Size = new Size(98, 20);
            lblPasswordAdmin.TabIndex = 8;
            lblPasswordAdmin.Text = "Mot de passe";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 256);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 337);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 27);
            textBox2.TabIndex = 10;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(397, 411);
            btnConnexion.Margin = new Padding(3, 4, 3, 4);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(117, 31);
            btnConnexion.TabIndex = 11;
            btnConnexion.Text = "Se Connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            // 
            // FormConnexionAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnConnexion);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPasswordAdmin);
            Controls.Add(lblLoginAdmin);
            Controls.Add(lblConnexionTitre);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormConnexionAdmin";
            Text = "FormConnexionAdmin";
            Load += FormConnexionAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnexionAdmin;
        private Button btnConsultation;
        private Button btnItineraire;
        private Label lblConnexionTitre;
        private Label lblLoginAdmin;
        private Label lblPasswordAdmin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnConnexion;
    }
}