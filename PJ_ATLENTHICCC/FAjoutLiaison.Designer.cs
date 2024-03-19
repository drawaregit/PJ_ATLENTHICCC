namespace PJ_ATLENTHICCC
{
    partial class FAjoutLiaison
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
            this.txt_depart = new System.Windows.Forms.Label();
            this.txt_arrivee = new System.Windows.Forms.Label();
            this.txt_distance = new System.Windows.Forms.Label();
            this.lstbox_secteur = new System.Windows.Forms.ListBox();
            this.cmbox_depart = new System.Windows.Forms.ComboBox();
            this.cmbox_arrivee = new System.Windows.Forms.ComboBox();
            this.txtbox_distance = new System.Windows.Forms.TextBox();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_secteur
            // 
            this.txt_secteur.AutoSize = true;
            this.txt_secteur.Location = new System.Drawing.Point(23, 54);
            this.txt_secteur.Name = "txt_secteur";
            this.txt_secteur.Size = new System.Drawing.Size(59, 16);
            this.txt_secteur.TabIndex = 0;
            this.txt_secteur.Text = "Secteur :";
            // 
            // txt_depart
            // 
            this.txt_depart.AutoSize = true;
            this.txt_depart.Location = new System.Drawing.Point(161, 86);
            this.txt_depart.Name = "txt_depart";
            this.txt_depart.Size = new System.Drawing.Size(54, 16);
            this.txt_depart.TabIndex = 1;
            this.txt_depart.Text = "Départ :";
            // 
            // txt_arrivee
            // 
            this.txt_arrivee.AutoSize = true;
            this.txt_arrivee.Location = new System.Drawing.Point(384, 89);
            this.txt_arrivee.Name = "txt_arrivee";
            this.txt_arrivee.Size = new System.Drawing.Size(56, 16);
            this.txt_arrivee.TabIndex = 2;
            this.txt_arrivee.Text = "Arrivée :";
            // 
            // txt_distance
            // 
            this.txt_distance.AutoSize = true;
            this.txt_distance.Location = new System.Drawing.Point(374, 283);
            this.txt_distance.Name = "txt_distance";
            this.txt_distance.Size = new System.Drawing.Size(66, 16);
            this.txt_distance.TabIndex = 3;
            this.txt_distance.Text = "Distance :";
            this.txt_distance.Click += new System.EventHandler(this.label4_Click);
            // 
            // lstbox_secteur
            // 
            this.lstbox_secteur.FormattingEnabled = true;
            this.lstbox_secteur.ItemHeight = 16;
            this.lstbox_secteur.Location = new System.Drawing.Point(26, 86);
            this.lstbox_secteur.Name = "lstbox_secteur";
            this.lstbox_secteur.Size = new System.Drawing.Size(120, 292);
            this.lstbox_secteur.TabIndex = 4;
            this.lstbox_secteur.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbox_depart
            // 
            this.cmbox_depart.FormattingEnabled = true;
            this.cmbox_depart.Location = new System.Drawing.Point(222, 86);
            this.cmbox_depart.Name = "cmbox_depart";
            this.cmbox_depart.Size = new System.Drawing.Size(121, 24);
            this.cmbox_depart.TabIndex = 5;
            // 
            // cmbox_arrivee
            // 
            this.cmbox_arrivee.FormattingEnabled = true;
            this.cmbox_arrivee.Location = new System.Drawing.Point(457, 86);
            this.cmbox_arrivee.Name = "cmbox_arrivee";
            this.cmbox_arrivee.Size = new System.Drawing.Size(121, 24);
            this.cmbox_arrivee.TabIndex = 6;
            // 
            // txtbox_distance
            // 
            this.txtbox_distance.Location = new System.Drawing.Point(457, 283);
            this.txtbox_distance.Name = "txtbox_distance";
            this.txtbox_distance.Size = new System.Drawing.Size(121, 22);
            this.txtbox_distance.TabIndex = 7;
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(457, 382);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout.TabIndex = 8;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // FAjoutLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.txtbox_distance);
            this.Controls.Add(this.cmbox_arrivee);
            this.Controls.Add(this.cmbox_depart);
            this.Controls.Add(this.lstbox_secteur);
            this.Controls.Add(this.txt_distance);
            this.Controls.Add(this.txt_arrivee);
            this.Controls.Add(this.txt_depart);
            this.Controls.Add(this.txt_secteur);
            this.Name = "FAjoutLiaison";
            this.Text = "Ajout Liaison";
            this.Load += new System.EventHandler(this.FAjoutLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_secteur;
        private System.Windows.Forms.Label txt_depart;
        private System.Windows.Forms.Label txt_arrivee;
        private System.Windows.Forms.Label txt_distance;
        private System.Windows.Forms.ListBox lstbox_secteur;
        private System.Windows.Forms.ComboBox cmbox_depart;
        private System.Windows.Forms.ComboBox cmbox_arrivee;
        private System.Windows.Forms.TextBox txtbox_distance;
        private System.Windows.Forms.Button btn_ajout;
    }
}