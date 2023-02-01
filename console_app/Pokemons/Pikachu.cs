using System;
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
        private float m_vie = 50.0f;
        private float m_degats = 20.0f;
        static private float m_speed = 30.0f;
        // varie de 0 à 100 , 50 = 50% de res
        private float m_defence = 0.0f;

        static public Pikachu Create()
        {
            return new Pikachu();
        }

        public void TakeDamage(float nbDegats)
        {
            m_vie -= nbDegats;

            if (m_vie < 0)
            {
                m_vie = 0;
            }
        }

        public void Attack(Tetunel cible)
        {
            cible.TakeDamage((1 - m_defence / 100) * m_degats);
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

        /*DEBUG*/

        public void Infos()
        {
            Console.WriteLine("Vie Pikachu: " + m_vie);
        }

        /*DEBUG*/
    }
}
