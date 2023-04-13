using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue cata = new Catalogue();
            Film film = new Film("Star Wars", "George Lucas", 2001, "Guerre dans les étoiles");
            film.Acteurs.Add("Brad Pitt");
            film.Acteurs.Add("Scarlet Johannson");
            cata.AjouterFilm(film);

            film = new Film("Jurassic Park", "Spielberg", 2006, "Des dinosaures");
            film.Acteurs.Add("Coluche");
            film.Acteurs.Add("Bourville");
            cata.AjouterFilm(film);
            cata.AfficherFilms();
            //recherche = Console.ReadLine();
            cata.RechercherParTitre(Console.ReadLine());
            cata.RechercherParActeur(Console.ReadLine());
        }
    }
}
