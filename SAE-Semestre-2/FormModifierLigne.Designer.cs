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
            // txtNouvelleCouleurLigne
            // 
            txtNouvelleCouleurLigne.Location = new Point(112, 252);
            txtNouvelleCouleurLigne.Margin = new Padding(3, 4, 3, 4);
            txtNouvelleCouleurLigne.Name = "txtNouvelleCouleurLigne";
            txtNouvelleCouleurLigne.Size = new Size(193, 27);
            txtNouvelleCouleurLigne.TabIndex = 20;
            txtNouvelleCouleurLigne.Tag = "";
            // 
            // lblNouvelleCouleurLigne
            // 
            lblNouvelleCouleurLigne.AutoSize = true;
            lblNouvelleCouleurLigne.Location = new Point(112, 228);
            lblNouvelleCouleurLigne.Name = "lblNouvelleCouleurLigne";
            lblNouvelleCouleurLigne.Size = new Size(134, 20);
            lblNouvelleCouleurLigne.TabIndex = 21;
            lblNouvelleCouleurLigne.Text = "Couleur de la ligne";
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Location = new Point(112, 140);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(116, 20);
            lblNomLigne.TabIndex = 22;
            lblNomLigne.Text = "Nom de la ligne";
            // 
            // lblNomStation
            // 
            lblNomStation.AutoSize = true;
            lblNomStation.Location = new Point(479, 140);
            lblNomStation.Name = "lblNomStation";
            lblNomStation.Size = new Size(128, 20);
            lblNomStation.TabIndex = 23;
            lblNomStation.Text = "Nom de la station";
            // 
            // lblHorairesStationLigne
            // 
            lblHorairesStationLigne.AutoSize = true;
            lblHorairesStationLigne.Location = new Point(479, 228);
            lblHorairesStationLigne.Name = "lblHorairesStationLigne";
            lblHorairesStationLigne.Size = new Size(65, 20);
            lblHorairesStationLigne.TabIndex = 24;
            lblHorairesStationLigne.Text = "Horaires";
            // 
            // btnEnregistrerModifLigne
            // 
            btnEnregistrerModifLigne.Location = new Point(219, 435);
            btnEnregistrerModifLigne.Margin = new Padding(3, 4, 3, 4);
            btnEnregistrerModifLigne.Name = "btnEnregistrerModifLigne";
            btnEnregistrerModifLigne.Size = new Size(92, 31);
            btnEnregistrerModifLigne.TabIndex = 25;
            btnEnregistrerModifLigne.Text = "Enregistrer";
            btnEnregistrerModifLigne.UseVisualStyleBackColor = true;
            btnEnregistrerModifLigne.Click += btnEnregistrerModifLigne_Click;
            // 
            // lstHorairesStationLigne
            // 
            lstHorairesStationLigne.FormattingEnabled = true;
            lstHorairesStationLigne.Location = new Point(479, 252);
            lstHorairesStationLigne.Margin = new Padding(3, 4, 3, 4);
            lstHorairesStationLigne.Name = "lstHorairesStationLigne";
            lstHorairesStationLigne.Size = new Size(314, 204);
            lstHorairesStationLigne.TabIndex = 26;
            // 
            // cbxNomStation
            // 
            cbxNomStation.FormattingEnabled = true;
            cbxNomStation.Location = new Point(479, 164);
            cbxNomStation.Margin = new Padding(3, 4, 3, 4);
            cbxNomStation.Name = "cbxNomStation";
            cbxNomStation.Size = new Size(314, 28);
            cbxNomStation.TabIndex = 27;
            // 
            // cbxNomLigne
            // 
            cbxNomLigne.FormattingEnabled = true;
            cbxNomLigne.Location = new Point(112, 164);
            cbxNomLigne.Margin = new Padding(3, 4, 3, 4);
            cbxNomLigne.Name = "cbxNomLigne";
            cbxNomLigne.Size = new Size(193, 28);
            cbxNomLigne.TabIndex = 28;
            // 
            // FormModifierLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModifierLigne";
            Text = "FormModifierLigne";
            Load += FormModifierLigne_Load;
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