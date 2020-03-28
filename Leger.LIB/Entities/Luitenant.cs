using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leger.LIB.Entities
{
    public class Luitenant:Officier
    {
        public Luitenant()
        {
            Sterren = 1;
            Gewicht = 5;
            AantalRechtstreeksOndergeschikten = 3;
            for (int r = 1; r <= AantalRechtstreeksOndergeschikten; r++)
            {
                RechtstreeksOndergeschikte.Add(new Adjudant());
            }
        }
    }
}
