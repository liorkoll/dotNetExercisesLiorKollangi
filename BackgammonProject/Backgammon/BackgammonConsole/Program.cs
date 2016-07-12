using BackgammonLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgammonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            Console.WriteLine(b.Cells[6 + 12].CheckersColor == CheckerColor.Red);



            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 12; j++)
                {

                    if ((b.Cells[j + 12].CheckersColor == CheckerColor.Black && (b.Cells[j + 12].NumOfCheckers > 5 - i || b.Cells[j + 12].NumOfCheckers>=5)))
                    {
                         Console.Write("|B|");

                    }
                    else if ((b.Cells[j + 12].CheckersColor == CheckerColor.Red && (b.Cells[j + 12].NumOfCheckers > 5 - i || b.Cells[j + 12].NumOfCheckers >= 5)))
                        {
                        Console.Write("|R|");
                       
                    }
                    else
                    {
                        Console.Write("| |");
                    }
                                      
                }
            }
            Console.WriteLine();
            int x = 11;

            for (int i = 0; i < 6; i++)
            {               
                Console.WriteLine();
                //Console.WriteLine("| |");
                for (int j = 0; j < 12; j++)                   
                {
                    if (j == 0)
                    {
                        x = 11;
                    }
                    if ((b.Cells[j + x].CheckersColor == CheckerColor.Black && (b.Cells[j + x].NumOfCheckers > 5 - i || b.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|B|");                      
                    }
                    else if ((b.Cells[j + x].CheckersColor == CheckerColor.Red  && (b.Cells[j + x].NumOfCheckers > 5 - i || b.Cells[j + 12].NumOfCheckers >= 5)))
                    {
                        Console.Write("|R|");                       
                        
                    }
                    else
                    {
                        Console.Write("| |");
                    }                                  
                        x = x - 2;
                   
                }                
            }                                           
            }
        public static String drawCheckerX(Board b,int i,int j)
        {
            string checker = "| |";
            int count = b.Cells[j+12].NumOfCheckers;
            if (5 - count >= i)
            {
                checker = "|X|";
            }
            return checker;
        }
        public static String drawCheckerO(Board b, int i, int j)
        {
            string checker = "| |";
            int count = b.Cells[j + 12].NumOfCheckers;
            if  (count <= i-5)
            {
                checker = "|O|";
            }
            return checker;
        }


    }
    }
