using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leger.LIB.Entities
{
    public class Sergeant:OnderOfficier
    {
        public Sergeant()
        {
            Sterren = 1;
            Gewicht = 3;
            AantalRechtstreeksOndergeschikten = 4;
            for (int r = 1; r <= AantalRechtstreeksOndergeschikten; r++)
            {
                RechtstreeksOndergeschikte.Add(new Korporaal());
            }
        }
    }
}
