using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }


        public static void menu()
        {
            string start = @" 
                     ___ _            _   
                    / __| |_ __ _ _ _| |_ 
                    \__ \  _/ _` | '_|  _|
                    |___/\__\__,_|_|  \__|";

            var linesstart = start.Split(new[] { Environment.NewLine },
            StringSplitOptions.None);
            var longestLengthstart = linesstart.Max(line => line.Length);
            var leadingSpacesstart = new string(' ', longestLengthstart);
            var startblock = string.Join(Environment.NewLine,
                linesstart.Select(line => leadingSpacesstart + line));

            string save = @" 
                     ___               
                    / __| __ ___ _____ 
                    \__ \/ _` \ V / -_)
                    |___/\__,_|\_/\___|";

            var linessave = save.Split(new[] { Environment.NewLine },
            StringSplitOptions.None);
            var longestLengthsave = linessave.Max(line => line.Length);
            var leadingSpacessave = new string(' ', longestLengthsave);
            var saveblock = string.Join(Environment.NewLine,
                linessave.Select(line => leadingSpacessave + line));

            string load = @" 
                      _                 _ 
                     | |   ___  __ _ __| |
                     | |__/ _ \/ _` / _` |
                     |____\___/\__,_\__,_|";

            var linesload = load.Split(new[] { Environment.NewLine },
            StringSplitOptions.None);
            var longestLengthload = linesload.Max(line => line.Length);
            var leadingSpacesload = new string(' ', longestLengthload);
            var loadblock = string.Join(Environment.NewLine,
                linesload.Select(line => leadingSpacesload + line));

            string extra = @"
                              _            
                      _____ _| |_ _ _ __ _ 
                     / -_) \ /  _| '_/ _` |
                     \___/_\_\\__|_| \__,_|";

            var linesextra = extra.Split(new[] { Environment.NewLine },
            StringSplitOptions.None);
            var longestLengthextra = linesextra.Max(line => line.Length);
            var leadingSpacesextra = new string(' ', longestLengthextra);
            var extrablock = string.Join(Environment.NewLine,
                linesextra.Select(line => leadingSpacesextra + line));

            string credits = @" 
                                    _ _ _      
                      __ _ _ ___ __| (_) |_ ___
                     / _| '_/ -_) _` | |  _(_-<
                     \__|_| \___\__,_|_|\__/__/";

            var linescredits = credits.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var longestLengthcredits = linescredits.Max(line => line.Length);
            var leadingSpacescredits = new string(' ', longestLengthcredits);
            var creditsblock = string.Join(Environment.NewLine,
                linescredits.Select(line => leadingSpacescredits + line));

            int selectedClass = Menu.MultipleChoice(true, startblock, saveblock, loadblock, extrablock, creditsblock);

            switch (selectedClass)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("4");
                    break;
            }
        }

        public static int MultipleChoice(bool canCancel, params string[] options)
        {
            const int startX = 20;
            const int startY = 0;
            const int optionsPerLine = 2;
            const int spacingPerLine = 5;

            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                Console.Clear();

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine,
                    startY + i / optionsPerLine);
                    if (i == currentSelection)

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (currentSelection % optionsPerLine > 0)
                        {
                            currentSelection--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (currentSelection % optionsPerLine < optionsPerLine - 1) {
                                currentSelection++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (currentSelection >= optionsPerLine)
                        {
                            currentSelection -= optionsPerLine;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (currentSelection + optionsPerLine < options.Length)
                        {
                            currentSelection += optionsPerLine;
                        }
                        break;
                    case ConsoleKey.Escape:
                        if (canCancel)
                        {
                            return -1;
                        }
                        break;
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;
        }
    }
}
