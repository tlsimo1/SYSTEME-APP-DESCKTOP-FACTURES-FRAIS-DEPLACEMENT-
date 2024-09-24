namespace Suivie_Facture.Frais_deplacement.CRY
{
    partial class Imp_ModReg
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
            this.crv_modReg = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_modReg
            // 
            this.crv_modReg.ActiveViewIndex = -1;
            this.crv_modReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_modReg.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_modReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_modReg.Location = new System.Drawing.Point(0, 0);
            this.crv_modReg.Name = "crv_modReg";
            this.crv_modReg.Size = new System.Drawing.Size(800, 450);
            this.crv_modReg.TabIndex = 0;
            // 
            // Imp_ModReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_modReg);
            this.Name = "Imp_ModReg";
            this.Text = "Imp_ModReg";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_modReg;
    }
}