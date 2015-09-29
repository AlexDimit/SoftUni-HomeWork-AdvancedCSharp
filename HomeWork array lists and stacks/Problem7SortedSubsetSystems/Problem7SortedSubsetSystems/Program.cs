using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7SortedSubsetSystems
{
    class Program
    {
        static void Main()
        {
            int AllSum = Int32.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            bool Solution = false;
            List<List<int>> SortedSum = new List<List<int>>();

            for (int i = 1; i < Math.Pow(2, nums.Length); i++)
            {
                List<int> MemoryForSum = new List<int>();
                // Console.WriteLine(i + ":i");
                for (int bits = 0; bits < nums.Length; bits++)
                {
                    //Console.WriteLine(bits + ":BitsForCYCLE");

                    if ((i >> bits & 1) == 1)
                    {
                        MemoryForSum.Add(nums[bits]);
                        // Console.WriteLine(nums[bits] + ":bits");

                    }
                }
                if (MemoryForSum.Sum() != AllSum) continue;
                SortedSum.Add(MemoryForSum);

                Solution = true;
            }
            if (Solution != true || AllSum == 0)
                Console.WriteLine("No Matching Subsets");
            //int b = 1 >> 0;
            //Console.WriteLine(b + ":3");
            else
            {
                SortedSum.ForEach(sorted => sorted.Sort());
                SortedSum = SortedSum.OrderBy(first => first.Count).ThenBy(second => second.First()).ToList();// first sorting through number of elements, then through first number;
                SortedSum.ForEach(sorted => Console.WriteLine(string.Join(" + ", sorted) + "=" + AllSum));
            }
          
            
        }
    }
}
