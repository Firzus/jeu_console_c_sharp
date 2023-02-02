using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace YOURNAMESPACE
{
    [SupportedOSPlatform("windows")]
    internal static class ConsoleManager
    {
        [DllImport("user32.dll")]
        private static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        /// <summary>
        /// Disable resizing, minimize and maximize buttons.
        /// Change console properties.
        /// </summary>
        public static void WindowSetup()
        {
            //Set console properties
            /*Console.Title = ;*/
            //Console.CursorVisible = false;

            //Set console size to 80% of the largest possible size
            int width = (int)(Console.LargestWindowWidth * 0.8);
            int height = (int)(Console.LargestWindowHeight * 0.8);
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
        }
    }
}