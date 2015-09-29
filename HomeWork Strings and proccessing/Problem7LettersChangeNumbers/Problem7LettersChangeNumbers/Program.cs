using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(
                new string[] { " ", "\t" }, 
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string subbedInput = input[i];
                char letterBefore = subbedInput[0];
                char letterAfter = subbedInput[subbedInput.Length-1];
                double num = double.Parse(subbedInput.Substring(1, subbedInput.Length - 2));

                if (char.IsUpper(letterBefore))
                {
                    num = num / ((((int)letterBefore) - 65)+1);
                }

                if (char.IsLower(letterBefore))
                {
                    num = num * ((((int)letterBefore) - 97) + 1);
                }

                if (char.IsUpper(letterAfter))
                {
                    num = num - ((((int)letterAfter) - 65) + 1);
                }
                if (char.IsLower(letterAfter))
                {
                    num = num + ((((int)letterAfter) - 97) + 1);
                }
                sum = sum + num;
            }
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
