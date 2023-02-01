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
        private float m_life = 50.0f;
        private float m_damage = 20.0f;
        static private float m_speed = 30.0f;
        // varie de 0 à 100 , 50 = 50% de res
        private float m_defence = 0.0f;

        static public Pikachu Create()
        {
            return new Pikachu();
        }

        public float GetLife()
        {
            return m_life;
        }

        public float GetDamage()
        {
            return m_damage;
        }

        public bool IsAlive()
        {
            return m_life > 0;
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
            Console.WriteLine("Vie Pikachu: " + m_life);
        }

        /*DEBUG*/
    }
}
