using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    public class Abenteuer
    {
        public string Name { get; set; }

        public List<Welt> welten;

        public Abenteuer(string name)
        {
            Name = name;
        }
    }
}
