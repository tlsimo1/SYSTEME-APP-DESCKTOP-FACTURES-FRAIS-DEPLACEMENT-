namespace Suivie_Facture
{
    partial class Form_Detail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_achat = new System.Windows.Forms.TextBox();
            this.txt_assdaf = new System.Windows.Forms.TextBox();
            this.txt_br = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cmp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fournisseur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numfac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dtfac = new System.Windows.Forms.TextBox();
            this.txt_dtbr = new System.Windows.Forms.TextBox();
            this.txt_dtassdaf = new System.Windows.Forms.TextBox();
            this.txt_dtcmp = new System.Windows.Forms.TextBox();
            this.txt_dtachat = new System.Windows.Forms.TextBox();
            this.txt_dtsaisi = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dtsaisi);
            this.groupBox1.Controls.Add(this.txt_dtachat);
            this.groupBox1.Controls.Add(this.txt_dtcmp);
            this.groupBox1.Controls.Add(this.txt_dtassdaf);
            this.groupBox1.Controls.Add(this.txt_dtbr);
            this.groupBox1.Controls.Add(this.txt_dtfac);
            this.groupBox1.Controls.Add(this.txt_achat);
            this.groupBox1.Controls.Add(this.txt_assdaf);
            this.groupBox1.Controls.Add(this.txt_br);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_cmp);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_fournisseur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_numfac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail de la Facture";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_achat
            // 
            this.txt_achat.Location = new System.Drawing.Point(483, 307);
            this.txt_achat.Name = "txt_achat";
            this.txt_achat.Size = new System.Drawing.Size(249, 26);
            this.txt_achat.TabIndex = 38;
            // 
            // txt_assdaf
            // 
            this.txt_assdaf.Location = new System.Drawing.Point(483, 203);
            this.txt_assdaf.Name = "txt_assdaf";
            this.txt_assdaf.Size = new System.Drawing.Size(249, 26);
            this.txt_assdaf.TabIndex = 37;
            // 
            // txt_br
            // 
            this.txt_br.Location = new System.Drawing.Point(483, 151);
            this.txt_br.Name = "txt_br";
            this.txt_br.Size = new System.Drawing.Size(249, 26);
            this.txt_br.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Statut  Achat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Date Saisie  Achat";
            // 
            // txt_cmp
            // 
            this.txt_cmp.Location = new System.Drawing.Point(483, 255);
            this.txt_cmp.Name = "txt_cmp";
            this.txt_cmp.Size = new System.Drawing.Size(249, 26);
            this.txt_cmp.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Statut comptabilité";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Date Saisie  comptabilité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Statut Assistante DAF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date Saisie  Assistante DAF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Statut Bureau d\'ordre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date Saisie bureau d\'ordre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Saisie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date Facture";
            // 
            // txt_fournisseur
            // 
            this.txt_fournisseur.Location = new System.Drawing.Point(483, 47);
            this.txt_fournisseur.Name = "txt_fournisseur";
            this.txt_fournisseur.Size = new System.Drawing.Size(249, 26);
            this.txt_fournisseur.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fournisseur";
            // 
            // txt_numfac
            // 
            this.txt_numfac.Location = new System.Drawing.Point(142, 47);
            this.txt_numfac.Name = "txt_numfac";
            this.txt_numfac.Size = new System.Drawing.Size(249, 26);
            this.txt_numfac.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numéro Facture";
            // 
            // txt_dtfac
            // 
            this.txt_dtfac.Location = new System.Drawing.Point(142, 99);
            this.txt_dtfac.Name = "txt_dtfac";
            this.txt_dtfac.Size = new System.Drawing.Size(249, 26);
            this.txt_dtfac.TabIndex = 39;
            // 
            // txt_dtbr
            // 
            this.txt_dtbr.Location = new System.Drawing.Point(142, 151);
            this.txt_dtbr.Name = "txt_dtbr";
            this.txt_dtbr.Size = new System.Drawing.Size(249, 26);
            this.txt_dtbr.TabIndex = 40;
            // 
            // txt_dtassdaf
            // 
            this.txt_dtassdaf.Location = new System.Drawing.Point(142, 203);
            this.txt_dtassdaf.Name = "txt_dtassdaf";
            this.txt_dtassdaf.Size = new System.Drawing.Size(249, 26);
            this.txt_dtassdaf.TabIndex = 41;
            // 
            // txt_dtcmp
            // 
            this.txt_dtcmp.Location = new System.Drawing.Point(142, 255);
            this.txt_dtcmp.Name = "txt_dtcmp";
            this.txt_dtcmp.Size = new System.Drawing.Size(249, 26);
            this.txt_dtcmp.TabIndex = 42;
            // 
            // txt_dtachat
            // 
            this.txt_dtachat.Location = new System.Drawing.Point(142, 307);
            this.txt_dtachat.Name = "txt_dtachat";
            this.txt_dtachat.Size = new System.Drawing.Size(249, 26);
            this.txt_dtachat.TabIndex = 43;
            // 
            // txt_dtsaisi
            // 
            this.txt_dtsaisi.Location = new System.Drawing.Point(483, 99);
            this.txt_dtsaisi.Name = "txt_dtsaisi";
            this.txt_dtsaisi.Size = new System.Drawing.Size(249, 26);
            this.txt_dtsaisi.TabIndex = 44;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(877, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 30);
            this.button5.TabIndex = 2;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 397);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Detail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fournisseur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numfac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cmp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_achat;
        private System.Windows.Forms.TextBox txt_assdaf;
        private System.Windows.Forms.TextBox txt_br;
        private System.Windows.Forms.TextBox txt_dtfac;
        private System.Windows.Forms.TextBox txt_dtsaisi;
        private System.Windows.Forms.TextBox txt_dtachat;
        private System.Windows.Forms.TextBox txt_dtcmp;
        private System.Windows.Forms.TextBox txt_dtassdaf;
        private System.Windows.Forms.TextBox txt_dtbr;
        private System.Windows.Forms.Button button5;
    }
}