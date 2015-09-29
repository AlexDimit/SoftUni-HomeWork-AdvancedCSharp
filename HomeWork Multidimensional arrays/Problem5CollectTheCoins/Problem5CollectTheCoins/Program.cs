using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5CollectTheCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Collect_The_Coins
    {
        class Program
        {
            public static int coins
            {
                get;
                set;
            }

            public static int wallsHit
            {
                get;
                set;
            }

            public static int[] playerCordinates = new int[2];

            static void Main(string[] args)
            {
                List<string> board = inputBoard();
                string commands = Console.ReadLine();
                //string commands = "V>>^^>>>VVV<<";


                playerCordinates[0] = 0;
                playerCordinates[1] = 0;

                int commandsLength = commands.Length;

                for (int i = 0; i < commandsLength; i++)
                {
                    switch (commands[i])
                    {
                        case 'V':

                            moveDown(board);

                            break;

                        case '>':

                            moveRight(board);

                            break;

                        case '^':

                            moveUp(board);

                            break;

                        case '<':

                            moveLeft(board);

                            break;
                    }
                }

                Console.WriteLine("Coins collected: {0}", coins);
                Console.WriteLine("Walls hit: {0}", wallsHit);

                Console.ReadLine();

            }

            static List<string> inputBoard()
            {
                List<string> board = new List<string>();

                for (int i = 0; i < 4; i++)
                {
                    board.Add(Console.ReadLine());
                }

                //board.Add("Sj0u$hbc");
                //board.Add("$87yihc87");
                //board.Add("Ewg3444");
                //board.Add("$4$$");

                return board;
            }

            static bool isItCoint(List<string> board, int x, int y)
            {
                if (board[y][x] == '$')
                    return true;
                else
                    return false;
            }



            static void moveUp(List<string> board)
            {
                if (playerCordinates[1] - 1 < 0)
                {
                    wallsHit++;
                    return;
                }
                else
                {
                    bool isValidPosition = (board[playerCordinates[1] - 1].Length > playerCordinates[0]) ? true : false;

                    if (isValidPosition)
                    {
                        playerCordinates[1] -= 1;

                        if (isItCoint(board, playerCordinates[0], playerCordinates[1]))
                            coins++;
                    }
                    else
                    {
                        wallsHit++;
                    }
                }
            }
            static void moveDown(List<string> board)
            {

                if (playerCordinates[1] + 1 > board.Count)
                {
                    wallsHit++;
                    return;
                }
                else
                {
                    bool isValidPosition = (board[playerCordinates[1] + 1].Length > playerCordinates[0]) ? true : false;

                    if (isValidPosition)
                    {
                        playerCordinates[1] += 1;

                        if (isItCoint(board, playerCordinates[0], playerCordinates[1]))
                            coins++;
                    }
                    else
                    {
                        wallsHit++;
                    }
                }

            }
            static void moveLeft(List<string> board)
            {
                if (playerCordinates[0] - 1 < 0)
                {
                    wallsHit++;
                    return;
                }
                else
                {
                    playerCordinates[0] -= 1;

                    if (isItCoint(board, playerCordinates[0], playerCordinates[1]))
                        coins++;
                }

            }
            static void moveRight(List<string> board)
            {
                if (playerCordinates[0] + 1 > board[playerCordinates[1]].Length)
                {
                    wallsHit++;
                    return;
                }
                else
                {
                    playerCordinates[0] += 1;

                    if (isItCoint(board, playerCordinates[0], playerCordinates[1]))
                        coins++;
                }

            }
        }
    }

}
