using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_app.Objects;

namespace console_app.Pokemons
{
    internal class Carapuce
    {
        private float m_vie = 50.0f;
        private float m_degats = 20.0f;
        private float m_speed = 50.0f;

        // pokemon de base
        private bool m_isStarter = true;

        // varie de 0 à 100 (exemple : 50 = 50% de résitance)
        private float m_defence = 20.0f;

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
            cible.TakeDamage((1 - m_defence / 100) * m_degats);
        }

        public bool IsAlive()
        {
            return m_vie > 0;
        }

        public void Infos()
        {
            Console.WriteLine("Vie Carapuce: " + m_vie);
        }

        public void TakeVial()
        {
            Vial potion = new Vial();
        }

        public float GetSpeed()
        {
            return m_speed;
        }

        public bool GetStarter()
        {
            return m_isStarter;
        }
    }
}
