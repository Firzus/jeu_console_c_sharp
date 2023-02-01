using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using console_app;

namespace YOURNAMESPACE
{
    [SupportedOSPlatform("windows")]
    internal static class Game
    {
        static void Main()
        {
            bool play = true;

            ConsoleManager.WindowSetup();

            while(play == true)
            {
                Map map = new Map();
                map.DrawMap();
                //map.DrawPlayer();
                
               /* if(Console.CancelKeyPress)
                {
                    play = false;
                }*/
            }
            
        }
    }
}