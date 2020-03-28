using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leger.LIB.Entities
{
    public class Militair
    {
        private static int volgnummer = 0;
        public static Dictionary<string, int> aantalPersoort = new Dictionary<string, int>();
        public string Naam { get; set; }
        public int Gewicht { get; set; }
        public string Kleur { get; set; }
        public int Sterren { get; set; }
        public int AantalRechtstreeksOndergeschikten { get; set; }
        public List<Militair> RechtstreeksOndergeschikte { get; set; }
        public Militair()
        {
            string soort = this.GetType().Name;
            volgnummer++;
            Naam = soort + " " + volgnummer.ToString();
            RechtstreeksOndergeschikte = new List<Militair>();

            if(aantalPersoort.ContainsKey(soort))
            {
                aantalPersoort.TryGetValue(soort, out int aantal);
                aantal++;
                aantalPersoort[soort] = aantal;
            }
            else
            {
                aantalPersoort.Add(soort, 1);
            }
        }
        public override string ToString()
        {
            return Naam;
        }
        public int TotaalAantalOndergeschikten()
        {
            int aantal = 0;
            foreach (Militair militair in RechtstreeksOndergeschikte)
            {
                aantal++;
                aantal += militair.TotaalAantalOndergeschikten();
            }
            return aantal;
        }


    }
}
