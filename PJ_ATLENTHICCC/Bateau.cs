using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_ATLENTHICCC
{
    internal class Bateau
    {
        private int numero;
        private string nom;
        public Bateau(int numero, string nom)
        {
            this.numero = numero;
            this.nom = nom;
        }
        public string GetNom()
        {
            return nom;
        }

        public int GetNumero()
        {
            return numero;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
