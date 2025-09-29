namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };
            int monthNumber;
            string input;

            Console.Write("Bitte gib eine Ganzzahl von 1 - 12 ein: ");
            input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out monthNumber))
                {

                    if (monthNumber >= 0 && monthNumber <= 13)
                    {
                        break;
                    }

                    else
                    {
                        Console.Write($"Eingabefehler: {input} liegt nicht in 1 - 12 oder ist keine Ganzzahl: ");
                        input = Console.ReadLine();
                    }

                }

                else
                { 
                    Console.Write("Eingabefehler: Bitte gib eine Ganzzahl von 1 - 12 ein: ");
                }
            }

            Console.Write($"Monat: {months[monthNumber - 1]}");
        
        }
    }
}
