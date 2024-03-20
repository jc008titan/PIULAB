using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    internal class Medicament
    {
        public string nume { get; set; }
        public string data_expirare {  get; set; }
        public double pret { get; set; }
        public int cantitate { get; set; }

        public Medicament(string nume, string data_expirare, double pret, int cantitate)
        {
            this.nume = nume;
            this.data_expirare = data_expirare;
            this.pret = pret;
            this.cantitate = cantitate;
        }   
    }
}
