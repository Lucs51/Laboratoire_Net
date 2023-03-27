using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChienNamespace;

namespace ChatNamespace
{
    internal class Chat
    {
        public string Name { get; set; }
        public string Ami { get; set; }
        public string Humeur { get; set; }

        public Chat(string name)
        {
            Name = name;
            Random rand = new Random();
            if (rand.Next(1, 10) >= 5)
            {
                Humeur = "mauvaise";
            }
            else
            {
                Humeur = "bonne";
            }
        }   

        public Chien DevenirAmi(Chien chien)
        {
            if(Humeur == "bonne")
            {
                Ami = chien.Name;
                chien.Ami = Name;
            }
            return chien;
        }
    }
}
