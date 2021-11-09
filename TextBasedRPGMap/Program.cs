﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGMap
{
    class Program
    {

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
        {'\'','\'','\'','\'','~','\'','~','~','\'','\'','\'','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','=','~'}
        
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
            
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int yy = 0; yy < scale; yy++)
                {
                    Console.Write("|");
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        for (int xx = 0; xx < scale; xx++)
                        {
                            Console.Write(map[y, x]);
                        }
                    }
                    Console.WriteLine("|");
                }
            }

        }

    }
}
