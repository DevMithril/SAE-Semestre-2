namespace SAE_Semestre_2
{
    partial class FormModifierLigne
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
            txtNouvelleCouleurLigne = new TextBox();
            lblNouvelleCouleurLigne = new Label();
            lblNomLigne = new Label();
            lblNomStation = new Label();
            lblHorairesStationLigne = new Label();
            btnEnregistrerModifLigne = new Button();
            lstHorairesStationLigne = new ListBox();
            cbxNomStation = new ComboBox();
            cbxNomLigne = new ComboBox();
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
            // txtNouvelleCouleurLigne
            // 
            txtNouvelleCouleurLigne.Location = new Point(98, 189);
            txtNouvelleCouleurLigne.Name = "txtNouvelleCouleurLigne";
            txtNouvelleCouleurLigne.Size = new Size(169, 23);
            txtNouvelleCouleurLigne.TabIndex = 20;
            txtNouvelleCouleurLigne.Tag = "";
            txtNouvelleCouleurLigne.Text = "J'ai pas trouvé de color picker";
            // 
            // lblNouvelleCouleurLigne
            // 
            lblNouvelleCouleurLigne.AutoSize = true;
            lblNouvelleCouleurLigne.Location = new Point(98, 171);
            lblNouvelleCouleurLigne.Name = "lblNouvelleCouleurLigne";
            lblNouvelleCouleurLigne.Size = new Size(106, 15);
            lblNouvelleCouleurLigne.TabIndex = 21;
            lblNouvelleCouleurLigne.Text = "Couleur de la ligne";
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Location = new Point(98, 105);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(91, 15);
            lblNomLigne.TabIndex = 22;
            lblNomLigne.Text = "Nom de la ligne";
            // 
            // lblNomStation
            // 
            lblNomStation.AutoSize = true;
            lblNomStation.Location = new Point(419, 105);
            lblNomStation.Name = "lblNomStation";
            lblNomStation.Size = new Size(101, 15);
            lblNomStation.TabIndex = 23;
            lblNomStation.Text = "Nom de la station";
            // 
            // lblHorairesStationLigne
            // 
            lblHorairesStationLigne.AutoSize = true;
            lblHorairesStationLigne.Location = new Point(419, 171);
            lblHorairesStationLigne.Name = "lblHorairesStationLigne";
            lblHorairesStationLigne.Size = new Size(51, 15);
            lblHorairesStationLigne.TabIndex = 24;
            lblHorairesStationLigne.Text = "Horaires";
            // 
            // btnEnregistrerModifLigne
            // 
            btnEnregistrerModifLigne.Location = new Point(192, 326);
            btnEnregistrerModifLigne.Name = "btnEnregistrerModifLigne";
            btnEnregistrerModifLigne.Size = new Size(75, 23);
            btnEnregistrerModifLigne.TabIndex = 25;
            btnEnregistrerModifLigne.Text = "Enregistrer";
            btnEnregistrerModifLigne.UseVisualStyleBackColor = true;
            // 
            // lstHorairesStationLigne
            // 
            lstHorairesStationLigne.FormattingEnabled = true;
            lstHorairesStationLigne.ItemHeight = 15;
            lstHorairesStationLigne.Location = new Point(419, 189);
            lstHorairesStationLigne.Name = "lstHorairesStationLigne";
            lstHorairesStationLigne.Size = new Size(275, 154);
            lstHorairesStationLigne.TabIndex = 26;
            // 
            // cbxNomStation
            // 
            cbxNomStation.FormattingEnabled = true;
            cbxNomStation.Location = new Point(419, 123);
            cbxNomStation.Name = "cbxNomStation";
            cbxNomStation.Size = new Size(275, 23);
            cbxNomStation.TabIndex = 27;
            // 
            // cbxNomLigne
            // 
            cbxNomLigne.FormattingEnabled = true;
            cbxNomLigne.Location = new Point(98, 123);
            cbxNomLigne.Name = "cbxNomLigne";
            cbxNomLigne.Size = new Size(169, 23);
            cbxNomLigne.TabIndex = 28;
            // 
            // FormModifierLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxNomLigne);
            Controls.Add(cbxNomStation);
            Controls.Add(lstHorairesStationLigne);
            Controls.Add(btnEnregistrerModifLigne);
            Controls.Add(lblHorairesStationLigne);
            Controls.Add(lblNomStation);
            Controls.Add(lblNomLigne);
            Controls.Add(lblNouvelleCouleurLigne);
            Controls.Add(txtNouvelleCouleurLigne);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Name = "FormModifierLigne";
            Text = "FormModifierLigne";
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
        private TextBox txtNouvelleCouleurLigne;
        private Label lblNouvelleCouleurLigne;
        private Label lblNomLigne;
        private Label lblNomStation;
        private Label lblHorairesStationLigne;
        private Button btnEnregistrerModifLigne;
        private ListBox lstHorairesStationLigne;
        private ComboBox cbxNomStation;
        private ComboBox cbxNomLigne;
    }
}