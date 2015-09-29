using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5UnicodeCharecters
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 100)
                    Console.Write("\\u0" + (int)input[i]);
                else
                    Console.Write("\\u00" + (int)input[i]);
            }
            Console.WriteLine();
        }
    }
}
