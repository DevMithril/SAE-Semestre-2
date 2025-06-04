using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_Semestre_2
{
    public class CalculTemps
    {
        private string heureDebut;
        private string heureFin;

        public CalculTemps(string heureDebut, string heureFin)
        {
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
        }

        private int ConvertirEnMinutes(string heure)
        {
            string[] parties = heure.ToLower().Split('h');
            int heures = int.Parse(parties[0]);
            int minutes = int.Parse(parties[1]);
            return heures * 60 + minutes;
        }

        public int CalculerDifference()
        {
            int debutMinutes = ConvertirEnMinutes(heureDebut);
            int finMinutes = ConvertirEnMinutes(heureFin);
            if (finMinutes < debutMinutes)
            {
                finMinutes += 24 * 60;
            }

            return finMinutes - debutMinutes;
        }
    }

}
