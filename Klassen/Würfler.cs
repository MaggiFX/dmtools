using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmtools
{
    static class Würfler
    {
        public static Random rand = new Random();
        public static int Würfelmenge { get; set; }
        public static int Würfelart { get; set; }
        public static int Würfelmod { get; set; }

        public static string Roll(int dicecount, int dicekind)
        {
            string resultstring = "";
            int resultint = 0;

            for (int i=0; i<dicecount; i++)
            {
                int roll = rand.Next(1, dicekind+1);
                resultint += roll;

                if (i==0)
                {
                    resultstring = roll.ToString();
                }
                else
                {
                    resultstring += " + " + roll;
                }
            }

            resultstring = resultint + " = " + resultstring;
            return resultstring;
        }

        public static string Roll(int dicecount, int dicekind, int mod)
        {
            string resultstring = "";
            int resultint = 0;

            for (int i = 0; i < dicecount; i++)
            {
                int roll = rand.Next(1, dicekind + 1);
                resultint += roll;

                if (i == 0)
                {
                    resultstring = roll.ToString();
                }
                else
                {
                    resultstring += " + " + roll;
                }
            }

            int modint = mod * dicecount;
            string modstring = " + (" + modint + " <= " + mod + " * " + dicecount + ")";

            resultint += modint;

            resultstring = resultint + " = " + resultstring + modstring;
            return resultstring;
        }
    }
}
