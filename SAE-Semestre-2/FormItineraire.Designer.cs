namespace SAE_Semestre_2
{
    partial class FormItineraire
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnItineraire = new Button();
            btnConsultation = new Button();
            btnConnexionAdmin = new Button();
            flpAffichageItin = new FlowLayoutPanel();
            btnRechercheItin = new Button();
            lblInputDepart = new Label();
            lblInputArrivee = new Label();
            txtDepartItin = new TextBox();
            txtArriveeItin = new TextBox();
            lblHoraireItin = new Label();
            numMinuteDepItin = new NumericUpDown();
            numHeureDepItin = new NumericUpDown();
            lblHeureDeuxPointsItin = new Label();
            ((System.ComponentModel.ISupportInitialize)numMinuteDepItin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeureDepItin).BeginInit();
            SuspendLayout();
            // 
            // btnItineraire
            // 
            btnItineraire.Location = new Point(143, 29);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(170, 23);
            btnItineraire.TabIndex = 0;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(319, 29);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(170, 23);
            btnConsultation.TabIndex = 1;
            btnConsultation.Text = "Consulter les horaires";
            btnConsultation.UseVisualStyleBackColor = true;
            btnConsultation.Click += btnConsultation_Click;
            // 
            // btnConnexionAdmin
            // 
            btnConnexionAdmin.Location = new Point(495, 29);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(170, 23);
            btnConnexionAdmin.TabIndex = 2;
            btnConnexionAdmin.Text = "Espace Administrateur";
            btnConnexionAdmin.UseVisualStyleBackColor = true;
            btnConnexionAdmin.Click += btnConnexionAdmin_Click;
            // 
            // flpAffichageItin
            // 
            flpAffichageItin.Location = new Point(429, 129);
            flpAffichageItin.Name = "flpAffichageItin";
            flpAffichageItin.Size = new Size(342, 309);
            flpAffichageItin.TabIndex = 3;
            // 
            // btnRechercheItin
            // 
            btnRechercheItin.Location = new Point(143, 351);
            btnRechercheItin.Name = "btnRechercheItin";
            btnRechercheItin.Size = new Size(158, 23);
            btnRechercheItin.TabIndex = 4;
            btnRechercheItin.Text = "Rechercher un itinéraire";
            btnRechercheItin.UseVisualStyleBackColor = true;
            btnRechercheItin.Click += btnRechercheItin_Click;
            // 
            // lblInputDepart
            // 
            lblInputDepart.AutoSize = true;
            lblInputDepart.Location = new Point(41, 129);
            lblInputDepart.Name = "lblInputDepart";
            lblInputDepart.Size = new Size(48, 15);
            lblInputDepart.TabIndex = 5;
            lblInputDepart.Text = "Départ :";
            // 
            // lblInputArrivee
            // 
            lblInputArrivee.AutoSize = true;
            lblInputArrivee.Location = new Point(41, 193);
            lblInputArrivee.Name = "lblInputArrivee";
            lblInputArrivee.Size = new Size(50, 15);
            lblInputArrivee.TabIndex = 6;
            lblInputArrivee.Text = "Arrivée :";
            // 
            // txtDepartItin
            // 
            txtDepartItin.Location = new Point(41, 147);
            txtDepartItin.Name = "txtDepartItin";
            txtDepartItin.Size = new Size(336, 23);
            txtDepartItin.TabIndex = 7;
            txtDepartItin.TextChanged += InputChanged;
            // 
            // txtArriveeItin
            // 
            txtArriveeItin.Location = new Point(41, 211);
            txtArriveeItin.Name = "txtArriveeItin";
            txtArriveeItin.Size = new Size(336, 23);
            txtArriveeItin.TabIndex = 8;
            txtArriveeItin.TextChanged += InputChanged;
            // 
            // lblHoraireItin
            // 
            lblHoraireItin.AutoSize = true;
            lblHoraireItin.Location = new Point(41, 259);
            lblHoraireItin.Name = "lblHoraireItin";
            lblHoraireItin.Size = new Size(52, 15);
            lblHoraireItin.TabIndex = 9;
            lblHoraireItin.Text = "Horaire :";
            // 
            // numMinuteDepItin
            // 
            numMinuteDepItin.Location = new Point(95, 277);
            numMinuteDepItin.Name = "numMinuteDepItin";
            numMinuteDepItin.Size = new Size(37, 23);
            numMinuteDepItin.TabIndex = 10;
            // 
            // numHeureDepItin
            // 
            numHeureDepItin.Location = new Point(41, 277);
            numHeureDepItin.Name = "numHeureDepItin";
            numHeureDepItin.Size = new Size(37, 23);
            numHeureDepItin.TabIndex = 11;
            // 
            // lblHeureDeuxPointsItin
            // 
            lblHeureDeuxPointsItin.AutoSize = true;
            lblHeureDeuxPointsItin.Location = new Point(79, 279);
            lblHeureDeuxPointsItin.Name = "lblHeureDeuxPointsItin";
            lblHeureDeuxPointsItin.Size = new Size(10, 15);
            lblHeureDeuxPointsItin.TabIndex = 12;
            lblHeureDeuxPointsItin.Text = ":";
            // 
            // FormItineraire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeureDeuxPointsItin);
            Controls.Add(numHeureDepItin);
            Controls.Add(numMinuteDepItin);
            Controls.Add(lblHoraireItin);
            Controls.Add(txtArriveeItin);
            Controls.Add(txtDepartItin);
            Controls.Add(lblInputArrivee);
            Controls.Add(lblInputDepart);
            Controls.Add(btnRechercheItin);
            Controls.Add(flpAffichageItin);
            Controls.Add(btnConnexionAdmin);
            Controls.Add(btnConsultation);
            Controls.Add(btnItineraire);
            Name = "FormItineraire";
            Text = "FormItineraire";
            Load += FormItineraire_Load;
            ((System.ComponentModel.ISupportInitialize)numMinuteDepItin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeureDepItin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnItineraire;
        private Button btnConsultation;
        private Button btnConnexionAdmin;
        private FlowLayoutPanel flpAffichageItin;
        private Button btnRechercheItin;
        private Label lblInputDepart;
        private Label lblInputArrivee;
        private TextBox txtDepartItin;
        private TextBox txtArriveeItin;
        private Label lblHoraireItin;
        private NumericUpDown numMinuteDepItin;
        private NumericUpDown numHeureDepItin;
        private Label lblHeureDeuxPointsItin;
    }
}
