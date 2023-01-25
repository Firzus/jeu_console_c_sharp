using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace console_app
{
    internal class Sprite
    {
        public static void Spriteextraction()
        {
            /*extraction d'un sprite a partir d'un fichier TXT affin de l'afficcher dans la consol, le string recois le txt et permet donc de le retouner en console
             pour avoir une extraction d'autre fichier il suffira de copier la ligne ci dessoue et de mettre le bon path*/
            string[] text = System.IO.File.ReadAllLines(@"X:\jeu_console_c_sharp\console_app\Sprite\Sprite.txt");
            

            for (int i = 0; i < text.Length; i++)
            {
                if (i >= 0)
                {
                    //text[i] = i.ToString("2");
                    var el = text[i];
                    text[i] = el.Reverse().Select(i => i.ToString()).Aggregate((a, b) => a + b);
                    //text[i] = el.Replace('\', '0');
                }
            }

            foreach (var el  in text)
            {
                Console.WriteLine(el);
            }
            System.Console.Write(text);

            /*StringBuilder sb = new StringBuilder(text);
            string reversed = new string(text.Reverse().ToArray()); // retourne le sprite (lui met la tete en bas)

            Console.WriteLine(reversed);*/
            
            


            Console.WriteLine("Press any key to exit."); 
            System.Console.ReadKey();
        }
    }
}
