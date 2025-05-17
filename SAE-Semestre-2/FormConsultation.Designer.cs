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
            btnConnexionAdmin.Location = new Point(495, 29);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(170, 23);
            btnConnexionAdmin.TabIndex = 5;
            btnConnexionAdmin.Text = "Espace Administrateur";
            btnConnexionAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(319, 29);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(170, 23);
            btnConsultation.TabIndex = 4;
            btnConsultation.Text = "Consulter les horaires";
            btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnItineraire
            // 
            btnItineraire.Location = new Point(143, 29);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(170, 23);
            btnItineraire.TabIndex = 3;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            // 
            // cbxLigneConsult
            // 
            cbxLigneConsult.FormattingEnabled = true;
            cbxLigneConsult.Location = new Point(43, 181);
            cbxLigneConsult.Name = "cbxLigneConsult";
            cbxLigneConsult.Size = new Size(366, 23);
            cbxLigneConsult.TabIndex = 6;
            // 
            // cbxStationConsult
            // 
            cbxStationConsult.FormattingEnabled = true;
            cbxStationConsult.Location = new Point(43, 283);
            cbxStationConsult.Name = "cbxStationConsult";
            cbxStationConsult.Size = new Size(366, 23);
            cbxStationConsult.TabIndex = 7;
            // 
            // lstHorairesConsult
            // 
            lstHorairesConsult.FormattingEnabled = true;
            lstHorairesConsult.ItemHeight = 15;
            lstHorairesConsult.Location = new Point(479, 99);
            lstHorairesConsult.Name = "lstHorairesConsult";
            lstHorairesConsult.Size = new Size(273, 334);
            lstHorairesConsult.TabIndex = 8;
            // 
            // FormConsultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstHorairesConsult);
            Controls.Add(cbxStationConsult);
            Controls.Add(cbxLigneConsult);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Name = "FormConsultation";
            Text = "FormConsultation";
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