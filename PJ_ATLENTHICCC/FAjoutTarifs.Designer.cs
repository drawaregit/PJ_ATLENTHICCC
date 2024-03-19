namespace PJ_ATLENTHICCC
{
    partial class FAjoutTarifs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_secteurs = new System.Windows.Forms.Label();
            this.txt_liaison = new System.Windows.Forms.Label();
            this.txt_periode = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.cb_liaison = new System.Windows.Forms.ComboBox();
            this.cb_periode = new System.Windows.Forms.ComboBox();
            this.gb_tarifs = new System.Windows.Forms.GroupBox();
            this.txt_tarifs = new System.Windows.Forms.Label();
            this.txt_categorietype = new System.Windows.Forms.Label();
            this.lst_secteurs = new System.Windows.Forms.ListBox();
            this.gb_tarifs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_secteurs
            // 
            this.txt_secteurs.AutoSize = true;
            this.txt_secteurs.Location = new System.Drawing.Point(26, 40);
            this.txt_secteurs.Name = "txt_secteurs";
            this.txt_secteurs.Size = new System.Drawing.Size(66, 16);
            this.txt_secteurs.TabIndex = 0;
            this.txt_secteurs.Text = "Secteurs :";
            // 
            // txt_liaison
            // 
            this.txt_liaison.AutoSize = true;
            this.txt_liaison.Location = new System.Drawing.Point(26, 306);
            this.txt_liaison.Name = "txt_liaison";
            this.txt_liaison.Size = new System.Drawing.Size(56, 16);
            this.txt_liaison.TabIndex = 1;
            this.txt_liaison.Text = "Liaison :";
            // 
            // txt_periode
            // 
            this.txt_periode.AutoSize = true;
            this.txt_periode.Location = new System.Drawing.Point(31, 421);
            this.txt_periode.Name = "txt_periode";
            this.txt_periode.Size = new System.Drawing.Size(61, 16);
            this.txt_periode.TabIndex = 2;
            this.txt_periode.Text = "Période :";
            this.txt_periode.Click += new System.EventHandler(this.txt_periode_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(516, 421);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(272, 23);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // cb_liaison
            // 
            this.cb_liaison.FormattingEnabled = true;
            this.cb_liaison.Location = new System.Drawing.Point(29, 325);
            this.cb_liaison.Name = "cb_liaison";
            this.cb_liaison.Size = new System.Drawing.Size(353, 24);
            this.cb_liaison.TabIndex = 4;
            this.cb_liaison.SelectedIndexChanged += new System.EventHandler(this.cb_liaison_SelectedIndexChanged);
            // 
            // cb_periode
            // 
            this.cb_periode.FormattingEnabled = true;
            this.cb_periode.Location = new System.Drawing.Point(98, 421);
            this.cb_periode.Name = "cb_periode";
            this.cb_periode.Size = new System.Drawing.Size(363, 24);
            this.cb_periode.TabIndex = 5;
            this.cb_periode.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // gb_tarifs
            // 
            this.gb_tarifs.AutoSize = true;
            this.gb_tarifs.Controls.Add(this.txt_tarifs);
            this.gb_tarifs.Controls.Add(this.txt_categorietype);
            this.gb_tarifs.Location = new System.Drawing.Point(388, 28);
            this.gb_tarifs.Name = "gb_tarifs";
            this.gb_tarifs.Size = new System.Drawing.Size(400, 380);
            this.gb_tarifs.TabIndex = 6;
            this.gb_tarifs.TabStop = false;
            this.gb_tarifs.Text = "Traifs par Catégories-Type";
            this.gb_tarifs.Enter += new System.EventHandler(this.gb_tarifs_Enter);
            // 
            // txt_tarifs
            // 
            this.txt_tarifs.AutoSize = true;
            this.txt_tarifs.Location = new System.Drawing.Point(275, 30);
            this.txt_tarifs.Name = "txt_tarifs";
            this.txt_tarifs.Size = new System.Drawing.Size(34, 16);
            this.txt_tarifs.TabIndex = 1;
            this.txt_tarifs.Text = "Tarif";
            // 
            // txt_categorietype
            // 
            this.txt_categorietype.AutoSize = true;
            this.txt_categorietype.Location = new System.Drawing.Point(17, 30);
            this.txt_categorietype.Name = "txt_categorietype";
            this.txt_categorietype.Size = new System.Drawing.Size(108, 16);
            this.txt_categorietype.TabIndex = 0;
            this.txt_categorietype.Text = "Catégorie - Type";
            // 
            // lst_secteurs
            // 
            this.lst_secteurs.FormattingEnabled = true;
            this.lst_secteurs.ItemHeight = 16;
            this.lst_secteurs.Location = new System.Drawing.Point(29, 72);
            this.lst_secteurs.Name = "lst_secteurs";
            this.lst_secteurs.Size = new System.Drawing.Size(353, 228);
            this.lst_secteurs.TabIndex = 7;
            this.lst_secteurs.SelectedIndexChanged += new System.EventHandler(this.lst_secteurs_SelectedIndexChanged);
            // 
            // FAjoutTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.lst_secteurs);
            this.Controls.Add(this.gb_tarifs);
            this.Controls.Add(this.cb_periode);
            this.Controls.Add(this.cb_liaison);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_periode);
            this.Controls.Add(this.txt_liaison);
            this.Controls.Add(this.txt_secteurs);
            this.Name = "FAjoutTarifs";
            this.Text = "Ajouter des Tarifs";
            this.Load += new System.EventHandler(this.FAjoutTarifs_Load);
            this.gb_tarifs.ResumeLayout(false);
            this.gb_tarifs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_secteurs;
        private System.Windows.Forms.Label txt_liaison;
        private System.Windows.Forms.Label txt_periode;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.ComboBox cb_liaison;
        private System.Windows.Forms.ComboBox cb_periode;
        private System.Windows.Forms.GroupBox gb_tarifs;
        private System.Windows.Forms.ListBox lst_secteurs;
        private System.Windows.Forms.Label txt_tarifs;
        private System.Windows.Forms.Label txt_categorietype;
    }
}