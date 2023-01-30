using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace console_app
{
    internal class Map
    {
        public static void DrawMap()
        {

            string[] map = System.IO.File.ReadAllLines(@"X:\jeu_console_c_sharp\console_app\Sprite\Map.txt");
            System.Console.Write(map);

            /* // modeling map
             string[] map =
             {
                 "   ┌─────────────────────────────────────┐",
                 "   │#####################################│",
                 "   │##############     ############### ##│",
                 "   │############    !  %%%%  #####  #   #│",
                 "   │###########        %%%%             @│",
                 "   │#######            %%%%              │",
                 "   │#####              ####      ##### ##│",
                 "   │@  ###          ########     ########│",
                 "   │#              ##########      ######│",
                 "   │#              ##############     ###│",
                 "   │###           ####%%%#########    &&#│",
                 "   │####              %%%##########   &&#│",
                 "   │#############       ##############&&#│",
                 "   │##############     ##################│",
                 "   │#####################################│",
                 "   └─────────────────────────────────────┘"    
             };

             // modeling character
             string character = "?";

             // modeling zap
             string zap = "*";

             // display map
             for (int y = 0; y < map.Length; y++)
             {
                 for (int x = 0; x < map[y].Length; x++)
                 {
                     char title = map[y][x];
                     Console.Write(title);
                 }
                 Console.WriteLine();
        }*/
        }
    }
}
