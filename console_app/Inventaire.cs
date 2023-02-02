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
        private List<Object> _object;

        public Inventaire()
        {
            _object = new List<Object> { };
        }

        public void AddAtInventaire(Object Name)
        {

            _object.Add(Name);
            
        }

        public void WindowInventaire()
        {
            Console.Clear();
            Console.WriteLine("Binvenue dans l'inventaire");
            Console.WriteLine("Appuyer sur space pour sortir");
            foreach (Object obj in _object)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
