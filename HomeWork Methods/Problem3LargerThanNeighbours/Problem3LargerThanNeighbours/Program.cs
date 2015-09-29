using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            //int[] numbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargetThanNeighbours(numbers, i));
            }                       
        }
        static bool IsLargetThanNeighbours(int[] array,int index)
        {
            bool larger = false;
            if (index == 0)
                if (array[index] > array[index + 1])
                    larger = true;
          
            if ((index !=0 && index!= array.Length-1) && (array[index] > array[index + 1] && array[index] > array[index - 1]))
                larger = true;

            if (index == array.Length - 1)
                if (array[index] > array[index - 1])
                    larger = true;

            return larger;
        }
    }
}
