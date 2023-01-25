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

            string[] linesStart = start.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int longestLengthStart = linesStart.Max(line => line.Length);
            string leadingSpacesStart = new string(' ', longestLengthStart);
            string startBlock = string.Join(Environment.NewLine, linesStart.Select(line => leadingSpacesStart + line));

            string save = @" 
                     ___               
                    / __| __ ___ _____ 
                    \__ \/ _` \ V / -_)
                    |___/\__,_|\_/\___|";

            string[] linesSave = save.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int longestLengthSave = linesSave.Max(line => line.Length);
            string leadingSpacesSave = new string(' ', longestLengthSave);
            string saveBlock = string.Join(Environment.NewLine, linesSave.Select(line => leadingSpacesSave + line));

            string load = @" 
                     _                 _ 
                    | |   ___  __ _ __| |
                    | |__/ _ \/ _` / _` |
                    |____\___/\__,_\__,_|";

            string[] linesLoad = load.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int longestLengthLoad = linesLoad.Max(line => line.Length);
            string leadingSpacesLoad = new string(' ', longestLengthLoad);
            string loadBlock = string.Join(Environment.NewLine, linesLoad.Select(line => leadingSpacesLoad + line));

            //Console.Clear();
            Console.WriteLine(start);
            Console.WriteLine(save);
            Console.WriteLine(load);

            /*
            int selectedClass = Menu.MultipleChoice(startBlock, saveBlock, loadBlock);

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
            }*/
        }

        public static int MultipleChoice(params string[] options)
        {
            const int startY = 0;

            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                Console.Clear();

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition((i % 1)*5, (startY + i)*6);
                    if (i == currentSelection)

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (currentSelection > 0)
                        {
                            currentSelection--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (currentSelection < 0) {
                                currentSelection++;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return -1;
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;
        }
    }
}
