using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_ATLENTHICCC
{
    internal class Traversee
    {
        private int numeroTraversee;
        private int numeroLiaison;
        private int numeroBateau;
        private string dateheuredepart;
        private string dateheurearrivee;

        public Traversee(int numeroTraversee, int numeroLiaison, int numeroBateau, string dateheuredepart, string dateheuredarrivee)
        {
            this.numeroTraversee = numeroTraversee;
            this.numeroLiaison = numeroLiaison;
            this.numeroBateau = numeroBateau;
            this.dateheuredepart = dateheuredepart;
            this.dateheurearrivee = dateheuredarrivee;
        }

        public int getNumeroTraversee() {  return numeroTraversee; }
        public int getNumeroLiaison() {  return numeroLiaison; }
        public int getNumeroBateau() {  return numeroBateau; }
        public string getDateheuredepart() {  return dateheuredepart; }
        public string getDateheurearrivee() { return dateheurearrivee; }

        public string getLesTraverseesBateaux(int noLiaison, string dateTraversee)
        {
            return
        }
    }


}
