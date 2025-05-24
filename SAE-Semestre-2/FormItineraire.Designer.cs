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
            btnItineraire.Location = new Point(163, 39);
            btnItineraire.Margin = new Padding(3, 4, 3, 4);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(194, 31);
            btnItineraire.TabIndex = 0;
            btnItineraire.Text = "Trouver un itinéraire";
            btnItineraire.UseVisualStyleBackColor = true;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(365, 39);
            btnConsultation.Margin = new Padding(3, 4, 3, 4);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(194, 31);
            btnConsultation.TabIndex = 1;
            btnConsultation.Text = "Consulter les horaires";
            btnConsultation.UseVisualStyleBackColor = true;
            // 
            // btnConnexionAdmin
            // 
            btnConnexionAdmin.Location = new Point(566, 39);
            btnConnexionAdmin.Margin = new Padding(3, 4, 3, 4);
            btnConnexionAdmin.Name = "btnConnexionAdmin";
            btnConnexionAdmin.Size = new Size(194, 31);
            btnConnexionAdmin.TabIndex = 2;
            btnConnexionAdmin.Text = "Espace Administrateur";
            btnConnexionAdmin.UseVisualStyleBackColor = true;
            // 
            // flpAffichageItin
            // 
            flpAffichageItin.Location = new Point(490, 172);
            flpAffichageItin.Margin = new Padding(3, 4, 3, 4);
            flpAffichageItin.Name = "flpAffichageItin";
            flpAffichageItin.Size = new Size(391, 412);
            flpAffichageItin.TabIndex = 3;
            // 
            // btnRechercheItin
            // 
            btnRechercheItin.Location = new Point(163, 468);
            btnRechercheItin.Margin = new Padding(3, 4, 3, 4);
            btnRechercheItin.Name = "btnRechercheItin";
            btnRechercheItin.Size = new Size(181, 31);
            btnRechercheItin.TabIndex = 4;
            btnRechercheItin.Text = "Rechercher un itinéraire";
            btnRechercheItin.UseVisualStyleBackColor = true;
            // 
            // lblInputDepart
            // 
            lblInputDepart.AutoSize = true;
            lblInputDepart.Location = new Point(47, 172);
            lblInputDepart.Name = "lblInputDepart";
            lblInputDepart.Size = new Size(62, 20);
            lblInputDepart.TabIndex = 5;
            lblInputDepart.Text = "Départ :";
            // 
            // lblInputArrivee
            // 
            lblInputArrivee.AutoSize = true;
            lblInputArrivee.Location = new Point(47, 257);
            lblInputArrivee.Name = "lblInputArrivee";
            lblInputArrivee.Size = new Size(63, 20);
            lblInputArrivee.TabIndex = 6;
            lblInputArrivee.Text = "Arrivée :";
            // 
            // txtDepartItin
            // 
            txtDepartItin.Location = new Point(47, 196);
            txtDepartItin.Margin = new Padding(3, 4, 3, 4);
            txtDepartItin.Name = "txtDepartItin";
            txtDepartItin.Size = new Size(383, 27);
            txtDepartItin.TabIndex = 7;
            // 
            // txtArriveeItin
            // 
            txtArriveeItin.Location = new Point(47, 281);
            txtArriveeItin.Margin = new Padding(3, 4, 3, 4);
            txtArriveeItin.Name = "txtArriveeItin";
            txtArriveeItin.Size = new Size(383, 27);
            txtArriveeItin.TabIndex = 8;
            // 
            // lblHoraireItin
            // 
            lblHoraireItin.AutoSize = true;
            lblHoraireItin.Location = new Point(47, 345);
            lblHoraireItin.Name = "lblHoraireItin";
            lblHoraireItin.Size = new Size(66, 20);
            lblHoraireItin.TabIndex = 9;
            lblHoraireItin.Text = "Horaire :";
            // 
            // numMinuteDepItin
            // 
            numMinuteDepItin.Location = new Point(109, 369);
            numMinuteDepItin.Margin = new Padding(3, 4, 3, 4);
            numMinuteDepItin.Name = "numMinuteDepItin";
            numMinuteDepItin.Size = new Size(42, 27);
            numMinuteDepItin.TabIndex = 10;
            // 
            // numHeureDepItin
            // 
            numHeureDepItin.Location = new Point(47, 369);
            numHeureDepItin.Margin = new Padding(3, 4, 3, 4);
            numHeureDepItin.Name = "numHeureDepItin";
            numHeureDepItin.Size = new Size(42, 27);
            numHeureDepItin.TabIndex = 11;
            // 
            // lblHeureDeuxPointsItin
            // 
            lblHeureDeuxPointsItin.AutoSize = true;
            lblHeureDeuxPointsItin.Location = new Point(90, 372);
            lblHeureDeuxPointsItin.Name = "lblHeureDeuxPointsItin";
            lblHeureDeuxPointsItin.Size = new Size(12, 20);
            lblHeureDeuxPointsItin.TabIndex = 12;
            lblHeureDeuxPointsItin.Text = ":";
            // 
            // FormItineraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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
