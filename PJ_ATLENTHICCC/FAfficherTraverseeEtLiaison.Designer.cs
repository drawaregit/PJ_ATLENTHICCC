namespace PJ_ATLENTHICCC
{
    partial class FAfficherTraverseeEtLiaison
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
            this.txt_secteur = new System.Windows.Forms.Label();
            this.txt_liaison = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.Label();
            this.LBX_secteur = new System.Windows.Forms.ListBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.CB_liaison = new System.Windows.Forms.ComboBox();
            this.lst_traversee = new System.Windows.Forms.ListView();
            this.txt_place = new System.Windows.Forms.Label();
            this.txt_traversee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_secteur
            // 
            this.txt_secteur.AutoSize = true;
            this.txt_secteur.Location = new System.Drawing.Point(13, 13);
            this.txt_secteur.Name = "txt_secteur";
            this.txt_secteur.Size = new System.Drawing.Size(66, 16);
            this.txt_secteur.TabIndex = 0;
            this.txt_secteur.Text = "Secteurs :";
            // 
            // txt_liaison
            // 
            this.txt_liaison.AutoSize = true;
            this.txt_liaison.Location = new System.Drawing.Point(13, 305);
            this.txt_liaison.Name = "txt_liaison";
            this.txt_liaison.Size = new System.Drawing.Size(56, 16);
            this.txt_liaison.TabIndex = 1;
            this.txt_liaison.Text = "Liaison :";
            // 
            // txt_date
            // 
            this.txt_date.AutoSize = true;
            this.txt_date.Location = new System.Drawing.Point(375, 46);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(193, 16);
            this.txt_date.TabIndex = 2;
            this.txt_date.Text = "Date (par défaut date du jours) :";
            this.txt_date.Click += new System.EventHandler(this.txt_date_Click);
            // 
            // LBX_secteur
            // 
            this.LBX_secteur.FormattingEnabled = true;
            this.LBX_secteur.ItemHeight = 16;
            this.LBX_secteur.Location = new System.Drawing.Point(16, 46);
            this.LBX_secteur.Name = "LBX_secteur";
            this.LBX_secteur.Size = new System.Drawing.Size(318, 228);
            this.LBX_secteur.TabIndex = 3;
            this.LBX_secteur.SelectedIndexChanged += new System.EventHandler(this.LBX_secteur_SelectedIndexChanged);
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "yyyy-MM-dd";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(574, 46);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(221, 22);
            this.dtp_date.TabIndex = 4;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(378, 91);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(443, 37);
            this.btn_afficher.TabIndex = 5;
            this.btn_afficher.Text = "Afficher les traversées";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // CB_liaison
            // 
            this.CB_liaison.FormattingEnabled = true;
            this.CB_liaison.Location = new System.Drawing.Point(16, 324);
            this.CB_liaison.Name = "CB_liaison";
            this.CB_liaison.Size = new System.Drawing.Size(318, 24);
            this.CB_liaison.TabIndex = 6;
            // 
            // lst_traversee
            // 
            this.lst_traversee.HideSelection = false;
            this.lst_traversee.Location = new System.Drawing.Point(378, 163);
            this.lst_traversee.Name = "lst_traversee";
            this.lst_traversee.Size = new System.Drawing.Size(610, 261);
            this.lst_traversee.TabIndex = 7;
            this.lst_traversee.UseCompatibleStateImageBehavior = false;
            this.lst_traversee.SelectedIndexChanged += new System.EventHandler(this.lst_traversee_SelectedIndexChanged);
            // 
            // txt_place
            // 
            this.txt_place.AutoSize = true;
            this.txt_place.Location = new System.Drawing.Point(783, 144);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(205, 16);
            this.txt_place.TabIndex = 9;
            this.txt_place.Text = "Places disponible par catégories";
            this.txt_place.Click += new System.EventHandler(this.lblcacaaaaaa_Click);
            // 
            // txt_traversee
            // 
            this.txt_traversee.AutoSize = true;
            this.txt_traversee.Location = new System.Drawing.Point(375, 144);
            this.txt_traversee.Name = "txt_traversee";
            this.txt_traversee.Size = new System.Drawing.Size(70, 16);
            this.txt_traversee.TabIndex = 8;
            this.txt_traversee.Text = "Traversée";
            // 
            // FAfficherTraverseeEtLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.txt_place);
            this.Controls.Add(this.txt_traversee);
            this.Controls.Add(this.lst_traversee);
            this.Controls.Add(this.CB_liaison);
            this.Controls.Add(this.btn_afficher);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.LBX_secteur);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_liaison);
            this.Controls.Add(this.txt_secteur);
            this.Name = "FAfficherTraverseeEtLiaison";
            this.Text = "FAfficherTraverseeEtLiaison";
            this.Load += new System.EventHandler(this.FAfficherTraverseeEtLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_secteur;
        private System.Windows.Forms.Label txt_liaison;
        private System.Windows.Forms.Label txt_date;
        private System.Windows.Forms.ListBox LBX_secteur;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.ComboBox CB_liaison;
        private System.Windows.Forms.ListView lst_traversee;
        private System.Windows.Forms.Label txt_place;
        private System.Windows.Forms.Label txt_traversee;
    }
}