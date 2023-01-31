using console_app.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app.Pokemons
{
    internal class Tetunel
    {
        static private float m_vie = 120.0f;
        static private float m_degats = 15.0f;
        static private float m_speed = 100.0f;

        // pokemon de base
        static private bool m_isStarter = true;

        // varie de 0 à 100 (exemple : 50 = 50% de résitance)
        static private float m_defence = 5.0f;

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

        // debug
        static public void Infos()
        {
            Console.WriteLine("Vie Tetunel: " + m_vie);
        }
    }
}
