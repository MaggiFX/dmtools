using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    public class Stadt
    {
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        //public Land Anker { get; set;}

        public List<Poi> PoiListe = new List<Poi>();


        public Stadt()
        {
            Name = "Stadt";
        }

        public Stadt(string name)
        {
            Name = name;
        }
    }
}
