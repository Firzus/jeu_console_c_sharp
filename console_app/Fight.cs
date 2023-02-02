using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_app.Pokemons;
using console_app.Team;

namespace console_app
{
    internal class Fight
    {
        static private bool _isPlayerInitiator;
        static private string _tour = "whoStart";

        static private bool _isAnswerAttackNull = true;

        static Altere _player;
        static Altere _enemy;

        public static void FightScene()
        {
            Console.WriteLine(" Un " + AltereIAActive().Name + " niveau " + AltereIAActive().Level + " sauvage apparait !\n");

            Console.WriteLine(" " + AlterePLayerActive().Name + " niveau " + AlterePLayerActive().Level + " à toi de jouer !\n");

            // determine le premier
            if (AlterePLayerActive().Speed > AltereIAActive().Speed)
            {
                _isPlayerInitiator = true;
            }
            else if (AlterePLayerActive().Speed < AltereIAActive().Speed)
            {
                _isPlayerInitiator = false;
            }
            else
            {
                Random random = new Random();
                _isPlayerInitiator = random.Next(0, 2) == 0 ? false : true;
            }

            // tant que tout les pokemons sont en vie
            while (AlterePLayerActive().IsAlive && AltereIAActive().IsAlive)
            {
                // boucle de tours
                switch (_tour)
                {
                    case "tourIA":

                        Console.WriteLine(" TOUR IA\n");

                        Thread.Sleep(2500);

                        AltereIAActive().BasicAttack(AlterePLayerActive());
                        Console.WriteLine(" " + AltereIAActive().Name + " attaque " + AlterePLayerActive().Name);
                        Console.WriteLine(" Vie de " + AlterePLayerActive().Name + " : " + AlterePLayerActive().Life);;

                        _tour = "tourPlayer";

                        break;

                    case "tourPlayer":

                        Console.WriteLine(" TOUR JOUEUR\n");

                        Thread.Sleep(2500);

                        Console.WriteLine(" Que voulez-vous faire ?\n");

                        Console.WriteLine(" *1* Attaque basique");
                        Console.WriteLine(" *2* Attaque élementaire\n");

                        string _answerAttack = Console.ReadLine();

                        while(_isAnswerAttackNull)
                        {
                            _isAnswerAttackNull = false;

                            switch (_answerAttack)
                            {
                                case "Attaque basique":
                                case "attaque basique":
                                case "basique":
                                case "Basique":
                                case "1":
                                    AlterePLayerActive().BasicAttack(AltereIAActive());
                                    Console.WriteLine(" " + AlterePLayerActive().Name + " attaque " + AltereIAActive().Name);
                                    Console.WriteLine(" Vie de " + AltereIAActive().Name + " : " + AltereIAActive().Life + "\n");
                                    break;

                                case "Attaque élementaire":
                                case "Attaque elementaire":
                                case "attaque élementaire":
                                case "attaque elementaire":
                                case "élementaire":
                                case "elementaire":
                                case "2":
                                    AlterePLayerActive().ElementarySpell(AltereIAActive());
                                    Console.WriteLine(" " + AlterePLayerActive().Name + " attaque " + AltereIAActive().Name);
                                    Console.WriteLine(" Vie de " + AltereIAActive().Name + " : " + AltereIAActive().Life + "\n");
                                    break;

                                default:
                                    _isAnswerAttackNull = true;
                                    Console.WriteLine("Je n'ai pas compris, veillez recommencer. \n");
                                    break;
                            }
                        }

                        _tour = "tourIA";
                        break;

                    case "whoStart":

                        if (_isPlayerInitiator)
                        {
                            _tour = "tourPlayer";
                        }
                        if (!_isPlayerInitiator)
                        {
                            _tour = "tourIA";
                        }

                        break;
                }
            }

            if (!AlterePLayerActive().IsAlive)
            {
                Console.WriteLine(" Vous êtes KO !");
            }
            if (!AltereIAActive().IsAlive)
            {
                Console.WriteLine(" Vous avez gagné !");
            }
        }

        static public Altere AlterePLayerActive()
        {
            if (_player == null)
            {
                foreach (var item in TeamPlayer.TeamComposition)
                {
                    if (item == Tetunel.SrcName) _player = new Tetunel();
                    if (item == Manchouette.SrcName) _player = new Manchouette();
                    if (item == Volovan.SrcName) _player = new Volovan();
                    if (item == Carafon.SrcName) _player = new Carafon();

                    if (item == Microcher.SrcName) _player = new Microcher();
                    if (item == Chacharmant.SrcName) _player = new Chacharmant();
                    if (item == Goinfrelon.SrcName) _player = new Goinfrelon();
                    if (item == Cochombre.SrcName) _player = new Cochombre();
                }
            }

            return _player;
        }
        static public Altere AltereIAActive()
        {
            if (_enemy == null)
            {
                foreach (var item in TeamIA.TeamComposition)
                {
                    if (item == Tetunel.SrcName) _enemy = new Tetunel();
                    if (item == Manchouette.SrcName) _enemy = new Manchouette();
                    if (item == Volovan.SrcName) _enemy = new Volovan();
                    if (item == Carafon.SrcName) _player = new Carafon();

                    if (item == Microcher.SrcName) _enemy = new Microcher();
                    if (item == Chacharmant.SrcName) _enemy = new Chacharmant();
                    if (item == Goinfrelon.SrcName) _enemy = new Goinfrelon();
                    if (item == Cochombre.SrcName) _enemy = new Cochombre();
                }
            }

            return _enemy;
        }
    }
}
