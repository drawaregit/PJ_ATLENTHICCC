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
    public partial class FAjoutTraversee : Form
    {
        private MySqlConnection maCnx;
        private MySqlDataReader jeuEnr = null;
        public FAjoutTraversee()
        {
            InitializeComponent();
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
                    lstbx_secteurs.Items.Add(new Secteurs(int.Parse(jeuEnr["NOSECTEUR"].ToString()), jeuEnr["NOM"].ToString()));

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
                requête = "Select * from bateau";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée



                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Console.WriteLine();
                    CB_nomBateau.Items.Add(new Bateau(int.Parse(jeuEnr["NOBATEAU"].ToString()), jeuEnr["NOM"].ToString()));

                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_liaison.Items.Clear();
            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from liaison where NOSECTEUR=(@nosecteur)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@nosecteur", ((Secteurs)lstbx_secteurs.SelectedItem).GetNumero().ToString());
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée



                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Console.WriteLine();
                    CB_liaison.Items.Add(new liaison(int.Parse(jeuEnr["NOLIAISON"].ToString()), int.Parse(jeuEnr["NOPORT_DEPART"].ToString()), int.Parse(jeuEnr["NOSECTEUR"].ToString()), int.Parse(jeuEnr["NOPORT_ARRIVEE"].ToString()), double.Parse(jeuEnr["DISTANCE"].ToString())));

                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try

            {
                string requête;
                maCnx.Open(); // on se connecte
                // NOTA BENE : title est un nom de champ, titles le nom de la table !
                // DEBUT requête paramétrée
                requête = "INSERT INTO traversee (NOLIAISON,NOBATEAU,DATEHEUREDEPART,DATEHEUREARRIVEE) VALUES (@noliaison, @nobateau, @dateheuredepart, @dateheurearrivee)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noliaison", ((liaison)(CB_liaison.SelectedItem)).GetNumero().ToString());
                maCde.Parameters.AddWithValue("@nobateau", ((Bateau)(CB_nomBateau.SelectedItem)).GetNumero().ToString());
                maCde.Parameters.AddWithValue("@dateheuredepart", date_depart.Text.ToString());
                maCde.Parameters.AddWithValue("@dateheurearrivee", date_Arrivee.Text.ToString());
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                maCde.ExecuteNonQuery();
                MessageBox.Show("Traversée ajouté.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }

        private void FAjoutTraversee_Load(object sender, EventArgs e)
        {

        }

        private void CB_liaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
