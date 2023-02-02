using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app.Pokemons
{
    internal class Cochombre : Altere
    {
        public static string SrcName => "Cochombre";

        public Cochombre()
        {
            Random random = new Random();

            _name = "Cochombre";
            _level = (float)random.Next(1, 6);
            _life = 50.0f;
            _damage = 20.0f;
            _speed = 35.0f;

            // varie de 0 à 100 , 50 = 50% de res
            _defense = 5.0f;
        }
    }
}
