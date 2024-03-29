using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PJ_ATLENTHICCC
{
    public partial class FModifierParametreDuSIte : Form
    {
        private MySqlConnection maCnx;
        private MySqlDataReader jeuEnr = null;
        public FModifierParametreDuSIte()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2023;port=3306;password=");
            jeuEnr = null;
            bool estactif = false;

            try
            {
                
                string requête;
                maCnx.Open();
                requête = "Select * from parametres";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée



                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    txtb_site.Text = jeuEnr["SITE_PB"].ToString();
                    txtb_rang.Text = jeuEnr["RANG_PB"].ToString();
                    txtb_identifiants.Text = jeuEnr["IDENTIFIANT_PB"].ToString();
                    txtb_cle.Text = jeuEnr["CLEHMAC_PB"].ToString();
                    txtb_mail.Text = jeuEnr["MELSITE"].ToString();
                    checkB_prof.Checked = jeuEnr["ENPRODUCTION"].ToString()=="True";
                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }

        private void FModifierParametreDuSIte_Load(object sender, EventArgs e)
        {

        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            bool test = false;
            foreach (Control textbox in this.Controls.OfType<TextBox>())
            {
                var objetRegEx = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
                // Nombre : ^[0-9]*$
                // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
                // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$
                var résultatTest = objetRegEx.Match(textbox.Text);
                if (!résultatTest.Success)
                {
                    // KO : Fond de la zone de saisie passe en rouge
                    textbox.BackColor = Color.Red;
                    test = true;
                }
            }

            if (test == false)
            {
                try

                {
                    string requête;
                    maCnx.Open(); // on se connecte
                                  // NOTA BENE : title est un nom de champ, titles le nom de la table !
                                  // DEBUT requête paramétrée

                    requête = "UPDATE parametres SET SITE_PB = @site, RANG_PB = @rang, IDENTIFIANT_PB = @identifiant, CLEHMAC_PB = @cle, ENPRODUCTION = @prod, MELSITE = @mail ";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@site", txtb_site.Text);
                    maCde.Parameters.AddWithValue("@rang", txtb_rang.Text);
                    maCde.Parameters.AddWithValue("@identifiant", txtb_identifiants.Text);
                    maCde.Parameters.AddWithValue("@cle", txtb_cle.Text);
                    maCde.Parameters.AddWithValue("@mail", txtb_mail.Text);
                    maCde.Parameters.AddWithValue("@prod", checkB_prof.Checked);

                    // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                    // FIN requête paramétrée
                    maCde.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur " + ex.ToString());
                }
                finally { maCnx.Close(); }

                MessageBox.Show("Parametres modifié.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
