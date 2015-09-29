using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int colls = input[1];
            Console.WriteLine("rows:{0}\ncollumns:{1}", rows, colls);
            int[,] matrix = new int[rows, colls];
            int bestSum = int.MinValue;
            int tempRow, tempColl = 0;
            int maxRow = 0;
            int maxColl = 0;

            for (int i = 0; i < rows; i++)
            {
                int[] inputNumbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < colls; j++)
                {
                    matrix[i, j] = inputNumbers[j];
                }
               
            }

            for (int i = 0; i < rows-2; i++)
            {
                for (int j = 0; j < colls - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    tempRow = i;
                    tempColl = j;
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        maxRow = tempRow;                   // zapazi lokaciqta na max sum;
                        maxColl = tempColl;
                    }
                }
            }
            Console.WriteLine(bestSum + ":max");
            Console.WriteLine();
            for (int i = maxRow; i < rows; i++)
            {
                for (int j = maxColl; j < colls; j++)
                {
                    if (j == 4) break;                              //izvedi mi edinstveno 3 koloni
                    Console.Write(matrix[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
