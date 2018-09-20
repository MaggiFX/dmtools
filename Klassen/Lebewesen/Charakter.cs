using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    class Charakter
    {
        public int Id { get; set; }
        public Geld Geldbeutel { get; set; }
        public List<Gegenstand> gegenstände = new List<Gegenstand>();
        public string Name { get; set; }

        public void AddGegenstand(Gegenstand neu)
        {
            gegenstände.Add(neu);
        }
    }
}
