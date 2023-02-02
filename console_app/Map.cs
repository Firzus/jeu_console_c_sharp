﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace console_app
{
    public class Map
    {
        char[,] _map;

        int m_playerX = 11, m_playerY = 14;

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
            var rand = new Random();

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                for (int i = 0; i < _map.GetLength(0); i++)
                {
                    // Joueur
                    if (m_playerX == i && m_playerY == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(_map[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        // Hautes herbes
                        if (_map[i, j] == '%')
                        {
                            int chance = rand.Next(5);
                            if (chance < 2)
                            {
                                //Combat combat = new Combat();
                                //combat.drawCombat();
                                continue;
                            }
                        }

                        // Objets
                        else if (_map[i, j] == '!')
                        {
                            //Object object = new Object();
                            //object.AddObject();
                        }

                        continue;
                    }

                    // Carte
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
            bool Isopen = false;
            
            ConsoleKeyInfo key;
            key = Console.ReadKey();

            switch (key.Key)
            {
               case ConsoleKey.I:
                   inventaire.WindowInventaire();
                   Isopen = true;
                   break;
                    
                case ConsoleKey.Z:
                    if (_map[m_playerX, m_playerY - 1] != '#')
                    {
                        m_playerY -= 1;
                        DrawMap();
                    }
                    break;
                    
                case ConsoleKey.Escape:
                    if(Isopen == true)
                    {
                        drawMap();
                    }
                    else if (Isopen == false) 
                    {
                        Menu.menu();
                    }
                    break;

                case ConsoleKey.Q:
                    if (_map[m_playerX - 1, m_playerY] != '#')
                    {
                        m_playerX -= 1;
                        DrawMap();
                    }
                    break;

                case ConsoleKey.S:
                    if (_map[m_playerX, m_playerY + 1] != '#')
                    {
                        m_playerY += 1;
                        DrawMap();
                    }
                    break;

                case ConsoleKey.D:
                    if (_map[m_playerX + 1, m_playerY] != '#')
                    {
                        m_playerX += 1;
                        DrawMap();
                    }
                    break;
                    
                case ConsoleKey.J:
                    inventaire.AddAtInventaire("Potion");
                    inventaire.AddAtInventaire("Pierre D'ames");
                    break;
                    
                default:
                    key = Console.ReadKey();
                    break;

            }
        }
    }
}