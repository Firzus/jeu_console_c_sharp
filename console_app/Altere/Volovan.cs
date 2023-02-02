using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app.Pokemons
{
    internal class Volovan : Altere
    {
        public static string SrcName => "Volovan";

        public Volovan()
        {
            Random random = new Random();

            _name = "Volovan";
            _level = (float)random.Next(1, 6);
            _life = 40.0f;
            _damage = 30.0f;
            _speed = 30.0f;

            _type = "Air";
            _typeFire = false;
            _typeWatter = false;
            _typeGround = false;
            _typeAir = true;

            // varie de 0 à 100 , 50 = 50% de res
            _defense = 0.0f;
        }
    }
}
