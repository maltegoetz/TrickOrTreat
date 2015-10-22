using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickOrTreatForms
{
    public static class Random
    {
        public static bool IsTreat()
        {
            var r = new System.Random();
            return r.NextDouble() >= 0.5;
        }

        public static string TrickTreatText(bool isTreat)
        {
            return isTreat ? "Treat" : "Trick";
        }
    }
}
