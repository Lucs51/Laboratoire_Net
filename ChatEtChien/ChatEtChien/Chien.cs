using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienNamespace
{
    internal class Chien
    {
        public string Name { get; set; }
        public string Ami { get; set; }

        public Chien(string name)
        {
            Name = name;
        }

        public void DevenirAmi(Chien chien)
        {
            Ami = chien.Name;
            chien.Ami = Name;
        }
    }
}
