using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leger.LIB.Entities
{
    public class Generaal:Officier
    {
        public Generaal()
        {
            Sterren = 3;
            Gewicht = 7;
            AantalRechtstreeksOndergeschikten = 3;

            for(int r = 1; r <= AantalRechtstreeksOndergeschikten; r++)
            {
                RechtstreeksOndergeschikte.Add(new Majoor());
            }
        }
    }
}
