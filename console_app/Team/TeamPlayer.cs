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
        static private string _starter = "";

        static private bool _isStarterInputNull = true;
        static private bool _isSwitchAltereNull = true;
        static private bool _isSwitchAltereByNull = true;
        static private bool _isTeamChangeNull = true;

        static private string[] _teamComposition = new string[3];

        public static string[] TeamComposition { get => _teamComposition; set => _teamComposition = value; }

        static public void SetStarter()
        {
            Console.WriteLine(" Bienvenue dans le monde merveilleux d'Osatopia !");
            Console.WriteLine(" Je suis professeur Raimon Santo, je vais t'accompagner dans ton aventure.\n");

            Console.WriteLine(" Pour commencer choisi ton starter :\n");
            Console.WriteLine(" *1* Carafon *1* - *2* Manchouette *2* - *3* Volovan *3* - *4* Têtunel *4* \n");

            while(_isStarterInputNull)
            {
                _isStarterInputNull = false;

                Console.WriteLine(" Qui veux-tu choisir ?\n");
                string m_starterInput = Console.ReadLine();

                switch (m_starterInput)
                {
                    case "1":
                    case "Carafon":
                    case "carafon":
                        _starter = "Carafon";
                        _teamComposition[0] = _starter;
                        Console.WriteLine("\n Très bon choix, Carafon sera un très grand allié !\n");
                        break;

                    case "2":
                    case "Manchouette":
                    case "manchouette":
                        _starter = "Manchouette";
                        _teamComposition[0] = _starter;
                        Console.WriteLine("\n Très bon choix, Manchouette sera un très grand allié !\n");
                        break;

                    case "3":
                    case "Volovan":
                    case "volovan":
                        _starter = "Volovan";
                        _teamComposition[0] = _starter;
                        Console.WriteLine("\n Très bon choix, Volovan sera un très grand allié !\n");
                        break;

                    case "4":
                    case "Tetunel":
                    case "tetunel":
                    case "Têtunel":
                    case "têtunel":
                        _starter = "Tetunel";
                        _teamComposition[0] = _starter;
                        Console.WriteLine("\n Très bon choix, Tetunel sera un très grand allié !\n");
                        break;

                    default:
                        Console.WriteLine("Je n'ai pas compris, veillez recommencer. \n");
                        _isStarterInputNull = true;
                        break;
                }
            }
        }

        static public void SetTeamComposition()
        {
            Console.WriteLine(" Equipe :\n");

            Console.WriteLine(" 1 - " + _teamComposition[0]);
            Console.WriteLine(" 2 - " + _teamComposition[1]);
            Console.WriteLine(" 3 - " + _teamComposition[2] + "\n");

            Console.WriteLine(" Vos altérés :\n");

            Console.WriteLine(" * Microcher *");
            Console.WriteLine(" * Pikachu *\n");

            while (_isTeamChangeNull)
            {
                _isTeamChangeNull = false;

                Console.WriteLine(" Souhaitez-vous changer la composition de vôtre équipe ?\n");
                string _teamChange = Console.ReadLine();

                switch (_teamChange)
                {
                    case "oui":
                    case "Oui":

                        while (_isSwitchAltereNull)
                        {
                            _isSwitchAltereNull = false;

                            Console.WriteLine(" Qui veux-tu ajouter ?\n");
                            string _switchAltere = Console.ReadLine();

                            switch (_switchAltere)
                            {
                                case "Tetunel":
                                case "Têtunel":
                                case "tetunel":
                                case "têtunel":

                                    if (_teamComposition[0] == "Tetunel" || _teamComposition[1] == "Tetunel" || _teamComposition[2] == "Tetunel")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");

                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            Console.WriteLine(" A la place de qui ?\n");
                                            string _switchAltereBy = Console.ReadLine();

                                            switch (_switchAltereBy)
                                            {
                                                case "Pikachu":
                                                case "pikachu":
                                                    Console.WriteLine(" Ajout de Pikachu à ton équipe.\n");
                                                    for (int i = 0; i < _teamComposition.Length; i++)
                                                    {
                                                        if (_teamComposition[i] == "Tetunel") // old value
                                                        {
                                                            _teamComposition[i] = "Pikachu"; // new value
                                                        }
                                                    }
                                                    break;

                                                default:
                                                    Console.WriteLine(" Je n'ai pas compris, veillez recommencer. \n");
                                                    _isSwitchAltereByNull = true;
                                                    break;
                                            }
                                        }
                                    }
                                    break;

                                case "Pikachu":
                                case "pikachu":

                                    if (_teamComposition[0] == "Pikachu" || _teamComposition[1] == "Pikachu" || _teamComposition[2] == "Pikachu")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");

                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            Console.WriteLine(" A la place de qui ?\n");
                                            string _switchAltereBy= Console.ReadLine();

                                            switch (_switchAltereBy)
                                            {
                                                case "Tetunel":
                                                case "tetunel":
                                                    Console.WriteLine(" Ajout de Tetunel à ton équipe.\n");
                                                    for (int i = 0; i < _teamComposition.Length; i++)
                                                    {
                                                        if (_teamComposition[i] == "Pikachu") // old value
                                                        {
                                                            _teamComposition[i] = "Tetunel"; // new value
                                                        }
                                                    }
                                                    break;

                                                default:
                                                    Console.WriteLine(" Je n'ai pas compris, veillez recommencer. \n");
                                                    _isSwitchAltereByNull = true;
                                                    break;
                                            }
                                        }
                                    }
                                    break;

                                default:
                                    Console.WriteLine(" Je n'ai pas compris, veillez recommencer. \n");
                                    _isSwitchAltereNull = true;
                                    break;
                            }
                        }

                        break;

                    case "non":
                    case "Non":
                        break;

                    default:
                        Console.WriteLine(" Je n'ai pas compris, veillez recommencer. \n");
                        _isTeamChangeNull = true;
                        break;
                }
            }
        }

        static public string GetFirstAltere()
        {
            return _teamComposition[0];
        }

        static public string GetSecondAltere()
        {
            return _teamComposition[1];
        }

        static public string GetThirdAltere()
        {
            return _teamComposition[2];
        }
    }
}
