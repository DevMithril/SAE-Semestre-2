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
            // lblNomNouvelleStation
            // 
            lblNomNouvelleStation.AutoSize = true;
            lblNomNouvelleStation.Location = new Point(70, 123);
            lblNomNouvelleStation.Name = "lblNomNouvelleStation";
            lblNomNouvelleStation.Size = new Size(101, 15);
            lblNomNouvelleStation.TabIndex = 20;
            lblNomNouvelleStation.Text = "Nom de la station";
            // 
            // txtNomNouvelleStation
            // 
            txtNomNouvelleStation.Location = new Point(70, 141);
            txtNomNouvelleStation.Name = "txtNomNouvelleStation";
            txtNomNouvelleStation.Size = new Size(300, 23);
            txtNomNouvelleStation.TabIndex = 21;
            // 
            // btnEnregistrerNouvelleStation
            // 
            btnEnregistrerNouvelleStation.Location = new Point(368, 313);
            btnEnregistrerNouvelleStation.Name = "btnEnregistrerNouvelleStation";
            btnEnregistrerNouvelleStation.Size = new Size(75, 23);
            btnEnregistrerNouvelleStation.TabIndex = 22;
            btnEnregistrerNouvelleStation.Text = "Enregistrer";
            btnEnregistrerNouvelleStation.UseVisualStyleBackColor = true;
            // 
            // btnValiderStationAdjacente
            // 
            btnValiderStationAdjacente.Location = new Point(520, 222);
            btnValiderStationAdjacente.Name = "btnValiderStationAdjacente";
            btnValiderStationAdjacente.Size = new Size(118, 23);
            btnValiderStationAdjacente.TabIndex = 23;
            btnValiderStationAdjacente.Text = "Valider la Station";
            btnValiderStationAdjacente.UseVisualStyleBackColor = true;
            // 
            // cbxStationAdjacente
            // 
            cbxStationAdjacente.FormattingEnabled = true;
            cbxStationAdjacente.Location = new Point(437, 141);
            cbxStationAdjacente.Name = "cbxStationAdjacente";
            cbxStationAdjacente.Size = new Size(287, 23);
            cbxStationAdjacente.TabIndex = 24;
            // 
            // FormAjouterStation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormAjouterStation";
            Text = "FormAjouterStation";
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