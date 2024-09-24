namespace Suivie_Facture
{
    partial class Form_CMP
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
            this.dg_assdaf = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_assdaf)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_assdaf
            // 
            this.dg_assdaf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_assdaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_assdaf.Location = new System.Drawing.Point(11, 68);
            this.dg_assdaf.Margin = new System.Windows.Forms.Padding(0);
            this.dg_assdaf.Name = "dg_assdaf";
            this.dg_assdaf.ReadOnly = true;
            this.dg_assdaf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_assdaf.Size = new System.Drawing.Size(787, 161);
            this.dg_assdaf.TabIndex = 3;
            this.dg_assdaf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_assdaf_CellContentClick);
            this.dg_assdaf.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_assdaf_CellMouseEnter);
            // 
            // Form_CMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_assdaf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CMP";
            this.Text = "Form_CMP";
            this.Load += new System.EventHandler(this.Form_CMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_assdaf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_assdaf;
    }
}