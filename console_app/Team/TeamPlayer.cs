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

        static private bool m_isStarterInputNull = true;
        static private bool m_isSwitchAltereNull = true;
        static private bool m_isSwitchAltereByNull = true;
        static private bool m_isTeamChangeNull = true;

        // team select
        static private bool m_isCarafonSelected = false;
        static private bool m_isManchouetteSelected = false;
        static private bool m_isVolovanSelected = false;
        static private bool m_isPikachuSelected = false;
        static private bool m_isTetunelSelected = false;

        static private string[] m_teamComposition = new string[3];

        static public TeamPlayer Create()
        {
            return new TeamPlayer();
        }

        private static void FlushKeyboard()
        {
            while (Console.In.Peek() != -1)
                Console.In.Read();
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
                string m_starterInput = Console.ReadLine();

                switch (m_starterInput)
                {
                    case "1":
                    case "Carafon":
                    case "carafon":
                        m_isCarafonSelected = true;
                        m_starter = "Carafon";
                        m_teamComposition[0] = m_starter;
                        Console.WriteLine("\n Très bon choix, Carafon sera un très grand allié !\n");
                        break;

                    case "2":
                    case "Manchouette":
                    case "manchouette":
                        m_isManchouetteSelected = true;
                        m_starter = "Manchouette";
                        m_teamComposition[0] = m_starter;
                        Console.WriteLine("\n Très bon choix, Manchouette sera un très grand allié !\n");
                        break;

                    case "3":
                    case "Volovan":
                    case "volovan":
                        m_isVolovanSelected = true;
                        m_starter = "Volovan";
                        m_teamComposition[0] = m_starter;
                        Console.WriteLine("\n Très bon choix, Volovan sera un très grand allié !\n");
                        break;

                    case "4":
                    case "Tetunel":
                    case "tetunel":
                    case "Têtunel":
                    case "têtunel":
                        m_isTetunelSelected = true;
                        m_starter = Tetunel.GetName();
                        m_teamComposition[0] = m_starter;
                        Console.WriteLine("\n Très bon choix, Tetunel sera un très grand allié !\n");
                        break;

                    default:
                        Console.WriteLine("Je n'ai pas compris, veillez recommencer. \n");
                        m_isStarterInputNull = true;
                        break;
                }
            }
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
                string m_teamChange = Console.ReadLine();

                switch (m_teamChange)
                {
                    case "oui":
                    case "Oui":

                        while (m_isSwitchAltereNull)
                        {
                            m_isSwitchAltereNull = false;

                            Console.WriteLine(" Qui veux-tu ajouter ?\n");
                            string m_switchAltere = Console.ReadLine();

                            switch (m_switchAltere)
                            {
                                case "Tetunel":
                                case "Têtunel":
                                case "tetunel":
                                case "têtunel":

                                    if (m_isTetunelSelected)
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");

                                        m_isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (m_isSwitchAltereByNull)
                                        {
                                            m_isSwitchAltereByNull = false;

                                            Console.WriteLine(" A la place de qui ?\n");
                                            string m_switchAltereBy = Console.ReadLine();

                                            switch (m_switchAltereBy)
                                            {
                                                case "Pikachu":
                                                case "pikachu":
                                                    Console.WriteLine(" Ajout de Pikachu à ton équipe.\n");
                                                    m_isTetunelSelected = false;
                                                    m_isPikachuSelected = true;
                                                    for (int i = 0; i < m_teamComposition.Length; i++)
                                                    {
                                                        if (m_teamComposition[i] == Tetunel.GetName()) // old value
                                                        {
                                                            m_teamComposition[i] = Pikachu.GetName(); // new value
                                                        }
                                                    }
                                                    break;

                                                default:
                                                    Console.WriteLine(" Je n'ai pas compris, veillez recommencer. \n");
                                                    m_isSwitchAltereByNull = true;
                                                    break;
                                            }
                                        }
                                    }
                                    break;

                                case "Pikachu":
                                case "pikachu":

                                    if (m_isPikachuSelected)
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");

                                        m_isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (m_isSwitchAltereByNull)
                                        {
                                            m_isSwitchAltereByNull = false;

                                            Console.WriteLine(" A la place de qui ?\n");
                                            string m_switchAltereBy = Console.ReadLine();

                                            switch (m_switchAltereBy)
                                            {
                                                case "Tetunel":
                                                case "tetunel":
                                                    Console.WriteLine(" Ajout de Tetunel à ton équipe.\n");
                                                    m_isPikachuSelected = false;
                                                    m_isTetunelSelected = true;
                                                    for (int i = 0; i < m_teamComposition.Length; i++)
                                                    {
                                                        if (m_teamComposition[i] == Pikachu.GetName()) // old value
                                                        {
                                                            m_teamComposition[i] = Tetunel.GetName(); // new value
                                                        }
                                                    }
                                                    break;

                                                default:
                                                    Console.WriteLine(" Je n'ai pas compris, veillez recommencer. \n");
                                                    m_isSwitchAltereByNull = true;
                                                    break;
                                            }
                                        }
                                    }
                                    break;

                                default:
                                    Console.WriteLine(" Je n'ai pas compris, veillez recommencer. \n");
                                    m_isSwitchAltereNull = true;
                                    break;
                            }
                        }

                        break;

                    case "non":
                    case "Non":
                        break;

                    default:
                        Console.WriteLine(" Je n'ai pas compris, veillez recommencer. \n");
                        m_isTeamChangeNull = true;
                        break;
                }
            }
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

        static public bool IsTetunelSelected()
        {
            return m_isTetunelSelected;
        }

    }
}
