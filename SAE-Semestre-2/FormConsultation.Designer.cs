namespace SAE_Semestre_2
{
    partial class FormConsultation
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
            cbxLigneConsult = new ComboBox();
            cbxStationConsult = new ComboBox();
            lstHorairesConsult = new ListBox();
            SuspendLayout();
            // 
            // btnConnexionAdmin
            // 
            btnConnexionAdmin.Location = new Point(566, 39);
            btnConnexionAdmin.Margin = new Padding(3, 4, 3, 4);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(194, 31);
            btnConnexionAdmin.TabIndex = 5;
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
            btnConsultation.TabIndex = 4;
            btnConsultation.Text = "Consulter les horaires";
            btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnItineraire
            // 
            btnItineraire.Location = new Point(163, 39);
            btnItineraire.Margin = new Padding(3, 4, 3, 4);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(194, 31);
            btnItineraire.TabIndex = 3;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            btnItineraire.Click += btnItineraire_Click;
            // 
            // cbxLigneConsult
            // 
            cbxLigneConsult.FormattingEnabled = true;
            cbxLigneConsult.Location = new Point(49, 241);
            cbxLigneConsult.Margin = new Padding(3, 4, 3, 4);
            cbxLigneConsult.Name = "cbxLigneConsult";
            cbxLigneConsult.Size = new Size(418, 28);
            cbxLigneConsult.TabIndex = 6;
            cbxLigneConsult.SelectedIndexChanged += cbxLigneConsult_SelectedIndexChanged;
            // 
            // cbxStationConsult
            // 
            cbxStationConsult.FormattingEnabled = true;
            cbxStationConsult.Location = new Point(49, 377);
            cbxStationConsult.Margin = new Padding(3, 4, 3, 4);
            cbxStationConsult.Name = "cbxStationConsult";
            cbxStationConsult.Size = new Size(418, 28);
            cbxStationConsult.TabIndex = 7;
            cbxStationConsult.SelectedIndexChanged += cbxStationConsult_SelectedIndexChanged;
            // 
            // lstHorairesConsult
            // 
            lstHorairesConsult.FormattingEnabled = true;
            lstHorairesConsult.Location = new Point(547, 132);
            lstHorairesConsult.Margin = new Padding(3, 4, 3, 4);
            lstHorairesConsult.Name = "lstHorairesConsult";
            lstHorairesConsult.Size = new Size(311, 444);
            lstHorairesConsult.TabIndex = 8;
            // 
            // FormConsultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lstHorairesConsult);
            Controls.Add(cbxStationConsult);
            Controls.Add(cbxLigneConsult);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormConsultation";
            Text = "FormConsultation";
            Load += FormConsultation_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnexionAdmin;
        private Button btnConsultation;
        private Button btnItineraire;
        private ComboBox cbxLigneConsult;
        private ComboBox cbxStationConsult;
        private ListBox lstHorairesConsult;
    }
}