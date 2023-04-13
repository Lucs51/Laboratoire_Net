using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_agence
{
    partial class Mission
    {
        public string Nom { get; set; }
        public string Destination { get; set; }
        public string DateDepart { get; set; }
        public string DateArrivee { get; set; }
        public string Statut { get; set; }

        public Mission(string nom, string destination, string dateDepart, string dateArrivee, string statut)
        {
            Nom = nom;
            Destination = destination;
            DateDepart = dateDepart;
            DateArrivee = dateArrivee;
            Statut = statut;
        }
    }
}
