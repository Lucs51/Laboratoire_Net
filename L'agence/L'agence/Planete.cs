using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_agence
{
    internal class Planete
    {
        Random r = new Random();
        public string Nom { get; set; }
        public int Taille { get; set; }
        public int DistanceTerre { get; set; }
        public bool Viable { get; set; }
        public bool Visite { get; set; }

        public void AEteVisite()
        {
            if (Visite) { throw new Exception("La planète a déjà été explorée"); }
            else
            {
                Visite = true;
                Taille = r.Next(1000,5000);
                DistanceTerre = r.Next(5000, 10000);
                Viable = true;

                Console.WriteLine($"Rapport : Taille = {Taille}, Distance depuis la terre = {DistanceTerre} et Viabilité = {Viable}");
            }
        }
    }
}
