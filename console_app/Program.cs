using System;

namespace console_app;
class Program
{
    static void Main()
    {
        // modeling map
        string[] map =
        { 
            "#############################################",
            "#.......#############################.......#",
            "#.#.#.#.#############################.......#",
            "#.......#############################.......#",
            "#############################################" 
        };

        // display map
        for (int y = 0; y < map.Length; y++)
        {
            for (int x = 0; x < map[y].Length; x++)
            {
                char title = map[y][x];
                Console.Write(title);
            }
            Console.WriteLine();
        }
    }
}