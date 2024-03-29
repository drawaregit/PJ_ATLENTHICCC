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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace PJ_ATLENTHICCC
{
    public partial class FAfficherTraverseeEtLiaison : Form
    {
        private MySqlConnection maCnx;
        private MySqlDataReader jeuEnr = null;

        public int getQuantiteEnregistree(int noTraversee, string lettreCategorie)
        {
            int valeurretour = 0;
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT SUM(QUANTITERESERVEE) FROM enregistrer as e INNER JOIN reservation as r ON r.NORESERVATION = e.NORESERVATION INNER JOIN traversee as t ON t.NOTRAVERSEE = r.NOTRAVERSEE WHERE t.NOTRAVERSEE = @notraversee AND e.LETTRECATEGORIE = @lettrecategorie";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                maCde.Parameters.AddWithValue("@notraversee", noTraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    MessageBox.Show(jeuEnr["SUM(QUANTITERESERVEE)"].ToString());
                    valeurretour = int.Parse(jeuEnr["SUM(QUANTITERESERVEE)"].ToString());
                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
            return valeurretour;
        }

        public int getCapaciteMaximale(int noTraversee, string lettreCategorie)
        {
            int valeurretour = 0;
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT CAPACITEMAX FROM contenir as c INNER JOIN bateau as b ON c.NOBATEAU = b.NOBATEAU INNER JOIN traversee as t ON t.NOBATEAU = B.NOBATEAU WHERE t.NOTRAVERSEE = @notraversee AND c.LETTRECATEGORIE = @lettrecategorie";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée
                maCde.Parameters.AddWithValue("@notraversee", noTraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    valeurretour = int.Parse(jeuEnr["CAPACITEMAX"].ToString());
                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
            return valeurretour;
        }

        public string[] getLesCategories()
        {
            string valeurretour = "";
            int i = 0;
            try
            {
                string requête;
                maCnx.Open();
                requête = "select * from categorie";
                var maCde = new MySqlCommand(requête, maCnx);
                // POUR SOUCIS DE TYPAGE voir exemple ExecuteNonQuery, ci-dessus
                // FIN requête paramétrée

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    valeurretour  += jeuEnr["LETTRECATEGORIE"].ToString() + "-" + jeuEnr["LIBELLE"].ToString()+",";
                    i++;
                }
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally { maCnx.Close(); }
            return valeurretour.Split(',');
        }

        public string[] getLesTraverseesBateaux(int noLiaison, string dateTraversee)
{
    string valeurretour = "";
    try
    {
        string requête;
        maCnx.Open();
        requête = "SELECT t.NOTRAVERSEE, DATE_FORMAT(t.DATEHEUREDEPART, '%H:%i') as Time, b.NOM FROM traversee AS t INNER JOIN bateau AS b ON t.Nobateau = b.Nobateau WHERE t.DATEHEUREDEPART LIKE @datedepart AND t.NOLIAISON = @noliaison";
        var maCde = new MySqlCommand(requête, maCnx);
        maCde.Parameters.AddWithValue("@datedepart", dateTraversee + "%");
        maCde.Parameters.AddWithValue("@noliaison", noLiaison);

        var jeuEnr = maCde.ExecuteReader();
        while (jeuEnr.Read())
        {
            valeurretour += jeuEnr["NOTRAVERSEE"].ToString() + "-" + jeuEnr["Time"].ToString() + "-" + jeuEnr["NOM"].ToString() + ",";
        }
        // Supprimez la dernière virgule pour éviter un élément vide à la fin du tableau
        if (valeurretour.Length > 0)
        {
            valeurretour = valeurretour.Remove(valeurretour.Length - 1);
        }
    }
    catch (MySqlException ex)
    {
        Console.WriteLine("Erreur " + ex.ToString());
    }
    finally { maCnx.Close(); }
    // Utilisez Split pour créer un tableau, en séparant les éléments par des virgules
    return valeurretour.Split(',');
}

        public FAfficherTraverseeEtLiaison()
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik2023;port=3306;password=");
            MessageBox.Show(getCapaciteMaximale(1, "A").ToString());
            MessageBox.Show(getQuantiteEnregistree(1, "A").ToString());
            MessageBox.Show(getLesCategories()[0].ToString());
            MessageBox.Show(getLesTraverseesBateaux(11,"2024-03-28")[0].ToString());
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
                maCde.Parameters.AddWithValue("@nosecteur", ((Secteurs)LBX_secteur.SelectedItem).GetNumero().ToString());
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

            /*truc obselete
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
            finally { maCnx.Close(); }*/

            lst_traversee.Columns.Add("N°", 50);
            lst_traversee.Columns.Add("Heure", 70);
            lst_traversee.Columns.Add("Bateau", 65);

            // Ajout de 2 lignes dans le Listview
            
            
            string[] categoriesplit = getLesCategories();
            MessageBox.Show(getLesCategories()[0].ToString());
            for (int i = 0; i < categoriesplit.Length; i++)
            {
                lst_traversee.Columns.Add(categoriesplit[i], 75);
            }

            // Supprimez la déclaration de tabItem ici, elle n'est pas nécessaire
            // var tabItem = new string[4];

            string[] lestraversee = getLesTraverseesBateaux(((liaison)(CB_liaison.SelectedItem)).GetNumero(), dtp_date.Text.ToString());
            string[] categories = getLesCategories(); // Obtenez les catégories pour calculer les places libres

            foreach (string traversee in lestraversee)
            {
                string[] tabItem = traversee.Split('-');
                if (tabItem.Length == 3)
                {
                    ListViewItem unItem = new ListViewItem(tabItem[0]);
                    unItem.SubItems.Add(tabItem[1]);
                    unItem.SubItems.Add(tabItem[2]);

  
                    foreach (string categorie in categories)
                    {
                        string[] categorieDetails = categorie.Split('-');
                        if (categorieDetails.Length == 2)
                        {
                            string lettreCategorie = categorieDetails[0];
                            int totalPlaces = getCapaciteMaximale(int.Parse(tabItem[0]), lettreCategorie);
                            int placesReservees = getQuantiteEnregistree(int.Parse(tabItem[0]), lettreCategorie);
                            int placesLibres = totalPlaces - placesReservees;

                            
                            unItem.SubItems.Add(placesLibres.ToString());
                        }
                    }

                    lst_traversee.Items.Add(unItem);
                }
            }


        }

        private void txt_date_Click(object sender, EventArgs e)
        {

        }
    }
}
