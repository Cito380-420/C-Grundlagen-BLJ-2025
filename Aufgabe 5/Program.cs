namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int howManyKilometers;
            double howManyRounds;
            string input;
            string readyForRun;
            int i = 1;
             
            Console.Write("Wie viele ganze Kilometer möchtest du rennen? ");
            input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out howManyKilometers))
                {
                    break;
                }

                else
                {
                    Console.Write("Bitte gib eine Ganzzahl ein -> Wie viele ganze Kilometer möchtest du rennen? ");
                    input = Console.ReadLine();
                }
            }

            if (howManyKilometers < 42)
            {
                howManyRounds = Convert.ToSingle(howManyKilometers) / 0.4;
                Console.WriteLine($"Das sind {howManyRounds} Runden.");

                Console.Write("Bist du Bereit? (Ja / Nein) ");
                readyForRun = Console.ReadLine();
                while (true)
                {
                    if (readyForRun.ToUpper() == "JA")
                    {
                        while (i <= howManyRounds)
                        {
                            Console.WriteLine($"Du läufst Runde {i}");
                            i++;
                        }
                    }

                    else if (readyForRun.ToUpper() == "NEIN")
                    {
                        break;
                    }

                    else
                    {
                        Console.Write("Eingabefehler: Bist du Bereit? (Ja / Nein) ");
                        readyForRun = Console.ReadLine();
                    }


                }
            }

            else
            {
                Console.WriteLine("Das schaffst du nicht!");
            }

        }
    }
}
