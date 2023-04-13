using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_agence
{
    partial class Vaisseau
    {
        public void ChangerVitesse(int vitesse)
        {
            if (vitesse > VitesseMax) { throw new Exception("La vitesse demandée dépasse la vitesse maximale du vaisseau"); }
            else
            {
                VitesseActuelle = vitesse;
            }
        }
    }
}
