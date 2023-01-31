using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_app.Pokemons;

namespace console_app.Team
{
    internal class TeamPlayer
    {
        static private string m_starter = "";
        static private string m_starterInput = "";
        static private string m_teamChange = "";
        static private bool m_isNull = false;
        static private string[] m_teamComposition = new string[3];

        static public void SetStarter()
        {
            Console.WriteLine(" Bienvenue dans le monde merveilleux d'Osatopia !");
            Console.WriteLine(" Je suis professeur Raimon Santo, je vais t'accompagner dans ton aventure.\n");

            Console.WriteLine(" Pour commencer choisi ton starter :\n");
            Console.WriteLine(" *1* Carafon *1* - *2* Manchouette *2* - *3* Volovan *3* - *4* Têtunel *4* \n");

            Console.WriteLine(" Qui veux-tu choisir ?\n");

            m_starterInput = Console.ReadLine();

            if (m_starterInput == "1" || m_starterInput == "Carafon" || m_starterInput == "carafon")
            {
                m_starter = "Carafon";
                m_teamComposition[0] = m_starter;

                Console.WriteLine(" Très bon choix, Carafon sera un très grand allié !\n");
            }
            if (m_starterInput == "2" || m_starterInput == "Manchouette" || m_starterInput == "manchouette")
            {
                m_starter = "Manchouette";
                m_teamComposition[0] = m_starter;

                Console.WriteLine(" Très bon choix, Manchouette sera un très grand allié !\n");
            }
            if (m_starterInput == "3" || m_starterInput == "Volovan" || m_starterInput == "volovan")
            {
                m_starter = "Volovan";
                m_teamComposition[0] = m_starter;

                Console.WriteLine(" Très bon choix, Volovan sera un très grand allié !\n");
            }
            if (m_starterInput == "4" || m_starterInput == "Têtunel" || m_starterInput == "Têtunel" || m_starterInput == "Tetunel" || m_starterInput == "tetunel")
            {
                m_starter = "Têtunel";
                m_teamComposition[0] = m_starter;

                Console.WriteLine(" Très bon choix, Têtunel sera un très grand allié !\n");
            }

            // condition pour les autre valeurs
        }

        static public void SetTeamComposition()
        {
            Console.WriteLine(" Equipe :\n");

            Console.WriteLine(" 1 - " + m_teamComposition[0]);
            Console.WriteLine(" 2 - " + m_teamComposition[1]);
            Console.WriteLine(" 3 - " + m_teamComposition[2] + "\n");

            Console.WriteLine(" Vos altérés :\n");
            Console.WriteLine(" Têtunel - Pikachu - etc\n");
            Console.WriteLine(" Souhaitez-vous changer la composition de vôtre équipe ?\n");

            while(m_isNull)
            {
                m_teamChange = Console.ReadLine();

                switch (m_teamChange)
                {
                    case "oui":
                    case "Oui":
                    case "yes":
                    case "Yes":


                        break;

                    case "non":
                    case "Non":
                    case "no":
                    case "No":

                        break;

                    default:
                        m_isNull = true;
                        break;
                }
            }
        }

        static public void GetInitiator()
        {

        }
    }
}
