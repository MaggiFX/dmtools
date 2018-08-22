using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    public class Stadt
    {
        public string Name { get; set; }

        public List<Poi> pois;

        public Stadt(string name)
        {
            Name = name;
        }
    }
}
