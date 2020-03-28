using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leger.LIB.Entities
{
    public class Adjudant:OnderOfficier
    {
        public Adjudant()
        {
            Sterren = 2;
            Gewicht = 4;
            AantalRechtstreeksOndergeschikten = 3;
            for (int r = 1; r <= AantalRechtstreeksOndergeschikten; r++)
            {
                RechtstreeksOndergeschikte.Add(new Sergeant());
            }
        }
    }
}
