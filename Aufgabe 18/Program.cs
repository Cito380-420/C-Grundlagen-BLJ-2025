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
                zaehler.ErhoeheUmEins(Convert.ToString(input[i]));
            }

            
            Console.WriteLine(zaehler.HoleResultat());

        }
    }
}
