namespace Suivie_Facture.Frais_deplacement.CRY
{
    partial class Etat_Avancement
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
            this.crv_avancement = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_avancement
            // 
            this.crv_avancement.ActiveViewIndex = -1;
            this.crv_avancement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_avancement.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_avancement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_avancement.Location = new System.Drawing.Point(0, 0);
            this.crv_avancement.Name = "crv_avancement";
            this.crv_avancement.Size = new System.Drawing.Size(800, 450);
            this.crv_avancement.TabIndex = 0;
            this.crv_avancement.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Etat_Avancement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_avancement);
            this.Name = "Etat_Avancement";
            this.Text = "Etat_Avancement";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_avancement;
    }
}