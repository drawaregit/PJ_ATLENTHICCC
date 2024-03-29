namespace PJ_ATLENTHICCC
{
    partial class FModifierParametreDuSIte
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
            this.gb_indentifiants = new System.Windows.Forms.GroupBox();
            this.txt_site = new System.Windows.Forms.Label();
            this.txt_rang = new System.Windows.Forms.Label();
            this.txt_identifiants = new System.Windows.Forms.Label();
            this.txt_cle = new System.Windows.Forms.Label();
            this.checkB_prof = new System.Windows.Forms.CheckBox();
            this.btn_modif = new System.Windows.Forms.Button();
            this.txtb_site = new System.Windows.Forms.TextBox();
            this.txtb_rang = new System.Windows.Forms.TextBox();
            this.txtb_identifiants = new System.Windows.Forms.TextBox();
            this.txtb_cle = new System.Windows.Forms.TextBox();
            this.txtb_mail = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.Label();
            this.gb_indentifiants.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_indentifiants
            // 
            this.gb_indentifiants.Controls.Add(this.txtb_cle);
            this.gb_indentifiants.Controls.Add(this.txtb_identifiants);
            this.gb_indentifiants.Controls.Add(this.txtb_rang);
            this.gb_indentifiants.Controls.Add(this.txtb_site);
            this.gb_indentifiants.Controls.Add(this.txt_cle);
            this.gb_indentifiants.Controls.Add(this.txt_identifiants);
            this.gb_indentifiants.Controls.Add(this.txt_rang);
            this.gb_indentifiants.Controls.Add(this.txt_site);
            this.gb_indentifiants.Location = new System.Drawing.Point(29, 41);
            this.gb_indentifiants.Name = "gb_indentifiants";
            this.gb_indentifiants.Size = new System.Drawing.Size(442, 270);
            this.gb_indentifiants.TabIndex = 0;
            this.gb_indentifiants.TabStop = false;
            this.gb_indentifiants.Text = "Indentifiants PayBox";
            // 
            // txt_site
            // 
            this.txt_site.AutoSize = true;
            this.txt_site.Location = new System.Drawing.Point(39, 60);
            this.txt_site.Name = "txt_site";
            this.txt_site.Size = new System.Drawing.Size(36, 16);
            this.txt_site.TabIndex = 0;
            this.txt_site.Text = "Site :";
            // 
            // txt_rang
            // 
            this.txt_rang.AutoSize = true;
            this.txt_rang.Location = new System.Drawing.Point(42, 95);
            this.txt_rang.Name = "txt_rang";
            this.txt_rang.Size = new System.Drawing.Size(46, 16);
            this.txt_rang.TabIndex = 1;
            this.txt_rang.Text = "Rang :";
            // 
            // txt_identifiants
            // 
            this.txt_identifiants.AutoSize = true;
            this.txt_identifiants.Location = new System.Drawing.Point(42, 129);
            this.txt_identifiants.Name = "txt_identifiants";
            this.txt_identifiants.Size = new System.Drawing.Size(83, 16);
            this.txt_identifiants.TabIndex = 2;
            this.txt_identifiants.Text = "Indentifiants :";
            // 
            // txt_cle
            // 
            this.txt_cle.AutoSize = true;
            this.txt_cle.Location = new System.Drawing.Point(42, 163);
            this.txt_cle.Name = "txt_cle";
            this.txt_cle.Size = new System.Drawing.Size(75, 16);
            this.txt_cle.TabIndex = 3;
            this.txt_cle.Text = "Clé HMAC :";
            // 
            // checkB_prof
            // 
            this.checkB_prof.AutoSize = true;
            this.checkB_prof.Location = new System.Drawing.Point(45, 358);
            this.checkB_prof.Name = "checkB_prof";
            this.checkB_prof.Size = new System.Drawing.Size(111, 20);
            this.checkB_prof.TabIndex = 1;
            this.checkB_prof.Text = "En production";
            this.checkB_prof.UseVisualStyleBackColor = true;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(45, 394);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(426, 23);
            this.btn_modif.TabIndex = 2;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // txtb_site
            // 
            this.txtb_site.Location = new System.Drawing.Point(122, 54);
            this.txtb_site.Name = "txtb_site";
            this.txtb_site.Size = new System.Drawing.Size(293, 22);
            this.txtb_site.TabIndex = 4;
            // 
            // txtb_rang
            // 
            this.txtb_rang.Location = new System.Drawing.Point(122, 92);
            this.txtb_rang.Name = "txtb_rang";
            this.txtb_rang.Size = new System.Drawing.Size(293, 22);
            this.txtb_rang.TabIndex = 5;
            // 
            // txtb_identifiants
            // 
            this.txtb_identifiants.Location = new System.Drawing.Point(122, 129);
            this.txtb_identifiants.Name = "txtb_identifiants";
            this.txtb_identifiants.Size = new System.Drawing.Size(293, 22);
            this.txtb_identifiants.TabIndex = 6;
            // 
            // txtb_cle
            // 
            this.txtb_cle.Location = new System.Drawing.Point(122, 163);
            this.txtb_cle.Name = "txtb_cle";
            this.txtb_cle.Size = new System.Drawing.Size(293, 22);
            this.txtb_cle.TabIndex = 7;
            // 
            // txtb_mail
            // 
            this.txtb_mail.Location = new System.Drawing.Point(121, 330);
            this.txtb_mail.Name = "txtb_mail";
            this.txtb_mail.Size = new System.Drawing.Size(350, 22);
            this.txtb_mail.TabIndex = 3;
            // 
            // txt_mail
            // 
            this.txt_mail.AutoSize = true;
            this.txt_mail.Location = new System.Drawing.Point(42, 330);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(62, 16);
            this.txt_mail.TabIndex = 4;
            this.txt_mail.Text = "Mail site :";
            // 
            // FModifierParametreDuSIte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txtb_mail);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.checkB_prof);
            this.Controls.Add(this.gb_indentifiants);
            this.Name = "FModifierParametreDuSIte";
            this.Text = "Modifier les paremetres du site";
            this.Load += new System.EventHandler(this.FModifierParametreDuSIte_Load);
            this.gb_indentifiants.ResumeLayout(false);
            this.gb_indentifiants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_indentifiants;
        private System.Windows.Forms.TextBox txtb_rang;
        private System.Windows.Forms.TextBox txtb_site;
        private System.Windows.Forms.Label txt_cle;
        private System.Windows.Forms.Label txt_identifiants;
        private System.Windows.Forms.Label txt_rang;
        private System.Windows.Forms.Label txt_site;
        private System.Windows.Forms.CheckBox checkB_prof;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.TextBox txtb_cle;
        private System.Windows.Forms.TextBox txtb_identifiants;
        private System.Windows.Forms.TextBox txtb_mail;
        private System.Windows.Forms.Label txt_mail;
    }
}