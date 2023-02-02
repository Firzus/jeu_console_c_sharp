using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace console_app
{
    internal class Inventaire
    {
        private List<Object> _objetc;
        Objet obj = new Objet();

        public void InInventaire()
        {
            _objetc = new List<Object>();
        }

        public void AddAtInventaire()
        {

            _objetc.Add(obj);
        }

        public void WindowInventaire()
        {
            Console.Clear();
            Console.WriteLine(_objetc);

        }
    }
}
