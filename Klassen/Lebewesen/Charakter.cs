using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    class Charakter
    {
        public Geld geld { get; set; }
        public List<Gegenstand> gegenstände = new List<Gegenstand>();

        public void AddGegenstand(Gegenstand neu)
        {
            gegenstände.Add(neu);
        }
    }
}
