using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using console_app;
using console_app.Pokemons;
using console_app.Team;

namespace YOURNAMESPACE
{
    [SupportedOSPlatform("windows")]
    internal static class Game
    {
        static void Main()
        {
            bool Play = true;
            bool Isdraw = false;

            Map map = new Map();
            Intro intro= new Intro();
            while(Play == true)
            {
                if(Isdraw == false)
                {
                   intro.drawIntro();
                   map.DrawMap();
                   Isdraw= true;
                }
                
                map.Move();
                
                
               /* if(Console.CancelKeyPress)
                {
                    play = false;
                }*/
            }
            
            /* 
            
            TeamIA.SetTeamComposition();

            TeamPlayer.SetStarter();
            TeamPlayer.SetTeamComposition();

            // fight
            Fight.FightScene();
            
            */
        }
    }
}