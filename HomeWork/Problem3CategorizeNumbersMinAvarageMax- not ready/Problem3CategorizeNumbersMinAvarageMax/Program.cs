using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CategorizeNumbersMinAvarageMax
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            float[] num  = new float[input.Length];
            float[] Rounded = new float[input.Length];
            float[] Floating = new float[input.Length];
            int FlagForCycle = 0;
            float temp = 0;
            int Roundedmin = 0;
            float Floatingmin = 0f;
            float RoundedSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                num[i] = float.Parse(input[i]);
                if ((num[i] % 1) > 0)
                {
                    Floating[i] = num[i];
                }
                else Rounded[i] = num[i];
            }        
           

            for (int i = 0; i < input.Length; i++)
            {
                if (Rounded[i] != 0)
                {
                    RoundedSum +=  Rounded[i];
                    FlagForCycle++;
                    Roundedmin = (int) Rounded[i];
                    if (i<input.Length-1 &&(Rounded[i] < Rounded[i + 1]))
                    {
                        temp = Rounded[i];
                        if (temp < Roundedmin)
                            Roundedmin = (int)temp;
                        else break;
                    }
                    Console.Write(Rounded[i] + " ");
                  
                }
            }
            Console.WriteLine();
            Console.WriteLine(Roundedmin + ":min! ");
            Console.WriteLine(Rounded.Max() + ":max! ");
            Console.WriteLine(RoundedSum + ":sum! ");
            Console.WriteLine(RoundedSum/FlagForCycle + ":avarage! ");
            Console.WriteLine();

            RoundedSum=0;
            FlagForCycle = 0;
            temp = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Floating[i] != 0)
                {
                    RoundedSum += Floating[i];
                    FlagForCycle++;
                    Floatingmin = Floating[i];
                    if (i < input.Length - 1 && (Floating[i] < Floating[i + 1]))
                    {
                        temp = Floating[i];
                        if (temp < Floatingmin)
                        {
                            Floatingmin = temp;
                        }
                        else break;
                        
                    }

                }
                if (Floating[i] != 0)
                Console.Write(Floating[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine(Floatingmin + ":min! ");
            Console.WriteLine(Floating.Max() + ":max! ");
            Console.WriteLine(RoundedSum + ":sum! ");
            Console.WriteLine(RoundedSum / FlagForCycle + ":avarage! ");
            Console.WriteLine();
            
        }
    }
}
