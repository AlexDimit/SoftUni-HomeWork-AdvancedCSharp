using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9StuckNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        int Ncount = int.Parse(Console.ReadLine());

        int[] nums = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

        int flagforNum = 0;
        for (int num1 = 0; num1 < nums.Length; num1++)
        {
            for (int num2 = 0; num2 < nums.Length; num2++)
            {
                for (int num3 = 0; num3 < nums.Length; num3++)
                {
                    for (int num4 = 0; num4 < nums.Length; num4++)
                    {
                        int a = nums[num1];
                        int b = nums[num2];
                        int c = nums[num3];
                        int d = nums[num4];
                        if (a != b && a != c && a != d && b != c && b != d && c != d)
                        {
                            string ArrayOne = "" + a + b;
                            string ArrayTwo = "" + c + d;
                            if (ArrayOne.Equals(ArrayTwo))
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                flagforNum++;
                            }
                        }
                    }
                }
            }
        }

        if (flagforNum == 0)
        {
            Console.WriteLine("No");
        }

        }
    }
}
