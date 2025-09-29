namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = 0;
            string input;

            Console.WriteLine("Berechnung von Sekunden eins Moats in Abhängigkeit seiner Anzahl Tage");
            Console.Write("\n\nWie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen? ");
            input = Console.ReadLine();

            while (true)
            {
         
                if (int.TryParse(input, out days))
                {
                    if (days < 32 && days > 27)
                    {
                        break;
                    }

                    else
                    {
                        Console.Write($"Es gibt kein Monat mit {input} Tagen ");
                        input = Console.ReadLine();
                    }
                }
                

                else if (int.TryParse(input, out days) == false)
                {
                    Console.Write("Eingabefehler, die Eingabe muss eine Ganzzahl von 28 - 31 sein. ");
                    input = Console.ReadLine();
                }

            }

            Console.WriteLine($"Ein Monat mit {days} Tagen, hat {days * 86400} Sekunden.");





        }
    }
}
