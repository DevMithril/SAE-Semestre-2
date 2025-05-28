using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_données
{
    public class Station
    {
        // Propriétés
        private int _idStation;
        private string _nomStation;

        // Constructeur
        public Station(int idStation, string nomStation)
        {
            _idStation = idStation;
            _nomStation = nomStation;
        }

        // Accesseurs
        public int IdStation { get { return _idStation; } }
        public string NomStation { get { return _nomStation; } }
    }
}
