using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_agence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vaisseau vaisseau = new Vaisseau(5000);
            try
            {
                vaisseau.EnOrbite = true;
                vaisseau.Decollage("Mission 1","Mars","2023-04-12", "2023-04-15");
            }
            catch (Exception ex)
            {
               Console.WriteLine("Erreur lors du lancement! " + ex.Message);
            }

            vaisseau.CompleterMission();

        }
    }
}
