using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aufgabe_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string userkey;
            do
            {
                WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string json = new StreamReader(responseStream).ReadToEnd();


                JArray array = JArray.Parse(json);

                Console.WriteLine(array[0].SelectToken("text"));

                Console.Write("\nNächsten Witz holen? j/n: ");
                userkey = Convert.ToString(Console.ReadKey().KeyChar);
                if (userkey.ToUpper() == "J")
                {
                    Console.Clear();

                    //Console.WriteLine("\n\n\n");
                }

                else
                {
                    break;
                }

            }
            while (true);
        }
    }
}
