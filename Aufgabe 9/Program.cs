namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binNumber = "";
            int decNumber;
            int rest;
            int decNumberUnchanged;
            string input;


            Console.Write("Dezimalzahl:\t");
            input = Console.ReadLine();
            decNumberUnchanged = decNumber;

            while (decNumber > 0)
            {
                rest = decNumber % 2;
                binNumber = rest + binNumber;
                decNumber = decNumber / 2;
            }

            Console.WriteLine($"\n\nDezimal: \t{input}");
            Console.WriteLine("Binär: \t\t" + binNumber);

        }
    }
}
