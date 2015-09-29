using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10PythagoreanNumbers
{
    class Problem10
    {
        static void Main()
        {
            int Ncount = int.Parse(Console.ReadLine());
            int[] nums = new int[Ncount];
            for (int i = 0; i < Ncount; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            List<int> numsSq = new List<int>();
            foreach (int integer in nums)
            {
                numsSq.Add(integer * integer);
            }
            bool flag = false;
            foreach (int a in nums)
            {
                foreach (int b in nums)
                {
                    int cSq = a * a + b * b;
                    if (a <= b && numsSq.Contains(cSq))
                    {
                        int c = (int)Math.Sqrt(cSq);
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                        flag = true ;
                    }
                }
            }

            if (flag == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
