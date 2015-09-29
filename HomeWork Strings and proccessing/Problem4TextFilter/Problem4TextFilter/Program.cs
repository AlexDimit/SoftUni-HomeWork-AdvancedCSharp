using System;

namespace Problem4TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] separator = new string[] { ",", " " };
            string[] bannedWords = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string burp = text;

            for (int i = 0; i < bannedWords.Length; i++)
            {
                if (text.Contains(bannedWords[i]))
                {
                   burp = text.Replace(bannedWords[i],new string ('*',bannedWords[i].Length));
                }
                text = burp.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            Console.WriteLine(text);


        }
    }
}
