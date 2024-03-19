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
            this.CB_nmbateau = new System.Windows.Forms.ComboBox();
            this.GB_Capacites = new System.Windows.Forms.GroupBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_nmbateau
            // 
            this.CB_nmbateau.FormattingEnabled = true;
            this.CB_nmbateau.Location = new System.Drawing.Point(207, 49);
            this.CB_nmbateau.Name = "CB_nmbateau";
            this.CB_nmbateau.Size = new System.Drawing.Size(121, 24);
            this.CB_nmbateau.TabIndex = 12;
            // 
            // GB_Capacites
            // 
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
            this.btn_ajouter.Location = new System.Drawing.Point(185, 364);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(174, 23);
            this.btn_ajouter.TabIndex = 10;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // txt_nom
            // 
            this.txt_nom.AutoSize = true;
            this.txt_nom.Location = new System.Drawing.Point(86, 49);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(87, 16);
            this.txt_nom.TabIndex = 9;
            this.txt_nom.Text = "Nom bateau :";
            // 
            // FAjoutBateauV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_nmbateau);
            this.Controls.Add(this.GB_Capacites);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_nom);
            this.Name = "FAjoutBateauV2";
            this.Text = "FAjoutBateauV2";
            this.Load += new System.EventHandler(this.FAjoutBateauV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_nmbateau;
        private System.Windows.Forms.GroupBox GB_Capacites;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label txt_nom;
    }
}