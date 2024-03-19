using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class FAjoutLiaison : Form
    {
        private MySqlConnection maCnx;
        public FAjoutLiaison()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
           // MySqlConnection maCnx; // ! déclaration avant le bloc Try

            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2023;port=3306;password=");

            try
            {
                string requête;
                maCnx.Open();
            requête = "Select * from secteur";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée



                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Console.WriteLine();
                    lstbox_secteur.Items.Add(new Secteurs(int.Parse(jeuEnr["NOSECTEUR"].ToString()), jeuEnr["NOM"].ToString()));

                }
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
                requête = "Select * from port";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée



                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Console.WriteLine();
                    cmbox_depart.Items.Add(new Ports(int.Parse(jeuEnr["NOPORT"].ToString()), jeuEnr["NOM"].ToString()));
                    cmbox_arrivee.Items.Add(new Ports(int.Parse(jeuEnr["NOPORT"].ToString()), jeuEnr["NOM"].ToString()));
                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FAjoutLiaison_Load(object sender, EventArgs e)
        {

        }

        private void lstbox_secteur_Load(object sender, EventArgs e)

        {
            
        }

        private void btnCréer_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            try

            {
                string requête;
                maCnx.Open(); // on se connecte
                // NOTA BENE : title est un nom de champ, titles le nom de la table !
                // DEBUT requête paramétrée
                requête = "INSERT INTO liaison (NOPORT_DEPART,NOSECTEUR,NOPORT_ARRIVEE,DISTANCE) VALUES (@noport_depart, @nosecteur, @noport_arrivee, @distance)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noport_depart", ((Ports)(cmbox_depart.SelectedItem)).GetNumero().ToString());
                maCde.Parameters.AddWithValue("@nosecteur", ((Secteurs)(lstbox_secteur.SelectedItem)).GetNumero().ToString());
                maCde.Parameters.AddWithValue("@noport_arrivee", ((Ports)(cmbox_arrivee.SelectedItem)).GetNumero().ToString());
                maCde.Parameters.AddWithValue("@distance", double.Parse(txtbox_distance.Text));
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                maCde.ExecuteNonQuery();
                MessageBox.Show("Liaison ajouté.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }
    }
}
