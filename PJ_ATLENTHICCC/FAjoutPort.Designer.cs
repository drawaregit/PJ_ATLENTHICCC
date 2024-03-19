namespace PJ_ATLENTHICCC
{
    partial class FAjoutPort
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
            this.btn_Ajout = new System.Windows.Forms.Button();
            this.txtbox_entree = new System.Windows.Forms.TextBox();
            this.txt_nomsecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ajout
            // 
            this.btn_Ajout.Location = new System.Drawing.Point(121, 104);
            this.btn_Ajout.Name = "btn_Ajout";
            this.btn_Ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajout.TabIndex = 5;
            this.btn_Ajout.Text = "Ajouter";
            this.btn_Ajout.UseVisualStyleBackColor = true;
            this.btn_Ajout.Click += new System.EventHandler(this.btn_Ajout_Click);
            // 
            // txtbox_entree
            // 
            this.txtbox_entree.Location = new System.Drawing.Point(121, 40);
            this.txtbox_entree.Name = "txtbox_entree";
            this.txtbox_entree.Size = new System.Drawing.Size(100, 22);
            this.txtbox_entree.TabIndex = 4;
            // 
            // txt_nomsecteur
            // 
            this.txt_nomsecteur.AutoSize = true;
            this.txt_nomsecteur.Location = new System.Drawing.Point(26, 43);
            this.txt_nomsecteur.Name = "txt_nomsecteur";
            this.txt_nomsecteur.Size = new System.Drawing.Size(72, 16);
            this.txt_nomsecteur.TabIndex = 3;
            this.txt_nomsecteur.Text = "Nom Port  :";
            // 
            // FAjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ajout);
            this.Controls.Add(this.txtbox_entree);
            this.Controls.Add(this.txt_nomsecteur);
            this.Name = "FAjoutPort";
            this.Text = "FAjoutPort";
            this.Load += new System.EventHandler(this.FAjoutPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ajout;
        private System.Windows.Forms.TextBox txtbox_entree;
        private System.Windows.Forms.Label txt_nomsecteur;
    }
}