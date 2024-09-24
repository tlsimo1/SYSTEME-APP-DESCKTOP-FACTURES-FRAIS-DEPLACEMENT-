namespace Suivie_Facture
{
    partial class form_param
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_user = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_prm = new System.Windows.Forms.Button();
            this.dg_param2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_param2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cmb_user);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Controls.Add(this.btn_prm);
            this.groupBox1.Location = new System.Drawing.Point(11, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmb_user
            // 
            this.cmb_user.FormattingEnabled = true;
            this.cmb_user.Items.AddRange(new object[] {
            "Selected Value",
            "admin",
            "achat",
            "cmp",
            "ass",
            "br",
            "chefcmp"});
            this.cmb_user.Location = new System.Drawing.Point(440, 18);
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.Size = new System.Drawing.Size(121, 21);
            this.cmb_user.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(273, 19);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 5;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(82, 19);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 4;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new.Image = global::Suivie_Facture.Properties.Resources.icons8_add_new_24px;
            this.btn_new.Location = new System.Drawing.Point(648, 11);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(38, 34);
            this.btn_new.TabIndex = 12;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_prm
            // 
            this.btn_prm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_prm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_prm.Image = global::Suivie_Facture.Properties.Resources.icons8_save_close_32px_1;
            this.btn_prm.Location = new System.Drawing.Point(580, 11);
            this.btn_prm.Name = "btn_prm";
            this.btn_prm.Size = new System.Drawing.Size(49, 34);
            this.btn_prm.TabIndex = 11;
            this.btn_prm.UseVisualStyleBackColor = false;
            this.btn_prm.Click += new System.EventHandler(this.btn_prm_Click);
            // 
            // dg_param2
            // 
            this.dg_param2.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_param2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_param2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_param2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg_param2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_param2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_param2.GridColor = System.Drawing.Color.LightGreen;
            this.dg_param2.Location = new System.Drawing.Point(9, 21);
            this.dg_param2.Margin = new System.Windows.Forms.Padding(0);
            this.dg_param2.Name = "dg_param2";
            this.dg_param2.ReadOnly = true;
            this.dg_param2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_param2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_param2.Size = new System.Drawing.Size(717, 163);
            this.dg_param2.TabIndex = 4;
            this.dg_param2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_param2_CellContentClick);
            this.dg_param2.SelectionChanged += new System.EventHandler(this.dg_param2_SelectionChanged);
            this.dg_param2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_param2_KeyDown);
            // 
            // form_param
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.dg_param2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_param";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_param2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_param;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_prm;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ComboBox cmb_user;
        private System.Windows.Forms.DataGridView dg_param2;
    }
}