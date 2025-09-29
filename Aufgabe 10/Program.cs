namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int zahl1;

            while (true)
            {
                Console.Write("Quersumme von: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out zahl1))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("\nEingabefehler, bitte gib eine Ganzzahl ein, von der du die Quersumme wissen möchtest.");
                }
            }


            Console.WriteLine($"Quersumme: {BerechneQuersumme(zahl1)}");


            static int BerechneQuersumme(int zahl)
            {

                int sum = 0;

                while (zahl != 0) 
                {
                    sum = sum + (zahl % 10);
                    zahl = zahl / 10;
                }

                return sum;

            }
        }
    }
}
