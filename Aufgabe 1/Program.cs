namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number1;
            float number2;
            string input;

            Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");

            do
            {
                Console.Write("Zahl 1: ");
                input = Console.ReadLine();
            }
            while (float.TryParse(input, out number1) == false);
            
            do
            {
                Console.Write("Zahl 2: ");
                input = Console.ReadLine();
            }
            while(float.TryParse(input, out number2) == false);
            

            Console.WriteLine($"Die Summe von {number1} und {number2} ist {number1 + number2}");
        }
    }
}
