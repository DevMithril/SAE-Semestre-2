using Base_de_données;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Semestre_2
{
    public partial class FormConsultation : Form
    {
        private List<Station> stations;
        private List<Ligne> lignes;
        private List<Correspondance> correspondances;
        private Ligne ligneSelectionnee = null;

        public FormConsultation()
        {
            InitializeComponent();
        }

        // Formulaire pour consulter les horaires des stations
        private void FormConsultation_Load(object sender, EventArgs e)
        {
            // Connexion et chargement des données depuis la base
            if (!BD.connexion())
            {
                MessageBox.Show("Erreur de connexion à la base de données.");
                return;
            }
            stations = BD.LectureStations();
            lignes = BD.LectureLignes();
            correspondances = BD.LectureCorrespondances(stations, lignes);
            BD.fermeture();

            // Remplissage des listes déroulantes (stations et lignes)
            cbxStationConsult.Items.AddRange(stations.Select(s => s.NomStation).ToArray());
            cbxLigneConsult.Items.Add("Toutes les lignes");
            cbxLigneConsult.Items.AddRange(lignes.Select(l => l.NomLigne).ToArray());
            cbxLigneConsult.SelectedIndex = 0;
            if (cbxStationConsult.Items.Count > 0) cbxStationConsult.SelectedIndex = 0;

            // Configuration des boutons (visuel et activation)
            btnConsultation.Enabled = false;
            btnConsultation.BackColor = Color.DodgerBlue;
        }

        private void cbxLigneConsult_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise à jour de la ligne sélectionnée pour filtrer
            if (cbxLigneConsult.SelectedItem.ToString() == "Toutes les lignes")
                ligneSelectionnee = null;
            else
                ligneSelectionnee = lignes.FirstOrDefault(l => l.NomLigne == cbxLigneConsult.SelectedItem.ToString());

            // Actualisation de la liste des horaires
            if (cbxStationConsult.SelectedItem != null)
                cbxStationConsult_SelectedIndexChanged(sender, e);
        }

        private void cbxStationConsult_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Affiche les horaires selon la station et la ligne sélectionnées
            lstHorairesConsult.Items.Clear();
            string nomStation = cbxStationConsult.SelectedItem?.ToString();
            if (nomStation == null) return;

            Station stationChoisie = stations.FirstOrDefault(s => s.NomStation == nomStation);
            if (stationChoisie == null) return;

            if (!BD.connexion())
            {
                MessageBox.Show("Erreur de connexion à la base de données.");
                return;
            }
            correspondances = BD.LectureCorrespondances(stations, lignes);
            BD.fermeture();

            var resultats = correspondances
                .Where(c => c.StationA.IdStation == stationChoisie.IdStation &&
                            (ligneSelectionnee == null || c.Ligne.IdLigne == ligneSelectionnee.IdLigne))
                .OrderBy(c => c.HoraireDep)
                .ToList();

            if (resultats.Count == 0)
            {
                lstHorairesConsult.Items.Add("Aucun départ trouvé pour cette station.");
                return;
            }

            foreach (var c in resultats)
            {
                lstHorairesConsult.Items.Add($"{c.HoraireDep:hh\\:mm} → {c.StationB.NomStation} ({c.Ligne.NomLigne})");
            }
        }

        private void btnItineraire_Click(object sender, EventArgs e)
        {
            new FormItineraire().Show();
            this.Hide();
        }

        private void btnConnexionAdmin_Click(object sender, EventArgs e)
        {
            new FormConnexionAdmin().Show();
            this.Hide();
        }
    }
}
