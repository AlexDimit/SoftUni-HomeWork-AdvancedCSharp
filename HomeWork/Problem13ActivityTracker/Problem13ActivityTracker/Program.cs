using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13ActivityTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allActivities = new List<string>();

            int dataCount = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < dataCount; i++)
            {
                allActivities.Add(Console.ReadLine());
            }

            Dictionary<DateTime, Dictionary<string, int>> monthActivity = calculateMonthActivity(allActivities);

            foreach (KeyValuePair<DateTime, Dictionary<string, int>> key in monthActivity)
            {
                DateTime date = key.Key;

                SortedDictionary<string, int> sortedNamesAndActivities = new SortedDictionary<string, int>(key.Value);

                Console.Write("{0}: ", date.Month);

                foreach (KeyValuePair<string, int> personActivities in sortedNamesAndActivities)
                {
                    Console.Write("{0}({1})");
                }

            }

        }

        static Dictionary<DateTime, Dictionary<string, int>> calculateMonthActivity(List<string> input)
        {
            Dictionary<DateTime, Dictionary<string, int>> result = new Dictionary<DateTime, Dictionary<string, int>>();

            foreach (string s in input)
            {
                string[] inputArgs = s.Split(' ');
                DateTime time = Convert.ToDateTime(inputArgs[0]);
                time = new DateTime(time.Year, time.Month, 1);

                if (!result.ContainsKey(time))
                {
                    Dictionary<string, int> addPerson = new Dictionary<string, int>();

                    result.Add(time, addPerson);

                }

                Dictionary<string, int> personActivity = result[time];

                if (!personActivity.ContainsKey(inputArgs[1]))
                {
                    personActivity.Add(inputArgs[1], 0);
                }

                personActivity[inputArgs[1]] += Int32.Parse(inputArgs[2]);

            }

            return result;
        }
    }
}
