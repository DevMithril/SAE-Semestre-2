using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_données
{
    public class Ligne
    {
        // Propriétés
        private int _idLigne;
        private string _couleurLigne;
        private string _nomLigne;

        // Constructeur
        public Ligne(int idLigne, string couleurLigne, string nomLigne)
        {
            _idLigne = idLigne;
            _couleurLigne = couleurLigne;
            _nomLigne = nomLigne;
        }

        // Accesseurs
        public int IdLigne { get { return _idLigne; } }
        public string CouleurLigne { get { return _couleurLigne; } }
        public string NomLigne { get { return _nomLigne; } }
    }
}
}
