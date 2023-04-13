using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    partial class Catalogue
    {
        public void RechercherParTitre(string recherche)
        {
            foreach (var item in Films)
            {
                if (item.Titre.Contains(recherche))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void RechercherParActeur(string recherche)
        {
            foreach (var item in Films)
            {
                if (item.Acteurs.Contains(recherche))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
