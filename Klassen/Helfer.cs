using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    static class Helfer
    {
        public static string StringEinzeiler(string input)
        {
            if (input.Contains(Environment.NewLine))
            {
                return input.Substring(0, input.IndexOf(Environment.NewLine)) + " ...";
            }
            else
            {
                return input;
            }
        }
    }
}
