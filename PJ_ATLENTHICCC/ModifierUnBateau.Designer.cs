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
            this.GB_Capacites = new System.Windows.Forms.GroupBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.Label();
            this.CB_nmbateau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GB_Capacites
            // 
            this.GB_Capacites.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GB_Capacites.Location = new System.Drawing.Point(318, 40);
            this.GB_Capacites.Name = "GB_Capacites";
            this.GB_Capacites.Size = new System.Drawing.Size(335, 352);
            this.GB_Capacites.TabIndex = 7;
            this.GB_Capacites.TabStop = false;
            this.GB_Capacites.Text = "Capacités Maximales";
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(124, 355);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(174, 23);
            this.btn_modifier.TabIndex = 5;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // txt_nom
            // 
            this.txt_nom.AutoSize = true;
            this.txt_nom.Location = new System.Drawing.Point(25, 40);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(87, 16);
            this.txt_nom.TabIndex = 4;
            this.txt_nom.Text = "Nom bateau :";
            // 
            // CB_nmbateau
            // 
            this.CB_nmbateau.FormattingEnabled = true;
            this.CB_nmbateau.Location = new System.Drawing.Point(146, 40);
            this.CB_nmbateau.Name = "CB_nmbateau";
            this.CB_nmbateau.Size = new System.Drawing.Size(121, 24);
            this.CB_nmbateau.TabIndex = 8;
            // 
            // FModifierUnBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_nmbateau);
            this.Controls.Add(this.GB_Capacites);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.txt_nom);
            this.Name = "FModifierUnBateau";
            this.Text = "Modifier un bateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Capacites;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Label txt_nom;
        private System.Windows.Forms.ComboBox CB_nmbateau;
    }
}