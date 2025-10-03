namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            float[] calculation = new float[2];
            do
            {
                do
                {
                    Console.WriteLine("Make your calculation (or press Q to quit): ");
                    input = Console.ReadLine();

                    if (input == "q")
                        return; // beendet Methode Main

                    try
                    {
                        calculation = input.Split('+', '-', '/', '*').Select(float.Parse).ToArray();
                        break;
                    }
                    catch 
                    {
                        Console.WriteLine("Eingabefehler\n");
                    }
                }
                while (true);

                if (input.Contains('+'))
                {
                    Console.WriteLine(calculation[0] + calculation[1]);
                }
                else if (input.Contains('-'))
                {
                    Console.WriteLine(calculation[0] - calculation[1]);
                }
                else if (input.Contains('/'))
                {
                    Console.WriteLine(calculation[0] / calculation[1]);
                }
                else if (input.Contains('*'))
                {
                    Console.WriteLine(calculation[0] * calculation[1]);
                }
            }
            while (true);




        }
    }
}
