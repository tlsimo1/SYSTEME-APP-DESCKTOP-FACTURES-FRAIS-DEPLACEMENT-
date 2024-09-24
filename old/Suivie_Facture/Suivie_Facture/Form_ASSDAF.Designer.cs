namespace Suivie_Facture
{
    partial class Form_ASSDAF
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
            this.dg_cmp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_cmp
            // 
            this.dg_cmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_cmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cmp.Location = new System.Drawing.Point(11, 68);
            this.dg_cmp.Margin = new System.Windows.Forms.Padding(0);
            this.dg_cmp.Name = "dg_cmp";
            this.dg_cmp.ReadOnly = true;
            this.dg_cmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_cmp.Size = new System.Drawing.Size(787, 161);
            this.dg_cmp.TabIndex = 2;
            this.dg_cmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_assdaf_CellContentClick);
            this.dg_cmp.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_assdaf_CellMouseEnter);
            // 
            // Form_ASSDAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_cmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ASSDAF";
            this.Text = "Form_ASSDAF";
            this.Load += new System.EventHandler(this.Form_ASSDAF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_cmp;
    }
}