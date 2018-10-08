using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    class Geld
    {
        public static Geld operator +(Geld a, Geld b)
        {
            Geld c = new Geld();
            c.Kupfer = a.Kupfer + b.Kupfer;
            c.Silber = a.Silber + b.Silber;
            c.Gold   = a.Gold   + b.Gold;
            return c;
        }

        public int Kupfer { get; set; } // 1 Münze = 10 gramm / 0,01 kg => 100 Münzen = 1kg
        public int Silber { get; set; } // 1 Silber = 10 Kupfer
        public int Gold   { get; set; } // 1 Gold = 10 Silber = 100 Kupfer
        //public int Elektrum { get; set; } // 1 Elektrum = 5 Silber = 50 Kupfer
        //public int Platin { get; set; }   // 1 Platin = 10 Gold = 100 Silber = 1000 Kupfer

        public void AddGeld(Geld geldin)
        {
            Kupfer += geldin.Kupfer;
            Silber += geldin.Silber;
            Gold   += geldin.Gold;
        }
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

        public void RemoveGeld(Geld geldin)
        {

        }

        public void SetGeld(Geld geldin)
        {
            Kupfer = geldin.Kupfer;
            Silber = geldin.Silber;
            Gold   = geldin.Gold;
        }
        public void SetGeld(int goldin, int silberin, int kupferin)
        {
            Kupfer = kupferin;
            Silber = silberin;
            Gold   = goldin;
        }

    }
}
