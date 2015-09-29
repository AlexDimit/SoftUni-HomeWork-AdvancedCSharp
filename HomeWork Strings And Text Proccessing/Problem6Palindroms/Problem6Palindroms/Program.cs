using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6Palindroms
{
    class Program
    {

        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder word = new StringBuilder();
            SortedSet<string> palindromes = new SortedSet<string>();

            for (int i = 0; i < input.Length; i++)
            {
                while (char.IsLetter(input[i]))
                {
                    word.Append(input[i]);
                    i++;
                    if (i >= input.Length)
                    {
                        break;
                    }
                }
                if (word.ToString() == Reversing(word) && word.ToString() != string.Empty)
                {
                    palindromes.Add(word.ToString());
                }
                word.Clear();
            }
          Console.WriteLine(string.Join(", ", palindromes));
        }
        static string Reversing(StringBuilder word)
        {
            StringBuilder reversedWord = new StringBuilder();
            for (int j = word.Length - 1; j >= 0; j--)
            {
                reversedWord.Append(word[j]);
            }
            return reversedWord.ToString();
        }
    }
}
