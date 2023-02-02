using console_app.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app.Team
{
    internal class TeamIA
    {
        static private string[] m_teamComposition = new string[3];

        public static string[] TeamComposition { get => m_teamComposition; set => m_teamComposition = value; }

        static public void SetTeamComposition()
        {
            string[] options = { Microcher.SrcName, Goinfrelon.SrcName, Cochombre.SrcName, Chacharmant.SrcName };

            Random random = new Random();

            int randomIndex = random.Next(0, options.Length);

            m_teamComposition[0] = options[randomIndex];
            m_teamComposition[1] = options[randomIndex];
            m_teamComposition[2] = options[randomIndex];
        }
    }
}
