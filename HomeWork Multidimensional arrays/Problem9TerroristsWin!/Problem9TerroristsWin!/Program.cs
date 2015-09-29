using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9TerroristsWin_
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "asda|yo|dong softuni123456|the|best";
            string text = inputText;
            int offset = 0;

            while (true)
            {

                int firstWall = inputText.IndexOf('|', offset);
                int secondWall = inputText.IndexOf('|', firstWall + 1);

                if (firstWall == -1 || secondWall == -1)
                    break;

                string bomb = inputText.Substring(firstWall + 1, secondWall - firstWall - 1);
                int bombPower = getBombPower(bomb);

                int leftSideIndex = 0;
                int dotCount = 0;
                int rightSideIndex = 0;

                if (bombPower > firstWall - 1)
                    leftSideIndex = firstWall - 1;
                else
                    leftSideIndex = firstWall - bombPower;

                dotCount = bombPower * 2 + secondWall - firstWall + 1;

                if (leftSideIndex + dotCount >= inputText.Length)
                {
                    rightSideIndex = (leftSideIndex + dotCount) - inputText.Length;
                    rightSideIndex = (leftSideIndex + dotCount) - rightSideIndex;
                }
                else
                {
                    rightSideIndex = secondWall + bombPower + 1;
                }

                text = text.Substring(0, leftSideIndex) + new string('.', dotCount) + text.Substring(rightSideIndex);

                offset = secondWall + 1;


            }

            Console.WriteLine(text);

            Console.ReadLine();
        }

        static int getBombPower(string text)
        {
            int power = 0;

            for (int i = 0; i < text.Length; i++)
            {
                power += (int)text[i];
            }

            return getLastDigit(power);
        }

        static int getLastDigit(int number)
        {
            int lastDigit;

            string numberToString = number.ToString();

            lastDigit = Int32.Parse(numberToString[numberToString.Length - 1].ToString());

            return lastDigit;
        }
    }
}
