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
            }
        }

        public static int MultipleChoice(params string[] options)
        {
            int currentPosition = 0;

            ConsoleKey key = ConsoleKey.UpArrow;
            do
            {
                // Get Input
                key = Console.ReadKey().Key;
                
                // Update
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (currentPosition < 2)
                        {
                            currentPosition++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (currentPosition > 0)
                        {
                            currentPosition--;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return -1;
                }

                // Draw
                switch (currentPosition)
                {
                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(options[0]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(options[1]);
                        Console.WriteLine(options[2]);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine(options[0]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(options[1]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(options[2]);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(options[0]);
                        Console.WriteLine(options[1]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(options[2]);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            } while (key != ConsoleKey.Enter);

            if (key == ConsoleKey.Enter)
            {
                switch (currentPosition)
                {
                    case 0:
                        Map.drawMap();
                        break;
                    case 1:
                        return -1;
                        //break;
                    case 2:
                        return -1;
                        //break;
                }
            } 

            return currentPosition;
        }
    }
}