﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app.Pokemons
{
    internal class Manchouette : Altere
    {
        public static string SrcName => "Manchouette";

        public Manchouette()
        {
            Random random = new Random();

            _name = "Manchouette";
            _level = (float)random.Next(1, 6);
            _life = 50.0f;
            _damage = 20.0f;
            _speed = 35.0f;

            _typeFire = false;
            _typeWatter = true;
            _typeGround = false;
            _typeAir = false;

            // varie de 0 à 100 , 50 = 50% de res
            _defense = 5.0f;
        }
    }
}
