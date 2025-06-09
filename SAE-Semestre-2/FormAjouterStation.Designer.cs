namespace SAE_Semestre_2
{
    partial class FormAjouterStation
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
            lblNomNouvelleStation = new Label();
            txtNomNouvelleStation = new TextBox();
            btnEnregistrerNouvelleStation = new Button();
            btnValiderStationAdjacente = new Button();
            cbxStationAdjacente = new ComboBox();
            SuspendLayout();
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(513, 527);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(86, 31);
            btnSupprimer.TabIndex = 19;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(421, 527);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(86, 31);
            btnModifier.TabIndex = 18;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(328, 527);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(86, 31);
            btnAjouter.TabIndex = 17;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnConnexionAdmin
            // 
            btnConnexionAdmin.Location = new Point(566, 39);
            btnConnexionAdmin.Margin = new Padding(3, 4, 3, 4);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(194, 31);
            btnConnexionAdmin.TabIndex = 16;
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
            btnConsultation.TabIndex = 15;
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
            btnItineraire.TabIndex = 14;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            btnItineraire.Click += btnItineraire_Click;
            // 
            // lblNomNouvelleStation
            // 
            lblNomNouvelleStation.AutoSize = true;
            lblNomNouvelleStation.Location = new Point(80, 164);
            lblNomNouvelleStation.Name = "lblNomNouvelleStation";
            lblNomNouvelleStation.Size = new Size(128, 20);
            lblNomNouvelleStation.TabIndex = 20;
            lblNomNouvelleStation.Text = "Nom de la station";
            // 
            // txtNomNouvelleStation
            // 
            txtNomNouvelleStation.Location = new Point(80, 188);
            txtNomNouvelleStation.Margin = new Padding(3, 4, 3, 4);
            txtNomNouvelleStation.Name = "txtNomNouvelleStation";
            txtNomNouvelleStation.Size = new Size(342, 27);
            txtNomNouvelleStation.TabIndex = 21;
            txtNomNouvelleStation.TextChanged += txtNomNouvelleStation_TextChanged;
            // 
            // btnEnregistrerNouvelleStation
            // 
            btnEnregistrerNouvelleStation.Location = new Point(421, 417);
            btnEnregistrerNouvelleStation.Margin = new Padding(3, 4, 3, 4);
            btnEnregistrerNouvelleStation.Name = "btnEnregistrerNouvelleStation";
            btnEnregistrerNouvelleStation.Size = new Size(98, 31);
            btnEnregistrerNouvelleStation.TabIndex = 22;
            btnEnregistrerNouvelleStation.Text = "Enregistrer";
            btnEnregistrerNouvelleStation.UseVisualStyleBackColor = true;
            btnEnregistrerNouvelleStation.Click += btnEnregistrerNouvelleStation_Click;
            // 
            // btnValiderStationAdjacente
            // 
            btnValiderStationAdjacente.Location = new Point(594, 296);
            btnValiderStationAdjacente.Margin = new Padding(3, 4, 3, 4);
            btnValiderStationAdjacente.Name = "btnValiderStationAdjacente";
            btnValiderStationAdjacente.Size = new Size(135, 31);
            btnValiderStationAdjacente.TabIndex = 23;
            btnValiderStationAdjacente.Text = "Valider la Station";
            btnValiderStationAdjacente.UseVisualStyleBackColor = true;
            btnValiderStationAdjacente.Click += btnValiderStationAdjacente_Click;
            // 
            // cbxStationAdjacente
            // 
            cbxStationAdjacente.FormattingEnabled = true;
            cbxStationAdjacente.Location = new Point(499, 188);
            cbxStationAdjacente.Margin = new Padding(3, 4, 3, 4);
            cbxStationAdjacente.Name = "cbxStationAdjacente";
            cbxStationAdjacente.Size = new Size(327, 28);
            cbxStationAdjacente.TabIndex = 24;
            cbxStationAdjacente.SelectedIndexChanged += cbxStationAdjacente_SelectedIndexChanged;
            // 
            // FormAjouterStation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cbxStationAdjacente);
            Controls.Add(btnValiderStationAdjacente);
            Controls.Add(btnEnregistrerNouvelleStation);
            Controls.Add(txtNomNouvelleStation);
            Controls.Add(lblNomNouvelleStation);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAjouterStation";
            Text = "FormAjouterStation";
            Load += FormAjouterStation_Load;
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
        private Label lblNomNouvelleStation;
        private TextBox txtNomNouvelleStation;
        private Button btnEnregistrerNouvelleStation;
        private Button btnValiderStationAdjacente;
        private ComboBox cbxStationAdjacente;
    }
}