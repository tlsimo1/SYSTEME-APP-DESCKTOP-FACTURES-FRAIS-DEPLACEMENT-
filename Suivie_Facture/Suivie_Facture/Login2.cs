using Suivie_Facture.BL;
using Suivie_Facture.Class;
using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Suivie_Facture
{
    public partial class Login2 : Form
    {
        Facture_BL factureBL = new Facture_BL();
        public Login2()
        {
            InitializeComponent();
            txt_login.Text = "UserName";
            txt_login.ForeColor = Color.LightGray;
            txt_password.ForeColor = Color.LightGray;
            txt_password.Text = "Password";
            txt_password.UseSystemPasswordChar = false;

            
        }
        private void txt_login_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
        }
        private void txt_login_Enter(object sender, EventArgs e)
        {
            if (txt_login.Text == "UserName")
            {
                txt_login.Text = "";
                txt_login.ForeColor = Color.Black;
            }
        }

        private void txt_login_Leave(object sender, EventArgs e)
        {
            if (txt_login.Text == "")
            {
                txt_login.Text = "UserName";
                txt_login.ForeColor = Color.LightGray;

            }
        }
        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.UseSystemPasswordChar = true;
            }
        }
        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.LightGray;
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            try
            {
                Variable.UserName = txt_login.Text;
                factureBL.LogIn(txt_login.Text, txt_password.Text);
                if (Variable.IsConnected == true)
                {
                    this.Hide();
                    var Home = new Home();
                    Home.Closed += (s, args) => this.Close();
                    Home.Show();
                }
                else
                {
                    MessageBox.Show("Login ou Mot de passe est incorrecte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_login_Click_2(object sender, EventArgs e)
        {
            //txt_login.Text = "admin";
            //txt_password.Text = "admin";

            try
            {
                Variable.UserName = txt_login.Text;
                factureBL.LogIn(txt_login.Text, txt_password.Text);
                if (Variable.IsConnected == true)
                {
                    this.Hide();
                    var Home = new Home02();
                    Home.Closed += (s, args) => this.Close();
                    Home.Show();
                }
                else
                {
                    MessageBox.Show("Login ou Mot de passe est incorrecte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void Login2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click_2(sender, e);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
          
        }
    }
}
