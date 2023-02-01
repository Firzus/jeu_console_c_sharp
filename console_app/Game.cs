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
            bool Play = true;
            bool Isdraw = false;

            ConsoleManager.WindowSetup();
            Map map = new Map();
            while(Play == true)
            {
                if(Isdraw == false)
                {
                   map.DrawMap();
                   Isdraw= true;
                }
                
                map.Move();
                
                
               /* if(Console.CancelKeyPress)
                {
                    play = false;
                }*/
            }
            
        }
    }
}