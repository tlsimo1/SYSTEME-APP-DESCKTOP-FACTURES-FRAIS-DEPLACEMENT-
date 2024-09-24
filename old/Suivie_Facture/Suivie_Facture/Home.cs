using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.pnl_main.Controls.Count > 0)
                this.pnl_main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(f);
            this.pnl_main.Tag = f;
            f.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            loadform(new Form_BDR());
            if (Variable.UserName == "admin") { 
                btn_achat.Enabled = true;
                btn_assdaf.Enabled = true;
                btn_bdr.Enabled = true;
                btn_cmp.Enabled = true; 
            };
            if (Variable.UserName == "bdr") {
                btn_achat.Enabled = false;
                btn_achat.BackColor = Color.Green;
                btn_assdaf.Enabled = false;
                btn_assdaf.BackColor = Color.Green;
                btn_bdr.Enabled = true;
                btn_cmp.Enabled = false;
                btn_cmp.BackColor = Color.Green;
            };
            if (Variable.UserName == "com") 
            { 
                btn_achat.Enabled = false;
                btn_achat.BackColor = Color.Green;
                btn_assdaf.Enabled = false;
                btn_assdaf.BackColor = Color.Green;
                btn_bdr.Enabled = false;
                btn_bdr.BackColor = Color.Green;
                btn_cmp.Enabled = true;
            };
            if (Variable.UserName == "achat") { 
                btn_achat.Enabled = true;
                btn_assdaf.Enabled = false;
                btn_assdaf.BackColor = Color.Green;
                btn_bdr.Enabled = false;
                btn_bdr.BackColor = Color.Green;
                btn_cmp.Enabled = false;
                btn_cmp.BackColor = Color.Green;
            };
            if (Variable.UserName == "assdaf") { 
                btn_achat.Enabled = false;
                btn_achat.BackColor = Color.Green;
                btn_assdaf.Enabled = true;
                btn_bdr.Enabled = false;
                btn_bdr.BackColor = Color.Green;
                btn_cmp.Enabled = false;
                btn_cmp.BackColor = Color.Green;
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Form_BDR());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Form_ASSDAF());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Form_CMP());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Form_ACHAT());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new Form_consultation());
        }
    }
}
