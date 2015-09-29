using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6NumberCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] myDouble = Console.ReadLine().Trim().Split().Select(double.Parse).ToArray();
            decimal[] myDecimal = Console.ReadLine().Trim().Split().Select(Decimal.Parse).ToArray();

            Console.WriteLine("Max: {0}, Min: {1}, Sum: {2}, Product: {3}, Average: {4}",
                Max(myDouble), Min(myDouble), Summ(myDouble), Product(myDouble), Avarage(myDouble));
            Console.WriteLine("Max: {0}, Min: {1}, Sum: {2}, Product: {3}, Average: {4}",
                GetMax(myDecimal), GetMin(myDecimal), GetSum(myDecimal), GetProduct(myDecimal), GetAverage(myDecimal));
        }

        static double Max(double[] array)
        {
            double result = double.MinValue;
            foreach (var el in array)
            {
                if (el > result)
                {
                    result = el;
                }
            }
            return result;
        } 

        static decimal GetMax(decimal[] array)
        {
            decimal result = decimal.MinValue;
            foreach (var el in array)
            {
                if (el > result)
                {
                    result = el;
                }
            }
            return result;
        } 

        static double Min(double[] array)
        {
            double result = double.MaxValue;
            foreach (var el in array)
            {
                if (el < result)
                {
                    result = el;
                }
            }
            return result;
        } 

        static decimal GetMin(decimal[] array)
        {
            decimal result = decimal.MaxValue;
            foreach (var el in array)
            {
                if (el < result)
                {
                    result = el;
                }
            }
            return result;
        } 

        static double Summ(double[] array)
        {
            double sum = 0.0;
            foreach (var el in array)
            {
                sum += el;
            }
            return sum;
        } 

        static decimal GetSum(decimal[] array)
        {
            decimal sum = 0.0M;
            foreach (var el in array)
            {
                sum += el;
            }
            return sum;
        } 

        static double Product(double[] array)
        {
            double sum = 1.0;
            foreach (var el in array)
            {
                sum *= el;
            }
            return sum;
        } 

        static decimal GetProduct(decimal[] array)
        {
            decimal sum = 1.0M;
            foreach (var el in array)
            {
                sum *= el;
            }
            return sum;
        } 

        static double Avarage(double[] array)
        {
            double result = 0.0;
            foreach (var el in array)
            {
                result += el;
            }
            result = result / array.GetLength(0);
            return result;
        } 

        static decimal GetAverage(decimal[] array)
        {
            decimal result = 0.0M;
            foreach (var el in array)
            {
                result += el;
            }
            result = result / array.GetLength(0);
            return result;
        }
    }
}
