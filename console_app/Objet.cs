using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Objet
    {
        Inventaire inv = new Inventaire();
        // Propriété définie par l'utilisateur
        private string _nom;

        public void GetInformation(string nom)
        {
            _nom = nom;
            inv.AddAtInventaire(_nom);

        }

    }
}
