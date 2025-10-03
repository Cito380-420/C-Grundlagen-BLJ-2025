using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_18
{
    public class VokaleZaehler
    {
        private Dictionary<char, int> vokale = new Dictionary<char, int>();

        public void ErhoeheUmEins(char vokal)
        {
            if (vokal == 'a')
            {
                if (!vokale.Keys.Contains(vokal))
                    vokale.Add(vokal, 0);

                vokale[vokal]++;
            }
        }

        public string HoleResultat()
        {
            string resultat = "";

            foreach (char key in vokale.Keys)
            {
                resultat += key + ": " + vokale[key] + " mal" + Environment.NewLine;
            }
            

            return resultat;
        }
    }
}
