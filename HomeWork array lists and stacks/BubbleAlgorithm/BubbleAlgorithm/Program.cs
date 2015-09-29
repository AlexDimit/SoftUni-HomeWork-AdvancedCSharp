using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleAlgorithm
{
    class Program
    {
        static void Main()
        {
           

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
                  }                
              }  
            //for (int i = 0; i < input.Length-1; i++)
            //{
            //    Console.Write(num[i] + " ");
            //}          
        }
    }
}
