using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leger.LIB.Entities
{
    public class Korporaal:Troep
    {
        public Korporaal()
        {
            Sterren = 2;
            Gewicht = 2;
            AantalRechtstreeksOndergeschikten = 5;
            for (int r = 1; r <= AantalRechtstreeksOndergeschikten; r++)
            {
                RechtstreeksOndergeschikte.Add(new Soldaat());
            }
        }
    }
}
