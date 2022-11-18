using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG_Map
{
    internal class Program
    {
        static int y; //map position y
        static int x; //map position x
        static char[,] map=new char[,]
        {
           
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
         
        };

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

        static void Main(string[] args)
        {
            DisplayMap();
            DisplayMap(3); //zooming in by a factor of 3
            Console.WriteLine();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey(true);
            
        }

        static void Colourpicker()
        {
            switch (map[y,x])
            {
                default: Console.ResetColor();
                    break;

                case '*': Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;

                case '~': Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;

                case '`': Console.ForegroundColor=ConsoleColor.DarkYellow;
                    break;
                
                case '^': Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                
            }
        }
        

        static void DisplayMap()
        {
            Console.Write("+");
            
            for (x = 0; x <= 29; x++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.WriteLine("");
            for (y = 0; y <= 11; y++)
            {
                Console.Write("|");

                for (x = 0; x <= 29; x++)
                {
                    Colourpicker();
                    Console.Write(map[y, x]);
                    Console.ResetColor();
                }
                Console.Write("|");
                Console.WriteLine("");
            }
            Console.Write("+");
            for (x = 0; x <= 29; x++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }

        static void DisplayMap(int scale)
        {
            Console.WriteLine("");
            Console.Write("+");


            for (x = 0; x <= 29*scale; x++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.WriteLine("");

            for (y = 0; y <= 11; y++)
            {
                for(int ys=0; ys < scale; ys++)
                {

                    Console.Write("|");

                    for (x = 0; x <= 29; x++)
                    {
                        for (int xs=0; xs < scale; xs++)
                        {
                            Colourpicker();
                            Console.Write(map[y, x]);
                            Console.ResetColor();
                        }
                    }
                    Console.Write("|");
                    Console.WriteLine("");
                }
            }

            Console.Write("+");
            
            for (x = 0; x <= 29*scale; x++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }

    }
}
