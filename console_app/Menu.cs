using console_app.Team;

namespace console_app
{
    internal class Menu
    {


        public static void menu()
        {

            string play = @"
                      ___ _       __  __
                     | _ \ | __ _ \ \/ /
                     | ,_/ |/ _` |_\  / 
                     |_| |_|\__,_|___/  ";

            string[] linesPlay = play.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int longestLengthPlay = linesPlay.Max(line => line.Length);
            string leadingSpacesPlay = new string(' ', longestLengthPlay);
            string playBlock = string.Join(Environment.NewLine, linesPlay.Select(line => leadingSpacesPlay + line));

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


            MultipleChoice(playBlock, saveBlock, loadBlock);
        }

        public static void MultipleChoice(params string[] options)
        {
            int currentPosition = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(options[0]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(options[1]);
            Console.WriteLine(options[2]);

            ConsoleKey key; //= ConsoleKey.UpArrow;
            do
            {
                // Get Input
                key = Console.ReadKey().Key;
                
                // Update
                switch (key)
                {
                    case ConsoleKey.S:
                        if (currentPosition < 2)
                        {
                            currentPosition++;
                        }
                        break;
                    case ConsoleKey.Z:
                        if (currentPosition > 0)
                        {
                            currentPosition--;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
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
                        TeamPlayer.SetStarter();
                        TeamPlayer.SetTeamComposition();

                        Map map = new Map();
                        map.DrawMap();
                        break;
                    case 1:
                        Map map1 = new Map();
                        Save save = new Save();
                        save.SaveData(map1.PlayerX, map1.PlayerY);
                        break;
                    case 2:
                        Load load = new Load();
                        load.LoadData();
                        break;
                }
            }
        }
    }
}