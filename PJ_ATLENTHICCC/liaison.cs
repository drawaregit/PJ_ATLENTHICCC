using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_ATLENTHICCC
{
    
    internal class liaison
    {
        private int numero;
        private int noportdepart;
        private int nosecteur;
        private int noportarrivee;
        private double distance;
        private MySqlConnection maCnx;
        private string nomportdepart;
        private string nomportarrivee;

        public liaison(int numero, int noportdepart, int nosecteur, int noportarrivee, double distance)
        {
            this.numero = numero;
            this.noportdepart = noportdepart;
            this.nosecteur = nosecteur;
            this.noportarrivee = noportarrivee;
            this.distance = distance;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2023;port=3306;password=");

            try
            {
                string requête;
                maCnx.Open();
                requête = "Select NOM from port WHERE NOPORT = @noport";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                maCde.Parameters.AddWithValue("@noport", noportdepart);

                jeuEnr = maCde.ExecuteReader();
                jeuEnr.Read();
                nomportdepart = jeuEnr["NOM"].ToString();
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }


            try
            {
                string requête;
                maCnx.Open();
                requête = "Select NOM from port WHERE NOPORT = @noport";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                maCde.Parameters.AddWithValue("@noport", noportarrivee);

                jeuEnr = maCde.ExecuteReader();
                jeuEnr.Read();
                nomportarrivee = jeuEnr["NOM"].ToString();
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }

       


        public int GetNumero()
        {
            return numero;
        }

        public int GetNoPortDepart()
        { return noportdepart; }

        public int GetNoSecteur()
        { return nosecteur; }

        public int GetNoPortArrivee()
        { return noportarrivee; }

        public double GetDistance()
        { return distance; }

        public string GetNomPortDepart()
        { return nomportdepart; }

        public string GetNomPortArrivee()
        { return nomportarrivee; }

        public override string ToString()
        {
            string texte = (numero +"-"+ nomportdepart + "-" + nomportarrivee);
            return texte;
        }
    }
}
