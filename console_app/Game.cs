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
            // DEBUG
            //ConsoleManager.WindowSetup();
            // DEBUG

            // test
            TeamIA.SetTeamComposition();

            TeamPlayer.SetStarter();
            TeamPlayer.SetTeamComposition();

            // fight
            Fight.FightScene();
        }
    }
}
