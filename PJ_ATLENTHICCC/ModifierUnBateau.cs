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
    public partial class FModifierUnBateau : Form
    {
        private MySqlConnection maCnx;
        private MySqlDataReader jeuEnr = null;
        private int compteurbateau =0;
        public FModifierUnBateau()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2023;port=3306;password=");
            jeuEnr = null;

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
                    CB_nmbateau.Items.Add(new Bateau(int.Parse(jeuEnr["NOBATEAU"].ToString()), jeuEnr["NOM"].ToString()));

                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }


            
            
        }

        private void FModifierUnBateau_Load(object sender, EventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {

           

            

            foreach (TextBox txt1 in GB_Capacites.Controls.OfType<TextBox>())
            {

                try

                {
                    MessageBox.Show(txt1.Tag.ToString()[0].ToString());
                    string requête;
                    maCnx.Open(); // on se connecte
                                  // NOTA BENE : title est un nom de champ, titles le nom de la table !
                                  // DEBUT requête paramétrée
                                 
                    requête = "UPDATE contenir SET CAPACITEMAX = @capacitemax WHERE nobateau = @nobateau AND LETTRECATEGORIE = @lettrecategorie";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@lettrecategorie", txt1.Tag.ToString()[0]);
                    maCde.Parameters.AddWithValue("@nobateau", ((Bateau)CB_nmbateau.SelectedItem).GetNumero());
                    maCde.Parameters.AddWithValue("@capacitemax", double.Parse(txt1.Text));

                    // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                    // FIN requête paramétrée
                    maCde.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur " + ex.ToString());
                }
                finally { maCnx.Close(); }
            }
            MessageBox.Show("Bateau modifié.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CB_nmbateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            jeuEnr = null;
            GB_Capacites.Controls.Clear();

            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from categorie";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                Label txt;
 
                int baissey = 25;
                int pos = GB_Capacites.Location.Y + baissey;


                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {

                    txt = new Label();
                    txt.Text = (jeuEnr["LETTRECATEGORIE"].ToString() + " " + jeuEnr["LIBELLE"] + " " + (jeuEnr["LIBELLE"].ToString() + ":"));
                    txt.Location = new Point(GB_Capacites.Location.X - 275, pos);

                    pos += baissey;
                    GB_Capacites.Controls.Add(txt);
                    
                }
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Erreur " + ex.ToString());
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
                System.Windows.Forms.TextBox txtbox;
                int baissey = 25;
                int pos = GB_Capacites.Location.Y + baissey;


                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    txtbox = new System.Windows.Forms.TextBox();
                    txtbox.Tag = jeuEnr["LETTRECATEGORIE"].ToString();
                    txtbox.Location = new Point(GB_Capacites.Location.X-25 , pos);
                    txtbox.Text = jeuEnr["CAPACITEMAX"].ToString();


                    pos += baissey;
                    GB_Capacites.Controls.Add(txtbox);
                }
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }

        private void GB_Capacites_Enter(object sender, EventArgs e)
        {

        }
    }
}
