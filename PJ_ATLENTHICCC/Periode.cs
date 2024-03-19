using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_ATLENTHICCC
{
    internal class Periode
    {
        private int numero;
        private string datedebut;
        private string datefin;
        public Periode(int numero, string datedebut, string datefin)
        {
            this.numero = numero;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }
        public string GetDateDebut()
        {
            return datedebut;
        }
        public string GetDateFin()
        {
            return datefin;
        }
        public int GetNumero()
        {
            return numero;
        }

        public override string ToString()
        {
            string texte = (datedebut + " au " + datefin);
            return texte;
        }
    }
}
