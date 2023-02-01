using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Map
    {
        char[,] _map;

        public Map()
        {

            string[] lines = System.IO.File.ReadAllLines(@"X:\jeu_console_c_sharp\console_app\Sprite\Map.txt");
            _map = new char[lines[1].Count(), lines.GetLength(0)];

            int x, y = 0;

            foreach (string line in lines)
            {
                x = 0;
                foreach (char c in line)
                {
                    _map[x, y] = c;
                    x++;
                }
                y++;
            }
        }

        public void DrawMap()
        {
            Console.Clear();
            int playerx = 11, playery = 14;

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                for (int i = 0; i < _map.GetLength(0); i++)
                {
                    if (playery == i && playerx == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(_map[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                    }

                    switch (_map[i, j])
                    {
                        case '%':
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                    Console.Write(_map[i, j]);
                }
                Console.WriteLine();
            }

            // Sleep for 2 seconds
            Thread.Sleep(2000);

        }
        /*
        public void DrawPlayer() {

            int playerx = 11, playery = 14;

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                for (int i = 0; i < _map.GetLength(0); i++)
                {
                    if(playery == i && playerx == j)
                    {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(_map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;

                    }
                }
            }
        }*/
    }
}