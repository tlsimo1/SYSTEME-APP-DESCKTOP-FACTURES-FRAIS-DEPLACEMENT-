namespace Suivie_Facture
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_bdr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_assdaf = new System.Windows.Forms.Button();
            this.btn_cmp = new System.Windows.Forms.Button();
            this.btn_achat = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_consultation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btn_consultation);
            this.panel1.Controls.Add(this.btn_achat);
            this.panel1.Controls.Add(this.btn_cmp);
            this.panel1.Controls.Add(this.btn_assdaf);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_bdr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 659);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 41);
            this.panel2.TabIndex = 1;
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(200, 41);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(800, 659);
            this.pnl_main.TabIndex = 2;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint);
            // 
            // btn_bdr
            // 
            this.btn_bdr.BackColor = System.Drawing.Color.LightGreen;
            this.btn_bdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bdr.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bdr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_bdr.Location = new System.Drawing.Point(12, 183);
            this.btn_bdr.Name = "btn_bdr";
            this.btn_bdr.Size = new System.Drawing.Size(179, 38);
            this.btn_bdr.TabIndex = 0;
            this.btn_bdr.Text = "BUREAU D\'ORDRE";
            this.btn_bdr.UseVisualStyleBackColor = false;
            this.btn_bdr.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_assdaf
            // 
            this.btn_assdaf.BackColor = System.Drawing.Color.LightGreen;
            this.btn_assdaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assdaf.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assdaf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_assdaf.Location = new System.Drawing.Point(12, 227);
            this.btn_assdaf.Name = "btn_assdaf";
            this.btn_assdaf.Size = new System.Drawing.Size(179, 38);
            this.btn_assdaf.TabIndex = 2;
            this.btn_assdaf.Text = "ASSISTANTE DAF";
            this.btn_assdaf.UseVisualStyleBackColor = false;
            this.btn_assdaf.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cmp
            // 
            this.btn_cmp.BackColor = System.Drawing.Color.LightGreen;
            this.btn_cmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cmp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cmp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cmp.Location = new System.Drawing.Point(12, 271);
            this.btn_cmp.Name = "btn_cmp";
            this.btn_cmp.Size = new System.Drawing.Size(179, 38);
            this.btn_cmp.TabIndex = 3;
            this.btn_cmp.Text = "COMPTABILITE";
            this.btn_cmp.UseVisualStyleBackColor = false;
            this.btn_cmp.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_achat
            // 
            this.btn_achat.BackColor = System.Drawing.Color.LightGreen;
            this.btn_achat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_achat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_achat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_achat.Location = new System.Drawing.Point(11, 318);
            this.btn_achat.Name = "btn_achat";
            this.btn_achat.Size = new System.Drawing.Size(179, 38);
            this.btn_achat.TabIndex = 4;
            this.btn_achat.Text = "ACHAT";
            this.btn_achat.UseVisualStyleBackColor = false;
            this.btn_achat.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(964, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_consultation
            // 
            this.btn_consultation.BackColor = System.Drawing.Color.LightGreen;
            this.btn_consultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_consultation.Location = new System.Drawing.Point(11, 362);
            this.btn_consultation.Name = "btn_consultation";
            this.btn_consultation.Size = new System.Drawing.Size(179, 57);
            this.btn_consultation.TabIndex = 5;
            this.btn_consultation.Text = "CONSULATION FACTURE";
            this.btn_consultation.UseVisualStyleBackColor = false;
            this.btn_consultation.Click += new System.EventHandler(this.button6_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_bdr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_achat;
        private System.Windows.Forms.Button btn_cmp;
        private System.Windows.Forms.Button btn_assdaf;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_consultation;
    }
}