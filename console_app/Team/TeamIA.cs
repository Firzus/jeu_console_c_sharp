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
        static private bool m_isCarafonSelected = false;
        static private bool m_isManchouetteSelected = false;
        static private bool m_isVolovanSelected = false;
        static private bool m_isPikachuSelected = false;
        static private bool m_isTetunelSelected = false;

        static private string[] m_teamComposition = new string[3];

        static public void SetTeamComposition()
        {
            m_isPikachuSelected = true;

            m_teamComposition[0] = Pikachu.GetName();
            m_teamComposition[1] = "";
            m_teamComposition[2] = "";
        }

        static public string GetFirstAltere()
        {
            return m_teamComposition[0];
        }

        static public string GetSecondAltere()
        {
            return m_teamComposition[1];
        }

        static public string GetThirdAltere()
        {
            return m_teamComposition[2];
        }

        static public bool IsPikachuSelected()
        {
            return m_isPikachuSelected;
        }
    }
}
