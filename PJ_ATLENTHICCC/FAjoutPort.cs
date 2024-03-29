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
    public partial class FAjoutPort : Form
    {
        private MySqlConnection maCnx;
        public FAjoutPort()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2023;port=3306;password=");
        }

        private void btn_Ajout_Click(object sender, EventArgs e)
        {
            bool test = false;
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                var objetRegEx = new Regex("^([a-zA-Z]+\\s)*[a-zA-Z]+$");
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
                    requête = "INSERT INTO port (NOM) VALUES (@nom)";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@nom", txtbox_entree.Text);
                    // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                    // FIN requête paramétrée
                    maCde.ExecuteNonQuery();
                    MessageBox.Show("Port ajouté.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Erreur " + ex.ToString());
                }
                finally { maCnx.Close(); }
            }
        }

        private void FAjoutPort_Load(object sender, EventArgs e)
        {

        }
    }
}
