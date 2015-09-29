using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BubbleAlgorithm
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];
            int conteiner;

            for (int i = 0; i < input.Length; i++)
           num[i] = Int32.Parse(input[i]);


            for (int i = 0; i < input.Length; i++)
             for (int j = i+1; j < input.Length; j++)
              {
                  if (num[i] > num[j])
                  {
                     
                      conteiner = num[i];    // konteiner za cifra
                      num[i] = num[j];
                      num[j] = conteiner;
                      Console.WriteLine("J=" + j);
                      
                  }
                  //else break;
              }  
            

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(num[i] + " ");
            }

            Console.WriteLine(input.Length);

        }
    }
}
