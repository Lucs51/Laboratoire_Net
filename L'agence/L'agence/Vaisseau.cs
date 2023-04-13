using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_agence
{
    partial class Vaisseau
    {
        public string Name { get; set; }
        public int Capacite { get; set; }
        public int VitesseActuelle { get; set; }
        public int VitesseMax { get; set; }
        public bool EnOrbite { get; set; }
        public Mission mission { get; set; }

        public Vaisseau(int vitesseMax)
        {
            VitesseMax = vitesseMax;
        }

        public void Decollage(string nom, string destination, string dateDepart, string dateArrivee)
        {
            if (EnOrbite) { throw new Exception("Le vaisseau est deja en orbite"); }
            else {
                EnOrbite = true;
                mission = new Mission(nom, destination, dateDepart, dateArrivee, "Planifiée");
            }
        }

        public void CompleterMission()
        {
            mission.CompleterMission();
        }


    }
}
