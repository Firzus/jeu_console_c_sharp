using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_app.Objects;

namespace console_app.Pokemons
{
    internal class Microcher : Altere
    {
        public static string SrcName => "Microcher";

        public Microcher()
        {
            Random random = new Random();

            _name = "Microcher";
            _level = (float)random.Next(1, 6);
            _life = 50.0f;
            _damage = 20.0f;
            _speed = 30.0f;

            _typeFire = false;
            _typeWatter = false;
            _typeGround = true;
            _typeAir = false;

            // varie de 0 à 100 , 50 = 50% de res
            _defense = 15.0f;
        }
    }
}
