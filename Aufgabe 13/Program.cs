using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthLine = validInput();

            for (int i = 1; i <= lengthLine; i++)
            {
                for (int i2 = 1; i2 <= lengthLine; i2++)
                {
                    if (i2 == i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }


        }



        static int validInput()
        {
            string input;
            int parsedInput;

            while (true)
            {
                

                Console.WriteLine("Wie lange soll die Linie sein?");
                Console.Write("Deine Eingabe: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out parsedInput))
                {
                    if (parsedInput > 0)
                    {
                        Console.WriteLine("\n");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("\n\nEingabefehler: Bitte nur positive Ganzzahlen.");
                }

            }

            return parsedInput;

        }


    }
}
