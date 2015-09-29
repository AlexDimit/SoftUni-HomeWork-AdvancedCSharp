using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfNumbersUsingSelectionSort
{
    class Minimum
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
                array[i] = Int32.Parse(input[i]);

            int tmp, min_key;
           
            for (int j = 0; j < array.Length - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[k] < array[min_key])
                    {
                        min_key = k;
                    }
                }

                tmp = array[min_key];
                array[min_key] = array[j];
                array[j] = tmp;
            }
           
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(array[i] +" ");
            }
           // Console.WriteLine(currentmin + ",");

        }
    }
}
