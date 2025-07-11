﻿using Base_de_données;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormModifierLigne : Form
    {
        private List<Ligne> lignes;
        private List<Station> stations;
        private List<Correspondance> correspondances;

        public FormModifierLigne()
        {
            InitializeComponent();
        }

        private void FormModifierLigne_Load(object sender, EventArgs e)
        {
            btnConsultation.Enabled = true;
            btnItineraire.Enabled = true;
            btnConnexionAdmin.Enabled = false;
            btnModifier.Enabled = false;
            btnAjouter.Enabled = true;
            btnSupprimer.Enabled = true;

            btnConsultation.FlatStyle = btnItineraire.FlatStyle =
                btnAjouter.FlatStyle = btnSupprimer.FlatStyle = FlatStyle.Standard;

            btnConnexionAdmin.BackColor = btnModifier.BackColor = Color.DodgerBlue;
            btnConnexionAdmin.ForeColor = btnModifier.ForeColor = Color.White;
            btnConnexionAdmin.FlatStyle = btnModifier.FlatStyle = FlatStyle.Flat;
            btnConnexionAdmin.FlatAppearance.BorderSize = btnModifier.FlatAppearance.BorderSize = 0;

            BD.connexion();
            lignes = BD.LectureLignes();
            stations = BD.LectureStations();
            correspondances = BD.LectureCorrespondances(stations, lignes);

            cbxNomLigne.DataSource = lignes;
            cbxNomLigne.DisplayMember = "NomLigne";
            cbxNomLigne.ValueMember = "IdLigne";
            cbxNomLigne.SelectedIndex = -1;

            cbxNomStation.DataSource = stations;
            cbxNomStation.DisplayMember = "NomStation";
            cbxNomStation.ValueMember = "IdStation";
            cbxNomStation.SelectedIndex = -1;

            cbxNomLigne.SelectedIndexChanged += cbxNomLigne_SelectedIndexChanged;
            cbxNomStation.SelectedIndexChanged += cbxNomStation_SelectedIndexChanged;
            txtNouvelleCouleurLigne.TextChanged += ChampsModifies;
        }

        private void btnItineraire_Click(object sender, EventArgs e) => OuvrirForm(new FormItineraire());
        private void btnConsultation_Click(object sender, EventArgs e) => OuvrirForm(new FormConsultation());
        private void btnConnexionAdmin_Click(object sender, EventArgs e) => OuvrirForm(new FormConnexionAdmin());
        private void btnAjouter_Click(object sender, EventArgs e) => OuvrirForm(new FormAjouter());
        private void btnModifier_Click(object sender, EventArgs e) => OuvrirForm(new FormModifier());
        private void btnSupprimer_Click(object sender, EventArgs e) => OuvrirForm(new FormSupprimer());

        private void OuvrirForm(Form form)
        {
            form.Show();
            Close();
        }

        private void cbxNomLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNomLigne.SelectedItem is Ligne ligne)
            {
                txtNouvelleCouleurLigne.Text = ligne.CouleurLigne;
            }
            VerifierActivationBouton();
        }

        private void cbxNomStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHorairesStationLigne.Items.Clear();

            if (cbxNomStation.SelectedItem is Station station)
            {
                var horaires = correspondances
                    .Where(c => c.StationA.IdStation == station.IdStation)
                    .Select(c => c.HoraireDep)
                    .Distinct()
                    .OrderBy(h => h);

                foreach (var h in horaires)
                    lstHorairesStationLigne.Items.Add(h.ToString(@"hh\:mm"));
            }

            VerifierActivationBouton();
        }

        private void ChampsModifies(object sender, EventArgs e) => VerifierActivationBouton();

        private void VerifierActivationBouton()
        {
            btnEnregistrerModifLigne.Enabled =
                cbxNomLigne.SelectedItem != null &&
                cbxNomStation.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(txtNouvelleCouleurLigne.Text);
        }

        private void btnEnregistrerModifLigne_Click(object sender, EventArgs e)
        {
            if (cbxNomLigne.SelectedItem is Ligne ligneSelectionnee)
            {
                string nouvelleCouleur = txtNouvelleCouleurLigne.Text.Trim();
                if (!string.IsNullOrEmpty(nouvelleCouleur))
                {
                    var ligneModifiee = new Ligne(ligneSelectionnee.IdLigne, nouvelleCouleur, ligneSelectionnee.NomLigne);
                    try
                    {
                        BD.ModifierLigne(ligneModifiee);
                        MessageBox.Show("Ligne modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNouvelleCouleurLigne.Clear();
                        cbxNomLigne.SelectedIndex = -1;
                        cbxNomStation.SelectedIndex = -1;
                        lstHorairesStationLigne.Items.Clear();
                        btnEnregistrerModifLigne.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
