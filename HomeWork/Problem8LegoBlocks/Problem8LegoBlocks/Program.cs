using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8LegoBlocks
{
    class Program
    {
        static void Main()
        {
            Console.Write("Rows!:");
            int rows = int.Parse(Console.ReadLine());

            List<List<int>> firstList = new List<List<int>>();
            List<List<int>> secondList = new List<List<int>>();
            bool Rectanguler = false;
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                Console.Write("Add elements in the first List!:");
               firstList.Add(new List<int>());
               int[] Array = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
               for (int j = 0; j < Array.Length; j++)
               {
                   firstList[i].Add(Array[j]);
                  
               }
            }
            foreach(List<int> el in firstList)
            {
                count += el.Count();
            }

            for (int i = 0; i < rows; i++)
            {
                Console.Write("Add elements in the Second List!:");
                secondList.Add(new List<int>());
                int[] Array = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < Array.Length; j++)
                {
                    secondList[i].Add(Array[j]);

                }               
            }

            foreach (List<int> el in secondList)
            {
                count += el.Count();
            }

            for (int i = 0; i < firstList.Count(); i++)
            {
                secondList[i].Reverse();
               firstList[i].AddRange(secondList[i]);
            }

           int rowLength = firstList[0].Count();
           for (int i = 1; i < firstList.Count; i++)
           {
               if (rowLength == firstList[i].Count())
               {
                   Rectanguler = true;
               }
               else
               {
                   Rectanguler = false;
                   break;
               }
           }
           if (Rectanguler)
           {
               for (int k = 0; k < rows; k++)
               {
                   Console.Write("[");
                   for (int j = 0; j < firstList[k].Count; j++)
                   {
                       Console.Write("{0} ", firstList[k][j]);
                   }
                   Console.Write("]");
                   Console.WriteLine();
               }
           }
           else Console.WriteLine(count + "total count of cells is:");

            

        }
    }
}
