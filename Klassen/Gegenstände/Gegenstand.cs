using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    class Gegenstand
    {
        public int      Id         { get; set; }
        public string   Name       { get; set; }
        public int      Wert       { get; set; }
        public double    Gewicht    { get; set; }
        public int      Seltenheit { get; set; }

        public Gegenstand()
        {

        }

        public Gegenstand(string name, int wert, double gewicht, int seltenheit)
        {
            Name = name;
            Wert = wert;
            Gewicht = gewicht;
            Seltenheit = seltenheit;
        }

    }
}
