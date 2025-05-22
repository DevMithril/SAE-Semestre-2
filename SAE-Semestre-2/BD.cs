using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_de_données;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SAE_Semestre_2
{
    public static class BD
    {
        private static MySqlConnection conn;

        public static bool connexion()
        {
            string serveur = "10.1.139.236";
            string login = "b2";
            string mdp = "raoulmdp";
            string bd = "baseb2";

            string chaineConnexion = $"server = {serveur};uid = {login};pwd = {mdp};database = {bd}";
            conn = new MySqlConnection(chaineConnexion);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }

            return (conn.State == System.Data.ConnectionState.Open);
        }

        public static bool fermeture()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
            return (conn.State == System.Data.ConnectionState.Closed);
        }

        public static void AjouterLigne(Ligne ligne)
        {
            string sql = "INSERT INTO ligne (couleur_ligne, nom_ligne) VALUES (@couleur, @nom)";
            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@couleur", ligne.CouleurLigne);
            cmd.Parameters.AddWithValue("@nom", ligne.NomLigne);
            cmd.ExecuteNonQuery();
        }

        public static void ModifierLigne(Ligne ligne)
        {
            string sql = "UPDATE ligne SET couleur_ligne = @couleur, nom_ligne = @nom WHERE id_ligne = @id";
            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@couleur", ligne.CouleurLigne);
            cmd.Parameters.AddWithValue("@nom", ligne.NomLigne);
            cmd.Parameters.AddWithValue("@id", ligne.IdLigne);
            cmd.ExecuteNonQuery();
        }

        public static void SupprimerLigne(int idLigne)
        {
            string sql = "DELETE FROM ligne WHERE id_ligne = @id";
            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", idLigne);
            cmd.ExecuteNonQuery();
        }

        public static void AjouterStation(Station station)
        {
            string sql = "INSERT INTO station (nom_station) VALUES (@nom)";
            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nom", station.NomStation);
            cmd.ExecuteNonQuery();
        }

        public static void ModifierStation(Station station)
        {
            string sql = "UPDATE station SET nom_station = @nom WHERE id_station = @id";
            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nom", station.NomStation);
            cmd.Parameters.AddWithValue("@id", station.IdStation);
            cmd.ExecuteNonQuery();
        }

        public static void SupprimerStation(int idStation)
        {
            string sql = "DELETE FROM station WHERE id_station = @id";
            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", idStation);
            cmd.ExecuteNonQuery();
        }

        public static void AjouterCorrespondance(Correspondance c)
        {
            try
            {
                string sql = @"INSERT INTO correspondances 
                       (id_stationA, id_stationB, horaire_dep, horaire_arr, id_ligne) 
                       VALUES (@idA, @idB, @dep, @arr, @idLigne)";
                using MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idA", c.StationA.IdStation);
                cmd.Parameters.AddWithValue("@idB", c.StationB.IdStation);
                cmd.Parameters.AddWithValue("@dep", c.HoraireDep);
                cmd.Parameters.AddWithValue("@arr", c.HoraireArr);
                cmd.Parameters.AddWithValue("@idLigne", c.Ligne.IdLigne);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur AjouterCorrespondance : " + ex.Message);
            }
        }

        public static void SupprimerCorrespondance(Correspondance c)
        {
            try
            {
                string sql = @"DELETE FROM correspondances 
                       WHERE id_stationA = @idA 
                         AND id_stationB = @idB 
                         AND horaire_dep = @dep";
                using MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idA", c.StationA.IdStation);
                cmd.Parameters.AddWithValue("@idB", c.StationB.IdStation);
                cmd.Parameters.AddWithValue("@dep", c.HoraireDep);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur SupprimerCorrespondance : " + ex.Message);
            }
        }

        public static List<Ligne> LectureLignes()
        {
            List<Ligne> lignes = new List<Ligne>();
            try
            {
                string reqSQL = "SELECT * FROM ligne";
                using MySqlCommand cmd = new MySqlCommand(reqSQL, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = rdr.GetInt32("id_ligne");
                    string couleur = rdr.GetString("couleur_ligne");
                    string nom = rdr.GetString("nom_ligne");
                    Ligne ligne = new Ligne(id, couleur, nom);
                    lignes.Add(ligne);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur LectureLignes : " + ex.Message);
            }

            return lignes;
        }
        public static List<Station> LectureStations()
        {
            List<Station> stations = new List<Station>();
            try
            {
                string reqSQL = "SELECT * FROM station";
                using MySqlCommand cmd = new MySqlCommand(reqSQL, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = rdr.GetInt32("id_station");
                    string nom = rdr.GetString("nom_station");
                    Station station = new Station(id, nom);
                    stations.Add(station);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur LectureStations : " + ex.Message);
            }

            return stations;
        }

        public static List<Admin> LectureAdmins()
        {
            List<Admin> admins = new List<Admin>();

            try
            {
                string reqSQL = "SELECT * FROM admin";
                using MySqlCommand cmd = new MySqlCommand(reqSQL, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int id = rdr.GetInt32("id_admin");
                    string mdp = rdr.GetString("mdp_admin");
                    string login = rdr.GetString("login");
                    Admin admin = new Admin(id, mdp, login);
                    admins.Add(admin);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur LectureAdmins : " + ex.Message);
            }

            return admins;
        }

        public static List<Correspondance> LectureCorrespondances(List<Station> stations, List<Ligne> lignes)
        {
            List<Correspondance> correspondances = new List<Correspondance>();

            try
            {
                string reqSQL = "SELECT * FROM correspondances";
                using MySqlCommand cmd = new MySqlCommand(reqSQL, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int idStationA = rdr.GetInt32("id_stationA");
                    int idStationB = rdr.GetInt32("id_stationB");
                    TimeSpan horaireDep = rdr.GetTimeSpan("horaire_dep");
                    TimeSpan horaireArr = rdr.GetTimeSpan("horaire_arr");
                    int idLigne = rdr.GetInt32("id_ligne");

                    Station? stationA = stations.FirstOrDefault(s => s.IdStation == idStationA);
                    Station? stationB = stations.FirstOrDefault(s => s.IdStation == idStationB);
                    Ligne? ligne = lignes.FirstOrDefault(l => l.IdLigne == idLigne);

                    if (stationA != null && stationB != null && ligne != null)
                    {
                        Correspondance c = new Correspondance(stationA, stationB, horaireDep, horaireArr, ligne);
                        correspondances.Add(c);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur LectureCorrespondances : " + ex.Message);
            }

            return correspondances;
        }

    }
}
