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
    public partial class FAjoutSecteurcs : Form
    {
        private MySqlConnection maCnx;
        public FAjoutSecteurcs()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2023;port=3306;password=");
        }

        private void FAjoutSecteurcs_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_entree_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ajout_Click(object sender, EventArgs e)
        {
            try

            {
                string requête;
                maCnx.Open(); // on se connecte
                // NOTA BENE : title est un nom de champ, titles le nom de la table !
                // DEBUT requête paramétrée
                requête = "INSERT INTO secteur (NOM) VALUES (@nom)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@nom", txtbox_entree.Text);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                maCde.ExecuteNonQuery();
                MessageBox.Show("Secteur ajouté.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }
    }
}
