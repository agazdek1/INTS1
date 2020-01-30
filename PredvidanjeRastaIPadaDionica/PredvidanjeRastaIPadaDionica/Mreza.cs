using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredvidanjeRastaIPadaDionica
{
    class Mreza
    {
        public enum AktivacijskiAlgoritam
        {
            Identity         
        };

        private AktivacijskiAlgoritam algoritam = AktivacijskiAlgoritam.Identity;
        public AktivacijskiAlgoritam AktivacijskiAlgoritam1
        {
            get { return algoritam; }
            set { algoritam = value; }
        }

        private double stopaUcenja;
        private List<Sloj> slojevi;

        public int BrojSlojeva()
        {
            return slojevi.Count;
        }

        public double StopaUcenja
        {
            get
            { return stopaUcenja; }
            set
            { stopaUcenja = value; }
        }

        public Sloj DohvatiSloj(int index)
        {
            return slojevi[index];
        }
        public void PostaviSloj(int index, Sloj sloj)
        {
            slojevi[index] = sloj;
        }
        public Mreza(List<int> neuroniUSloju, double stopaUcenja)
        {
            this.stopaUcenja = stopaUcenja;
            slojevi = new List<Sloj>();
            int brojSlojeva = neuroniUSloju.Count;
            if (brojSlojeva > 1)
            {
                int i, brojS;
                Neuron neuron;
                Sloj sloj;
                for (brojS = 0; brojS < brojSlojeva; brojS++)
                {

                    sloj = new Sloj();


                    sloj.Inicijaliziraj(neuroniUSloju[brojS]);


                    if (brojSlojeva == 0)
                    {

                        for (i = 0; i < neuroniUSloju[0]; i++)
                        {
                            neuron = sloj.DohvatiNeuron(i);
                            neuron.Bias = 0.0;
                            sloj.PostaviNeuron(i, ref neuron);
                        }
                    }
                    else
                    {

                        if (brojS > 0)
                        {
                            sloj.DodajDendriteNeuronima(neuroniUSloju[brojS - 1]);
                        }

                        slojevi.Add(sloj);
                    }

                }
            }

        }
        public List<Double> Pokreni(List<Double> ulazi)
        {
            int brojIzlaznihNeurona = slojevi[slojevi.Count - 1].BrojNeurona();
            int brojSlojeva = slojevi.Count;
            double vrijednost;
            int i, j, k, brojNeuronaUSloju, brojDendrita;
            List<double> izlazi = new List<double>(brojIzlaznihNeurona);
            Neuron neuron;
            Dendrit dendrit;

        
            brojNeuronaUSloju = slojevi[0].BrojNeurona();
            for (i = 0; i < brojNeuronaUSloju; i++)
            {
                
                slojevi[0].PostaviNeuron(i, ulazi[i]);
            }


    
            for (k = 1; k < brojSlojeva; k++)
            {
                brojNeuronaUSloju = slojevi[k].BrojNeurona();
                brojDendrita = slojevi[k].DohvatiNeuron(0).BrojDendrita();
                for (i = 0; i < brojNeuronaUSloju; i++)
                {
                    neuron = new Neuron();
                    neuron = slojevi[k].DohvatiNeuron(i);
                    vrijednost = 0.0; 

                    for (j = 0; j < brojDendrita; j++)
                    {
                        dendrit = neuron.DohvatiDendrit(j);
                        vrijednost = vrijednost + dendrit.Tezina * slojevi[k - 1].DohvatiNeuron(j).Value;
                    }



                    neuron.Value = AktivacijskaFunkcija(vrijednost + neuron.Bias);
                    slojevi[k].PostaviNeuron(i, ref neuron); 
                }
            }
           
            for (i = 0; i < brojIzlaznihNeurona; i++)
            {
                izlazi.Add(slojevi[k - 1].DohvatiNeuron(i).Value);
            }
            return izlazi;
        }




        public int Treniraj(List<double> ulazi, List<double> izlazi)
        {

            int i, j, k, brojIzlaznihNeurona;
            double x; 
            Neuron trenutniNeuron;

            if (ulazi.Count != slojevi[0].BrojNeurona() || izlazi.Count != slojevi[slojevi.Count - 1].BrojNeurona())
            {
                return 1;
            }

            Pokreni(ulazi);

            brojIzlaznihNeurona = slojevi[slojevi.Count - 1].BrojNeurona();
            for (i = 0; i < brojIzlaznihNeurona; i++)
            {
                
                trenutniNeuron = slojevi[slojevi.Count - 1].DohvatiNeuron(i);
                x = trenutniNeuron.Value;
                trenutniNeuron.Delta = AktivacijskaFunkcija(x, true) * (izlazi[i] - x);

                for (j = slojevi.Count - 2; j >= 0; j--) 
                {
                    for (k = 0; k < slojevi[j].BrojNeurona(); k++)
                    {
                        Neuron neuron = slojevi[j].DohvatiNeuron(k);
                        neuron.Delta = neuron.Value *
                                    (1 - neuron.Value) * slojevi[j + 1].DohvatiNeuron(i).DohvatiDendrit(k).Tezina *
                                    slojevi[j + 1].DohvatiNeuron(i).Delta;
                    }
                }
            }


           

            for (i = slojevi.Count - 1; i >= 0; i--)
            {
                for (j = 0; j < slojevi[i].BrojNeurona(); j++)
                {
                    Neuron neuron = slojevi[i].DohvatiNeuron(j);
                    neuron.Bias = neuron.Bias + stopaUcenja * neuron.Delta;

                    for (k = 0; k < neuron.BrojDendrita(); k++)
                    {
                        neuron.DohvatiDendrit(k).Tezina = neuron.DohvatiDendrit(k).Tezina +
                                stopaUcenja * slojevi[i - 1].DohvatiNeuron(k).Value *
                                neuron.Delta;
                    }
                }
            }

            return 0;
        }

        private double AktivacijskaFunkcija(double x, Boolean izveden = false)
        {
      
            double povratnaVrijednost = x;
            if (izveden == true) povratnaVrijednost = 1.0; 
            switch (algoritam)
            {
                case AktivacijskiAlgoritam.Identity:
                    if (izveden == true)
                    {
                        povratnaVrijednost = 1.0; 
                    }
                    else
                    {
                        povratnaVrijednost = x;
                    }
                    break;
          

            }
            return povratnaVrijednost;
        }
    }
}
