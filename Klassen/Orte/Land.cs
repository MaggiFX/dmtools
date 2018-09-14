using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    public class Land
    {
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public Kontinent Anker { get; set; }

        public Land(string name)
        {
            Name = name;
        }
    }
}
