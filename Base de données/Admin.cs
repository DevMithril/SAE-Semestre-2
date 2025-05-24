using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_données
{
    public class Admin
    {
        // Propriétés
        private int _idAdmin;
        private string _mdpAdmin;
        private string _login;

        // Constructeur
        public Admin(int idAdmin, string mdpAdmin, string login)
        {
            _idAdmin = idAdmin;
            _mdpAdmin = mdpAdmin;
            _login = login;
        }

        // Accesseurs
        public int IdAdmin { get { return _idAdmin; } }
        public string MotDePasse { get { return _mdpAdmin; } }
        public string Login { get { return _login; } }
    }
}
