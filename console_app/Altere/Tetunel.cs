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
        static private string m_name = "Tetunel";
        private float m_vie = 50.0f;
        private float m_degats = 30.0f;
        static private float m_speed = 50.0f;
        // varie de 0 à 100 , 50 = 50% de res
        private float m_defence = 0.0f;

        static public Tetunel Create()
        {
            return new Tetunel();
        }

        public void TakeDamage(float nbDegats)
        {
            m_vie -= nbDegats;

            if (m_vie < 0)
            {
                m_vie = 0;
            }
        }

        public void Attack(Pikachu cible)
        {
            TakeDamage((1 - m_defence / 100) * m_degats);
        }

        public bool IsAlive()
        {
            return m_vie > 0;
        }

        static public float GetSpeed()
        {
            return m_speed;
        }

        static public string GetName()
        {
            return m_name;
        }

        // debug
        public void Infos()
        {
            Console.WriteLine("Vie Tetunel: " + m_vie);
        }
    }
}
