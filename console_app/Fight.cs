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
        static private bool m_isPlayerInitiator;
        static private string m_tour = "whoStart";

        static Altere _player;
        static Altere _enemy;

        public static void FightScene()
        {
            Console.WriteLine(" Un " + AltereIAActive().Name + " niveau " + AltereIAActive().Level + " sauvage apparait !\n");

            Console.WriteLine(" " + AlterePLayerActive().Name + " niveau " + AlterePLayerActive().Level + " à toi de jouer !\n");

            // determine le premier
            if (AlterePLayerActive().Speed > AltereIAActive().Speed)
            {
                m_isPlayerInitiator = true;
            }
            else if (AlterePLayerActive().Speed < AltereIAActive().Speed)
            {
                m_isPlayerInitiator = false;
            }
            else
            {
                Random random = new Random();
                m_isPlayerInitiator = random.Next(0, 2) == 0 ? false : true;
            }

            // tant que tout les pokemons sont en vie
            while (AlterePLayerActive().IsAlive && AltereIAActive().IsAlive)
            {
                // boucle de tours
                switch (m_tour)
                {
                    case "tourIA":

                        Console.WriteLine("TOUR IA");
                        Console.WriteLine(AltereIAActive().Name + " attaque " + AlterePLayerActive().Name);
                        AltereIAActive().Attack(AlterePLayerActive());

                        Console.WriteLine(" Vie " + AlterePLayerActive().Name + " : " + AlterePLayerActive().Life);

                        m_tour = "tourPlayer";

                        break;

                    case "tourPlayer":

                        Console.WriteLine("TOUR JOUEUR");
                        Console.WriteLine(AlterePLayerActive().Name + " attaque " + AltereIAActive().Name);
                        AlterePLayerActive().Attack(AltereIAActive());

                        Console.WriteLine(" Vie " + AltereIAActive().Name + " : " + AltereIAActive().Life);

                        m_tour = "tourIA";

                        break;

                    case "whoStart":

                        if (m_isPlayerInitiator)
                        {
                            m_tour = "tourPlayer";
                        }
                        if (!m_isPlayerInitiator)
                        {
                            m_tour = "tourIA";
                        }

                        break;
                }
            }

            if (!AlterePLayerActive().IsAlive)
            {
                Console.WriteLine("Vous êtes KO !");
            }
            if (!AltereIAActive().IsAlive)
            {
                Console.WriteLine("Vous avez gagné !");
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
