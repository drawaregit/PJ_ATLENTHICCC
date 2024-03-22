namespace PJ_ATLENTHICCC
{
    partial class FModifierUnBateau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FModifierUnBateau));
            this.img_techniciencool = new System.Windows.Forms.PictureBox();
            this.GB_Capacites = new System.Windows.Forms.GroupBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.Label();
            this.CB_nmbateau = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_techniciencool)).BeginInit();
            this.SuspendLayout();
            // 
            // img_techniciencool
            // 
            this.img_techniciencool.Image = ((System.Drawing.Image)(resources.GetObject("img_techniciencool.Image")));
            this.img_techniciencool.Location = new System.Drawing.Point(59, 144);
            this.img_techniciencool.Name = "img_techniciencool";
            this.img_techniciencool.Size = new System.Drawing.Size(330, 257);
            this.img_techniciencool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_techniciencool.TabIndex = 18;
            this.img_techniciencool.TabStop = false;
            // 
            // GB_Capacites
            // 
            this.GB_Capacites.AutoSize = true;
            this.GB_Capacites.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GB_Capacites.Location = new System.Drawing.Point(409, 49);
            this.GB_Capacites.Name = "GB_Capacites";
            this.GB_Capacites.Size = new System.Drawing.Size(335, 352);
            this.GB_Capacites.TabIndex = 16;
            this.GB_Capacites.TabStop = false;
            this.GB_Capacites.Text = "Capacités Maximales";
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(59, 94);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(330, 44);
            this.btn_modifier.TabIndex = 15;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.AutoSize = true;
            this.txt_nom.Location = new System.Drawing.Point(56, 49);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(87, 16);
            this.txt_nom.TabIndex = 14;
            this.txt_nom.Text = "Nom bateau :";
            // 
            // CB_nmbateau
            // 
            this.CB_nmbateau.FormattingEnabled = true;
            this.CB_nmbateau.Location = new System.Drawing.Point(166, 49);
            this.CB_nmbateau.Name = "CB_nmbateau";
            this.CB_nmbateau.Size = new System.Drawing.Size(223, 24);
            this.CB_nmbateau.TabIndex = 17;
            this.CB_nmbateau.SelectedIndexChanged += new System.EventHandler(this.CB_nmbateau_SelectedIndexChanged);
            // 
            // FModifierUnBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.img_techniciencool);
            this.Controls.Add(this.CB_nmbateau);
            this.Controls.Add(this.GB_Capacites);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.txt_nom);
            this.Name = "FModifierUnBateau";
            this.Text = "Modifier un bateau";
            this.Load += new System.EventHandler(this.FModifierUnBateau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_techniciencool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_techniciencool;
        private System.Windows.Forms.GroupBox GB_Capacites;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Label txt_nom;
        private System.Windows.Forms.ComboBox CB_nmbateau;
    }
}