using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4FirstLargerThanNeighb
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            int[] numbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int flag = 0;

            for (int i = 0; i < numbers.Length; i++)            
                if ((IsLargetThanNeighbours(numbers, i) > -1) && (flag==0))
                {
                    Console.WriteLine(IsLargetThanNeighbours(numbers, i));
                    flag++;
                }

               if(flag==0)
                   Console.WriteLine(IsLargetThanNeighbours(numbers, 0));

        }
        static int IsLargetThanNeighbours(int[] array, int index)
        {
            int first=-1;
            if (index == 0)
                if (array[index] > array[index + 1])
                {
                     first = index;
                }

            if ((index != 0 && index != array.Length - 1) && (array[index] > array[index + 1] && array[index] > array[index - 1]))
            {
                first = index;
            }

            if (index == array.Length - 1)
                if (array[index] > array[index - 1])
                {
                    first = index;

                }
           
            return first;
        }
    }
}
