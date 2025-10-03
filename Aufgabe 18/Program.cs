using System.Diagnostics.Metrics;
using System.Drawing;

namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VokaleZaehler zaehler = new VokaleZaehler();

            for (int i = 0; i < input.Length; i++)
            {
               
                zaehler.ErhoeheUmEins(input[i]);
            }

            



            Console.WriteLine(zaehler.HoleResultat());

            //Mensch damir = new Mensch("Hans");

            //damir.Haarfarbe = Color.Red;
            //damir.Koerpergroesse = 185;

            //Herz damirsHerz = damir.Herz;

            //char[] vokale = { 'e', 'a', 'i' };
            //int[] zaehler = { 0, 0, 0 };
            //zaehler[1]++; 


            //int counterA;
            //int counterE;
            //int counterI;
            //int counterO;
            //int counterU;
            //int counterÜ;
            //int counterÖ;
            //int counterÄ;

            //Console.WriteLine("Hello, World!");
        }
    }
}
