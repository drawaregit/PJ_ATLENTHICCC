namespace PJ_ATLENTHICCC
{
    partial class FAjoutBateauV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAjoutBateauV2));
            this.GB_Capacites = new System.Windows.Forms.GroupBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_nombateau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Capacites
            // 
            this.GB_Capacites.AutoSize = true;
            this.GB_Capacites.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GB_Capacites.Location = new System.Drawing.Point(379, 49);
            this.GB_Capacites.Name = "GB_Capacites";
            this.GB_Capacites.Size = new System.Drawing.Size(335, 352);
            this.GB_Capacites.TabIndex = 11;
            this.GB_Capacites.TabStop = false;
            this.GB_Capacites.Text = "Capacités Maximales";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(29, 94);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(330, 23);
            this.btn_ajouter.TabIndex = 10;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.AutoSize = true;
            this.txt_nom.Location = new System.Drawing.Point(26, 49);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(87, 16);
            this.txt_nom.TabIndex = 9;
            this.txt_nom.Text = "Nom bateau :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtbox_nombateau
            // 
            this.txtbox_nombateau.Location = new System.Drawing.Point(120, 49);
            this.txtbox_nombateau.Name = "txtbox_nombateau";
            this.txtbox_nombateau.Size = new System.Drawing.Size(239, 22);
            this.txtbox_nombateau.TabIndex = 14;
            // 
            // FAjoutBateauV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_nombateau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GB_Capacites);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_nom);
            this.Name = "FAjoutBateauV2";
            this.Text = "Ajout d\'un bateau";
            this.Load += new System.EventHandler(this.FAjoutBateauV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GB_Capacites;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label txt_nom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_nombateau;
    }
}