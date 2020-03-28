using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leger.LIB.Entities
{
    public class Majoor:Officier
    {
        public Majoor()
        {
            Sterren = 2;
            Gewicht = 6;
            AantalRechtstreeksOndergeschikten = 5;
            for (int r = 1; r <= AantalRechtstreeksOndergeschikten; r++)
            {
                RechtstreeksOndergeschikte.Add(new Luitenant());
            }
        }
    }
}
