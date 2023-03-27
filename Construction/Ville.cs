using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Ville
    {
        public List<Batiment> batiments { get; set; }



        public void AjouterBatiment(Batiment batiment)
        {
            if(batiments == null)
            {
                batiments = new List<Batiment>();
            }
            batiments.Add(batiment);
        }
    }
}
