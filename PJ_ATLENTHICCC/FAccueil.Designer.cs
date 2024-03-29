namespace PJ_ATLENTHICCC
{
    partial class FAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAccueil));
            this.Img_logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneLiaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBateauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneTraverséeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBateauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lesParamètresDuSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Img_logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Img_logo
            // 
            this.Img_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Img_logo.Image = ((System.Drawing.Image)(resources.GetObject("Img_logo.Image")));
            this.Img_logo.Location = new System.Drawing.Point(0, 27);
            this.Img_logo.Name = "Img_logo";
            this.Img_logo.Size = new System.Drawing.Size(872, 370);
            this.Img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_logo.TabIndex = 0;
            this.Img_logo.TabStop = false;
            this.Img_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unSecteurToolStripMenuItem,
            this.unPortToolStripMenuItem,
            this.uneLiaisonToolStripMenuItem,
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem,
            this.unBateauToolStripMenuItem,
            this.uneTraverséeToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // unSecteurToolStripMenuItem
            // 
            this.unSecteurToolStripMenuItem.Name = "unSecteurToolStripMenuItem";
            this.unSecteurToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.unSecteurToolStripMenuItem.Text = "Un secteur";
            this.unSecteurToolStripMenuItem.Click += new System.EventHandler(this.unSecteurToolStripMenuItem_Click);
            // 
            // unPortToolStripMenuItem
            // 
            this.unPortToolStripMenuItem.Name = "unPortToolStripMenuItem";
            this.unPortToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.unPortToolStripMenuItem.Text = "Un port";
            this.unPortToolStripMenuItem.Click += new System.EventHandler(this.unPortToolStripMenuItem_Click);
            // 
            // uneLiaisonToolStripMenuItem
            // 
            this.uneLiaisonToolStripMenuItem.Name = "uneLiaisonToolStripMenuItem";
            this.uneLiaisonToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.uneLiaisonToolStripMenuItem.Text = "Une liaison";
            this.uneLiaisonToolStripMenuItem.Click += new System.EventHandler(this.uneLiaisonToolStripMenuItem_Click);
            // 
            // lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem
            // 
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Name = "lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem";
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Text = "Les tarifs pour une liaison et une période";
            this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem.Click += new System.EventHandler(this.lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem_Click);
            // 
            // unBateauToolStripMenuItem
            // 
            this.unBateauToolStripMenuItem.Name = "unBateauToolStripMenuItem";
            this.unBateauToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.unBateauToolStripMenuItem.Text = "Un bateau";
            this.unBateauToolStripMenuItem.Click += new System.EventHandler(this.unBateauToolStripMenuItem_Click);
            // 
            // uneTraverséeToolStripMenuItem
            // 
            this.uneTraverséeToolStripMenuItem.Name = "uneTraverséeToolStripMenuItem";
            this.uneTraverséeToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.uneTraverséeToolStripMenuItem.Text = "Une traversée";
            this.uneTraverséeToolStripMenuItem.Click += new System.EventHandler(this.uneTraverséeToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unBateauToolStripMenuItem1,
            this.lesParamètresDuSiteToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // unBateauToolStripMenuItem1
            // 
            this.unBateauToolStripMenuItem1.Name = "unBateauToolStripMenuItem1";
            this.unBateauToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.unBateauToolStripMenuItem1.Text = "Un bateau";
            this.unBateauToolStripMenuItem1.Click += new System.EventHandler(this.unBateauToolStripMenuItem1_Click);
            // 
            // lesParamètresDuSiteToolStripMenuItem
            // 
            this.lesParamètresDuSiteToolStripMenuItem.Name = "lesParamètresDuSiteToolStripMenuItem";
            this.lesParamètresDuSiteToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.lesParamètresDuSiteToolStripMenuItem.Text = "Les paramètres du site";
            this.lesParamètresDuSiteToolStripMenuItem.Click += new System.EventHandler(this.lesParamètresDuSiteToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem,
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem
            // 
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem.Name = "lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStr" +
    "ipMenuItem";
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem.Size = new System.Drawing.Size(668, 26);
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gories";
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem.Click += new System.EventHandler(this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem_Click);
            // 
            // lesDétailsDuneRéservationPourUnClientToolStripMenuItem
            // 
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Name = "lesDétailsDuneRéservationPourUnClientToolStripMenuItem";
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Size = new System.Drawing.Size(668, 26);
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Text = "Les détails d\'une réservation pour un client";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.aProposToolStripMenuItem.Text = "A Propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // FAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 396);
            this.Controls.Add(this.Img_logo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FAccueil";
            this.Text = "ACCUEIL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneLiaisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesTarifsPourUneLiaisonEtUnePériodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBateauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneTraverséeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBateauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lesParamètresDuSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesDétailsDuneRéservationPourUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}

