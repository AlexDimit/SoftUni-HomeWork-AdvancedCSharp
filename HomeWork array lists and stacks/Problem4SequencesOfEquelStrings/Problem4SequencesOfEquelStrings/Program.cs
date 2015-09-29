using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SequencesOfEquelStrings
{
    class Problem4
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                if (i < input.Length - 1 && (input[i] == input[i + 1]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
