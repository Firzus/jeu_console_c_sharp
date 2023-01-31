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
            if (Pikachu.GetSpeed() > Tetunel.GetSpeed())
            {
                m_isPlayerInitiator = true;
            }
            else if(Pikachu.GetSpeed() < Tetunel.GetSpeed())
            {
                m_isPlayerInitiator = false;
            }
            else
            {
                Random random = new Random();
                m_isPlayerInitiator = random.Next(0, 2) == 0 ? false : true;
            }

            // tant que tout les pokemons sont en vie
            while (Pikachu.IsAlive() && Tetunel.IsAlive())
            {
                // boucle de tours
                switch (m_tour)
                {
                    case "tourImpair":

                        Console.WriteLine("Pikachu attaque éclair");
                        /*Pikachu.Attack(Carapuce); //pikachu attaque carapuce*/
                        Tetunel.Infos();

                        m_tour = "tourPair";

                        break;

                    case "tourPair":

                        Console.WriteLine("Carapuce à toi de jouer, gogogo !");
                        /*Carapuce.Attack(Pikachu); //carapuce attaque pikachu*/
                        Pikachu.Infos();

                        m_tour = "tourImpair";

                        break;

                    case "whoStart":

                        if (m_isPlayerInitiator)
                        {
                            m_tour = "tourImpair";
                        }
                        if (!m_isPlayerInitiator)
                        {
                            m_tour = "tourPair";
                        }

                        break;
                }
            }

            if (!Pikachu.IsAlive())
            {
                Console.WriteLine("Vous êtes KO !");
            }
            if (!Tetunel.IsAlive())
            {
                Console.WriteLine("Vous avez gagné !");
            }
        }
    }
}
