using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Problem1ReverseString
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string reversed = Reversing(input);
            Console.WriteLine(reversed);
        }
        static string Reversing(string input)
    {
        char[] b = input.ToString().ToCharArray();
        Array.Reverse(b);
            string result = (string.Join("",b));
        return result;  
    }
    }
}
