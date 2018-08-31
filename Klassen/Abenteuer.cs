using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    [Serializable()]
    public class Abenteuer
    {
        public Abenteuer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public List<Welt> Welten = new List<Welt>();

        
    }
}
