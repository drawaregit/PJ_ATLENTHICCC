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
    public partial class FAfficherTraverseeEtLiaison : Form
    {
        private MySqlConnection maCnx;
        private MySqlDataReader jeuEnr = null;
        public FAfficherTraverseeEtLiaison()
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



                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Console.WriteLine();
                    LBX_secteur.Items.Add(new Secteurs(int.Parse(jeuEnr["NOSECTEUR"].ToString()), jeuEnr["NOM"].ToString()));

                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }

           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lst_traversee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblcacaaaaaa_Click(object sender, EventArgs e)
        {

        }

        private void LBX_secteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_liaison.Items.Clear();
            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from liaison where NOSECTEUR=(@nosecteur)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@nosecteur", LBX_secteur.SelectedIndex);
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

        private void FAfficherTraverseeEtLiaison_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            lst_traversee.Clear();
            lst_traversee.View = View.Details; // Mode d'affichage
            // (on peut également afficher sous forme de petites icônes etc...)
            lst_traversee.GridLines = true; // on affichera la grille
            lst_traversee.FullRowSelect = true; // Mode de sélection : ligne
            // Pour le mode de selection voir aussi la property SelectionMode

            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT t.NOTRAVERSEE, DATE_FORMAT(t.DATEHEUREDEPART, '%H:%i') as Time, b.NOM FROM traversee AS t INNER JOIN bateau AS b ON t.Nobateau = b.Nobateau WHERE t.DATEHEUREDEPART LIKE @datedepart AND t.NOLIAISON = @noliaison;";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@datedepart", dtp_date.Text.ToString()+"%");
                maCde.Parameters.AddWithValue("@noliaison", ((liaison)CB_liaison.SelectedItem).GetNumero());
                jeuEnr = maCde.ExecuteReader();
                MessageBox.Show(dtp_date.Text.ToString() +" "+ ((liaison)CB_liaison.SelectedItem).GetNumero());
                while (jeuEnr.Read())
                {
                    Console.WriteLine();
                    lst_traversee.Columns.Add(jeuEnr["NOTRAVERSEE"].ToString(), 100);
                    lst_traversee.Columns.Add(jeuEnr["Time"].ToString(), 100);
                    lst_traversee.Columns.Add(jeuEnr["NOM"].ToString(), 100);
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
                requête = "Select * from contenir WHERE NOBATEAU = @nobateau";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                maCde.Parameters.AddWithValue("@nobateau", ((Bateau)CB_nmbateau.SelectedItem).GetNumero());

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lst_traversee.Columns.Add(jeuEnr["CAPACITEMAX"].ToString(), 100);
                }
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }

            // Ajout de 2 lignes dans le Listview
            var tabItem = new string[4];
            ListViewItem unItem;



            // Ajout d'un premier item

            tabItem[0] = "Produit1";
            tabItem[1] = "100";
            tabItem[2] = "10";
            unItem = new ListViewItem(tabItem); // Création ligne
            lst_traversee.Items.Add(unItem); // Ajout ligne



            // Ajout d'un second item
            tabItem[0] = "Produit2";
            tabItem[1] = "200";
            tabItem[2] = "20";
            lst_traversee.Items.Add(new ListViewItem(tabItem));
        }

        private void txt_date_Click(object sender, EventArgs e)
        {

        }
    }
}
