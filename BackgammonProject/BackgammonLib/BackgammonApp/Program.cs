using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
                printCell(2);
           



        }
        public static void print(int no)
        {

            for (int i = 1; i <= no; i++)
            {

                for (int j = i; j <= no; j++)
                {
                    Console.Write("  ");

                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
        public static void printRev(int no)
        {

            for (int i = no; i >0; i--)
            {

                for (int j = no-i; j >0; j--)
                {
                    Console.Write("  ");

                }

                for (int  k = 2 * i - 1; k>0; k--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
        public static void printBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (j != 6)
                    {
                        Console.Write("{0,4}", "|");

                    }
                    else
                    {
                        Console.Write("   ");
                    }

                }
                Console.WriteLine();
            }


            Console.WriteLine("------------------------      -------------------------");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (j != 6)
                    {
                        Console.Write("{0,4}", "|");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------      -------------------------");



        }
        public static void printCell(int solidersInside)
        {
            int[,] Board = new int[2, 26];
            Board[0, 1] = 2;
            Board[0, 12] = 5;
            Board[0, 18] = 5;
            Board[0, 20] = 3;
            Board[1, 24] = 5;
            Board[1, 13] = 2;
            Board[1, 8] = 3;
            Board[1, 6] = 5;
            for (int i = 0; i < 6; i++) //rows print
            {
                Console.WriteLine();
                for (int j = 2; j <=13; j++) // coloms print
                {
                    if (j == 8) {
                        Console.Write("    ");
                            }
                    Console.Write("|");

                    if (Board[0, j-1] != 0)
                    {
                        Board[0, j-1]--;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("*");
                    }
                    else if (Board[1, j - 1] != 0)
                    {
                        Board[1, j - 1]--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.ResetColor();
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++) //rows print
            {
                Console.WriteLine();
                for (int j = 14; j < 26; j++) // coloms print
                {
                    if (j == 20)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("|");
                    if (Board[0, j-1] != 0)
                    {
                        Board[0, j-1]--;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("*");

                    }
                    else if (Board[1, j - 1] != 0)
                    {
                        Board[1, j - 1]--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");


                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.ResetColor();
                    Console.Write("|");
                }

            }
        }
        }  
        
    
}
