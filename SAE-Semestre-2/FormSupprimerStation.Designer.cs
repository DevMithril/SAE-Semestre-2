namespace SAE_Semestre_2
{
    partial class FormSupprimerStation
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
            btnSupprimerStation = new Button();
            txtNomStationSuppr = new TextBox();
            lblNomStationSuppr = new Label();
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
            // btnSupprimerStation
            // 
            btnSupprimerStation.Location = new Point(347, 289);
            btnSupprimerStation.Name = "btnSupprimerStation";
            btnSupprimerStation.Size = new Size(123, 23);
            btnSupprimerStation.TabIndex = 20;
            btnSupprimerStation.Text = "Supprimer la Station";
            btnSupprimerStation.UseVisualStyleBackColor = true;
            // 
            // txtNomStationSuppr
            // 
            txtNomStationSuppr.Location = new Point(270, 185);
            txtNomStationSuppr.Name = "txtNomStationSuppr";
            txtNomStationSuppr.Size = new Size(272, 23);
            txtNomStationSuppr.TabIndex = 21;
            // 
            // lblNomStationSuppr
            // 
            lblNomStationSuppr.AutoSize = true;
            lblNomStationSuppr.Location = new Point(270, 167);
            lblNomStationSuppr.Name = "lblNomStationSuppr";
            lblNomStationSuppr.Size = new Size(101, 15);
            lblNomStationSuppr.TabIndex = 22;
            lblNomStationSuppr.Text = "Nom de la station";
            // 
            // FormSupprimerStation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNomStationSuppr);
            Controls.Add(txtNomStationSuppr);
            Controls.Add(btnSupprimerStation);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Name = "FormSupprimerStation";
            Text = "FormSupprimerStation";
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
        private Button btnSupprimerStation;
        private TextBox txtNomStationSuppr;
        private Label lblNomStationSuppr;
    }
}