using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    partial class Catalogue
    {
        public List<Film> Films { get; set; }

        public Catalogue()
        {
            Films = new List<Film>();
        }

        public void AjouterFilm(Film film)
        {
            Films.Add(film);
        }

        public void SupprimerFilm(Film film)
        {
            Films.Remove(film);
        }

        public void AfficherFilms()
        {
            foreach (var item in Films)
            {
                Console.WriteLine(item);
            }
        }
    }
}
