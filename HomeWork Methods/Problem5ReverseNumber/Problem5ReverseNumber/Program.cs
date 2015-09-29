using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double reversed = GetReversed(input);
            Console.WriteLine(reversed);

        }
        static double GetReversed(double input)
        {
            double result;
            char[] array = input.ToString().ToCharArray();
            Array.Reverse(array);
            result = double.Parse(string.Join("", array));
            return result;
        }
    }
}
