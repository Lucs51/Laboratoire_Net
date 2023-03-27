using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Robot
    {
        public Piece Piece1 { get; set; }
        public Piece Piece2 { get; set; }
        public Piece Piece3 { get; set; }

        public Robot(List<Piece> pieces)
        {
            Piece1 = pieces[0];
            Piece2 = pieces[1];
            Piece3 = pieces[2];
        }

        public override string ToString()
        {
            string message = $"Piece 1: {Piece1}, Piece 2: {Piece2}, Piece 3: {Piece3} ";
            return message;
        }

        public void ScannerVille(Ville ville)
        {
            
            foreach (Batiment item in ville.batiments)
            {
                Console.WriteLine(item.Statut);
            }
        }
    }
}
