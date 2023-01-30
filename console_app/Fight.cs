﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_app.Pokemons;

namespace console_app
{
    internal class Fight
    {
        static private bool m_isPLayerInitiator;
        static private int m_tour;

        public static void FightLoop()
        {
            // creation des pokemons
            Carapuce carapuce = new Carapuce();
            Pikachu pikachu = new Pikachu();

            Console.WriteLine("Un " + pikachu.GetName() + " sauvage apparait !");

            // tant que tout les pokemons sont en vie
            while (!pikachu.IsDead() || !carapuce.IsDead())
            {
                // determine le premier
                if (pikachu.GetSpeed() > carapuce.GetSpeed())
                {
                    m_isPLayerInitiator = true;
                }
                if(pikachu.GetSpeed() < carapuce.GetSpeed())
                {
                    m_isPLayerInitiator = false;
                }
                else
                {
                    // si egalité -> random choice
                }

                // boucle de tours
                switch(m_tour)
                {
                    case 1:
                        pikachu.Attack(carapuce); //pikachu attaque carapuce
                        carapuce.Infos();
                        m_tour = 2;
                        break;

                    case 2:
                        carapuce.Attack(pikachu); //carapuce attaque pikachu
                        pikachu.Infos();
                        m_tour = 1;
                        break;

                   default:
                        if (m_isPLayerInitiator)
                        {
                            m_tour = 1;
                        }
                        if(!m_isPLayerInitiator)
                        {
                            m_tour = 2;
                        }
                        break;
                }

                if(true)
                {
                    /* DEBUG */
                        
                    //display speed test
                    //Console.WriteLine(carapuce.GetSpeed());

                    /* DEBUG */
                }
            }

            if(pikachu.IsDead())
            {
                Console.WriteLine("Vous êtes KO");
            }
            if (carapuce.IsDead())
            {
                Console.WriteLine("Vous avez gagné !");
            }
        }
    }
}