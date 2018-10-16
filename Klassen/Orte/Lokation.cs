using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    class Lokation
    {
        public string Name { get; set; }
        public string Beschreibung { get; set; }

        //public Land Anker { get; set;}

        public List<Poi> PoiListe = new List<Poi>();


        public Lokation()
        {
            Name = "None";
            Beschreibung = "None";
        }

        public Lokation(string Name, string Beschreibung)
        {
            this.Name = Name;
            this.Beschreibung = Beschreibung;
        }
    }
}
