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

        static public void SetStarter()
        {
            Console.WriteLine("Bienvenue dans le monde merveilleux des Pokemon !");
            Console.WriteLine("Je suis professeur Rakka, et je vais t'accompagner dans ton aventure.\n");
            Console.WriteLine("Pour commencer choisi ton starter :\n");
            Console.WriteLine(" *1* Carafon *1* - *2* Manchouette *2* - *3* Volovan *3* - *4* Têtunel *4* \n");

            string starter = Console.ReadLine();

            if(starter == "aze")
            {
                Console.WriteLine("ok");
            }
        }

        static public void CreateTeam()
        {
            Console.WriteLine("Equipe :\n");

            Console.WriteLine();

            // starter
            Pikachu pikachu1 = new Pikachu();

            // others collectable pokemons
            Pikachu pikachu2 = new Pikachu();
            Pikachu pikachu3 = new Pikachu();
            Pikachu pikachu4 = new Pikachu();
        }

        static public void GetInitiator()
        {
            
        }
    }
}
