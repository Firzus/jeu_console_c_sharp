﻿namespace console_app;
using System;
class Program
{
    static void Main()
    {
        // type de terrain
        const char WALL = '#';
        const char FLOOR = '.';

        // modeling map
        string[] map =
        {
            "#########",
            "#.......#",
            "#.#.#.#.#",
            "#.......#",
            "#########"
        };

        // afficher la carte
        for (int y = 0; y < map.Length; y++)
        {
            for (int x = 0; x < map.Length; x++)
            {
                char title = map[y][x];
                Console.Write(title);
            }
            Console.WriteLine();
        }
    }
}