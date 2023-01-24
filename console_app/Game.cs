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
            ConsoleManager.WindowSetup();
            Map.drawMap();
        }
    }
}
