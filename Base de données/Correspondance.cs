using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_données
{
    public class Correspondance
    {
        // Propriétés
        private Station _stationA;
        private Station _stationB;
        private TimeSpan _horaireDep;
        private TimeSpan _horaireArr;
        private Ligne _ligne;

        // Constructeur
        public Correspondance(Station stationA, Station stationB, TimeSpan horaireDep, TimeSpan horaireArr, Ligne ligne)
        {
            _stationA = stationA;
            _stationB = stationB;
            _horaireDep = horaireDep;
            _horaireArr = horaireArr;
            _ligne = ligne;
        }

        // Accesseurs
        public Station StationA { get { return _stationA; } }
        public Station StationB { get { return _stationB; } }
        public TimeSpan HoraireDep { get { return _horaireDep; } }
        public TimeSpan HoraireArr { get { return _horaireArr; } }
        public Ligne Ligne { get { return _ligne; } }
    }
}
