using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Map
    {
        public static void DrawMap()
        {
            // modeling map
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
            }
        }
    }
}
