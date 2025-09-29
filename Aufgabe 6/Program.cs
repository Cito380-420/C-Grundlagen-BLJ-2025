using System;

namespace Aufgabe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 1;
            int i = 1;

            Console.WriteLine("--------------------");
            Console.WriteLine("--- Kleines 1x1 ----");
            Console.WriteLine("--------------------\n");

            while (number1 <= 10)
            {
                while (i <= 10)
                {
                    if (i == 1)
                    {
                        Console.Write(number1 * number2);
                        number2 = number2 + 1;
                        i = i + 1;
                    }

                    Console.Write("\t" + number1 * number2);
                    number2 = number2 + 1;
                    i = i + 1;
                }

                Console.WriteLine("\n");
                number1 = number1 + 1;
                number2 = 1;
                i = 1;

            }
            


        }
    }
}
