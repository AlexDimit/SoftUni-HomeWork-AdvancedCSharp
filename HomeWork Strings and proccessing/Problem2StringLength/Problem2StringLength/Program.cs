using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> sb = new List<string>();

            if (input.Length < 20)
                Console.WriteLine(Chars(input));
                            
            sb.Add(input);

            if(input.Length>19)
            {                
                    for (int i = 0; i < 19; i++)
                    {
                        Console.Write(sb[i].Substring(0,19));
                    }                                              
            }
              
        }
        static string Chars(string input)
    {
        for (int i = 0; i < 19; i++)
        {
           
                string[] result = new string[20];
                int length = input.Length;
                if (length < 20)
                {
                    result[i] = string.Join("", input, "*");
                    input = result[i].ToString();
                    length++;
                }

               
        }                         
        return input;
    }          
    }
}
