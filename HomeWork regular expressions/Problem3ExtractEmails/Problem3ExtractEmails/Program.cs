using System;
using System.Text.RegularExpressions;

namespace Problem3ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[\w_.]+@[._\w]+\.\w+\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
