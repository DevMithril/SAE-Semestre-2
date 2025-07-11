﻿namespace SAE_Semestre_2
{
    partial class FormSupprimerLigne
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
            cbxNomLigneSuppr = new ComboBox();
            btnSupprimerLigne = new Button();
            lblNomLigneSuppr = new Label();
            SuspendLayout();
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(514, 527);
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
            // cbxNomLigneSuppr
            // 
            cbxNomLigneSuppr.FormattingEnabled = true;
            cbxNomLigneSuppr.Location = new Point(391, 239);
            cbxNomLigneSuppr.Margin = new Padding(3, 4, 3, 4);
            cbxNomLigneSuppr.Name = "cbxNomLigneSuppr";
            cbxNomLigneSuppr.Size = new Size(138, 28);
            cbxNomLigneSuppr.TabIndex = 20;
            cbxNomLigneSuppr.SelectedIndexChanged += cbxNomLigneSuppr_SelectedIndexChanged;
            // 
            // btnSupprimerLigne
            // 
            btnSupprimerLigne.Location = new Point(391, 379);
            btnSupprimerLigne.Margin = new Padding(3, 4, 3, 4);
            btnSupprimerLigne.Name = "btnSupprimerLigne";
            btnSupprimerLigne.Size = new Size(146, 31);
            btnSupprimerLigne.TabIndex = 21;
            btnSupprimerLigne.Text = "Supprimer la ligne";
            btnSupprimerLigne.UseVisualStyleBackColor = true;
            btnSupprimerLigne.Click += btnSupprimerLigne_Click;
            // 
            // lblNomLigneSuppr
            // 
            lblNomLigneSuppr.AutoSize = true;
            lblNomLigneSuppr.Location = new Point(391, 215);
            lblNomLigneSuppr.Name = "lblNomLigneSuppr";
            lblNomLigneSuppr.Size = new Size(116, 20);
            lblNomLigneSuppr.TabIndex = 22;
            lblNomLigneSuppr.Text = "Nom de la ligne";
            // 
            // FormSupprimerLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblNomLigneSuppr);
            Controls.Add(btnSupprimerLigne);
            Controls.Add(cbxNomLigneSuppr);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSupprimerLigne";
            Text = "FormSupprimerLigne";
            Load += FormSupprimerLigne_Load;
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
        private ComboBox cbxNomLigneSuppr;
        private Button btnSupprimerLigne;
        private Label lblNomLigneSuppr;
    }
}