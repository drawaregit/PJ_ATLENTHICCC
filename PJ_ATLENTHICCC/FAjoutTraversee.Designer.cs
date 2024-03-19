namespace PJ_ATLENTHICCC
{
    partial class FAjoutTraversee
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
            this.txt_NomBateau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Depart = new System.Windows.Forms.Label();
            this.txt_Arivee = new System.Windows.Forms.Label();
            this.date_depart = new System.Windows.Forms.DateTimePicker();
            this.date_Arrivee = new System.Windows.Forms.DateTimePicker();
            this.CB_nomBateau = new System.Windows.Forms.ComboBox();
            this.CB_liaison = new System.Windows.Forms.ComboBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.lstbx_secteurs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_secteurs
            // 
            this.txt_secteurs.AutoSize = true;
            this.txt_secteurs.Location = new System.Drawing.Point(13, 41);
            this.txt_secteurs.Name = "txt_secteurs";
            this.txt_secteurs.Size = new System.Drawing.Size(66, 16);
            this.txt_secteurs.TabIndex = 0;
            this.txt_secteurs.Text = "Secteurs :";
            // 
            // txt_NomBateau
            // 
            this.txt_NomBateau.AutoSize = true;
            this.txt_NomBateau.Location = new System.Drawing.Point(183, 44);
            this.txt_NomBateau.Name = "txt_NomBateau";
            this.txt_NomBateau.Size = new System.Drawing.Size(87, 16);
            this.txt_NomBateau.TabIndex = 1;
            this.txt_NomBateau.Text = "Nom bateau :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liaison :";
            // 
            // txt_Depart
            // 
            this.txt_Depart.AutoSize = true;
            this.txt_Depart.Location = new System.Drawing.Point(183, 202);
            this.txt_Depart.Name = "txt_Depart";
            this.txt_Depart.Size = new System.Drawing.Size(154, 16);
            this.txt_Depart.TabIndex = 3;
            this.txt_Depart.Text = "Date et heure de départ :";
            // 
            // txt_Arivee
            // 
            this.txt_Arivee.AutoSize = true;
            this.txt_Arivee.Location = new System.Drawing.Point(183, 265);
            this.txt_Arivee.Name = "txt_Arivee";
            this.txt_Arivee.Size = new System.Drawing.Size(149, 16);
            this.txt_Arivee.TabIndex = 4;
            this.txt_Arivee.Text = "Date et heure d\'arrivée :";
            // 
            // date_depart
            // 
            this.date_depart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.date_depart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_depart.Location = new System.Drawing.Point(343, 202);
            this.date_depart.Name = "date_depart";
            this.date_depart.Size = new System.Drawing.Size(304, 22);
            this.date_depart.TabIndex = 5;
            // 
            // date_Arrivee
            // 
            this.date_Arrivee.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.date_Arrivee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Arrivee.Location = new System.Drawing.Point(343, 260);
            this.date_Arrivee.Name = "date_Arrivee";
            this.date_Arrivee.Size = new System.Drawing.Size(304, 22);
            this.date_Arrivee.TabIndex = 6;
            this.date_Arrivee.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // CB_nomBateau
            // 
            this.CB_nomBateau.FormattingEnabled = true;
            this.CB_nomBateau.Location = new System.Drawing.Point(313, 41);
            this.CB_nomBateau.Name = "CB_nomBateau";
            this.CB_nomBateau.Size = new System.Drawing.Size(334, 24);
            this.CB_nomBateau.TabIndex = 7;
            // 
            // CB_liaison
            // 
            this.CB_liaison.FormattingEnabled = true;
            this.CB_liaison.Location = new System.Drawing.Point(16, 310);
            this.CB_liaison.Name = "CB_liaison";
            this.CB_liaison.Size = new System.Drawing.Size(254, 24);
            this.CB_liaison.TabIndex = 8;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(343, 311);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(304, 23);
            this.btn_Ajouter.TabIndex = 9;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // lstbx_secteurs
            // 
            this.lstbx_secteurs.FormattingEnabled = true;
            this.lstbx_secteurs.ItemHeight = 16;
            this.lstbx_secteurs.Location = new System.Drawing.Point(16, 75);
            this.lstbx_secteurs.Name = "lstbx_secteurs";
            this.lstbx_secteurs.Size = new System.Drawing.Size(120, 196);
            this.lstbx_secteurs.TabIndex = 10;
            this.lstbx_secteurs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FAjoutTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbx_secteurs);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.CB_liaison);
            this.Controls.Add(this.CB_nomBateau);
            this.Controls.Add(this.date_Arrivee);
            this.Controls.Add(this.date_depart);
            this.Controls.Add(this.txt_Arivee);
            this.Controls.Add(this.txt_Depart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NomBateau);
            this.Controls.Add(this.txt_secteurs);
            this.Name = "FAjoutTraversee";
            this.Text = "Ajouter un traversée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_secteurs;
        private System.Windows.Forms.Label txt_NomBateau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_Depart;
        private System.Windows.Forms.Label txt_Arivee;
        private System.Windows.Forms.DateTimePicker date_depart;
        private System.Windows.Forms.DateTimePicker date_Arrivee;
        private System.Windows.Forms.ComboBox CB_nomBateau;
        private System.Windows.Forms.ComboBox CB_liaison;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.ListBox lstbx_secteurs;
    }
}