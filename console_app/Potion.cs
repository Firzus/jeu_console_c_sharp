using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace console_app
{
    internal class Potion : Objet
    {
        public Potion() {

            Name = "Potion";
            Quantiter = 1;
            IsConsomable = true;

        }

        public Potion(string name)
        {

            Name = name;
            Quantiter = 1;
            IsConsomable = true;

        }
    }
}
