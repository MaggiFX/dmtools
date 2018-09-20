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
    }
}
