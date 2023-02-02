﻿using console_app.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app.Pokemons
{
    internal class Tetunel : Altere
    {
        public static string SrcName => "Tetunel";

        public Tetunel()
        {
            Random random = new Random();

            _name = "Tetunel";
            _level = (float)random.Next(1, 6);
            _life = 50.0f;
            _damage = 30.0f;
            _speed = 50.0f;

            // varie de 0 à 100 , 50 = 50% de res
            _defense = 10.0f;
        }
    }
}