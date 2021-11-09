using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGMap
{
    class Program
    {
        static int y = 0;
        static int x = 0;

        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~'},
        {'~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~'},
        {'~','=','~','~','~','~','~','~','~','~','~','~','~','~','^','=','^','~','~','^','^','~','=','~'},
        {'~','=','=','*','*','*','*','^','^','^','^','^','^','^','^','^','^','^','^','^','^','=','=','='},
        {'=','=','=','*','*','~','~','*','*','*','*','*','*','*','*','^','^','^','^','^','^','^','=','~'},
        {'~','=','\'','*','~','~','~','~','~','~','~','*','*','*','\'','*','*','^','^','~','~','=','=','~'},
        {'~','=','\'','*','*','*','*','*','*','*','~','*','*','\'','\'','\'','*','*','*','^','^','^','=','~'},
        {'~','=','=','\'','\'','*','*','\'','\'','\'','~','*','\'','\'','\'','\'','*','*','*','*','*','*','=','~'},
        {'~','=','=','\'','\'','\'','\'','\'','\'','\'','~','\'','\'','\'','\'','\'','*','*','*','*','*','*','=','~'},
        {'~','~','~','~','~','\'','\'','~','~','~','~','\'','\'','\'','\'','*','*','*','*','*','*','*','=','='},
        {'~','=','=','\'','~','\'','\'','~','\'','\'','~','~','\'','\'','\'','*','*','*','*','*','*','\'','=','~'},
        {'~','=','=','\'','~','\'','\'','~','\'','\'','\'','~','\'','\'','\'','\'','*','*','*','\'','\'','\'','=','='},
        {'\'','\'','\'','\'','~','\'','~','~','\'','\'','\'','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','=','~'},
        {'~','=','=','\'','~','~','~','\'','\'','\'','\'','~','~','\'','\'','~','~','\'','\'','\'','\'','\'','=','~'},
        {'~','=','=','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','~','~','~','\'','\'','\'','\'','=','='},
        {'^','^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','\'','\'','\'','\'','=','~'},
        {'~','^','=','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','\'','\'','\'','\'','=','~'},
        {'~','=','=','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','\'','\'','\'','\'','\'','\'','=','='},
        {'~','~','=','=','\'','\'','=','=','=','=','=','=','=','=','=','~','=','=','\'','\'','\'','=','=','~'},
        {'~','~','~','=','=','=','=','=','~','=','=','=','~','=','=','~','=','=','=','=','=','=','=','='},
        {'~','~','~','~','=','~','~','~','~','~','~','~','~','~','~','~','~','~','~','=','~','~','=','='},

    };
        static void Main(string[] args)
        {
            
            Console.WriteLine("       +----LEGEND----+");
            Console.WriteLine("       | ^ = Mountain |");
            Console.WriteLine("       | ' =  Grass   |");
            Console.WriteLine("       | = =  Sand    |");
            Console.WriteLine("       | ~ =  Water   |");
            Console.WriteLine("       | * =  Trees   |");
            Console.WriteLine("       +--------------+");
            Console.WriteLine("");
            Console.WriteLine("Scale X1");
            MapScaler(1);
            Console.WriteLine("");
            Console.WriteLine("Scale X2");
            MapScaler(2);
            Console.WriteLine("");
            Console.WriteLine("Scale X5");
            MapScaler(5);
            Console.ReadKey(true);


        }

        static void ChangeColor(int x, int y)
        {
            if (map[y, x] == '~')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (map[y, x] == '^')
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (map[y, x] == '*')
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            if (map[y, x] == '\'')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Green;
            }

            if (map[y,x] == '=')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
        }

        static void MapScaler(int scale)
        {
            Console.Write("+");
            for (int topBorder = 0; topBorder < map.GetLength(1)*scale; topBorder++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            
            DisplayMap(scale);

            Console.Write("+");
            for (int bottomBorder = 0; bottomBorder < map.GetLength(1)*scale; bottomBorder++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

        }
        static void DisplayMap(int scale)
        {
            
            for ( y = 0; y < map.GetLength(0); y++)
            {
                for (int yy = 0; yy < scale; yy++)
                {
                    Console.Write("|");
                    for ( x = 0; x < map.GetLength(1); x++)
                    {
                        for (int xx = 0; xx < scale; xx++)
                        {
                            ChangeColor(x, y);
                            Console.Write(map[y, x]);
                        }
                    }
                    Console.WriteLine("|");
                }
            }

            // Change Color 
            


        }

    }
}
