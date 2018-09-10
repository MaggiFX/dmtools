using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    class Gegenstand
    {
        public string Name { get; set; }

        public Gegenstand()
        {
            Name = "Basic";
        }

        public Gegenstand(string name)
        {
            Name = name;
        }

    }
}
