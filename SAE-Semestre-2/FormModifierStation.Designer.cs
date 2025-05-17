namespace SAE_Semestre_2
{
    partial class FormModifierStation
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
            btnRenommerStation = new Button();
            lblNomStation = new Label();
            lblNouveauNomStation = new Label();
            cbxNomStation = new ComboBox();
            txtNouveauNomStation = new TextBox();
            SuspendLayout();
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(449, 395);
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
            // btnRenommerStation
            // 
            btnRenommerStation.Location = new Point(344, 320);
            btnRenommerStation.Name = "btnRenommerStation";
            btnRenommerStation.Size = new Size(126, 23);
            btnRenommerStation.TabIndex = 20;
            btnRenommerStation.Text = "Renommer la station";
            btnRenommerStation.UseVisualStyleBackColor = true;
            // 
            // lblNomStation
            // 
            lblNomStation.AutoSize = true;
            lblNomStation.Location = new Point(264, 133);
            lblNomStation.Name = "lblNomStation";
            lblNomStation.Size = new Size(136, 15);
            lblNomStation.TabIndex = 21;
            lblNomStation.Text = "Nom actuel de la station";
            // 
            // lblNouveauNomStation
            // 
            lblNouveauNomStation.AutoSize = true;
            lblNouveauNomStation.Location = new Point(264, 224);
            lblNouveauNomStation.Name = "lblNouveauNomStation";
            lblNouveauNomStation.Size = new Size(150, 15);
            lblNouveauNomStation.TabIndex = 22;
            lblNouveauNomStation.Text = "Nouveau nom de la station";
            // 
            // cbxNomStation
            // 
            cbxNomStation.FormattingEnabled = true;
            cbxNomStation.Location = new Point(264, 151);
            cbxNomStation.Name = "cbxNomStation";
            cbxNomStation.Size = new Size(292, 23);
            cbxNomStation.TabIndex = 23;
            // 
            // txtNouveauNomStation
            // 
            txtNouveauNomStation.Location = new Point(264, 242);
            txtNouveauNomStation.Name = "txtNouveauNomStation";
            txtNouveauNomStation.Size = new Size(292, 23);
            txtNouveauNomStation.TabIndex = 24;
            // 
            // FormModifierStation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNouveauNomStation);
            Controls.Add(cbxNomStation);
            Controls.Add(lblNouveauNomStation);
            Controls.Add(lblNomStation);
            Controls.Add(btnRenommerStation);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Name = "FormModifierStation";
            Text = "FormModifierStation";
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
        private Button btnRenommerStation;
        private Label lblNomStation;
        private Label lblNouveauNomStation;
        private ComboBox cbxNomStation;
        private TextBox txtNouveauNomStation;
    }
}