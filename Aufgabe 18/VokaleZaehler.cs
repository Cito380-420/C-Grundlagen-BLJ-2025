using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_18
{
    public class VokaleZaehler
    {
        private Dictionary<string, int> vokale = new Dictionary<string, int>();

        public void ErhoeheUmEins(string vokal)
        {
            if (vokal.ToLower() == "a" || vokal.ToLower() == "e" || vokal.ToLower() == "i" || vokal.ToLower() == "o" || vokal.ToLower() == "u" || vokal.ToLower() == "ä" || vokal.ToLower() == "ö" || vokal.ToLower() == "ü")
            {
                if (!vokale.Keys.Contains(vokal))
                    vokale.Add(vokal, 0);

                vokale[vokal]++;
            }
        }

        public string HoleResultat()
        {
            string resultat = "";

            foreach (string key in vokale.Keys)
            {
                resultat += key + ": " + vokale[key] + " mal" + Environment.NewLine;
            }
            
            return resultat;
        }
    }
}
