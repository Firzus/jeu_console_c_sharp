using console_app.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Altere
    {
        public void TakeDamage(float nbDegats)
        {
            m_vie -= nbDegats;

            if (m_vie < 0)
            {
                m_vie = 0;
            }
        }

        public void Attack(Altere cible)
        {
            cible.TakeDamage((1 - m_defence / 100) * m_degats);
        }
    }
}
