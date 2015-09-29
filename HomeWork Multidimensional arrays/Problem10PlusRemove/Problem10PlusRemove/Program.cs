using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10PlusRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();

            while (true)
            {
                string consoleInput = Console.ReadLine();

                if (consoleInput == "END")
                    break;

                input.Add(consoleInput);
            }

            string[] filtered = removePluses(getAllPlusShapesCordinatesNotFiltered(input), input);

            print(filtered);

            Console.ReadLine();
        }

        static string[] removePluses(List<List<List<int>>> pointsToRemove, List<string> input)
        {
            string[] result = input.ToArray();
            StringBuilder sb = new StringBuilder();

            foreach (List<List<int>> allPoints in pointsToRemove)
            {
                foreach (List<int> point in allPoints)
                {
                    int x = point[0];
                    int y = point[1];

                    sb.Append(result[y]);

                    result[y] = sb.Remove(x, 1).Insert(x, ' ').ToString();

                    sb.Clear();
                }
            }

            return result;
        }

        static void print(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                foreach (char c in input[i])
                {
                    if (char.IsWhiteSpace(c))
                        continue;

                    Console.Write(c);
                }

                Console.WriteLine();
            }

        }

        static List<List<List<int>>> getAllPlusShapesCordinatesNotFiltered(List<string> input)
        {
            List<List<List<int>>> result = new List<List<List<int>>>();

            for (int iy = 1; iy < input.Count - 1; iy++)
            {
                for (int ix = 1; ix < input[iy].Length - 1; ix++)
                {
                    if (isItPlusShape(input, ix, iy))
                    {
                        List<List<int>> cordinates = new List<List<int>>();

                        cordinates.Add(new List<int> { ix, iy });
                        cordinates.Add(new List<int> { ix + 1, iy });
                        cordinates.Add(new List<int> { ix - 1, iy });
                        cordinates.Add(new List<int> { ix, iy - 1 });
                        cordinates.Add(new List<int> { ix, iy + 1 });

                        result.Add(cordinates);

                    }
                }
            }

            return result;
        }

        static bool isItPlusShape(List<string> input, int x, int y)
        {
            if ((x - 1 < 0) || (y - 1 < 0) || (y + 1 >= input.Count) || (x + 1 >= input[y].Length) || (x >= input[y - 1].Length) || (x >= input[y + 1].Length))
                return false;

            string symbolToMatch = input[y][x].ToString().ToLower();

            bool up, down, left, right;

            up = symbolToMatch == input[y - 1][x].ToString().ToLower();
            down = symbolToMatch == input[y + 1][x].ToString().ToLower();
            left = symbolToMatch == input[y][x - 1].ToString().ToLower();
            right = symbolToMatch == input[y][x + 1].ToString().ToLower();

            if (up && down && left && right)
                return true;
            else
                return false;
        }
    }
}
