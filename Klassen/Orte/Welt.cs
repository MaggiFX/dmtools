using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    public class Welt
    {
        public string Name { get; set; }

        public List<Kontinent> Kontinente = new List<Kontinent>();

        public Welt(string name)
        {
            Name = name;
        }
    }
}
