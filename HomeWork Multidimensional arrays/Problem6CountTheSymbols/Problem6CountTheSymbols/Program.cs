using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6CountTheSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for(int i = 0; i < input.Length; i++)
            {
                if(charCount.ContainsKey(input[i]))
                {
                    charCount[input[i]] += 1;
                }
                else
                {
                    charCount.Add(input[i], 1);
                }
            }

            SortedDictionary<char, int> sortedCharCount = new SortedDictionary<char,int>(charCount);

            printDictionary(sortedCharCount);

            Console.ReadLine();

        }

        static void printDictionary(SortedDictionary<char, int> dic)
        {
            List<char> keys = new List<char>(dic.Keys);

            foreach(char key in keys)
            {
                Console.WriteLine("{0} : {1} time/s", key, dic[key]);
            }
        }
    }
}
