using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture
{
    public partial class Home : Form
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);
        public Home()
        {
            InitializeComponent();
           
        }
        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);
                const int WM_NCPAINT = 0x85;
                if (m.Msg == WM_NCPAINT)
                {
                    IntPtr hdc = GetWindowDC(m.HWnd);
                    if ((int)hdc != 0)
                    {
                        Graphics g = Graphics.FromHdc(hdc);
                        g.FillRectangle(Brushes.Green, new Rectangle(0, 0, 4800, 23));
                        g.Flush();
                        ReleaseDC(m.HWnd, hdc);
                    }
                }
            }
            catch (Exception)
            {

                return;
            }
           
        }
        public Home(int n)
        {
            InitializeComponent();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var log = new Login2();
                log.Closed += (s, args) => this.Close();
                log.Show();
            }
            catch (Exception)
            {

                return;
            }
           
        }
        

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {
        }
        public void loadform(object Form)
        {
            try
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
            catch (Exception)
            {

                return;
            }
            
        }
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_BDR());
                if (Variable.GetRol.ToLower() == "admin")
                {
                    btn_achat.Enabled = true;
                    btn_assdaf.Enabled = true;
                    btn_bdr.Enabled = true;
                    btn_cmp.Enabled = true;
                    btn_chefCMP.Enabled = true;
                    btn_prm.Enabled = true;
                };
                if (Variable.GetRol.ToLower() == "br")
                {
                    btn_achat.Visible = false;
                    btn_achat.BackColor = Color.Gray;
                    btn_assdaf.Visible = false;
                    btn_assdaf.BackColor = Color.Gray;
                    btn_bdr.Enabled = true;
                    btn_cmp.Visible = false;
                    btn_cmp.BackColor = Color.Gray;
                    btn_chefCMP.Visible = false;
                    btn_chefCMP.BackColor = Color.Gray;
                    btn_consultation.Location = new Point(12, 227);

                    btn_bl.Visible = false;
                    btn_bl.BackColor = Color.Gray;
                    btn_prm.Visible = false;
                    button1_Click(sender, e);

                };
                if (Variable.GetRol.ToLower() == "cmp")
                {
                    btn_achat.Visible = false;
                    btn_achat.BackColor = Color.Gray;
                    btn_assdaf.Visible = false;
                    btn_assdaf.BackColor = Color.Gray;
                    btn_bdr.Visible = false;
                    btn_bdr.BackColor = Color.Gray;
                    btn_cmp.Enabled = true;
                    btn_cmp.Location = new Point(12, 183);
                    btn_chefCMP.Visible = false;
                    btn_chefCMP.BackColor = Color.Gray;
                    btn_consultation.Visible = true;
                    btn_consultation.Location = new Point(12, 227);
                    btn_bl.Visible = false;
                    btn_bl.BackColor = Color.Gray;
                    btn_prm.Visible = false;
                    button3_Click(sender, e);
                };
                if (Variable.GetRol.ToLower() == "achat")
                {
                    btn_achat.Enabled = true;
                    btn_assdaf.Visible = false;
                    btn_assdaf.BackColor = Color.Gray;
                    btn_bdr.Visible = false;
                    btn_bdr.BackColor = Color.Gray;
                    btn_cmp.Visible = false;
                    btn_cmp.BackColor = Color.Gray;
                    btn_chefCMP.Visible = false;
                    btn_chefCMP.BackColor = Color.Gray;
                    btn_bl.Visible = false;
                    btn_bl.BackColor = Color.Gray;


                    btn_prm.Visible = false;
                    btn_achat.Location = new Point(12, 183);
                    btn_consultation.Location = new Point(12, 227);

                    button4_Click(sender, e);
                };
                if (Variable.GetRol.ToLower() == "ass")
                {
                    btn_achat.Visible = false;
                    btn_achat.BackColor = Color.Gray;
                    btn_assdaf.Enabled = true;
                    btn_bdr.Visible = false;
                    btn_bdr.BackColor = Color.Gray;
                    btn_cmp.Visible = false;
                    btn_cmp.BackColor = Color.Gray;
                    btn_chefCMP.Visible = false;
                    btn_chefCMP.BackColor = Color.Gray;

                    btn_bl.Visible = false;
                    btn_bl.BackColor = Color.Gray;

                    btn_prm.Visible = false;
                    btn_assdaf.Location = new Point(12, 183);
                    btn_consultation.Location = new Point(12, 227);

                    button2_Click(sender, e);
                };
                if (Variable.GetRol.ToLower() == "chefcmp")
                {
                    btn_achat.Visible = false;
                    btn_achat.BackColor = Color.Gray;

                    btn_chefCMP.Enabled = true;

                    btn_bdr.Visible = false;
                    btn_bdr.BackColor = Color.Gray;

                    btn_cmp.Visible = false;
                    btn_cmp.BackColor = Color.Gray;

                    btn_assdaf.Visible = false;
                    btn_assdaf.BackColor = Color.Gray;

                    btn_prm.Visible = false;

                    btn_bl.Visible = false;
                    btn_bl.BackColor = Color.Gray;

                    btn_chefCMP.Location = new Point(12, 183);
                    btn_consultation.Location = new Point(12, 227);
                    button2_Click(sender, e);
                };
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_BDR());
            }
            catch (Exception)
            {

                return;
            }
            
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ASSDAF());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_CMP());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ACHAT());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_consultation());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void btn_chefCMP_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_ChefCMP());
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void btn_prm_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new form_param());
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void btn_bl_Click(object sender, EventArgs e)
        {
            try
            {
                loadform(new Form_BL());
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
