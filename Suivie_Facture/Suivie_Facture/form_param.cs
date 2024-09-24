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
    public partial class form_param : Form
    {
        User_BL UserBl = new User_BL();
        public form_param()
        {
            InitializeComponent();
            try
            {
                LoadDate();
                if (Variable.UserName == Variable.UserNameAdmin)
                {
                    DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                    btnDelete.Name = "btnDelete";
                    btnDelete.HeaderText = "";
                    btnDelete.Image = Properties.Resources.DELETE2;
                    dg_param2.Columns.Add(btnDelete);
                }
                //dg_param.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //dg_param.AllowUserToOrderColumns = true;
                //dg_param.AllowUserToResizeRows = true;
                //dg_param.AllowUserToAddRows = false;
                //this.dg_param.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //this.dg_param.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //this.dg_param.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cmb_user.Text = "Selected Value";
            }    
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_username.Enabled = false;
        }
        void LoadDate()
        {
            try
            {
                DataTable dt = new DataTable();
                // DataTable dt_ComBox = new DataTable();
                dt = UserBl.GetAllUser();
                dg_param2.DataSource = UserBl.GetAllUser();

                txt_username.Text = dt.Rows[0][0].ToString();
                txt_password.Text = dt.Rows[0][1].ToString();
                cmb_user.DisplayMember = dt.Rows[0][2].ToString();

                //dt_ComBox = UserBl.RemplirComBox();
                //DataRow row = dt_ComBox.NewRow();
                //row[0] = 0;
                //row[1] = "Please select";
                //dt_ComBox.Rows.InsertAt(row, 0);

                ////Assign DataTable as DataSource.
                //cmb_user.DataSource = dt_ComBox;
                //cmb_user.DisplayMember = "Role";
                //cmb_user.ValueMember = "Role";

                //this.dg_param.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //this.dg_param.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //this.dg_param.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (Exception)
            {
                return;
            }
            
        }


        private void dg_param_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //private void dg_param_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        string column = dg_param.Columns[e.ColumnIndex].Name;
        //        DataGridViewRow row = dg_param.Rows[e.RowIndex];
        //        row.Selected = true;
        //        txt_username.Text = dg_param.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
        //        txt_password.Text = dg_param.Rows[e.RowIndex].Cells["Password"].Value.ToString();
        //        cmb_user.Text = dg_param.Rows[e.RowIndex].Cells["Role"].Value.ToString();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
            cmb_user.Text = "Selected Value";
            txt_username.Enabled = true;
            
        }
        private void btn_prm_Click(object sender, EventArgs e)
        {
            try
            {
                Variable.IsExist = UserBl.ChekIsExist(txt_username.Text);
                if (Variable.IsExist == false)
                {
                    if(cmb_user.Text == "Selected Value" || txt_username.Text==""|| txt_password.Text == "")
                    {
                        MessageBox.Show("Merci de remplir tous les champs");
                    }
                    else
                    {
                        UserBl.AjouterUser(txt_username.Text, txt_password.Text, cmb_user.Text);
                        MessageBox.Show("Ajouter avec succés");
                        LoadDate();
                    }
                }
                else
                {
                    UserBl.UpdateUser(txt_username.Text, txt_password.Text, cmb_user.Text);
                    MessageBox.Show("Modifier avec succés");
                    LoadDate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dg_param_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataGridViewRow row = dg_param.Rows[e.RowIndex];
            //    row.Selected = true;
            //    txt_username.Text = dg_param.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            //    txt_password.Text = dg_param.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            //    cmb_user.Text = dg_param.Rows[e.RowIndex].Cells["Role"].Value.ToString();
            //}
            //catch (Exception)
            //{
            //}
        }

        private void dg_param_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataGridViewRow row = dg_param.Rows[e.RowIndex];
            //    row.Selected = true;
            //    txt_username.Text = dg_param.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            //    txt_password.Text = dg_param.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            //    cmb_user.Text = dg_param.Rows[e.RowIndex].Cells["Role"].Value.ToString();
            //}
            //catch (Exception)
            //{
            //}
        }

        private void dg_param_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    string username = string.Empty;
            //    string column = dg_param.Columns[e.ColumnIndex].Name;
            //    //string column = dg_param.Columns[e.ColumnIndex].Name;
            //    if (column == "btnDelete")
            //    {
            //        username = dg_param.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            //        DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer User " + username + " ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //        if (res == DialogResult.OK)
            //        {
            //            UserBl.DeleteUser(username);
            //            MessageBox.Show("Supprimer avec succés ");
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //LoadDate();
        }
        private void dg_param1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dg_param1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dg_param1_Click(object sender, EventArgs e)
        {
        }

        private void dg_param1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dg_param2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string username = string.Empty;
                string column = dg_param2.Columns[e.ColumnIndex].Name;
                //string column = dg_param.Columns[e.ColumnIndex].Name;
                if (column == "btnDelete")
                {
                    username = dg_param2.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                    DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer User " + username + " ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        UserBl.DeleteUser(username);
                        MessageBox.Show("Supprimer avec succés ");
                    }
                    LoadDate();
                }
                else
                {
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void dg_param2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dg_param2.SelectedRows)
                {
                    txt_username.Text = row.Cells["UserName"].Value.ToString();
                    txt_password.Text = row.Cells["Password"].Value.ToString();
                    cmb_user.Text = row.Cells["Role"].Value.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
           

        }

        private void dg_param2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dg_param2.SelectedRows)
                {
                    txt_username.Text = row.Cells["UserName"].Value.ToString();
                    txt_password.Text = row.Cells["Password"].Value.ToString();
                    cmb_user.Text = row.Cells["Role"].Value.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
