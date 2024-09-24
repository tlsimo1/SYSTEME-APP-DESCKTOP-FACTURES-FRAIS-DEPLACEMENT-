using Suivie_Facture.BL;
using Suivie_Facture.Class;
using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Suivie_Facture.Frais_deplacement
{
    public partial class Imp_CodeAnalytique : Form
    {
        PopupNotifier popup = new PopupNotifier();
        Code_AnalytiqueBL code_AnalytiqueBL = new Code_AnalytiqueBL();
        public Imp_CodeAnalytique()
        {
            InitializeComponent();
        }

        private void Imp_CodeAnalytique_Load(object sender, EventArgs e)
        {
            try
            {
                GetALLCodeActivite();
                DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Image = Properties.Resources.DELETE2;
                dg_CodeAnalytique.Columns.Add(btnDelete);
                if (dg_CodeAnalytique.Rows.Count > 0)
                {
                    dg_CodeAnalytique.Columns["ID_Analytique"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void GetALLCodeActivite()
        {
            try
            {
                dg_CodeAnalytique.DataSource = code_AnalytiqueBL.GetAll_CodeAnalytique();
                dg_CodeAnalytique.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg_CodeAnalytique.AllowUserToOrderColumns = true;
                dg_CodeAnalytique.AllowUserToResizeRows = true;
                dg_CodeAnalytique.AllowUserToAddRows = false;
                if (dg_CodeAnalytique.Rows.Count > 0)
                {
                    dg_CodeAnalytique.Columns["ID_Analytique"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dg_CodeAnalytique_SelectionChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            DateTime currentTime = DateTime.Now;
            try
            {
                if (dg_CodeAnalytique.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dg_CodeAnalytique.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dg_CodeAnalytique.Rows[selectedrowindex];
                    lbl_codeanalytique.Text = Convert.ToString(selectedRow.Cells["ID_Analytique"].Value);
                    txt_activite.Text = Convert.ToString(selectedRow.Cells["Activite_Service"].Value);
                    txt_codeanalytique.Text = Convert.ToString(selectedRow.Cells["Code_Analytique"].Value);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlDateTime sqldatenull;
            sqldatenull = SqlDateTime.Null;
            try
            {
                Code_Analytique codeAnalytique = new Code_Analytique();
                codeAnalytique.ID_Analytique = int.Parse(lbl_codeanalytique.Text);
                codeAnalytique.Activite_Service = txt_activite.Text;
                codeAnalytique.CodeAnalytique = txt_codeanalytique.Text;
                codeAnalytique.Activite_Service = txt_activite.Text;
                code_AnalytiqueBL.Update_CodeAnalytique(codeAnalytique);
                GetALLCodeActivite();

                popup.TitleText = "";
                popup.ContentText = "Enregistrement Modifié ";
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ResetFrorm();
            btn_save.Enabled = true;
        }
        void ResetFrorm()
        {
            txt_activite.Text = "";
            txt_codeanalytique.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Code_Analytique codeAnalytique = new Code_Analytique();
                //personnel.ID_Personnel = int.Parse(lblidPersonnel.Text);
                codeAnalytique.Activite_Service = txt_activite.Text;
                codeAnalytique.CodeAnalytique = txt_codeanalytique.Text;
                code_AnalytiqueBL.Insert_CodeAnalytique(codeAnalytique);
                popup.TitleText = "";
                popup.ContentText = "Enregistrement Ajouté ";
                popup.Popup();
                GetALLCodeActivite();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dg_CodeAnalytique_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_CodeAnalytique.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_CodeAnalytique.Rows[e.RowIndex];
                row.Selected = true;
                int codeAnalytique = int.Parse(dg_CodeAnalytique.Rows[e.RowIndex].Cells["ID_Analytique"].Value.ToString());

                if ((column == "btnDelete"))
                {
                    DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer l'enregistrement  ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        code_AnalytiqueBL.Delete_CodeAnalytique(codeAnalytique);
                        MessageBox.Show("Enregistrement Supprimé avec succés ");
                    }

                    popup.TitleText = "";
                    popup.ContentText = "Enregistrement supprimé ";
                    popup.Popup();
                    GetALLCodeActivite();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_recherch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dg_CodeAnalytique.Columns.Clear();
                dg_CodeAnalytique.DataSource = code_AnalytiqueBL.GetCodeAnalytique(txt_recherch.Text);
                DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Image = Properties.Resources.DELETE2;
                dg_CodeAnalytique.Columns.Add(btnDelete);

                if (dg_CodeAnalytique.Rows.Count > 0)
                {
                    dg_CodeAnalytique.Columns["ID_Analytique"].Visible = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
