using System;


namespace Problem3CountSubstringOccur
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();
            int flag=0;

            for (int i = 0; i <= text.Length - substring.Length; i++)
            {
                if (text.Substring(i, substring.Length).Contains(substring))
                {
                    flag++;
                }
            }

            Console.WriteLine(flag);
        }
         
    }
}
