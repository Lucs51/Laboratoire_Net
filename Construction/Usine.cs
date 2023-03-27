using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Usine
    {


        public Robot CreerRobot(string type)
        {
            List<Piece> pieces = new List<Piece>();
       
            if (type == "Construction")
            {
                pieces.Add(new Contruction());
                pieces.Add(new Contruction());
                pieces.Add(new Contruction());
            }
            else if (type == "Destruction")
            {
                pieces.Add(new Destruction());
                pieces.Add(new Destruction());
                pieces.Add(new Destruction());
            }
            else if (type == "Transport")
            {
                pieces.Add(new Transport());
                pieces.Add(new Transport());
                pieces.Add(new Transport());
            }
            else if (type == "Vitesse")
            {
                pieces.Add(new Vitesse());
                pieces.Add(new Vitesse());
                pieces.Add(new Vitesse());
            }

            Robot robot = new Robot(pieces);
            return robot;
        }
    }
}
