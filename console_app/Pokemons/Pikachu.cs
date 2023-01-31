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
        private string m_name;
        private bool m_isStarter;
        private int m_level;
        private float m_vie;
        private float m_degats;
        private float m_speed;
        private float m_defence;

        public Pikachu()
        {
            m_name = "Pikachu";
            m_isStarter = true;
            m_level = 5;
            m_vie = 50.0f;
            m_degats = 20.0f;
            m_speed = 20.0f;

            // varie de 0 à 100 (exemple : 50 = 50% de résitance)
            m_defence = 10.0f;
        }

        public void TakeDamage(float nbDegats)
        {
            m_vie -= nbDegats;

            if (m_vie < 0)
            {
                m_vie = 0;
            }
        }

        public void Attack(Carapuce cible)
        {
            cible.TakeDamage((1 - m_defence / 100) * m_degats);
        }

        public bool IsDead()
        {
            return m_vie <= 0;
        }

        public float GetSpeed()
        {
            return m_speed;
        }

        public bool GetStarter()
        {
            return m_isStarter;
        }

        public string GetName()
        {
            return m_name;
        }

        /*DEBUG*/

        public void Infos()
        {
            Console.WriteLine("Vie: " + m_vie);
        }

        /*DEBUG*/
    }
}
