using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7GenericArraySort
{
    class Program
    {     
           static void Main()
    {
        int[] NumsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] wordsArray = Console.ReadLine().Split().ToArray();
        DateTime[] datesArray = Console.ReadLine().Split().Select(DateTime.Parse).ToArray();
                           // new DateTime(2011, 11, 06), new DateTime(1955, 13, 03) };

        SortArray(NumsArr);        
        SortArray(wordsArray);     
        SortArray(datesArray);
    }

    
    static void SortArray<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minValue = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[minValue].CompareTo(array[j]) > 0)
                {
                    minValue = j;
                }
            }
            T temp = array[i];
            array[i] = array[minValue];
            array[minValue] = temp;
        }

        Console.WriteLine(PrintArray(array));
    }    
    static string PrintArray<T>(IEnumerable<T> array)
    {
        return string.Join(", ", array);
    }

        
    }
}
