using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    public class Poi
    {
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        //public Stadt Anker { get; set; }

        public Poi()
        {
            Name = "POI";
        }

        public Poi(string name)
        {
            Name = name;
        }
    }

}
