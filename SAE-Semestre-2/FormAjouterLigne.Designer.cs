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
            // lblNomNouvelleLigne
            // 
            lblNomNouvelleLigne.AutoSize = true;
            lblNomNouvelleLigne.Location = new Point(104, 116);
            lblNomNouvelleLigne.Name = "lblNomNouvelleLigne";
            lblNomNouvelleLigne.Size = new Size(91, 15);
            lblNomNouvelleLigne.TabIndex = 20;
            lblNomNouvelleLigne.Text = "Nom de la ligne";
            // 
            // txtNomNouvelleLigne
            // 
            txtNomNouvelleLigne.Location = new Point(104, 134);
            txtNomNouvelleLigne.Name = "txtNomNouvelleLigne";
            txtNomNouvelleLigne.Size = new Size(174, 23);
            txtNomNouvelleLigne.TabIndex = 21;
            // 
            // txtCouleurNouvelleLigne
            // 
            txtCouleurNouvelleLigne.Location = new Point(104, 200);
            txtCouleurNouvelleLigne.Name = "txtCouleurNouvelleLigne";
            txtCouleurNouvelleLigne.Size = new Size(174, 23);
            txtCouleurNouvelleLigne.TabIndex = 22;
            txtCouleurNouvelleLigne.Text = "J'ai pas trouvé de color picker";
            // 
            // lblCouleurNouvelleLigne
            // 
            lblCouleurNouvelleLigne.AutoSize = true;
            lblCouleurNouvelleLigne.Location = new Point(104, 182);
            lblCouleurNouvelleLigne.Name = "lblCouleurNouvelleLigne";
            lblCouleurNouvelleLigne.Size = new Size(106, 15);
            lblCouleurNouvelleLigne.TabIndex = 23;
            lblCouleurNouvelleLigne.Text = "Couleur de la ligne";
            // 
            // lblNomStationNouvelleLigne
            // 
            lblNomStationNouvelleLigne.AutoSize = true;
            lblNomStationNouvelleLigne.Location = new Point(435, 116);
            lblNomStationNouvelleLigne.Name = "lblNomStationNouvelleLigne";
            lblNomStationNouvelleLigne.Size = new Size(101, 15);
            lblNomStationNouvelleLigne.TabIndex = 24;
            lblNomStationNouvelleLigne.Text = "Nom de la station";
            // 
            // lblHorairesStationNouvelleLigne
            // 
            lblHorairesStationNouvelleLigne.AutoSize = true;
            lblHorairesStationNouvelleLigne.Location = new Point(435, 182);
            lblHorairesStationNouvelleLigne.Name = "lblHorairesStationNouvelleLigne";
            lblHorairesStationNouvelleLigne.Size = new Size(51, 15);
            lblHorairesStationNouvelleLigne.TabIndex = 25;
            lblHorairesStationNouvelleLigne.Text = "Horaires";
            // 
            // cbxNomStationNouvelleLigne
            // 
            cbxNomStationNouvelleLigne.FormattingEnabled = true;
            cbxNomStationNouvelleLigne.Location = new Point(435, 134);
            cbxNomStationNouvelleLigne.Name = "cbxNomStationNouvelleLigne";
            cbxNomStationNouvelleLigne.Size = new Size(258, 23);
            cbxNomStationNouvelleLigne.TabIndex = 26;
            // 
            // btnEnregistrerNouvelleLigne
            // 
            btnEnregistrerNouvelleLigne.Location = new Point(163, 324);
            btnEnregistrerNouvelleLigne.Name = "btnEnregistrerNouvelleLigne";
            btnEnregistrerNouvelleLigne.Size = new Size(75, 23);
            btnEnregistrerNouvelleLigne.TabIndex = 27;
            btnEnregistrerNouvelleLigne.Text = "Enregistrer";
            btnEnregistrerNouvelleLigne.UseVisualStyleBackColor = true;
            // 
            // lstHorairesStationNouvelleLigne
            // 
            lstHorairesStationNouvelleLigne.FormattingEnabled = true;
            lstHorairesStationNouvelleLigne.ItemHeight = 15;
            lstHorairesStationNouvelleLigne.Location = new Point(435, 200);
            lstHorairesStationNouvelleLigne.Name = "lstHorairesStationNouvelleLigne";
            lstHorairesStationNouvelleLigne.Size = new Size(258, 124);
            lstHorairesStationNouvelleLigne.TabIndex = 28;
            // 
            // FormAjouterLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormAjouterLigne";
            Text = "FormAjouterLigne";
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