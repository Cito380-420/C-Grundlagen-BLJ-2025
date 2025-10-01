namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int breiteStamm = validInput("Wie breit soll der Stamm sein: ");
            int hoeheStamm = validInput("Wie hoch soll der Stamm sein: ");
            int hoeheKrone = validInput("Wie hoch soll die Krone sein: ");

            zeichneTannenbaum(hoeheKrone, breiteStamm, hoeheStamm);
            Console.WriteLine("\n\n");
           
        }
        static int validInput(string Frage)
        {
            string input;
            int parsedInput;

            while (true)
            {
                Console.Write(Frage);
                input = Console.ReadLine();

                if (int.TryParse(input, out parsedInput))
                {
                    return parsedInput;
                }

                else
                {
                    Console.WriteLine($"\nEingabefehler, bitte eine Ganzzahl eingeben.");
                }
            }
        }
        static void zeichneZeileStamm(int leerzeichen, int sterne)
        {
            for (int i = 0; i < leerzeichen; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0;i < sterne; i++)
            {
                Console.Write("\x1b[38;2;102;44;23m*\x1b[0m");
            }

        }
        static void zeichneZeileKrone(int leerzeichen, int sterne)
        {
            for (int i = 0; i < leerzeichen; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < sterne; i++)
            {
                Console.Write("\x1b[38;2;102;255;102m*");
            }

        }
        static void zeichneKrone(int kronenHoehe)
        {
            int leerzeichen = kronenHoehe - 1;
            int sterne = 1;

            for (int i = 0; i < kronenHoehe; i++)
            {
                Console.WriteLine();

                zeichneZeileKrone(leerzeichen, sterne);

                leerzeichen = leerzeichen - 1;
                sterne = sterne + 2;
                                
            }

            Console.WriteLine();
        }
        static void zeincheStamm(int kronenHoehe, int breiteStamm, int hoeheStamm)
        {
            int leerzeichen = (((kronenHoehe - 1) * 2 + 1) - breiteStamm)/2;
            int sterne = breiteStamm;

            for (int i = 0; i < hoeheStamm; i++)
            {
                zeichneZeileStamm(leerzeichen, sterne);
                Console.WriteLine();
            }

        }
        static void zeichneTannenbaum(int kronenHoehe, int breiteStamm, int hoeheStamm)
        {
            zeichneKrone(kronenHoehe);
            zeincheStamm(kronenHoehe, breiteStamm, hoeheStamm);
        }

        
    }
}
