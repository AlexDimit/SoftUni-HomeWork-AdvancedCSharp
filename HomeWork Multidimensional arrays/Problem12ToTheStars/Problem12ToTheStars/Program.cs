using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12ToTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allStarsInfo = new string[3];

            for (int i = 0; i < 3; i++)
            {
                allStarsInfo[i] = Console.ReadLine();
            }

            Dictionary<string, float[]> starsInfo = getStarsInfo(allStarsInfo);
            float[] shipCordinates = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
            int movesToMake = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= movesToMake; i++)
            {
                string output = isInRangeOfStar(starsInfo, shipCordinates[0], shipCordinates[1] + i);

                Console.WriteLine(output);
            }

            Console.ReadLine();

        }

        static Dictionary<string, float[]> getStarsInfo(string[] starsInfo)
        {
            Dictionary<string, float[]> result = new Dictionary<string, float[]>();

            for (int i = 0; i < starsInfo.Length; i++)
            {
                string[] split = starsInfo[i].Split(' ');

                result.Add(split[0], new float[] { float.Parse(split[1]), float.Parse(split[2]) });
            }

            return result;
        }

        static string isInRangeOfStar(Dictionary<string, float[]> stars, float x, float y)
        {
            string result = "space";

            foreach (KeyValuePair<string, float[]> key in stars)
            {
                float[] cordinates = key.Value;

                float distance = (float)Math.Sqrt(Math.Pow((cordinates[0] - x), 2) + Math.Pow((cordinates[1] - y), 2));

                if (distance <= 2)
                {
                    result = key.Key.ToString().ToLower();
                }

            }

            return result;
        }
    }
}
