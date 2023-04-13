using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_agence
{
    partial class Mission
    {
        public void CompleterMission()
        {
            Statut = "terminée";
            Console.WriteLine("La mission a été complétée!");
        }
    }
}
