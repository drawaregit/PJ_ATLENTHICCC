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
    public partial class FAccueil : Form
    {
        public FAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void unSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutSecteurcs form2 = new FAjoutSecteurcs();
            form2.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutPort form2 = new FAjoutPort();
            form2.Show();
        }

        private void uneLiaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutLiaison form2 = new FAjoutLiaison();
            form2.Show();
        }

        private void lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutTarifs form2 = new FAjoutTarifs();
            form2.Show();
        }

        private void unBateauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutBateauV2 form2 = new FAjoutBateauV2();
            form2.Show();
        }

        private void uneTraverséeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutTraversee form2 = new FAjoutTraversee();
            form2.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programme par Neal LEVEQUE-YVARD.\r\nBase de données par Damien BOUCARD. \r\nLycée Rabelais 22000.\r\n2024");
        }

        private void unBateauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FModifierUnBateau form2 = new FModifierUnBateau();
            form2.Show();
        }

        private void lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAfficherTraverseeEtLiaison form2 = new FAfficherTraverseeEtLiaison();
            form2.Show();
        }

        private void lesParamètresDuSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FModifierParametreDuSIte form2 = new FModifierParametreDuSIte();
            form2.Show();
        }
    }
}
