using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredvidanjeRastaIPadaDionica
{
    public partial class PocetniZaslon : Form
    {
        
        private List<int> brojNeuronaUSloju;
        private double stopaUcenja = 0.0001;
        private Mreza mreza;

        public PocetniZaslon()
        {
            InitializeComponent();
            btnPredvidaj.Enabled = false;
        }
        

        private string Izvrsi()
        {
            
            int i;
            string ulazniPodaci, a = "";
            string[] polje;
            List<double> ulazi, izlazi;

            ulazi = new List<double>(mreza.DohvatiSloj(0).BrojNeurona());
            izlazi = new List<double>(mreza.DohvatiSloj(mreza.BrojSlojeva() - 1).BrojNeurona());

            ulazniPodaci = txtPodaciZaUcenje.Text;

            polje = ulazniPodaci.Split(',');

            for (int c = 0; c < 3; c++)
            {

                for (i = 0; i < mreza.DohvatiSloj(0).BrojNeurona(); i++)
                {
                    ulazi.Clear();
                    Thread.Sleep(100);
                    double broj = PomocneFunkcije.GenerirajBrojUIntervalu(1, 3);
                    ulazi.Add(broj);
                }
                izlazi.Clear();
                izlazi = mreza.Pokreni(ulazi);

                for (i = 0; i < izlazi.Count; i++)
                {
                    a = a + izlazi[i].ToString() + Environment.NewLine;

                }
            }

            return a;
        }

        public void KreirajNeuralnuMrezu()
        {
            int i;

            int brojUlaznihNeurona = 1;
            int brojSkrivenihSlojeva = 2;
            int BrojNeuronaUSvakomSloju = 8;
            int brojIzlaznihNeurona = 1;

            brojNeuronaUSloju = new List<int>(brojSkrivenihSlojeva + 2);

            brojNeuronaUSloju.Add(brojUlaznihNeurona);
            for (i = 0; i < brojSkrivenihSlojeva; i++)
            {
                brojNeuronaUSloju.Add(BrojNeuronaUSvakomSloju);
            }
            brojNeuronaUSloju.Add(brojIzlaznihNeurona);

            mreza = new Mreza(brojNeuronaUSloju, stopaUcenja);

            lblPostotakZavrsenostiUcenja.Text = "Mreža je uspješno kreirana";

        }

        private void BtnZapocniTrening_Click(object sender, EventArgs e)
        {
            txtIzlaznaPredvidanja.Text = "";
            if (mreza is null)
            {
                KreirajNeuralnuMrezu();
            }

            int brojIteracija = (int)nudBrojIteracijaTreniranja.Value;
            string ip, op;
            int brojUlaza, brojIzlaza, brojPodataka;
            double[,] ulazi, izlazi;
            string[] iarr, oarr, iarr1, oarr1;
            int i, j;

            lblPostotakZavrsenostiUcenja.Text = "";
            ip = "0;0.025;0.05;0.075;0.1;0.125;0.15;0.175;0.2;0.225;0.25;0.275;0.3";
            op = txtPodaciZaUcenje.Text;

            brojUlaza = mreza.DohvatiSloj(0).BrojNeurona();
            brojIzlaza = mreza.DohvatiSloj(mreza.BrojSlojeva() - 1).BrojNeurona();


            iarr = ip.Split(';');
            brojPodataka = iarr.Length;
            oarr = op.Split(';');

            ulazi = new double[brojPodataka, brojUlaza];
            izlazi = new double[brojPodataka, brojIzlaza];


            for (i = 0; i < brojPodataka; i++)
            {
                iarr1 = iarr[i].Split(',');
                oarr1 = oarr[i].Split(',');
                for (j = 0; j < iarr1.Length; j++)
                {
                    ulazi[i, j] = Convert.ToDouble(iarr1[j]);
                }
                for (j = 0; j < oarr1.Length; j++)
                {
                    izlazi[i, j] = Convert.ToDouble(oarr1[j]);
                }
            }

            mreza.AktivacijskiAlgoritam1 = Mreza.AktivacijskiAlgoritam.Identity;

            List<double> ins, ops;
            int ii;
            for (i = 0; i < brojIteracija; i++)
            {

                for (j = 0; j < brojPodataka; j++)
                {
                    ins = new List<double>(mreza.DohvatiSloj(0).BrojNeurona());
                    ops = new List<double>(mreza.DohvatiSloj(mreza.BrojSlojeva() - 1).BrojNeurona());
                    for (ii = 0; ii < mreza.DohvatiSloj(0).BrojNeurona(); ii++)
                    {
                        ins.Add(ulazi[j, ii]);
                    }
                    for (ii = 0; ii < mreza.DohvatiSloj(mreza.BrojSlojeva() - 1).BrojNeurona(); ii++)
                    {
                        ops.Add(izlazi[j, ii]);
                    }

                    mreza.Treniraj(ins, ops);
                }
                if (i == 0 || (i + 1) % 1000 == 0 || i == brojIteracija - 1)
                {
                    lblPostotakZavrsenostiUcenja.Text = "Postotak učenja: " + 
                        (i + 1).ToString() + 
                        " od " + brojIteracija.ToString()
                        + " (" + Math.Round(((double)(i + 1) /
                        brojIteracija * 100.0), 2).ToString() + "%)";

                    Application.DoEvents();
                }

            }
            lblPostotakZavrsenostiUcenja.Text = "Učenje završeno";
            btnPredvidaj.Enabled = true;

        }

        private void BtnPredvidaj_Click(object sender, EventArgs e)
        {
            KreirajNeuralnuMrezu();
            txtIzlaznaPredvidanja.Text = Izvrsi();
            btnPredvidaj.Enabled = false;
        }
    }
}
