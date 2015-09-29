using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8NightLife
{
    class Program
    {                   
        public static Dictionary<string, SortedDictionary<string, SortedSet<string>>> citiesNightLife = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        static void Main(string[] args)
        {
           
            while(true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                    break;

                string[] nightLifeInfo = getInputInfo(input);
                
                if(!citiesNightLife.ContainsKey(nightLifeInfo[0]))
                {
                    SortedDictionary<string, SortedSet<string>> newCity = new SortedDictionary<string,SortedSet<string>>();

                    citiesNightLife.Add(nightLifeInfo[0], newCity);
                }
                
                if (!citiesNightLife[nightLifeInfo[0]].ContainsKey(nightLifeInfo[1]))
                {
                    citiesNightLife[nightLifeInfo[0]].Add(nightLifeInfo[1], new SortedSet<string>());
                }

                citiesNightLife[nightLifeInfo[0]][nightLifeInfo[1]].Add(nightLifeInfo[2]);

            }

            printNightLifeInfo();

            Console.ReadLine();
        }

        static void printNightLifeInfo()
        {
            foreach(string key in citiesNightLife.Keys)
            {
                Console.WriteLine(key);
                var venueKeys = citiesNightLife[key].Keys;

                foreach (var venue in venueKeys)
                {
                    Console.WriteLine("->{0} : {1}", venue, string.Join(", ", citiesNightLife[key][venue]));
                }
            }
        }

        static string[] getInputInfo(string input)
        {
            string[] result = new string[3];
            int firstSemiColon = input.IndexOf(';');
            int lastSemiColon = input.LastIndexOf(';');
            StringBuilder sb = new StringBuilder(input.Remove(lastSemiColon));

            sb.Remove(0, firstSemiColon + 1);

            result[0] = input.Remove(firstSemiColon);
            result[1] = sb.ToString();
            result[2] = input.Remove(0, lastSemiColon + 1);
            
            return result;
        }

        }
    }
