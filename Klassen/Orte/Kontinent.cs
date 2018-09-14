using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    public class Kontinent
    {
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public Welt Anker { get; set; }


        public Kontinent(string name)
        {
            Name = name;
        }
    }
}
