using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1FillTheMatrix
{
    class SnakeLike
    {
        static void Main()
        {        
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int num = 0;
            // Normal matrix!!
            for (int row = 0; row < n; row++)
            {
                for (int coll = 0; coll < n; coll++)
                {
                    num++;
                        matrix[row,coll]=num;
                    Console.Write(matrix[row, coll]+ " ");
                    if (coll == n - 1) Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //SNAKE LIKE MATRIX
            for (int row = 0; row < n; row++)
            {
                if(row%2==1)
                {
                    for (int coll = n-1; coll >= 0; coll--)
                     {
                    
                    Console.Write(matrix[row, coll] + " ");
                    if (coll == 0) Console.WriteLine();
                    }
                }
                else 
                {               
                    for (int coll = 0; coll < n; coll++)
                    {
                    Console.Write(matrix[row, coll] + " ");
                    if (coll == n-1) Console.WriteLine();
                     }                     
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // Snake Like columns
            num = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {

                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = num;
                        num++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = num;
                        num++;
                    }
                }         
            }
            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                if (row % 1 == 0) Console.WriteLine();

            }
        }
    }
}
