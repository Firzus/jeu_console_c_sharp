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

        static private bool _isFirstLocationOccupt = false;
        static private bool _isSecondLocationOccupt = false;
        static private bool _isThirdLocationOccupt = false;

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

                _isFirstLocationOccupt = true;

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
                        _starter = "Têtunel";
                        _teamComposition[0] = _starter;
                        Console.WriteLine("\n Très bon choix, Têtunel sera un très grand allié !\n");
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
            Console.WriteLine(" Votre équipe :\n");

            Console.WriteLine(" 1 - " + _teamComposition[0]);
            Console.WriteLine(" 2 - " + _teamComposition[1]);
            Console.WriteLine(" 3 - " + _teamComposition[2] + "\n");

            Console.WriteLine(" Vos altérés (Tous disponible pour les tests) :\n");

            Console.WriteLine(" * Carafon (FEU)");
            Console.WriteLine(" * Manchouette (EAU)");
            Console.WriteLine(" * Volovan (AIE)");
            Console.WriteLine(" * Têtunel (TERRE)");
            Console.WriteLine(" * Goinfrelon (AIR)");
            Console.WriteLine(" * Microcher (TERRE)");
            Console.WriteLine(" * Chacharmant (EAU)");
            Console.WriteLine(" * Cochombre (AIR)\n");

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

                                    if (_teamComposition[0] == "Têtunel" || _teamComposition[1] == "Têtunel" || _teamComposition[2] == "Têtunel")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");
                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            if(!_isFirstLocationOccupt)
                                            {
                                                _teamComposition[0] = "Têtunel";

                                                _isFirstLocationOccupt = true;
                                            }
                                            else if(!_isSecondLocationOccupt)
                                            {
                                                _teamComposition[1] = "Têtunel";

                                                _isSecondLocationOccupt = true;
                                            }
                                            else if(!_isThirdLocationOccupt)
                                            {
                                                _teamComposition[2] = "Têtunel";

                                                _isThirdLocationOccupt = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" A la place de qui ?\n");

                                                string _switchAltereBy = Console.ReadLine();

                                                switch (_switchAltereBy)
                                                {
                                                    case "Chacharmant":
                                                    case "chacharmant":
                                                        Console.WriteLine(" Ajout de Chacharmant à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Chacharmant")
                                                            {
                                                                _teamComposition[i] = "Têtunel";
                                                            }
                                                        }
                                                        break;

                                                    case "Cochombre":
                                                    case "cochombre":
                                                        Console.WriteLine(" Ajout de Cochombre à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Cochombre")
                                                            {
                                                                _teamComposition[i] = "Têtunel";
                                                            }
                                                        }
                                                        break;

                                                    case "Carafon":
                                                    case "carafon":
                                                        Console.WriteLine(" Ajout de Carafon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Carafon")
                                                            {
                                                                _teamComposition[i] = "Têtunel";
                                                            }
                                                        }
                                                        break;

                                                    case "Goinfrelon":
                                                    case "goinfrelon":
                                                        Console.WriteLine(" Ajout de Goinfrelon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Goinfrelon")
                                                            {
                                                                _teamComposition[i] = "Têtunel";
                                                            }
                                                        }
                                                        break;

                                                    case "Manchouette":
                                                    case "manchouette":
                                                        Console.WriteLine(" Ajout de Manchouette à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Manchouette")
                                                            {
                                                                _teamComposition[i] = "Têtunel";
                                                            }
                                                        }
                                                        break;

                                                    case "Microcher":
                                                    case "microcher":
                                                        Console.WriteLine(" Ajout de Microcher à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Microcher")
                                                            {
                                                                _teamComposition[i] = "Têtunel";
                                                            }
                                                        }
                                                        break;

                                                    case "Volovan":
                                                    case "volovan":
                                                        Console.WriteLine(" Ajout de Volovan à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Volovan")
                                                            {
                                                                _teamComposition[i] = "Têtunel";
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
                                    }
                                    break;

                                case "Carafon":
                                case "carafon":

                                    if (_teamComposition[0] == "Carafon" || _teamComposition[1] == "Carafon" || _teamComposition[2] == "Carafon")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");
                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            if (!_isFirstLocationOccupt)
                                            {
                                                _teamComposition[0] = "Carafon";

                                                _isFirstLocationOccupt = true;
                                            }
                                            else if (!_isSecondLocationOccupt)
                                            {
                                                _teamComposition[1] = "Carafon";

                                                _isSecondLocationOccupt = true;
                                            }
                                            else if (!_isThirdLocationOccupt)
                                            {
                                                _teamComposition[2] = "Carafon";

                                                _isThirdLocationOccupt = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" A la place de qui ?\n");

                                                string _switchAltereBy = Console.ReadLine();

                                                switch (_switchAltereBy)
                                                {
                                                    case "Chacharmant":
                                                    case "chacharmant":
                                                        Console.WriteLine(" Ajout de Chacharmant à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Chacharmant")
                                                            {
                                                                _teamComposition[i] = "Carafon";
                                                            }
                                                        }
                                                        break;

                                                    case "Cochombre":
                                                    case "cochombre":
                                                        Console.WriteLine(" Ajout de Cochombre à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Cochombre")
                                                            {
                                                                _teamComposition[i] = "Carafon";
                                                            }
                                                        }
                                                        break;

                                                    case "Têtunel":
                                                    case "Tetunel":
                                                    case "têtunel":
                                                    case "tetunel":
                                                        Console.WriteLine(" Ajout de Têtunel à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Têtunel")
                                                            {
                                                                _teamComposition[i] = "Carafon";
                                                            }
                                                        }
                                                        break;

                                                    case "Goinfrelon":
                                                    case "goinfrelon":
                                                        Console.WriteLine(" Ajout de Goinfrelon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Goinfrelon")
                                                            {
                                                                _teamComposition[i] = "Carafon";
                                                            }
                                                        }
                                                        break;

                                                    case "Manchouette":
                                                    case "manchouette":
                                                        Console.WriteLine(" Ajout de Manchouette à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Manchouette")
                                                            {
                                                                _teamComposition[i] = "Carafon";
                                                            }
                                                        }
                                                        break;

                                                    case "Microcher":
                                                    case "microcher":
                                                        Console.WriteLine(" Ajout de Microcher à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Microcher")
                                                            {
                                                                _teamComposition[i] = "Carafon";
                                                            }
                                                        }
                                                        break;

                                                    case "Volovan":
                                                    case "volovan":
                                                        Console.WriteLine(" Ajout de Volovan à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Volovan")
                                                            {
                                                                _teamComposition[i] = "Carafon";
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
                                    }
                                    break;

                                case "Cochombre":
                                case "cochombre":

                                    if (_teamComposition[0] == "Cochombre" || _teamComposition[1] == "Cochombre" || _teamComposition[2] == "Cochombre")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");
                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            if (!_isFirstLocationOccupt)
                                            {
                                                _teamComposition[0] = "Cochombre";

                                                _isFirstLocationOccupt = true;
                                            }
                                            else if (!_isSecondLocationOccupt)
                                            {
                                                _teamComposition[1] = "Cochombre";

                                                _isSecondLocationOccupt = true;
                                            }
                                            else if (!_isThirdLocationOccupt)
                                            {
                                                _teamComposition[2] = "Cochombre";

                                                _isThirdLocationOccupt = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" A la place de qui ?\n");

                                                string _switchAltereBy = Console.ReadLine();

                                                switch (_switchAltereBy)
                                                {
                                                    case "Chacharmant":
                                                    case "chacharmant":
                                                        Console.WriteLine(" Ajout de Chacharmant à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Chacharmant")
                                                            {
                                                                _teamComposition[i] = "Cochombre";
                                                            }
                                                        }
                                                        break;

                                                    case "Carafon":
                                                    case "carafon":
                                                        Console.WriteLine(" Ajout de Carafon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Carafon")
                                                            {
                                                                _teamComposition[i] = "Cochombre";
                                                            }
                                                        }
                                                        break;

                                                    case "Têtunel":
                                                    case "Tetunel":
                                                    case "têtunel":
                                                    case "tetunel":
                                                        Console.WriteLine(" Ajout de Têtunel à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Têtunel")
                                                            {
                                                                _teamComposition[i] = "Cochombre";
                                                            }
                                                        }
                                                        break;

                                                    case "Goinfrelon":
                                                    case "goinfrelon":
                                                        Console.WriteLine(" Ajout de Goinfrelon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Goinfrelon")
                                                            {
                                                                _teamComposition[i] = "Cochombre";
                                                            }
                                                        }
                                                        break;

                                                    case "Manchouette":
                                                    case "manchouette":
                                                        Console.WriteLine(" Ajout de Manchouette à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Manchouette")
                                                            {
                                                                _teamComposition[i] = "Cochombre";
                                                            }
                                                        }
                                                        break;

                                                    case "Microcher":
                                                    case "microcher":
                                                        Console.WriteLine(" Ajout de Microcher à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Microcher")
                                                            {
                                                                _teamComposition[i] = "Cochombre";
                                                            }
                                                        }
                                                        break;

                                                    case "Volovan":
                                                    case "volovan":
                                                        Console.WriteLine(" Ajout de Volovan à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Volovan")
                                                            {
                                                                _teamComposition[i] = "Cochombre";
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
                                    }
                                    break;

                                case "Goinfrelon":
                                case "goinfrelon":

                                    if (_teamComposition[0] == "Goinfrelon" || _teamComposition[1] == "Goinfrelon" || _teamComposition[2] == "Goinfrelon")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");
                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            if (!_isFirstLocationOccupt)
                                            {
                                                _teamComposition[0] = "Goinfrelon";

                                                _isFirstLocationOccupt = true;
                                            }
                                            else if (!_isSecondLocationOccupt)
                                            {
                                                _teamComposition[1] = "Goinfrelon";

                                                _isSecondLocationOccupt = true;
                                            }
                                            else if (!_isThirdLocationOccupt)
                                            {
                                                _teamComposition[2] = "Goinfrelon";

                                                _isThirdLocationOccupt = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" A la place de qui ?\n");

                                                string _switchAltereBy = Console.ReadLine();

                                                switch (_switchAltereBy)
                                                {
                                                    case "Chacharmant":
                                                    case "chacharmant":
                                                        Console.WriteLine(" Ajout de Chacharmant à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Chacharmant")
                                                            {
                                                                _teamComposition[i] = "Goinfrelon";
                                                            }
                                                        }
                                                        break;

                                                    case "Carafon":
                                                    case "carafon":
                                                        Console.WriteLine(" Ajout de Carafon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Carafon")
                                                            {
                                                                _teamComposition[i] = "Goinfrelon";
                                                            }
                                                        }
                                                        break;

                                                    case "Têtunel":
                                                    case "Tetunel":
                                                    case "têtunel":
                                                    case "tetunel":
                                                        Console.WriteLine(" Ajout de Têtunel à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Têtunel")
                                                            {
                                                                _teamComposition[i] = "Goinfrelon";
                                                            }
                                                        }
                                                        break;

                                                    case "Cochombre":
                                                    case "cochombre":
                                                        Console.WriteLine(" Ajout de Cochombre à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Cochombre")
                                                            {
                                                                _teamComposition[i] = "Goinfrelon";
                                                            }
                                                        }
                                                        break;

                                                    case "Manchouette":
                                                    case "manchouette":
                                                        Console.WriteLine(" Ajout de Manchouette à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Manchouette")
                                                            {
                                                                _teamComposition[i] = "Goinfrelon";
                                                            }
                                                        }
                                                        break;

                                                    case "Microcher":
                                                    case "microcher":
                                                        Console.WriteLine(" Ajout de Microcher à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Microcher")
                                                            {
                                                                _teamComposition[i] = "Goinfrelon";
                                                            }
                                                        }
                                                        break;

                                                    case "Volovan":
                                                    case "volovan":
                                                        Console.WriteLine(" Ajout de Volovan à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Volovan")
                                                            {
                                                                _teamComposition[i] = "Goinfrelon";
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
                                    }
                                    break;

                                case "Manchouette":
                                case "manchouette":

                                    if (_teamComposition[0] == "Manchouette" || _teamComposition[1] == "Manchouette" || _teamComposition[2] == "Manchouette")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");
                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            if (!_isFirstLocationOccupt)
                                            {
                                                _teamComposition[0] = "Manchouette";

                                                _isFirstLocationOccupt = true;
                                            }
                                            else if (!_isSecondLocationOccupt)
                                            {
                                                _teamComposition[1] = "Manchouette";

                                                _isSecondLocationOccupt = true;
                                            }
                                            else if (!_isThirdLocationOccupt)
                                            {
                                                _teamComposition[2] = "Manchouette";

                                                _isThirdLocationOccupt = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" A la place de qui ?\n");

                                                string _switchAltereBy = Console.ReadLine();

                                                switch (_switchAltereBy)
                                                {
                                                    case "Chacharmant":
                                                    case "chacharmant":
                                                        Console.WriteLine(" Ajout de Chacharmant à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Chacharmant")
                                                            {
                                                                _teamComposition[i] = "Manchouette";
                                                            }
                                                        }
                                                        break;

                                                    case "Carafon":
                                                    case "carafon":
                                                        Console.WriteLine(" Ajout de Carafon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Carafon")
                                                            {
                                                                _teamComposition[i] = "Manchouette";
                                                            }
                                                        }
                                                        break;

                                                    case "Têtunel":
                                                    case "Tetunel":
                                                    case "têtunel":
                                                    case "tetunel":
                                                        Console.WriteLine(" Ajout de Têtunel à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Têtunel")
                                                            {
                                                                _teamComposition[i] = "Manchouette";
                                                            }
                                                        }
                                                        break;

                                                    case "Cochombre":
                                                    case "cochombre":
                                                        Console.WriteLine(" Ajout de Cochombre à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Cochombre")
                                                            {
                                                                _teamComposition[i] = "Manchouette";
                                                            }
                                                        }
                                                        break;

                                                    case "Goinfrelon":
                                                    case "goinfrelon":
                                                        Console.WriteLine(" Ajout de Goinfrelon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Goinfrelon")
                                                            {
                                                                _teamComposition[i] = "Manchouette";
                                                            }
                                                        }
                                                        break;

                                                    case "Microcher":
                                                    case "microcher":
                                                        Console.WriteLine(" Ajout de Microcher à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Microcher")
                                                            {
                                                                _teamComposition[i] = "Manchouette";
                                                            }
                                                        }
                                                        break;

                                                    case "Volovan":
                                                    case "volovan":
                                                        Console.WriteLine(" Ajout de Volovan à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Volovan")
                                                            {
                                                                _teamComposition[i] = "Manchouette";
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
                                    }
                                    break;

                                case "Microcher":
                                case "microcher":

                                    if (_teamComposition[0] == "Microcher" || _teamComposition[1] == "Microcher" || _teamComposition[2] == "Microcher")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");
                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            if (!_isFirstLocationOccupt)
                                            {
                                                _teamComposition[0] = "Microcher";

                                                _isFirstLocationOccupt = true;
                                            }
                                            else if (!_isSecondLocationOccupt)
                                            {
                                                _teamComposition[1] = "Microcher";

                                                _isSecondLocationOccupt = true;
                                            }
                                            else if (!_isThirdLocationOccupt)
                                            {
                                                _teamComposition[2] = "Microcher";

                                                _isThirdLocationOccupt = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" A la place de qui ?\n");

                                                string _switchAltereBy = Console.ReadLine();

                                                switch (_switchAltereBy)
                                                {
                                                    case "Chacharmant":
                                                    case "chacharmant":
                                                        Console.WriteLine(" Ajout de Chacharmant à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Chacharmant")
                                                            {
                                                                _teamComposition[i] = "Microcher";
                                                            }
                                                        }
                                                        break;

                                                    case "Carafon":
                                                    case "carafon":
                                                        Console.WriteLine(" Ajout de Carafon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Carafon")
                                                            {
                                                                _teamComposition[i] = "Microcher";
                                                            }
                                                        }
                                                        break;

                                                    case "Têtunel":
                                                    case "Tetunel":
                                                    case "têtunel":
                                                    case "tetunel":
                                                        Console.WriteLine(" Ajout de Têtunel à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Têtunel")
                                                            {
                                                                _teamComposition[i] = "Microcher";
                                                            }
                                                        }
                                                        break;

                                                    case "Cochombre":
                                                    case "cochombre":
                                                        Console.WriteLine(" Ajout de Cochombre à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Cochombre")
                                                            {
                                                                _teamComposition[i] = "Microcher";
                                                            }
                                                        }
                                                        break;

                                                    case "Goinfrelon":
                                                    case "goinfrelon":
                                                        Console.WriteLine(" Ajout de Goinfrelon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Goinfrelon")
                                                            {
                                                                _teamComposition[i] = "Microcher";
                                                            }
                                                        }
                                                        break;

                                                    case "Manchouette":
                                                    case "manchouette":
                                                        Console.WriteLine(" Ajout de Manchouette à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Manchouette")
                                                            {
                                                                _teamComposition[i] = "Microcher";
                                                            }
                                                        }
                                                        break;

                                                    case "Volovan":
                                                    case "volovan":
                                                        Console.WriteLine(" Ajout de Volovan à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Volovan")
                                                            {
                                                                _teamComposition[i] = "Microcher";
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
                                    }
                                    break;

                                case "Volovan":
                                case "volovan":

                                    if (_teamComposition[0] == "Volovan" || _teamComposition[1] == "Volovan" || _teamComposition[2] == "Volovan")
                                    {
                                        Console.WriteLine(" Il est déjà dans ton équipe.\n");
                                        _isSwitchAltereNull = true;
                                    }
                                    else
                                    {
                                        while (_isSwitchAltereByNull)
                                        {
                                            _isSwitchAltereByNull = false;

                                            if (!_isFirstLocationOccupt)
                                            {
                                                _teamComposition[0] = "Volovan";

                                                _isFirstLocationOccupt = true;
                                            }
                                            else if (!_isSecondLocationOccupt)
                                            {
                                                _teamComposition[1] = "Volovan";

                                                _isSecondLocationOccupt = true;
                                            }
                                            else if (!_isThirdLocationOccupt)
                                            {
                                                _teamComposition[2] = "Volovan";

                                                _isThirdLocationOccupt = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" A la place de qui ?\n");

                                                string _switchAltereBy = Console.ReadLine();

                                                switch (_switchAltereBy)
                                                {
                                                    case "Chacharmant":
                                                    case "chacharmant":
                                                        Console.WriteLine(" Ajout de Chacharmant à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Chacharmant")
                                                            {
                                                                _teamComposition[i] = "Volovan";
                                                            }
                                                        }
                                                        break;

                                                    case "Carafon":
                                                    case "carafon":
                                                        Console.WriteLine(" Ajout de Carafon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Carafon")
                                                            {
                                                                _teamComposition[i] = "Volovan";
                                                            }
                                                        }
                                                        break;

                                                    case "Têtunel":
                                                    case "Tetunel":
                                                    case "têtunel":
                                                    case "tetunel":
                                                        Console.WriteLine(" Ajout de Têtunel à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Têtunel")
                                                            {
                                                                _teamComposition[i] = "Volovan";
                                                            }
                                                        }
                                                        break;

                                                    case "Cochombre":
                                                    case "cochombre":
                                                        Console.WriteLine(" Ajout de Cochombre à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Cochombre")
                                                            {
                                                                _teamComposition[i] = "Volovan";
                                                            }
                                                        }
                                                        break;

                                                    case "Goinfrelon":
                                                    case "goinfrelon":
                                                        Console.WriteLine(" Ajout de Goinfrelon à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Goinfrelon")
                                                            {
                                                                _teamComposition[i] = "Volovan";
                                                            }
                                                        }
                                                        break;

                                                    case "Manchouette":
                                                    case "manchouette":
                                                        Console.WriteLine(" Ajout de Manchouette à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Manchouette")
                                                            {
                                                                _teamComposition[i] = "Volovan";
                                                            }
                                                        }
                                                        break;

                                                    case "Microcher":
                                                    case "microcher":
                                                        Console.WriteLine(" Ajout de Microcher à ton équipe.\n");
                                                        for (int i = 0; i < _teamComposition.Length; i++)
                                                        {
                                                            if (_teamComposition[i] == "Microcher")
                                                            {
                                                                _teamComposition[i] = "Volovan";
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
