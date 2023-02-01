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

        public static void FightScene()
        {
            Console.WriteLine("Un " + Pikachu.GetName() + " sauvage apparait !");

            // determine le premier
            if (SpeedAlterePLayerActive() > Pikachu.GetSpeed())
            {
                m_isPlayerInitiator = true;
            }
            else if (SpeedAlterePLayerActive() < Pikachu.GetSpeed())
            {
                m_isPlayerInitiator = false;
            }
            else
            {
                Random random = new Random();
                m_isPlayerInitiator = random.Next(0, 2) == 0 ? false : true;
            }

            // tant que tout les pokemons sont en vie
            while (AlterePLayer().IsAlive() && AltereIA().IsAlive())
            {
                // boucle de tours
                switch (m_tour)
                {
                    case "tourIA":

                        Console.WriteLine("TOUR IA");
                        Console.WriteLine("pikachu" + " attaque " + NameAlterePLayerActive());
                        AltereIA().Attack(AlterePLayer()); //pikachu attaque Tetunel
                        AlterePLayer().Infos();

                        m_tour = "tourPlayer";

                        break;

                    case "tourPlayer":

                        Console.WriteLine("TOUR JOUEUR");
                        Console.WriteLine(NameAlterePLayerActive() + " attaque " + "Pikachu");
                        AlterePLayer().Attack(AltereIA()); //tetunel attaque pikachu*/
                        AltereIA().Infos();

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

            if (!AlterePLayer().IsAlive())
            {
                Console.WriteLine("Vous êtes KO !");
            }
            if (!AltereIA().IsAlive())
            {
                Console.WriteLine("Vous avez gagné !");
            }
        }

        static public float SpeedAlterePLayerActive()
        {
            if (TeamPlayer.GetFirstAltere() == Tetunel.GetName())
            {
                return Tetunel.GetSpeed();
            }
            else if (TeamPlayer.GetFirstAltere() == Pikachu.GetName())
            {
                return Pikachu.GetSpeed();
            }
            else
            {
                return 0;
            }
        }

        static public string NameAlterePLayerActive()
        {
            if (TeamPlayer.GetFirstAltere() == Tetunel.GetName())
            {
                return Tetunel.GetName();
            }
            else if (TeamPlayer.GetFirstAltere() == Pikachu.GetName())
            {
                return Pikachu.GetName();
            }
            else
            {
                return "";
            }
        }

        static public Tetunel AlterePLayer()
        {
            if (TeamPlayer.IsTetunelSelected() && TeamPlayer.GetFirstAltere() == Tetunel.GetName())
            {
                Tetunel tetunel = Tetunel.Create();

                return tetunel;
            }
            return null;
        }

        static public Pikachu AltereIA()
        {
            if (TeamIA.IsPikachuSelected() && TeamIA.GetFirstAltere() == Pikachu.GetName())
            {
                Pikachu pikachu = Pikachu.Create();

                return pikachu;
            }
            return null;
        }
    }
}
