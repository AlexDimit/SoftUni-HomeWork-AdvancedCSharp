using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5LongestIncreasingSequence
{
    class Problem4
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Sequence = 1;
            int longestSequence =1;
            int longestSequenceEndPos = 0; 

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
                if (i < input.Length - 1 && (input[i] < input[i + 1]))
                {
                    Sequence++;
                }
                else if (i < input.Length - 1 && input[i] > input[i + 1])
                {
                    Console.WriteLine();
                    if (Sequence > longestSequence)
                    {
                        longestSequence = Sequence;  // nai dulga poredica
                        longestSequenceEndPos = i;   // poziciqta na nai dulgata poredica                        
                        Sequence = 1;
                    }
                }
            }
            int[] PrintLongestSequence = new int[longestSequence];

            for (int j = longestSequenceEndPos; j > longestSequenceEndPos - longestSequence; j--)
            {
                if (j < 0)
                {
                    break;
                }
                else PrintLongestSequence[j] = input[j];
            }
           
            Console.Write("\n Longest:");
            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write(" " + PrintLongestSequence[i]);
            }
            //Console.WriteLine("\n"+ Sequence + "teku6ta poredica ");
            //Console.WriteLine("\n" + longestSequence + " nai dulga poredica");
            //Console.WriteLine("\n" + longestSequenceEndPos + " kraina poziciq na nai dulgata poredica");

        }
    }
}
