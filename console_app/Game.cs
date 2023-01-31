using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using console_app;
using console_app.Team;

namespace YOURNAMESPACE
{
    [SupportedOSPlatform("windows")]
    internal static class Game
    {
        static void Main()
        {
            ConsoleManager.WindowSetup();
            /*Map.DrawMap();*/

            // fight
            /*Fight.FightScene();*/
            TeamPlayer.SetStarter();

            TeamPlayer.SetTeamComposition();
        }
    }
}
