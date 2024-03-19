using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PJ_ATLENTHICCC
{
    public partial class FAjoutTarifs : Form
    {
        private MySqlConnection maCnx;
        private MySqlDataReader jeuEnr = null;
        public FAjoutTarifs()
        {
            InitializeComponent();

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
                    lst_secteurs.Items.Add(new Secteurs(int.Parse(jeuEnr["NOSECTEUR"].ToString()), jeuEnr["NOM"].ToString()));

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
                requête = "Select * from periode";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée



                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Console.WriteLine();
                    cb_periode.Items.Add(new Periode(int.Parse(jeuEnr["NOPERIODE"].ToString()), jeuEnr["DATEDEBUT"].ToString(), jeuEnr["DATEFIN"].ToString()));

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
                requête = "Select * from type";
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

                    txt = new Label();
                    txt.Text = (jeuEnr["LETTRECATEGORIE"].ToString() + jeuEnr["NOTYPE"] + " " + (jeuEnr["LIBELLE"].ToString() + ":"));
                    txt.Location = new Point(txt_categorietype.Location.X, pos);

                    txtbox = new System.Windows.Forms.TextBox();
                    txtbox.Tag = jeuEnr;
                    txtbox.Location = new Point(txt_tarifs.Location.X, pos);

                    pos += baissey;
                    gb_tarifs.Controls.Add(txt);
                    gb_tarifs.Controls.Add(txtbox);
                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }


        }


        private void txt_periode_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt1 in gb_tarifs.Controls.OfType<TextBox>())
            {
                try

                {
                    string requête;
                    maCnx.Open(); // on se connecte
                                  // NOTA BENE : title est un nom de champ, titles le nom de la table !
                                  // DEBUT requête paramétrée
                    requête = "INSERT INTO tarifer (NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) VALUES (@noperidode, @lettrecategorie, @notype, @noliaison, @tarif)";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@noperiode", ((Periode)cb_periode.SelectedItem).GetNumero());
                    maCde.Parameters.AddWithValue("@lettrecategorie", txt1.Tag.ToString()[0]);
                    maCde.Parameters.AddWithValue("@notype", txt1.Tag.ToString()[1]);
                    maCde.Parameters.AddWithValue("@noliaison", ((liaison)cb_liaison.SelectedItem).GetNumero());
                    maCde.Parameters.AddWithValue("@tarif", double.Parse(txt1.Text));

                    // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                    // FIN requête paramétrée
                    maCde.ExecuteNonQuery();
                    MessageBox.Show("Tarif ajouté.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur " + ex.ToString());
                }
                finally { maCnx.Close(); }
            }
            
        }

        private void gb_tarifs_Enter(object sender, EventArgs e)
        {

        }

        private void FAjoutTarifs_Load(object sender, EventArgs e)
        {
        }

        private void cb_liaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_secteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_liaison.Items.Clear();
            try
            {
                string requête;
                maCnx.Open();
                requête = "Select * from liaison where NOSECTEUR=(@nosecteur)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@nosecteur", lst_secteurs.SelectedIndex);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée



                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    Console.WriteLine();
                    cb_liaison.Items.Add(new liaison(int.Parse(jeuEnr["NOLIAISON"].ToString()), int.Parse(jeuEnr["NOPORT_DEPART"].ToString()), int.Parse(jeuEnr["NOSECTEUR"].ToString()), int.Parse(jeuEnr["NOPORT_ARRIVEE"].ToString()), double.Parse(jeuEnr["DISTANCE"].ToString())));

                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
        }
    }
}
