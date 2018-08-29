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

        public List<Stadt> Städte = new List<Stadt>();

        public Land(string name)
        {
            Name = name;
        }
    }
}
