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
                Console.Write($"\n[{i}] -> {SumUp(inputArray)[i]}");

                if (i != inputArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }

        }

        static int[] SumUp(int[] arr)
        {

            int[] result = (int[]) arr.Clone();

            for (int i = 1; i < result.Length; i++)
            {
                result[i] = result[i] + result[i - 1];
            }

            return result;

        }

    }
}
