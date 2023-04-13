using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    partial class Film
    {
        public string Titre { get; set; }
        public string Directeur { get; set; }
        public int Annee { get; set; }
        public List<string> Acteurs { get; set; }

        public Film(string titre, string directeur, int annee, string synopsis)
        {
            Titre = titre;
            Directeur = directeur;
            Annee = annee;
            Synopsis = synopsis;
            Acteurs = new List<string>();
        }

        public override string ToString()
        {
            string temp = "";
            foreach (var item in Acteurs)
            {
                temp += item + ", ";
            }
            return $"Titre: {Titre}, Directeur: {Directeur}, Année: {Annee} Acteurs: " + temp;
        }
    }

}
