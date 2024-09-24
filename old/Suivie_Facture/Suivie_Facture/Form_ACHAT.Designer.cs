namespace Suivie_Facture
{
    partial class Form_ACHAT
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
            this.dg_achat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_achat)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_achat
            // 
            this.dg_achat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_achat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_achat.Location = new System.Drawing.Point(11, 68);
            this.dg_achat.Margin = new System.Windows.Forms.Padding(0);
            this.dg_achat.Name = "dg_achat";
            this.dg_achat.ReadOnly = true;
            this.dg_achat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_achat.Size = new System.Drawing.Size(787, 161);
            this.dg_achat.TabIndex = 4;
            this.dg_achat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_achat_CellContentClick);
            this.dg_achat.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_achat_CellMouseEnter);
            // 
            // Form_ACHAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_achat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ACHAT";
            this.Load += new System.EventHandler(this.Form_ACHAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_achat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_achat;
    }
}