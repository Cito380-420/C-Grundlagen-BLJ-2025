namespace Aufgabe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int forbiddenWordsCounter = 0;
            string comment;

            string[] forbiddenWords = {
            "viagra", "sex", "porno", "fick", "schlampe", "arsch",
            "hurensohn", "fotze", "drecksau", "wichser", "nutte", "miststück",
            "pimmel", "schwanz", "hure", "bitch", "anal", "fuck",
            "motherfucker", "cunt", "slut", "dildo", "vergewaltigung", "penis",
            "vagina", "ejakulat", "sperma", "oral", "gangbang", "fetisch",
            "arschloch", "kacke", "scheiße", "dummkopf", "trottel", "idiot",
            "spast", "opfer", "lappen", "schwachkopf", "blödmann", "vollidiot",
            "kotze", "mistkerl", "sau", "schwein", "verpiss", "ekelhaft"
            };

            Console.WriteLine("Dein Kommentar:");
            comment = Console.ReadLine();

            comment = comment.ToLower();

            for (i = 0; i < forbiddenWords.Length; i++)
            {
                if (comment.Contains(forbiddenWords[i]))
                {
                    forbiddenWordsCounter = forbiddenWordsCounter + 1;
                }
            }

            if (forbiddenWordsCounter == 0)
            {
                Console.WriteLine("\nVielen Dank für deinen Kommentar.");
            }
            else
            {
                Console.WriteLine("\nDein Kommentar enthält " +  forbiddenWordsCounter.ToString()  + " verbotene Wörter." +
                                  "\nEr wird nicht veröffentlicht.");
            }
        }
    }
}
