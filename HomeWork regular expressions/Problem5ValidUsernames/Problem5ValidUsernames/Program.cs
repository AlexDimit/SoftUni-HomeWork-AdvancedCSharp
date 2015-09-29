using System;
using System.Text.RegularExpressions;

namespace Problem5ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[a-zA-Z]\w{2,24}\b";
            Regex tries = new Regex(pattern);
            MatchCollection matches = tries.Matches(text);
            int first = 0;
            int second = 1;
            int bestSum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < matches.Count - 1; i++)
            {
                sum = matches[i].Length + matches[i + 1].Length;
                if (sum > bestSum)
                {
                    bestSum = sum;
                    first = i;
                    second = i + 1;
                }
            }
            Console.WriteLine(matches[first]);
            Console.WriteLine(matches[second]);
        }
        
    }
}
