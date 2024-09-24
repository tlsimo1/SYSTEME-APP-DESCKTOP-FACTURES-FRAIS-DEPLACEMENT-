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

namespace Suivie_Facture
{
    public partial class Login2 : Form
    {
        Facture_BL factureBL = new Facture_BL();
        public Login2()
        {
            InitializeComponent();
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            //txt_login.BackColor = Color.White;
            //lbl_login.BackColor = Color.White;
            //txt_password.BackColor = SystemColors.Control;
            //lbl_password.BackColor = SystemColors.Control;
            
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            //txt_password.BackColor = Color.White;
            //lbl_password.BackColor = Color.White;
            //txt_login.BackColor = SystemColors.Control;
            //lbl_login.BackColor = SystemColors.Control;
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
            try
            {
                factureBL.LogIn(txt_login.Text,txt_password.Text);
                if(Variable.IsConnected==true)
                {
                    Variable.UserName = txt_login.Text;
                    Home h = new Home();
                    h.Show();
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
    }
}
