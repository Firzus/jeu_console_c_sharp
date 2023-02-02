using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class PierreD_ames : Objet
    {
        public PierreD_ames() {

            Name = "Pierre D'ames";
            IsConsomable = true;
            Quantiter = 1; 
            
        } 

        public PierreD_ames(string name)
        {
            Name = name;
            IsConsomable= true;
            Quantiter = 1;
        }

    }
}
