using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Collumns:");
            int colls = int.Parse(Console.ReadLine());
            
            string[,] matrix = new string[rows, colls];
            bool hasSwap = false;
            bool End = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    //Console.Write("matrix[{0},{1}] = ", row, column);
                    string inputNumber = Console.ReadLine();
                    matrix[i, j] = inputNumber;
                }
            }

            while (!End)
            {
              
                string change = Console.ReadLine().Trim();

                if (change.Contains("END"))
                    break;

                if (change.Contains("swap") && (change.Count() == 12 || change.Count() > 12))
                {
                    hasSwap = true;

                    
                    string[] nums = change.Split(' ').ToArray();

                    int row1 = int.Parse(nums[1]);
                    int coll1 = int.Parse(nums[2]);
                    int row2 = int.Parse(nums[3]);
                    int coll2 = int.Parse(nums[4]);
                    
                    if (row1 > rows ||
                        coll1 > colls ||
                        row2 > rows ||
                        coll2 > colls)
                    {
                        Console.WriteLine("Invalid!");
                        continue;
                    }
                                                        
                    string temp = matrix[row1, coll1];
                    matrix[row1, coll1] = matrix[row2, coll2];
                    matrix[row2, coll2] = temp;
                   
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < colls; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    hasSwap = false;
                }
                else Console.WriteLine("Invalid input!");

            }
        }
    }
}
