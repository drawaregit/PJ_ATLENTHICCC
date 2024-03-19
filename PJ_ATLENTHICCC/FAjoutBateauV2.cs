using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_ATLENTHICCC
{
    public partial class FAjoutBateauV2 : Form
    {
        private MySqlConnection maCnx;
        public FAjoutBateauV2()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2023;port=3306;password=");
            MySqlDataReader jeuEnr = null;


            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from secteur";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                Label txt;
                System.Windows.Forms.TextBox txtbox;
                int baissey = 25;
                int pos = txt_categorietype.Location.Y + baissey;


                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                   /* Console.WriteLine();
                    txt.Text(new Bateau(int.Parse(jeuEnr["NOSECTEUR"].ToString()), jeuEnr["NOM"].ToString()));
                   */
                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }

        private void FAjoutBateauV2_Load(object sender, EventArgs e)
        {

        }
    }
}
