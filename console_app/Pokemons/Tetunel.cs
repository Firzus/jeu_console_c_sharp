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
        private bool m_isStarter = true;
        private bool m_isSelected = false;
        private float m_vie = 100.0f;
        private float m_degats = 30.0f;
        private float m_speed = 30.0f;
        // varie de 0 à 100 , 50 = 50% de res
        private float m_defence = 20.0f;

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
            cible.TakeDamage((1 - m_defence / 100) * m_degats);
        }

        public bool IsAlive()
        {
            return m_vie > 0;
        }

        public float GetSpeed()
        {
            return m_speed;
        }

        public bool GetStarter()
        {
            return m_isStarter;
        }

        static public string GetName()
        {
            return m_name;
        }

        public bool IsSelected()
        {
            return m_isSelected;
        }

        // debug
        public void Infos()
        {
            Console.WriteLine("Vie Tetunel: " + m_vie);
        }
    }
}
