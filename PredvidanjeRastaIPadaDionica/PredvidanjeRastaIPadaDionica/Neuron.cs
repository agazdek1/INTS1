using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredvidanjeRastaIPadaDionica
{
    class Neuron
    {
        private List<Dendrit> dendriti;
        private double bias, delta, _value;

        public double Bias
        {
            get
            { return bias; }
            set
            { bias = value; }
        }
        public double Delta
        {
            get
            { return delta; }
            set
            { delta = value; }
        }
        public double Value
        {
            get
            { return _value; }
            set
            { _value = value; }
        }

        public void DodajDendrit(int brojDendrita)
        {
            int i;
            for (i = 0; i < brojDendrita; i++)
            {
          
                dendriti.Add(new Dendrit());
            }
        }

        public int BrojDendrita()
        {
            return dendriti.Count;
        }

        public Dendrit DohvatiDendrit(int index)
        {
            return dendriti[index];
        }

        public Neuron()
        {
            bias = PomocneFunkcije.DohvatiRandomDouble();
            dendriti = new List<Dendrit>();
        }
    }
}
