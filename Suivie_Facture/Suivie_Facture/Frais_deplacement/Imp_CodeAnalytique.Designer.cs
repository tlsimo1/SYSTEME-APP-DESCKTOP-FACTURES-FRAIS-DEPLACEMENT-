namespace Suivie_Facture.Frais_deplacement
{
    partial class Imp_CodeAnalytique
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
            this.txt_codeanalytique = new System.Windows.Forms.TextBox();
            this.txt_activite = new System.Windows.Forms.TextBox();
            this.lbl_idFrais = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fournisseur = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_recherch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_codeanalytique = new System.Windows.Forms.Label();
            this.dg_CodeAnalytique = new Suivie_Facture.Class.ProgressDataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CodeAnalytique)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codeanalytique);
            this.groupBox1.Controls.Add(this.txt_activite);
            this.groupBox1.Controls.Add(this.lbl_idFrais);
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_fournisseur);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(540, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_codeanalytique
            // 
            this.txt_codeanalytique.Location = new System.Drawing.Point(374, 16);
            this.txt_codeanalytique.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codeanalytique.Name = "txt_codeanalytique";
            this.txt_codeanalytique.Size = new System.Drawing.Size(154, 20);
            this.txt_codeanalytique.TabIndex = 45;
            // 
            // txt_activite
            // 
            this.txt_activite.Location = new System.Drawing.Point(92, 16);
            this.txt_activite.Margin = new System.Windows.Forms.Padding(2);
            this.txt_activite.Multiline = true;
            this.txt_activite.Name = "txt_activite";
            this.txt_activite.Size = new System.Drawing.Size(187, 45);
            this.txt_activite.TabIndex = 44;
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
            this.btn_new.Location = new System.Drawing.Point(300, 66);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(228, 22);
            this.btn_new.TabIndex = 42;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(160, 66);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(134, 22);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(20, 66);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(134, 22);
            this.btn_update.TabIndex = 40;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activité Service :";
            // 
            // lbl_fournisseur
            // 
            this.lbl_fournisseur.AutoSize = true;
            this.lbl_fournisseur.Location = new System.Drawing.Point(286, 20);
            this.lbl_fournisseur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fournisseur.Name = "lbl_fournisseur";
            this.lbl_fournisseur.Size = new System.Drawing.Size(84, 13);
            this.lbl_fournisseur.TabIndex = 5;
            this.lbl_fournisseur.Text = "Code Analytique";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_recherch);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(11, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(540, 44);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // txt_recherch
            // 
            this.txt_recherch.Location = new System.Drawing.Point(220, 16);
            this.txt_recherch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_recherch.Name = "txt_recherch";
            this.txt_recherch.Size = new System.Drawing.Size(174, 20);
            this.txt_recherch.TabIndex = 1;
            this.txt_recherch.TextChanged += new System.EventHandler(this.txt_recherch_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Code Service  or  Nom or Code Analytique :";
            // 
            // lbl_codeanalytique
            // 
            this.lbl_codeanalytique.AutoSize = true;
            this.lbl_codeanalytique.Location = new System.Drawing.Point(-4, 370);
            this.lbl_codeanalytique.Name = "lbl_codeanalytique";
            this.lbl_codeanalytique.Size = new System.Drawing.Size(0, 13);
            this.lbl_codeanalytique.TabIndex = 8;
            this.lbl_codeanalytique.Visible = false;
            // 
            // dg_CodeAnalytique
            // 
            this.dg_CodeAnalytique.AllowUserToAddRows = false;
            this.dg_CodeAnalytique.AllowUserToDeleteRows = false;
            this.dg_CodeAnalytique.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_CodeAnalytique.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_CodeAnalytique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_CodeAnalytique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_CodeAnalytique.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dg_CodeAnalytique.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_CodeAnalytique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_CodeAnalytique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_CodeAnalytique.GridColor = System.Drawing.Color.LightGreen;
            this.dg_CodeAnalytique.Location = new System.Drawing.Point(9, 156);
            this.dg_CodeAnalytique.Margin = new System.Windows.Forms.Padding(0);
            this.dg_CodeAnalytique.Name = "dg_CodeAnalytique";
            this.dg_CodeAnalytique.ReadOnly = true;
            this.dg_CodeAnalytique.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_CodeAnalytique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_CodeAnalytique.Size = new System.Drawing.Size(540, 203);
            this.dg_CodeAnalytique.TabIndex = 7;
            this.dg_CodeAnalytique.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CodeAnalytique_CellContentClick);
            this.dg_CodeAnalytique.SelectionChanged += new System.EventHandler(this.dg_CodeAnalytique_SelectionChanged);
            // 
            // Imp_CodeAnalytique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 412);
            this.Controls.Add(this.lbl_codeanalytique);
            this.Controls.Add(this.dg_CodeAnalytique);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imp_CodeAnalytique";
            this.Text = "Imp_CodeAnalytique";
            this.Load += new System.EventHandler(this.Imp_CodeAnalytique_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CodeAnalytique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_idFrais;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fournisseur;
        private System.Windows.Forms.TextBox txt_codeanalytique;
        private System.Windows.Forms.TextBox txt_activite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_recherch;
        private System.Windows.Forms.Label label15;
        private Class.ProgressDataGridView dg_CodeAnalytique;
        private System.Windows.Forms.Label lbl_codeanalytique;
    }
}