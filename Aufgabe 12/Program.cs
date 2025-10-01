namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] a;
            int sum;


            Console.WriteLine("Geben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein:");
            string input = Console.ReadLine();
            int[] inputArray = input.Split(',').Select(int.Parse).ToArray();


            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"[{i}] -> {SumUp(inputArray)[i]}");
            }

        }

        static int[] SumUp(int[] arr)
        {

            int[] result = new int[arr.Length];

           

            return result;

        }

    }
}
