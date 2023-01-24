using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Sprite
    {
        int[,] array = new int[4, 2];
        public static void Spriteextraction()
        {
            //extraction d'un sprite a partir d'un fichier TXT affin de l'afficcher dans la consol, le string recois le txt et permet donc de le retouner en console
            string text = System.IO.File.ReadAllText(@"X:\jeu_console_c_sharp\console_app\Sprite.txt");
            System.Console.WriteLine(text);

            Console.WriteLine("Press any key to exit."); 
            System.Console.ReadKey();
        }

    }
}
