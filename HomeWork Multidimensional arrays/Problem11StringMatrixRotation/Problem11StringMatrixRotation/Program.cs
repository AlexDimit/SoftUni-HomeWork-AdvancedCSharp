using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11StringMatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> matrix = new List<string>();

            string degreesInput = "Rotate(270)";

            int firstBracked = degreesInput.IndexOf('(');
            int secondBracked = degreesInput.IndexOf(')');

            int degreesToRotate = int.Parse(degreesInput.Substring(firstBracked + 1, secondBracked - firstBracked - 1));

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                    break;

                matrix.Add(input);
            }

            List<string> rotatedMatrix = rotateMatrix(matrix, degreesToRotate);

            print(rotatedMatrix);

            Console.ReadLine();

        }

        static void print(List<string> matrix)
        {
            foreach (string s in matrix)
            {
                Console.WriteLine(s);
            }
        }

        static List<string> rotateMatrix(List<string> matrix, int gradus)
        {
            List<string> result = new List<string>(matrix.Count);

            gradus = gradus % 360;

            if (gradus == 0)
                return matrix;

            int matrixHeight = matrix.Count;

            if (gradus == 90)
            {

                matrix.Reverse();

                for (int y = 0; y < matrixHeight; y++)
                {

                    int matrixWidth = matrix[y].Length;

                    for (int x = 0; x < matrixWidth; x++)
                    {
                        if (result.Count <= x)
                            result.Add(" ");

                        result[x] = result[x].Insert(y, matrix[y][x].ToString());
                    }

                }

            }
            else if (gradus == 180)
            {
                matrix.Reverse();

                int widestRow = widestRowOfMatrix(matrix);

                for (int i = 0; i < matrixHeight; i++)
                {
                    result.Add("");
                }

                for (int y = 0; y < matrixHeight; y++)
                {
                    int matrixWidth = matrix[y].Length;

                    for (int x = matrixWidth - 1; x >= 0; x--)
                    {
                        result[y] += matrix[y][x];
                    }

                    result[y] = result[y].Insert(0, new string(' ', widestRow - matrixWidth));

                }


            }
            else if (gradus == 270)
            {

                int widestRow = widestRowOfMatrix(matrix);

                for (int i = 0; i < widestRow; i++)
                {
                    result.Add("");
                }

                for (int y = 0; y < matrixHeight; y++)
                {
                    int matrixWidth = matrix[y].Length;

                    for (int x = 0; x < matrixWidth; x++)
                    {
                        result[widestRow - x - 1] = result[widestRow - x - 1].Insert(y, matrix[y][x].ToString());
                    }

                    for (int i = matrixWidth; i < widestRow; i++)
                    {
                        result[widestRow - i - 1] = result[widestRow - i - 1].Insert(y, " ");
                    }
                }

            }

            return result;
        }

        static int widestRowOfMatrix(List<string> matrix)
        {
            int widest = 0;

            foreach (string s in matrix)
            {
                widest = Math.Max(s.Length, widest);
            }

            return widest;
        }
    }
}
