using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LastDigit
{
    class Program
    {
        public static int digit
    {
        get;
        set;
    }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int digit = Named(a);
            string bull = digit.ToString();
            Console.WriteLine(Print(bull));            
        }
        static int Named(int nums)
        {
            int num = nums % 10;
            
            return num;
        }
        static string Print(string digit)
    {       
                    if (digit.Equals("0"))
                        digit = "Zero";      
          
                    if (digit.Equals("1"))                           
                        digit = "One";
                                  
                    if (digit.Equals("2"))
                        digit = "Two";

                    if (digit.Equals("3"))
                       digit ="Three";

                    if (digit.Equals("4"))
                       digit ="Four";

                    if (digit.Equals("5"))
                        digit = "Five";

                    if (digit.Equals("6"))
                       digit ="Six";

                    if (digit.Equals("7"))
                        digit = ("Seven");

                    if (digit.Equals("8"))
                        digit = ("Eight");

                    if (digit.Equals("9"))                   
                     digit ="Nine";
                     
        return digit;

            }

    }
}
