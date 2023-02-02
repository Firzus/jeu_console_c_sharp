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
        int m_playerX = 14 , m_playerY = 11;

        Inventaire inventaire = new Inventaire();

        public Map()
        {
            string[] lines = System.IO.File.ReadAllLines(@"X:\jeu_console_c_sharp\console_app\Sprite\Map.txt");
            _map = new char[lines[1].Count(), lines.GetLength(0)];

            int x = 0, y = 0;

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


        public void drawMap()
        {
            Console.Clear();
            

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                for (int i = 0; i < _map.GetLength(0); i++)
                {
                    if (m_playerY == i && m_playerX == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(_map[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        continue;
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


        }


        public void Move()
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey() ;            

            switch (key.Key)
            {
                case ConsoleKey.S:         
                    m_playerX += 1;
                    drawMap();
                    break;

                case ConsoleKey.Z:
                    m_playerX -= 1;
                    drawMap();
                    break;

                case ConsoleKey.D:
                    m_playerY += 1;
                    drawMap();
                    break;

                case ConsoleKey.Q:
                    m_playerY -= 1;
                    drawMap();
                    break;

                case ConsoleKey.I:
                    inventaire.WindowInventaire();
                    break;

                case ConsoleKey.J:
                    AddAt
                    break;
                    
            }
        }
    }
}