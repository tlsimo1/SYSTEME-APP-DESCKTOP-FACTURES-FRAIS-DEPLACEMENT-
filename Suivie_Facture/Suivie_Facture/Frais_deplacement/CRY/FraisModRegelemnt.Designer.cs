﻿namespace Suivie_Facture.Frais_deplacement.CRY
{
    partial class FraisModRegelemnt
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
            this.cmb_modeReglement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_modeReglement
            // 
            this.cmb_modeReglement.FormattingEnabled = true;
            this.cmb_modeReglement.Items.AddRange(new object[] {
            "Virement",
            "Espece"});
            this.cmb_modeReglement.Location = new System.Drawing.Point(106, 12);
            this.cmb_modeReglement.Name = "cmb_modeReglement";
            this.cmb_modeReglement.Size = new System.Drawing.Size(178, 21);
            this.cmb_modeReglement.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mode Réglement";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 21);
            this.button3.TabIndex = 15;
            this.button3.Text = "Valider";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FraisModRegelemnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 47);
            this.Controls.Add(this.cmb_modeReglement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FraisModRegelemnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_modeReglement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}