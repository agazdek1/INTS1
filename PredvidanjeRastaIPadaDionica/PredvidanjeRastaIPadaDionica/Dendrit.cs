using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredvidanjeRastaIPadaDionica
{
    class Dendrit
    {
        private double wt;
        public double Tezina
        {
            get { return wt; }
            set { wt = value; }
        }

        public Dendrit()
        {
            wt = dohvatiRandomDouble(0.00000001, 1.0);
        }

        private double dohvatiRandomDouble(double minVrijednost, double maxVrijednost)
        {
            return PomocneFunkcije.DohvatiRandomDouble() * (maxVrijednost - minVrijednost) + minVrijednost;
        }

    }
}
