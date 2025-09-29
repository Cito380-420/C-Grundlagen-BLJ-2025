namespace _00_Input_prüfen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int zahl = 0;
            string input;

            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein.");
                input = Console.ReadLine();
            }
            while (int.TryParse(input, out zahl) == false);

            //int b = 1000000;
            //int a = -1000000;


            //while (true)
            //{ 
            //    Console.WriteLine(b);
            //    b = b - 1;
            //    Console.WriteLine(a);
            //    a = a + 1;

            //}

        }
    }
}
