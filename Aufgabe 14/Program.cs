using System.Diagnostics;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                int year;
                string input;

                Console.Write("Eingabe Jahr (q to quit): ");
                input = Console.ReadLine();

                if (int.TryParse(input, out year))
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine($"Das Jahr {year} ist ein Schaltjahr\n");
                    }
                    else
                    {
                        Console.WriteLine($"Das Jahr {year} ist kein Schaltjahr\n");
                    }
                }

                else if (input == "q")
                {
                    Console.WriteLine("Das Programm wird beendet.");
                    break;
                }

            }
        }
    }
}
