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
        static private string m_switchAltere = "";
        static private string m_switchAltereBy = "";

        static private bool m_isStarterInputNull = true;
        static private bool m_isSwitchAltereNull = true;
        static private bool m_isSwitchAltereByNull = true;
        static private bool m_isTeamChangeNull = true;

        static private bool m_isInTeam = false;

        static private string m_teamChange = "";
        static private string[] m_teamComposition = new string[3];

        static public TeamPlayer Create()
        {
            return new TeamPlayer();
        }

        static public void SetStarter()
        {
            Console.WriteLine(" Bienvenue dans le monde merveilleux d'Osatopia !");
            Console.WriteLine(" Je suis professeur Raimon Santo, je vais t'accompagner dans ton aventure.\n");

            Console.WriteLine(" Pour commencer choisi ton starter :\n");
            Console.WriteLine(" *1* Carafon *1* - *2* Manchouette *2* - *3* Volovan *3* - *4* Têtunel *4* \n");

            while(m_isStarterInputNull)
            {
                m_isStarterInputNull = false;

                Console.WriteLine(" Qui veux-tu choisir ?\n");
                m_starterInput = Console.ReadLine();

                switch (m_starterInput)
                {
                    case "1":
                    case "Carafon":
                    case "carafon":
                        // create Carafon
                        m_starter = "Carafon";
                        m_teamComposition[0] = m_starter;
                        Console.WriteLine(" Très bon choix, Carafon sera un très grand allié !\n");
                        break;

                    case "2":
                    case "Manchouette":
                    case "manchouette":
                        // create Manchouette
                        m_starter = "Manchouette";
                        m_teamComposition[0] = m_starter;
                        Console.WriteLine(" Très bon choix, Manchouette sera un très grand allié !\n");
                        break;

                    case "3":
                    case "Volovan":
                    case "volovan":
                        // create Volovan
                        m_starter = "Volovan";
                        m_teamComposition[0] = m_starter;
                        Console.WriteLine(" Très bon choix, Volovan sera un très grand allié !\n");
                        break;

                    case "4":
                    case "Tetunel":
                    case "tetunel":
                    case "Têtunel":
                    case "têtunel":
                        CreateTetunel();
                        m_starter = Tetunel.GetName();
                        m_teamComposition[0] = m_starter;
                        Console.WriteLine(" Très bon choix, Tetunel sera un très grand allié !\n");
                        break;

                    default:
                        Console.WriteLine("Je n'ai pas compris, veillez recommencer. \n");
                        m_isStarterInputNull = true;
                        break;
                }
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
            Console.WriteLine(" * " + Tetunel.GetName() + " *");

            Console.WriteLine(" * " + Pikachu.GetName() + " *\n");

            while (m_isTeamChangeNull)
            {
                m_isTeamChangeNull = false;

                Console.WriteLine(" Souhaitez-vous changer la composition de vôtre équipe ?\n");
                m_teamChange = Console.ReadLine();

                switch (m_teamChange)
                {
                    case "oui":
                    case "Oui":

                        while (m_isSwitchAltereNull)
                        {
                            m_isSwitchAltereNull = false;

                            Console.WriteLine(" Qui veux-tu ajouter ?");
                            m_switchAltere = Console.ReadLine();

                            switch (m_switchAltere)
                            {
                                case "1":
                                case "Tetunel":
                                case "Têtunel":
                                case "tetunel":
                                case "têtunel":

                                    if (m_teamComposition[0] == Tetunel.GetName() || m_teamComposition[1] == Tetunel.GetName() || m_teamComposition[2] == Tetunel.GetName())
                                    {
                                        Console.WriteLine("Il est déjà dans ton équipe.\n");

                                        m_isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (m_isSwitchAltereByNull)
                                        {
                                            m_isSwitchAltereByNull = false;

                                            Console.WriteLine("Par qui veux-tu le remplacer ?\n");
                                            m_switchAltereBy = Console.ReadLine();

                                            switch (m_switchAltereBy)
                                            {
                                                case "Pikachu":
                                                case "pikachu":
                                                    // altere is selected
                                                    // altere deselected
                                                    Console.WriteLine("Ajout de Pikachu à ton équipe.\n");
                                                    break;

                                                default:
                                                    Console.WriteLine("Je n'ai pas compris, veillez recommencer. \n");
                                                    m_isSwitchAltereByNull = true;
                                                    break;
                                            }
                                        }
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Je n'ai pas compris, veillez recommencer. \n");
                                    m_isSwitchAltereNull = true;
                                    break;
                            }
                        }

                        break;

                    case "non":
                    case "Non":
                        Console.WriteLine("Soit, retour au jeu.\n");
                        break;

                    default:
                        Console.WriteLine("Je n'ai pas compris, veillez recommencer. \n");
                        m_isTeamChangeNull = true;
                        break;
                }
            }
            // set composition

        }

        public float GetInitiator()
        {
            return 0.0f;
        }

        static public void CreateTetunel()
        {
            Tetunel tetunel = Tetunel.Create();
        }
    }
}
