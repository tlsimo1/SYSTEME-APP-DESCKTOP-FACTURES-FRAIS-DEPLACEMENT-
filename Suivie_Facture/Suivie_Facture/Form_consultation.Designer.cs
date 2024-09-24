namespace Suivie_Facture
{
    partial class Form_consultation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_consultation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chek_dept = new System.Windows.Forms.CheckBox();
            this.ck_dept = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_fournisseur = new System.Windows.Forms.TextBox();
            this.lbl_fournisseur = new System.Windows.Forms.Label();
            this.dt_recherch = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_recherch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dg_Facture = new Suivie_Facture.Class.ProgressDataGridView();
            this.btn_imp = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_recherch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Facture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chek_dept);
            this.groupBox1.Controls.Add(this.ck_dept);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btn_imp);
            this.groupBox1.Controls.Add(this.txt_fournisseur);
            this.groupBox1.Controls.Add(this.lbl_fournisseur);
            this.groupBox1.Controls.Add(this.btn_exp);
            this.groupBox1.Controls.Add(this.btn_recherch);
            this.groupBox1.Controls.Add(this.dt_recherch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_recherch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(635, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche Facture";
            // 
            // chek_dept
            // 
            this.chek_dept.AutoSize = true;
            this.chek_dept.Location = new System.Drawing.Point(149, 70);
            this.chek_dept.Name = "chek_dept";
            this.chek_dept.Size = new System.Drawing.Size(62, 18);
            this.chek_dept.TabIndex = 10;
            this.chek_dept.Text = "Achats";
            this.chek_dept.UseVisualStyleBackColor = true;
            // 
            // ck_dept
            // 
            this.ck_dept.AutoSize = true;
            this.ck_dept.Location = new System.Drawing.Point(4, 71);
            this.ck_dept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ck_dept.Name = "ck_dept";
            this.ck_dept.Size = new System.Drawing.Size(79, 14);
            this.ck_dept.TabIndex = 8;
            this.ck_dept.Text = "Departement";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(385, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 13);
            this.progressBar1.TabIndex = 4;
            // 
            // txt_fournisseur
            // 
            this.txt_fournisseur.Location = new System.Drawing.Point(149, 41);
            this.txt_fournisseur.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fournisseur.Name = "txt_fournisseur";
            this.txt_fournisseur.Size = new System.Drawing.Size(159, 22);
            this.txt_fournisseur.TabIndex = 6;
            this.txt_fournisseur.TextChanged += new System.EventHandler(this.txt_fournisseur_TextChanged);
            // 
            // lbl_fournisseur
            // 
            this.lbl_fournisseur.AutoSize = true;
            this.lbl_fournisseur.Location = new System.Drawing.Point(4, 45);
            this.lbl_fournisseur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fournisseur.Name = "lbl_fournisseur";
            this.lbl_fournisseur.Size = new System.Drawing.Size(72, 14);
            this.lbl_fournisseur.TabIndex = 5;
            this.lbl_fournisseur.Text = "Fournisseur";
            // 
            // dt_recherch
            // 
            this.dt_recherch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_recherch.Location = new System.Drawing.Point(385, 15);
            this.dt_recherch.Margin = new System.Windows.Forms.Padding(2);
            this.dt_recherch.Name = "dt_recherch";
            this.dt_recherch.Size = new System.Drawing.Size(171, 22);
            this.dt_recherch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Par Date :";
            // 
            // txt_recherch
            // 
            this.txt_recherch.Location = new System.Drawing.Point(149, 15);
            this.txt_recherch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_recherch.Name = "txt_recherch";
            this.txt_recherch.Size = new System.Drawing.Size(159, 22);
            this.txt_recherch.TabIndex = 1;
            this.txt_recherch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Par Numero de Facture :";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(142, 441);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 18);
            this.lbl_total.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dg_Facture
            // 
            this.dg_Facture.AllowUserToAddRows = false;
            this.dg_Facture.AllowUserToDeleteRows = false;
            this.dg_Facture.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Facture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Facture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Facture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_Facture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dg_Facture.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Facture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Facture.GridColor = System.Drawing.Color.LightGreen;
            this.dg_Facture.Location = new System.Drawing.Point(9, 116);
            this.dg_Facture.Margin = new System.Windows.Forms.Padding(0);
            this.dg_Facture.Name = "dg_Facture";
            this.dg_Facture.ReadOnly = true;
            this.dg_Facture.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_Facture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Facture.Size = new System.Drawing.Size(787, 343);
            this.dg_Facture.TabIndex = 0;
            this.dg_Facture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Facture_CellContentClick);
            this.dg_Facture.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Facture_CellDoubleClick);
            this.dg_Facture.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Facture_CellMouseEnter);
            this.dg_Facture.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dg_Facture_Scroll);
            // 
            // btn_imp
            // 
            this.btn_imp.Image = ((System.Drawing.Image)(resources.GetObject("btn_imp.Image")));
            this.btn_imp.Location = new System.Drawing.Point(564, 42);
            this.btn_imp.Name = "btn_imp";
            this.btn_imp.Size = new System.Drawing.Size(61, 30);
            this.btn_imp.TabIndex = 7;
            this.btn_imp.UseVisualStyleBackColor = true;
            this.btn_imp.Click += new System.EventHandler(this.btn_imp_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Image = global::Suivie_Facture.Properties.Resources.excel24_0;
            this.btn_exp.Location = new System.Drawing.Point(598, 13);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(27, 27);
            this.btn_exp.TabIndex = 4;
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // btn_recherch
            // 
            this.btn_recherch.Image = global::Suivie_Facture.Properties.Resources.icons8_google_web_search_32px;
            this.btn_recherch.Location = new System.Drawing.Point(565, 13);
            this.btn_recherch.Name = "btn_recherch";
            this.btn_recherch.Size = new System.Drawing.Size(27, 27);
            this.btn_recherch.TabIndex = 2;
            this.btn_recherch.UseVisualStyleBackColor = true;
            this.btn_recherch.Click += new System.EventHandler(this.btn_recherch_Click);
            // 
            // Form_consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_Facture);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_consultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form_consultation";
            this.Load += new System.EventHandler(this.Form_consultation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Facture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Suivie_Facture.Class.ProgressDataGridView  dg_Facture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_recherch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_recherch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_recherch;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.TextBox txt_fournisseur;
        private System.Windows.Forms.Label lbl_fournisseur;
        private System.Windows.Forms.Button btn_imp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ck_dept;
        private System.Windows.Forms.CheckBox chek_dept;
    }
}