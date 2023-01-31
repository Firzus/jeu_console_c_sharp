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
            // creation des pokemons
            Carapuce carapuce = new Carapuce();
            Pikachu pikachu = new Pikachu();

            Console.WriteLine("Un " + pikachu.GetName() + " sauvage apparait !");

            // determine le premier
            if (pikachu.GetSpeed() > carapuce.GetSpeed())
            {
                m_isPlayerInitiator = true;
            }
            else if(pikachu.GetSpeed() < carapuce.GetSpeed())
            {
                m_isPlayerInitiator = false;
            }
            else
            {
                Random random = new Random();
                m_isPlayerInitiator = random.Next(0, 2) == 0 ? false : true;
            }

            // tant que tout les pokemons sont en vie
            while (pikachu.IsAlive() && carapuce.IsAlive())
            {
                // boucle de tours
                switch (m_tour)
                {
                    case "tourImpair":

                        Console.WriteLine("Pikachu attaque éclair");
                        pikachu.Attack(carapuce); //pikachu attaque carapuce
                        carapuce.Infos();

                        m_tour = "tourPair";

                        break;

                    case "tourPair":

                        Console.WriteLine("Carapuce à toi de jouer, gogogo !");
                        carapuce.Attack(pikachu); //carapuce attaque pikachu
                        pikachu.Infos();

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

            if (!pikachu.IsAlive())
            {
                Console.WriteLine("Vous êtes KO");
            }
            if (!carapuce.IsAlive())
            {
                Console.WriteLine("Vous avez gagné !");
            }

            /* DEBUG */

            //display speed test
            //Console.WriteLine(carapuce.GetSpeed());

            /* DEBUG */
        }
    }
}
