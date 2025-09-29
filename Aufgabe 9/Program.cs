namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binNumber = "";
            int decNumber;
            int rest;
            int decNumberUnchanged;
            string input;

            while (true)
            {
                Console.Write("(Drücke 'q', um das Programm zu Beenden)\n" +
                              "Dezimalzahl:\t");

                input = Console.ReadLine();

                if (int.TryParse(input, out decNumber))
                {
                    decNumberUnchanged = decNumber;

                    while (decNumber > 0)
                    {
                        rest = decNumber % 2;
                        binNumber = rest + binNumber;
                        decNumber = decNumber / 2;
                    }

                    Console.WriteLine($"\nDezimal: \t{input}");
                    Console.WriteLine("Binär: \t\t" + binNumber + "\n\n\n");
                }

                else if (input.ToUpper() == "Q")
                {
                    break;
                }

                else
                {
                    Console.Write("\nEingabefehler, gib eine ganze Dezimalzahl ein\n\n");
                }
                    
            }


        }
    }
}
