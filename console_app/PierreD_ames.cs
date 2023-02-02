using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class PierreD_ames
    {
        Objet test = new Objet();

        string name = "Pierre d'âmes";
        public PierreD_ames() {
        }
        
        public void Rammasser()
        {
            test.GetInformation(name);
        }
      
        
    }
}
