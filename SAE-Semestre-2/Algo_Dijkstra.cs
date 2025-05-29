using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_Semestre_2
{

    /// Classe Algo_Dijkstra 
    ///trouver les plus courts chemins dans un graphe non orienté.
    /// Attributs :
    /// - matrix : matrice d'adjacence
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
        private int[,] matrix;
        private int[] distance;
        private bool[] visited;
        private int[] previous;
        private int n;

        /// Constructeur qui initialise la matrice et les structures internes.
        /// Paramètre d'entrée: adjacenceMatrice (d'adjacence du graphe).
        public Algo_Dijkstra(int[,] adjacenceMatrice)
        {
            this.matrix = adjacenceMatrice;
            this.n = matrix.GetLength(0);
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
        public void CalculerCheminMin(int start)
        {
            distance[start] = 0;

            for (int count = 0; count < n - 1; count++)
            {
                int u = MinDistance();
                if (u == -1) break;
                visited[u] = true;

                for (int v = 0; v < n; v++)
                {
                    if (!visited[v] && matrix[u, v] > 0 &&
                        distance[u] != int.MaxValue &&
                        distance[u] + matrix[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + matrix[u, v];
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
        public void AfficherChemin(int start, int end)
        {
            Console.WriteLine("Chemin du sommet " + start + " au sommet " + end + ":");
            if (distance[end] == int.MaxValue)
            {
                Console.WriteLine("Pas de chemin disponible.");
                return;
            }
            Console.Write("Distance: " + distance[end] + "\nChemin: ");
            PrintPath(end);
            Console.WriteLine();
        }
        /// Affiche récursivement le chemin jusqu'au sommet j.
        private void PrintPath(int j)
        {
            if (previous[j] == -1)
            {
                Console.Write(j);
                return;
            }
            PrintPath(previous[j]);
            Console.Write(" -> " + j);
        }
    }
}