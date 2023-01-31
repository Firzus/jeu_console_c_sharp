﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_app.Objects;

namespace console_app.Pokemons
{
    internal class Pikachu
    {
        static private string m_name = "Pikachu";
        static private bool m_isStarter = true;
        static private float m_vie = 50.0f;
        static private float m_degats = 20.0f;
        static private float m_speed = 30.0f;
        static private float m_defence = 10.0f; // varie de 0 à 100 , 50 = 50% de res

        static public void TakeDamage(float nbDegats)
        {
            m_vie -= nbDegats;

            if (m_vie < 0)
            {
                m_vie = 0;
            }
        }

        static public float Attack()
        {
            return (1 - m_defence / 100) * m_degats;
        }

        static public bool IsAlive()
        {
            return m_vie > 0;
        }

        static public float GetSpeed()
        {
            return m_speed;
        }

        static public bool GetStarter()
        {
            return m_isStarter;
        }

        static public string GetName()
        {
            return m_name;
        }

        /*DEBUG*/

        static public void Infos()
        {
            Console.WriteLine("Vie Pikachu: " + m_vie);
        }

        /*DEBUG*/
    }
}
