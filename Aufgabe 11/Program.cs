namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int number1;
            int number2;
            int numberTemp = 0;

            number1 = validInput(1);
            number2 = validInput(2);

            if (number2 < number1)
            {
                numberTemp = number1;
                number1 = number2;
                number2 = numberTemp;

            }

            while (number1 <= number2)
            {
                if (0 == number1 % quersummeBerechnen(number1))
                {
                    Console.WriteLine($"{number1}\t | {quersummeBerechnen(number1)} \t\t | {number1 / quersummeBerechnen(number1)}");
                }

                number1 = number1 + 1;
            }
        }

        ////Valid Input/////////////////////////////////////////////////////////   
        static int validInput(int whichNumber)
        {
            string input;
            int returnNumber;

            while (true)
            {
                Console.Write($"Zahl {whichNumber}: ");
                input = Console.ReadLine();


                if (int.TryParse(input, out returnNumber))
                {
                    return returnNumber;
                }

                else
                {
                    Console.WriteLine("Eingabefehler, bitte gib eine Ganzzahl ein.");
                }
            }

        }
        ////////////////////////////////////////////////////////////////////////  
        
        ////Quersumme berechnen/////////////////////////////////////////////////
        static int quersummeBerechnen(int numberFromUser)
        {
            int sum = 0;
            while (numberFromUser != 0)
            {
                sum = sum + (numberFromUser % 10);
                numberFromUser = numberFromUser / 10;
            }

            return sum;
        }
        ////////////////////////////////////////////////////////////////////////
    }
}
