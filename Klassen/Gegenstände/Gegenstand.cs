using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{

    class Gegenstand
    {
        public enum Rarity { Müll = 0, Häufig, Selten, Episch, Legendär, Artefakt }

        public int    Id           { get; set; }
        
        public string Name         { get; set; }
        public int    Wert         { get; set; }
        public double Gewicht      { get; set; }
        public string Seltenheit   { get; set; }
        public string Beschreibung { get; set; }

        public Gegenstand()
        {
            Name = "No Name";
            Wert = 0;
            Gewicht = 0;
            Seltenheit = Rarity.Müll.ToString();
            Beschreibung = "No Description";

        }

        public Gegenstand(string name, int wert, double gewicht, Rarity seltenheit, string beschreibung)
        {
            Name = name;
            Wert = wert;
            Gewicht = gewicht;
            Seltenheit = seltenheit.ToString();
            Beschreibung = beschreibung;
        }

    }
}
