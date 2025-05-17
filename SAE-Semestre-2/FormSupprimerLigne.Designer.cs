namespace SAE_Semestre_2
{
    partial class FormSupprimerLigne
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
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            btnConnexionAdmin = new Button();
            btnConsultation = new Button();
            btnItineraire = new Button();
            cbxNomLigneSuppr = new ComboBox();
            btnSupprimerLigne = new Button();
            lblNomLigneSuppr = new Label();
            SuspendLayout();
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(450, 395);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 19;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(368, 395);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 18;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(287, 395);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 17;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnConnexionAdmin
            // 
            btnConnexionAdmin.Location = new Point(495, 29);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(170, 23);
            btnConnexionAdmin.TabIndex = 16;
            btnConnexionAdmin.Text = "Espace Administrateur";
            btnConnexionAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(319, 29);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(170, 23);
            btnConsultation.TabIndex = 15;
            btnConsultation.Text = "Consulter les horaires";
            btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnItineraire
            // 
            btnItineraire.Location = new Point(143, 29);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(170, 23);
            btnItineraire.TabIndex = 14;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            // 
            // cbxNomLigneSuppr
            // 
            cbxNomLigneSuppr.FormattingEnabled = true;
            cbxNomLigneSuppr.Location = new Point(342, 179);
            cbxNomLigneSuppr.Name = "cbxNomLigneSuppr";
            cbxNomLigneSuppr.Size = new Size(121, 23);
            cbxNomLigneSuppr.TabIndex = 20;
            // 
            // btnSupprimerLigne
            // 
            btnSupprimerLigne.Location = new Point(342, 284);
            btnSupprimerLigne.Name = "btnSupprimerLigne";
            btnSupprimerLigne.Size = new Size(121, 23);
            btnSupprimerLigne.TabIndex = 21;
            btnSupprimerLigne.Text = "Supprimer la ligne";
            btnSupprimerLigne.UseVisualStyleBackColor = true;
            // 
            // lblNomLigneSuppr
            // 
            lblNomLigneSuppr.AutoSize = true;
            lblNomLigneSuppr.Location = new Point(342, 161);
            lblNomLigneSuppr.Name = "lblNomLigneSuppr";
            lblNomLigneSuppr.Size = new Size(91, 15);
            lblNomLigneSuppr.TabIndex = 22;
            lblNomLigneSuppr.Text = "Nom de la ligne";
            // 
            // FormSupprimerLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNomLigneSuppr);
            Controls.Add(btnSupprimerLigne);
            Controls.Add(cbxNomLigneSuppr);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Name = "FormSupprimerLigne";
            Text = "FormSupprimerLigne";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnConnexionAdmin;
        private Button btnConsultation;
        private Button btnItineraire;
        private ComboBox cbxNomLigneSuppr;
        private Button btnSupprimerLigne;
        private Label lblNomLigneSuppr;
    }
}