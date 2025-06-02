namespace SAE_Semestre_2
{
    partial class FormAjouter
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
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            btnAjouterLigne = new Button();
            btnAjouterStation = new Button();
            SuspendLayout();
            // 
            // btnConnexionAdmin
            // 
            btnConnexionAdmin.Location = new Point(566, 39);
            btnConnexionAdmin.Margin = new Padding(3, 4, 3, 4);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(194, 31);
            btnConnexionAdmin.TabIndex = 8;
            btnConnexionAdmin.Text = "Espace Administrateur";
            btnConnexionAdmin.UseVisualStyleBackColor = true;
            btnConnexionAdmin.Click += btnConnexionAdmin_Click;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(365, 39);
            btnConsultation.Margin = new Padding(3, 4, 3, 4);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(194, 31);
            btnConsultation.TabIndex = 7;
            btnConsultation.Text = "Consulter les horaires";
            btnConsultation.UseVisualStyleBackColor = true;
            btnConsultation.Click += btnConsultation_Click;
            // 
            // btnItineraire
            // 
            btnItineraire.Location = new Point(163, 39);
            btnItineraire.Margin = new Padding(3, 4, 3, 4);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(194, 31);
            btnItineraire.TabIndex = 6;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            btnItineraire.Click += btnItineraire_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(328, 527);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(86, 31);
            btnAjouter.TabIndex = 9;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(421, 527);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(86, 31);
            btnModifier.TabIndex = 10;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(513, 527);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(86, 31);
            btnSupprimer.TabIndex = 11;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnAjouterLigne
            // 
            btnAjouterLigne.Location = new Point(384, 219);
            btnAjouterLigne.Margin = new Padding(3, 4, 3, 4);
            btnAjouterLigne.Name = "btnAjouterLigne";
            btnAjouterLigne.Size = new Size(160, 31);
            btnAjouterLigne.TabIndex = 12;
            btnAjouterLigne.Text = "Ajouter une ligne";
            btnAjouterLigne.UseVisualStyleBackColor = true;
            btnAjouterLigne.Click += btnAjouterLigne_Click;
            // 
            // btnAjouterStation
            // 
            btnAjouterStation.Location = new Point(384, 356);
            btnAjouterStation.Margin = new Padding(3, 4, 3, 4);
            btnAjouterStation.Name = "btnAjouterStation";
            btnAjouterStation.Size = new Size(160, 31);
            btnAjouterStation.TabIndex = 13;
            btnAjouterStation.Text = "Ajouter une Station";
            btnAjouterStation.UseVisualStyleBackColor = true;
            btnAjouterStation.Click += btnAjouterStation_Click;
            // 
            // FormAjouter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAjouterStation);
            Controls.Add(btnAjouterLigne);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAjouter";
            Text = "FormAjouter";
            Load += FormAjouter_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnexionAdmin;
        private Button btnConsultation;
        private Button btnItineraire;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Button btnAjouterLigne;
        private Button btnAjouterStation;
    }
}