namespace Suivie_Facture.Frais_deplacement
{
    partial class Imp_Personnel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_activiteservice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mat = new System.Windows.Forms.TextBox();
            this.lbl_idFrais = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.cmb_codeAnalytique = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_fournisseur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_recherch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dg_Personnel = new Suivie_Facture.Class.ProgressDataGridView();
            this.lblidPersonnel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Personnel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_activiteservice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mat);
            this.groupBox1.Controls.Add(this.lbl_idFrais);
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.cmb_codeAnalytique);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.lbl_fournisseur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(113, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(601, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_activiteservice
            // 
            this.txt_activiteservice.Location = new System.Drawing.Point(139, 41);
            this.txt_activiteservice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_activiteservice.Name = "txt_activiteservice";
            this.txt_activiteservice.Size = new System.Drawing.Size(132, 20);
            this.txt_activiteservice.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Activité service";
            // 
            // txt_mat
            // 
            this.txt_mat.Location = new System.Drawing.Point(60, 16);
            this.txt_mat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mat.Name = "txt_mat";
            this.txt_mat.Size = new System.Drawing.Size(132, 20);
            this.txt_mat.TabIndex = 44;
            // 
            // lbl_idFrais
            // 
            this.lbl_idFrais.AutoSize = true;
            this.lbl_idFrais.Location = new System.Drawing.Point(393, 189);
            this.lbl_idFrais.Name = "lbl_idFrais";
            this.lbl_idFrais.Size = new System.Drawing.Size(0, 13);
            this.lbl_idFrais.TabIndex = 43;
            this.lbl_idFrais.Visible = false;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(288, 66);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(228, 22);
            this.btn_new.TabIndex = 42;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(148, 66);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(134, 22);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(8, 66);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(134, 22);
            this.btn_update.TabIndex = 40;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cmb_codeAnalytique
            // 
            this.cmb_codeAnalytique.FormattingEnabled = true;
            this.cmb_codeAnalytique.Location = new System.Drawing.Point(464, 16);
            this.cmb_codeAnalytique.Name = "cmb_codeAnalytique";
            this.cmb_codeAnalytique.Size = new System.Drawing.Size(132, 21);
            this.cmb_codeAnalytique.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(238, 16);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(132, 20);
            this.txt_nom.TabIndex = 35;
            // 
            // lbl_fournisseur
            // 
            this.lbl_fournisseur.AutoSize = true;
            this.lbl_fournisseur.Location = new System.Drawing.Point(375, 20);
            this.lbl_fournisseur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fournisseur.Name = "lbl_fournisseur";
            this.lbl_fournisseur.Size = new System.Drawing.Size(84, 13);
            this.lbl_fournisseur.TabIndex = 5;
            this.lbl_fournisseur.Text = "Code Analytique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_recherch);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(113, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(393, 44);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // txt_recherch
            // 
            this.txt_recherch.Location = new System.Drawing.Point(223, 15);
            this.txt_recherch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_recherch.Name = "txt_recherch";
            this.txt_recherch.Size = new System.Drawing.Size(159, 20);
            this.txt_recherch.TabIndex = 1;
            this.txt_recherch.TextChanged += new System.EventHandler(this.txt_recherch_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Matricule or  Nom or Code Analytique :";
            // 
            // dg_Personnel
            // 
            this.dg_Personnel.AllowUserToAddRows = false;
            this.dg_Personnel.AllowUserToDeleteRows = false;
            this.dg_Personnel.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_Personnel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Personnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Personnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_Personnel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_Personnel.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Personnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Personnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Personnel.GridColor = System.Drawing.Color.LightGreen;
            this.dg_Personnel.Location = new System.Drawing.Point(113, 173);
            this.dg_Personnel.Margin = new System.Windows.Forms.Padding(0);
            this.dg_Personnel.Name = "dg_Personnel";
            this.dg_Personnel.ReadOnly = true;
            this.dg_Personnel.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_Personnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Personnel.Size = new System.Drawing.Size(601, 142);
            this.dg_Personnel.TabIndex = 6;
            this.dg_Personnel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Personnel_CellContentClick);
            this.dg_Personnel.SelectionChanged += new System.EventHandler(this.dg_Personnel_SelectionChanged);
            // 
            // lblidPersonnel
            // 
            this.lblidPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblidPersonnel.AutoSize = true;
            this.lblidPersonnel.Location = new System.Drawing.Point(498, 116);
            this.lblidPersonnel.Name = "lblidPersonnel";
            this.lblidPersonnel.Size = new System.Drawing.Size(0, 13);
            this.lblidPersonnel.TabIndex = 7;
            this.lblidPersonnel.Visible = false;
            // 
            // Imp_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 398);
            this.Controls.Add(this.lblidPersonnel);
            this.Controls.Add(this.dg_Personnel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imp_Personnel";
            this.Text = "Imp_Personnel";
            this.Load += new System.EventHandler(this.Imp_Personnel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Personnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_idFrais;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cmb_codeAnalytique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_fournisseur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_recherch;
        private System.Windows.Forms.Label label15;
        private Class.ProgressDataGridView dg_Personnel;
        private System.Windows.Forms.TextBox txt_mat;
        private System.Windows.Forms.Label lblidPersonnel;
        private System.Windows.Forms.TextBox txt_activiteservice;
        private System.Windows.Forms.Label label3;
    }
}