namespace SAE_Semestre_2
{
    partial class FormModifier
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
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            btnModifLigne = new Button();
            btnModifStation = new Button();
            SuspendLayout();
            // 
            // btnConnexionAdmin
            // 
            btnConnexionAdmin.Location = new Point(495, 29);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(170, 23);
            btnConnexionAdmin.TabIndex = 8;
            btnConnexionAdmin.Text = "Espace Administrateur";
            btnConnexionAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(319, 29);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(170, 23);
            btnConsultation.TabIndex = 7;
            btnConsultation.Text = "Consulter les horaires";
            btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnItineraire
            // 
            btnItineraire.Location = new Point(143, 29);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(170, 23);
            btnItineraire.TabIndex = 6;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(449, 395);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 14;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(368, 395);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 13;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(287, 395);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 12;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifLigne
            // 
            btnModifLigne.Location = new Point(336, 164);
            btnModifLigne.Name = "btnModifLigne";
            btnModifLigne.Size = new Size(140, 23);
            btnModifLigne.TabIndex = 15;
            btnModifLigne.Text = "Modifier une Ligne";
            btnModifLigne.UseVisualStyleBackColor = true;
            // 
            // btnModifStation
            // 
            btnModifStation.Location = new Point(336, 267);
            btnModifStation.Name = "btnModifStation";
            btnModifStation.Size = new Size(140, 23);
            btnModifStation.TabIndex = 16;
            btnModifStation.Text = "Modifier une station";
            btnModifStation.UseVisualStyleBackColor = true;
            // 
            // FormModifier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModifStation);
            Controls.Add(btnModifLigne);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Name = "FormModifier";
            Text = "FormModifier";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnexionAdmin;
        private Button btnConsultation;
        private Button btnItineraire;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnModifLigne;
        private Button btnModifStation;
    }
}