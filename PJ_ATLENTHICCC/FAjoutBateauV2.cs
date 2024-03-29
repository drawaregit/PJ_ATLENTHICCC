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

namespace PJ_ATLENTHICCC
{
    public partial class FAjoutBateauV2 : Form
    {
        private MySqlConnection maCnx;
        private MySqlDataReader jeuEnr = null;
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
                requête = "Select * from categorie";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                Label txt;
                System.Windows.Forms.TextBox txtbox;
                int baissey = 25;
                int pos = GB_Capacites.Location.Y + baissey;


                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {

                    txt = new Label();
                    txt.Text = (jeuEnr["LETTRECATEGORIE"].ToString() + " " + jeuEnr["LIBELLE"] + " " + (jeuEnr["LIBELLE"].ToString() + ":"));
                    txt.Location = new Point(GB_Capacites.Location.X-275, pos);

                    txtbox = new System.Windows.Forms.TextBox();
                    txtbox.Tag = jeuEnr["LETTRECATEGORIE"].ToString() + jeuEnr["LIBELLE"];
                    txtbox.Location = new Point(txt.Location.X+200, pos);

                    pos += baissey;
                    GB_Capacites.Controls.Add(txt);
                    GB_Capacites.Controls.Add(txtbox);
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

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int compteurbateau = 0;
            bool test = false;
            foreach (TextBox textbox in GB_Capacites.Controls.OfType<TextBox>())
            {
                var objetRegEx = new Regex("^[0-9]*$");
                // Nombre : ^[0-9]*$
                // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
                // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$
                var résultatTest = objetRegEx.Match(textbox.Text);
                if (!résultatTest.Success)
                {
                    // KO : Fond de la zone de saisie passe en rouge
                    textbox.BackColor = Color.Red;
                    test = true;
                    return;
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
                    requête = "INSERT INTO bateau (NOM) VALUES (@nom)";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@nom", txtbox_nombateau.Text);
                    // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                    // FIN requête paramétrée
                    maCde.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Erreur " + ex.ToString());
                }
                finally { maCnx.Close(); }

                try

                {
                    string requête;
                    maCnx.Open(); // on se connecte
                                  // NOTA BENE : title est un nom de champ, titles le nom de la table !
                                  // DEBUT requête paramétrée
                    requête = "select * from bateau";
                    var maCde = new MySqlCommand(requête, maCnx);
                    // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                    // FIN requête paramétrée
                    maCde.ExecuteNonQuery();


                    jeuEnr = maCde.ExecuteReader();

                    while (jeuEnr.Read())
                    {
                        compteurbateau += 1;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Erreur " + ex.ToString());
                }
                finally { maCnx.Close(); }

                foreach (TextBox txt1 in GB_Capacites.Controls.OfType<TextBox>())
                {

                    try

                    {
                        MessageBox.Show(txt1.Tag.ToString()[0] + " " + txt1.Tag.ToString()[1]);
                        string requête;
                        maCnx.Open(); // on se connecte
                                      // NOTA BENE : title est un nom de champ, titles le nom de la table !
                                      // DEBUT requête paramétrée
                        requête = "INSERT INTO contenir (LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@lettrecategorie, @nobateau, @capacitemax)";
                        var maCde = new MySqlCommand(requête, maCnx);
                        maCde.Parameters.AddWithValue("@lettrecategorie", txt1.Tag.ToString()[0]);
                        maCde.Parameters.AddWithValue("@nobateau", compteurbateau);
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
                MessageBox.Show("Bateau ajouté.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GB_Capacites_Enter(object sender, EventArgs e)
        {

        }
    }
}
