namespace Aufgabe_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersFrom1to30 = 1;
            int firstevisor = 3;
            int secondevisor = 5;

            Console.WriteLine("Zahlen zwischen 1 - 30, die durch 5 oder 3 ohne Rest teilbar sind:");

            while (numbersFrom1to30 <= 30)
            {
                if (numbersFrom1to30 % 3 == 0 || numbersFrom1to30 % 5 == 0)
                {
                    if (numbersFrom1to30 == 30)
                    {
                        Console.Write(numbersFrom1to30);
                    }
                    else
                    {
                        Console.Write(numbersFrom1to30 + ", ");
                    }
                        
                }

                numbersFrom1to30 = numbersFrom1to30 + 1;
            }
            
        }
    }
}
