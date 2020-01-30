using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredvidanjeRastaIPadaDionica
{
    class Sloj
    {
        private List<Neuron> neuroni;

        public void Ocisti()
        {
            neuroni.Clear();
        }
        public void Inicijaliziraj(int brojNeurona)
        {
            int i;
            for (i = 0; i < brojNeurona; i++)
            {
                neuroni.Add(new Neuron());
            }
        }

        public Neuron DohvatiNeuron(int index)
        {
            return neuroni[index];
        }
        public void PostaviNeuron(int index, ref Neuron neuron)
        {
            neuroni[index] = neuron;
        }
        public void PostaviNeuron(int index, Double value)
        {
            Neuron n = new Neuron();
            n.Value = value;
            neuroni[index] = n;
        }


        public void DodajDendriteNeuronima(int brojDendrita)
        {
            int i;
            for (i = 0; i < neuroni.Count; i++)
            {
                neuroni[i].DodajDendrit(brojDendrita);
            }
        }

        public int BrojNeurona()
        {
            return neuroni.Count;
        }

        public Sloj()
        {
            neuroni = new List<Neuron>();
        }
    }
}
