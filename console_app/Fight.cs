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
            Pikachu pikachu = Pikachu.Create();
            Tetunel tetunel = Tetunel.Create();

            TeamPlayer teamPlayer = TeamPlayer.Create();

            Console.WriteLine("Un " + Pikachu.GetName() + " sauvage apparait !");

            // determine le premier
            if (pikachu.GetSpeed() > tetunel.GetSpeed())
            {
                m_isPlayerInitiator = true;
            }
            else if(pikachu.GetSpeed() < tetunel.GetSpeed())
            {
                m_isPlayerInitiator = false;
            }
            else
            {
                Random random = new Random();
                m_isPlayerInitiator = random.Next(0, 2) == 0 ? false : true;
            }

            // tant que tout les pokemons sont en vie
            while (pikachu.IsAlive() && tetunel.IsAlive())
            {
                // boucle de tours
                switch (m_tour)
                {
                    case "tourImpair":

                        Console.WriteLine("Pikachu attaque éclair");
                        pikachu.Attack(tetunel); //pikachu attaque carapuce
                        tetunel.Infos();

                        m_tour = "tourPair";

                        break;

                    case "tourPair":

                        Console.WriteLine("Carapuce à toi de jouer, gogogo !");
                        /*Carapuce.Attack(Pikachu); //carapuce attaque pikachu*/
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
                Console.WriteLine("Vous êtes KO !");
            }
            if (!tetunel.IsAlive())
            {
                Console.WriteLine("Vous avez gagné !");
            }
        }

        static public void SpawnAlere()
        {

        }
    }
}
