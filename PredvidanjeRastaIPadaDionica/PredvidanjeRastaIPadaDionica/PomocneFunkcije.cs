using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredvidanjeRastaIPadaDionica
{
    class PomocneFunkcije
    {
        private static Random random = new Random();
        public static int DohvatiRandomInteger()
        {
            return random.Next();
        }
        public static double DohvatiRandomDouble()
        {
            return random.NextDouble();
        }
        public static double GenerirajBrojUIntervalu(double minBroj, double maxBroj)
        {
            return Math.Round((new Random().NextDouble() * (maxBroj - minBroj) + minBroj), 2);
        }

    }
}
