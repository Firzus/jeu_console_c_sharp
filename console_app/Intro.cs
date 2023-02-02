using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    public class Intro
    {
        char[,] _logo;

        public Intro()
        {
            string[] lines = System.IO.File.ReadAllLines(@"X:\jeu_console_c_sharp\console_app\Sprite\Logo.txt");
            _logo = new char[lines[1].Count(), lines.GetLength(0)];

            int x = 0, y = 0;

            foreach (string line in lines)
            {
                x = 0;
                foreach (char c in line)
                {
                    _logo[x, y] = c;
                    x++;
                }
                y++;
            }
        }

        public void drawIntro()
        {

            for (int j = 0; j < _logo.GetLength(1); j++)
            {
                for (int i = 0; i < _logo.GetLength(0); i++)
                {
                    switch (_logo[i, j])
                    {
                        case '*':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            break;
                        case ';':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            break;
                        case '.':
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;
                        case '}':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case '(':
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            break;
                        case '&':
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.White;
                            break;
                        case '%':
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.BackgroundColor = ConsoleColor.Cyan;
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
                    Console.Write(_logo[i, j]);
                }
                Console.WriteLine();
            }

            // Sleep for 1,5 seconds
            Thread.Sleep(1500);

            Menu.menu();
        }
    }
}
