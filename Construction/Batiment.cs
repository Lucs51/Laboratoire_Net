using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Batiment
    {
        public int Coordonnes { get; set; }
        public string Statut { get; set; }
        public int QuantiteRess { get; set; }
        public int Priorite { get; set; }


        public Batiment (int coordonnes, string statut, int quantiteRess, int priorite)
        {
            Coordonnes = coordonnes;
            Statut = statut;
            QuantiteRess = quantiteRess;
            Priorite = priorite;
        }

       
    }
}
