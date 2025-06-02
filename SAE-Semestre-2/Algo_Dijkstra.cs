using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_Semestre_2
{
    /// Classe Station 
    ///Stocker les données d'une station.
    /// Attributs :
    /// - id_station : matrice d'adjacence
    /// - nom_station : tableau des distances minimales depuis le sommet de départ
    /// - correspondance_station : tableau des sommets déjà visités
    class Algo_Dijkstra_Station
    {
        private int id_station;
        private string nom_station;
        private Dictionary<int, int> correspondance_station;

        // Constructeur
        public Algo_Dijkstra_Station(int ID, string nom, Dictionary<int, int> corresp) 
        {
            id_station = ID;
            nom_station = nom;
            correspondance_station = corresp;
        }

        // Accesseurs
        public int Id_station { get { return id_station; } }
        public string Nom_station { get { return nom_station; } }
        public Dictionary<int, int> Correspondance_station { get { return correspondance_station; } }
    }

    class Matrice_de_station
    {
        private int[,] matrice;

        public Matrice_de_station(List<Algo_Dijkstra_Station> stations)
        {
            int taille = stations.Count;
            matrice = new int[taille, taille];

            // Initialisation à 0
            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    matrice[i, j] = 0;
                }
            }

            // Remplir la matrice avec les correspondances
            foreach (var station in stations)
            {
                int id = station.Id_station;
                foreach (var corresp in station.Correspondance_station)
                {
                    int id_corresp = corresp.Key;
                    int poids = corresp.Value;

                    if (id >= 0 && id < taille && id_corresp >= 0 && id_corresp < taille)
                    {
                        matrice[id, id_corresp] = poids;
                    }
                }
            }
        }

        // Méthode pour afficher la matrice (pour debug)
        public void AfficherMatrice()
        {
            int taille = matrice.GetLength(0);
            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Accesseurs
        public int[,] Matrice { get { return matrice; } }
    }

    /// Classe Algo_Dijkstra 
    ///trouver les plus courts chemins dans un graphe non orienté.
    /// Attributs :
    /// - matrice : matrice d'adjacence
    /// - distance : tableau des distances minimales depuis le sommet de départ
    /// - visited : tableau des sommets déjà visités
    /// - previous : tableau des prédécesseurs pour reconstruire les chemins
    /// - n : nombre de sommets
    ///
    /// Méthodes :
    /// - CalculerCheminMin(int start) : exécute l'algorithme depuis le sommet 'start'
    /// - AfficherChemin(int start) : affiche les distances et chemins depuis 'start'
    class Algo_Dijkstra
    {
        private int[,] matrice;
        private int[] distance;
        private bool[] visited;
        private int[] previous;
        private int n;

        /// Constructeur qui initialise la matrice et les structures internes.
        /// Paramètre d'entrée: adjacenceMatrice (d'adjacence du graphe).
        public Algo_Dijkstra(int[,] adjacenceMatrice)
        {
            this.matrice = adjacenceMatrice;
            this.n = matrice.GetLength(0);
            this.distance = new int[n];
            this.visited = new bool[n];
            this.previous = new int[n];

            for (int i = 0; i < n; i++)
            {
                distance[i] = int.MaxValue;
                visited[i] = false;
                previous[i] = -1;
            }
        }

        /// Exécute l'algorithme de Dijkstra à partir du sommet de départ.
        /// Paramètre d'entrée : start (Indice du sommet de départ).
        public void CalculerCheminMin(Algo_Dijkstra_Station start)
        {
            distance[start.Id_station] = 0;

            for (int count = 0; count < n - 1; count++)
            {
                int u = MinDistance();
                if (u == -1) break;
                visited[u] = true;

                for (int v = 0; v < n; v++)
                {
                    if (!visited[v] && matrice[u, v] > 0 &&
                        distance[u] != int.MaxValue &&
                        distance[u] + matrice[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + matrice[u, v];
                        previous[v] = u;
                    }
                }
            }
        }

        /// Retourne l'indice du sommet non visité ayant la distance minimale.
        private int MinDistance()
        {
            int min = int.MaxValue, minIndex = -1;
            for (int v = 0; v < n; v++)
            {
                if (!visited[v] && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }

        /// Affiche les distances et les chemins depuis le sommet de départ.
        /// Paramètre d'entrée : start (Indice du sommet de départ).
        ///                      end (Indice du sommet d'arrivé)
        public void AfficherChemin(Algo_Dijkstra_Station start, Algo_Dijkstra_Station end)
        {
            Console.WriteLine("Chemin entre " + start.Nom_station + " et " + end.Nom_station + ":");
            if (distance[end.Id_station] == int.MaxValue)
            {
                Console.WriteLine("Pas de chemin disponible.");
                return;
            }
            Console.Write("Distance: " + distance[end.Id_station] + "\nChemin: ");
            PrintPath(end, end.Id_station);
            Console.WriteLine();
        }
        /// Affiche récursivement le chemin jusqu'au sommet j.
        private void PrintPath(Algo_Dijkstra_Station station, int j)
        {
            if (previous[j] == -1)
            {
                Console.Write(station.Nom_station);
                return;
            }
            PrintPath(station, previous[j]);
            Console.Write(" -> " + station.Nom_station);
        }
    }
}