using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Problem6ExtractHyperlinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;
            StringBuilder sb = new StringBuilder();
            while (!((inputLine = Console.ReadLine()) == "END"))
            {
                sb.Append(inputLine);
            }
            string text = sb.ToString();
           
            string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'(?<url>[^']*)'|""(?<url>[^""]*)""|(?<url>[^\s>]+))[^>]*>";
            Regex users = new Regex(pattern);
            MatchCollection matches = users.Matches(text);
            foreach (Match hyperlink in matches)
            {
                Console.WriteLine(hyperlink.Groups["url"]);
            }
        }
    }
}
