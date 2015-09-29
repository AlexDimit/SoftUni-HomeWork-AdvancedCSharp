using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SequenceinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Collumns:");
            int colls = int.Parse(Console.ReadLine());
            int flag = 1;
            int flagForColl = 1;
            int flagForDiag = 1;         
            List<string> listRow = new List<string>();
            List<string> listCol = new List<string>();
            List<string> listDiag = new List<string>();

            string[,] matrix = new string[rows, colls];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    string inputNumber = Console.ReadLine();
                    matrix[i, j] = inputNumber;
                }
            }


            for (int i = 0; i < rows; i++) // for rows!
            {
                for (int j = 0; j < colls-1; j++)
                {
                    if (matrix[i, j].Equals(matrix[i, j + 1]))
                    {
                        flag++;
                        listRow.Add(matrix[i, j]);
                        listRow.Add(matrix[i, j + 1]);                      
                    }
                }
            }

            for (int i = 0; i < rows-1; i++) // for collumns!
            {
                for (int j = 0; j < colls ; j++)
                {
                    if (matrix[i, j].Equals(matrix[i + 1, j]))
                    {
                        flagForColl++;
                        listCol.Add(matrix[i, j]);
                        listCol.Add(matrix[i + 1, j]);
                    }                   
                }
            }
            for (int i = 0; i < rows - 1; i++) // for diagonals!
            {
                for (int j = 0; j < colls-1; j++)
                {
                    if (matrix[i, j].Equals(matrix[i + 1, j+1]))
                    {
                        flagForDiag++;
                        listDiag.Add(matrix[i, j]);
                        listDiag.Add(matrix[i + 1, j+1]);
                    }
                }
            }


 
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < colls; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //     Console.WriteLine();
            //}                        
            Console.WriteLine();
            if(flag > flagForColl && flag > flagForDiag)
            for (int i = 0; i < flag; i++)
            {
                Console.Write(listRow[i] + " ");
            }
            
            if (flagForColl > flag && flagForColl > flagForDiag)
            for (int i = 0; i <= flagForColl; i++)
            {
                if (listCol[i] == listCol[i + 1])
                {
                    int j = 0;
                    j++;
                    Console.Write(listCol[j] + " ");                   
                }
            }

            if(flagForDiag > flag && flagForDiag > flagForColl)
            for (int i = 0; i < flagForDiag; i++)
            {
                Console.Write(listDiag[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
