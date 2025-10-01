namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            int userNumber;
            string userkey;
            int tries = 1;
            string input;

            Random rnd = new Random();
            randomNumber = rnd.Next(1, 101);

            while (true)
            {
             
                Console.Write("Deine Zahl (1..100): ");
                input = Console.ReadLine();
                userNumber = validInput(input);

                if (userNumber == randomNumber)
                {
                    Console.Write($"Die Zahl stimmt! Du hast total {tries} Versuche benötigt. \n" +
                                      $"Noch einmal spielen? [J/(N) Irgendeine Taste] ");

                    userkey = Convert.ToString(Console.ReadKey().KeyChar);
                    if (userkey.ToUpper() == "J")
                    {
                        Console.Clear();
                    }

                    else
                    {
                        break;
                    }
                }

                else if (userNumber < randomNumber)
                {
                    Console.Write("Zahl ist zu klein! Nächster Versuch. ");
                    tries = tries + 1;
                }

                else if (userNumber > randomNumber)
                {
                    Console.Write("Zahl ist zu gross! Nächster Versuch. ");
                    tries = tries + 1;
                }
            }
            


        }
        static int validInput(string input)
        {
            int inputParsed;
            while (true)
            {
                if (int.TryParse (input, out inputParsed)) 
                {
                    if (inputParsed >= 1 && inputParsed <= 100)
                    {
                        return inputParsed;
                    }

                    else
                    {
                        Console.Write("Eingabefehler. Bitte eine Ganzzahl von 1 - 100 eingeben.");
                        input = Console.ReadLine();
                    }
                }

                else
                {
                    Console.Write("Eingabefehler. Bitte eine Ganzzahl von 1 - 100 eingeben.");
                    input = Console.ReadLine();
                }

                
            }


        }
    }
}
