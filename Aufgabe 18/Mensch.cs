using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_18
{
    public class Mensch 
    {
        public int Koerpergroesse;
        public Color Haarfarbe;
        public string Vorname;
        public Herz Herz;

        // Konstruktor
        public Mensch(string vorname)
        { 
            Vorname = vorname;
            Herz = new Herz(5000);
        }

        public bool  SagDeinenVorname()
        { 
            Console.WriteLine(Vorname);
            return true;
        }

       
    }
}
