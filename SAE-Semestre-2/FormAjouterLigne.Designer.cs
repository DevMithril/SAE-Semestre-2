namespace SAE_Semestre_2
{
    partial class FormAjouterLigne
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
            lblNomNouvelleLigne = new Label();
            txtNomNouvelleLigne = new TextBox();
            txtCouleurNouvelleLigne = new TextBox();
            lblCouleurNouvelleLigne = new Label();
            lblNomStationNouvelleLigne = new Label();
            lblHorairesStationNouvelleLigne = new Label();
            cbxNomStationNouvelleLigne = new ComboBox();
            btnEnregistrerNouvelleLigne = new Button();
            lstHorairesStationNouvelleLigne = new ListBox();
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
            // lblNomNouvelleLigne
            // 
            lblNomNouvelleLigne.AutoSize = true;
            lblNomNouvelleLigne.Location = new Point(119, 155);
            lblNomNouvelleLigne.Name = "lblNomNouvelleLigne";
            lblNomNouvelleLigne.Size = new Size(116, 20);
            lblNomNouvelleLigne.TabIndex = 20;
            lblNomNouvelleLigne.Text = "Nom de la ligne";
            // 
            // txtNomNouvelleLigne
            // 
            txtNomNouvelleLigne.Location = new Point(119, 179);
            txtNomNouvelleLigne.Margin = new Padding(3, 4, 3, 4);
            txtNomNouvelleLigne.Name = "txtNomNouvelleLigne";
            txtNomNouvelleLigne.Size = new Size(198, 27);
            txtNomNouvelleLigne.TabIndex = 21;
            // 
            // txtCouleurNouvelleLigne
            // 
            txtCouleurNouvelleLigne.Location = new Point(119, 267);
            txtCouleurNouvelleLigne.Margin = new Padding(3, 4, 3, 4);
            txtCouleurNouvelleLigne.Name = "txtCouleurNouvelleLigne";
            txtCouleurNouvelleLigne.Size = new Size(198, 27);
            txtCouleurNouvelleLigne.TabIndex = 22;
            // 
            // lblCouleurNouvelleLigne
            // 
            lblCouleurNouvelleLigne.AutoSize = true;
            lblCouleurNouvelleLigne.Location = new Point(119, 243);
            lblCouleurNouvelleLigne.Name = "lblCouleurNouvelleLigne";
            lblCouleurNouvelleLigne.Size = new Size(134, 20);
            lblCouleurNouvelleLigne.TabIndex = 23;
            lblCouleurNouvelleLigne.Text = "Couleur de la ligne";
            // 
            // lblNomStationNouvelleLigne
            // 
            lblNomStationNouvelleLigne.AutoSize = true;
            lblNomStationNouvelleLigne.Location = new Point(497, 155);
            lblNomStationNouvelleLigne.Name = "lblNomStationNouvelleLigne";
            lblNomStationNouvelleLigne.Size = new Size(128, 20);
            lblNomStationNouvelleLigne.TabIndex = 24;
            lblNomStationNouvelleLigne.Text = "Nom de la station";
            // 
            // lblHorairesStationNouvelleLigne
            // 
            lblHorairesStationNouvelleLigne.AutoSize = true;
            lblHorairesStationNouvelleLigne.Location = new Point(497, 243);
            lblHorairesStationNouvelleLigne.Name = "lblHorairesStationNouvelleLigne";
            lblHorairesStationNouvelleLigne.Size = new Size(65, 20);
            lblHorairesStationNouvelleLigne.TabIndex = 25;
            lblHorairesStationNouvelleLigne.Text = "Horaires";
            // 
            // cbxNomStationNouvelleLigne
            // 
            cbxNomStationNouvelleLigne.FormattingEnabled = true;
            cbxNomStationNouvelleLigne.Location = new Point(497, 179);
            cbxNomStationNouvelleLigne.Margin = new Padding(3, 4, 3, 4);
            cbxNomStationNouvelleLigne.Name = "cbxNomStationNouvelleLigne";
            cbxNomStationNouvelleLigne.Size = new Size(294, 28);
            cbxNomStationNouvelleLigne.TabIndex = 26;
            // 
            // btnEnregistrerNouvelleLigne
            // 
            btnEnregistrerNouvelleLigne.Location = new Point(186, 432);
            btnEnregistrerNouvelleLigne.Margin = new Padding(3, 4, 3, 4);
            btnEnregistrerNouvelleLigne.Name = "btnEnregistrerNouvelleLigne";
            btnEnregistrerNouvelleLigne.Size = new Size(91, 31);
            btnEnregistrerNouvelleLigne.TabIndex = 27;
            btnEnregistrerNouvelleLigne.Text = "Enregistrer";
            btnEnregistrerNouvelleLigne.UseVisualStyleBackColor = true;
            btnEnregistrerNouvelleLigne.Click += btnEnregistrerNouvelleLigne_Click;
            // 
            // lstHorairesStationNouvelleLigne
            // 
            lstHorairesStationNouvelleLigne.FormattingEnabled = true;
            lstHorairesStationNouvelleLigne.Location = new Point(497, 267);
            lstHorairesStationNouvelleLigne.Margin = new Padding(3, 4, 3, 4);
            lstHorairesStationNouvelleLigne.Name = "lstHorairesStationNouvelleLigne";
            lstHorairesStationNouvelleLigne.Size = new Size(294, 164);
            lstHorairesStationNouvelleLigne.TabIndex = 28;
            // 
            // FormAjouterLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lstHorairesStationNouvelleLigne);
            Controls.Add(btnEnregistrerNouvelleLigne);
            Controls.Add(cbxNomStationNouvelleLigne);
            Controls.Add(lblHorairesStationNouvelleLigne);
            Controls.Add(lblNomStationNouvelleLigne);
            Controls.Add(lblCouleurNouvelleLigne);
            Controls.Add(txtCouleurNouvelleLigne);
            Controls.Add(txtNomNouvelleLigne);
            Controls.Add(lblNomNouvelleLigne);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAjouterLigne";
            Text = "FormAjouterLigne";
            Load += FormAjouterLigne_Load;
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
        private Label lblNomNouvelleLigne;
        private TextBox txtNomNouvelleLigne;
        private TextBox txtCouleurNouvelleLigne;
        private Label lblCouleurNouvelleLigne;
        private Label lblNomStationNouvelleLigne;
        private Label lblHorairesStationNouvelleLigne;
        private ComboBox cbxNomStationNouvelleLigne;
        private Button btnEnregistrerNouvelleLigne;
        private ListBox lstHorairesStationNouvelleLigne;
    }
}