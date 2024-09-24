namespace Suivie_Facture.Frais_deplacement.CRY
{
    partial class imp_fraisANT
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
            this.crv_fraisANT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_fraisANT
            // 
            this.crv_fraisANT.ActiveViewIndex = -1;
            this.crv_fraisANT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_fraisANT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_fraisANT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_fraisANT.Location = new System.Drawing.Point(0, 0);
            this.crv_fraisANT.Name = "crv_fraisANT";
            this.crv_fraisANT.Size = new System.Drawing.Size(800, 450);
            this.crv_fraisANT.TabIndex = 0;
            // 
            // imp_fraisANT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_fraisANT);
            this.Name = "imp_fraisANT";
            this.Text = "imp_fraisANT";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_fraisANT;
    }
}