using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    class Geld
    {
        public int Kupfer { get; set; } // 100 Münzen = 1 Kilo
        public int Silber { get; set; } // 1 Silber = 10 Kupfer
        public int Gold   { get; set; } // 1 Gold = 10 Silber = 100 Kupfer

        //public int Elektrum { get; set; } // 1 Elektrum = 5 Silber = 50 Kupfer
        //public int Platin { get; set; }   // 1 Platin = 10 Gold = 100 Silber = 1000 Kupfer

        public void AddGeld(int kupferin)
        {
            Kupfer += kupferin;
        }
        public void AddGeld(int silberin, int kupferin)
        {
            Kupfer += kupferin;
            Silber += silberin;
        }
        public void AddGeld(int goldin, int silberin, int kupferin)
        {
            Kupfer += kupferin;
            Silber += silberin;
            Gold   += goldin;
        }

    }
}
