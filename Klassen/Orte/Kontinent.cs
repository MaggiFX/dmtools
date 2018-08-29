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

        public List<Land> Länder = new List<Land>();

        public Kontinent(string name)
        {
            Name = name;
        }
    }
}
