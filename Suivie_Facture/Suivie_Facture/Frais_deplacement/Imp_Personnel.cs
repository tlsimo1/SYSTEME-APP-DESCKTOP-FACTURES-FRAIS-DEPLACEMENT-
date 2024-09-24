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
    public partial class Imp_Personnel : Form
    {
        public Imp_Personnel()
        {
            InitializeComponent();
        }
        PopupNotifier popup = new PopupNotifier();
        Code_AnalytiqueBL Code_Analytique_BL = new Code_AnalytiqueBL();
        PersonnelBL personnelBL = new PersonnelBL();
        private void Imp_Personnel_Load(object sender, EventArgs e)
        {
            try
            {
                ReplirComBobox();
                GetALLPersonnel();
                DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Image = Properties.Resources.DELETE2;
                dg_Personnel.Columns.Add(btnDelete);
                if (dg_Personnel.Rows.Count > 0)
                {
                    dg_Personnel.Columns["ID_Personnel"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ReplirComBobox()
        {
            cmb_codeAnalytique.DataSource = Code_Analytique_BL.GetAll_CodeAnalytique();
            cmb_codeAnalytique.DisplayMember = "Code_Analytique";
            cmb_codeAnalytique.ValueMember = "ID_Analytique";
            cmb_codeAnalytique.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_codeAnalytique.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void GetALLPersonnel()
        {
            try
            {
                dg_Personnel.DataSource = personnelBL.GetAllPersonnel();
                dg_Personnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg_Personnel.AllowUserToOrderColumns = true;
                dg_Personnel.AllowUserToResizeRows = true;
                dg_Personnel.AllowUserToAddRows = false;
                if (dg_Personnel.Rows.Count > 0)
                {
                    dg_Personnel.Columns["ID_Personnel"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void dg_Personnel_SelectionChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            DateTime currentTime = DateTime.Now;
            try
            {
                if (dg_Personnel.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dg_Personnel.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dg_Personnel.Rows[selectedrowindex];
                    lblidPersonnel.Text = Convert.ToString(selectedRow.Cells["ID_Personnel"].Value);
                    cmb_codeAnalytique.Text = Convert.ToString(selectedRow.Cells["Code_Analytique"].Value);
                    txt_mat.Text = Convert.ToString(selectedRow.Cells["Matricule"].Value);
                    txt_nom.Text = Convert.ToString(selectedRow.Cells["Nom"].Value);
                    txt_activiteservice.Text = Convert.ToString(selectedRow.Cells["Activite_Service"].Value);
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
                Personnel personnel = new Personnel();
                personnel.ID_Personnel = int.Parse(lblidPersonnel.Text);
                personnel.Matricule = txt_mat.Text;
                personnel.Nom = txt_nom.Text;
                personnel.Activite_Service = txt_activiteservice.Text;
                personnel.Analytique_id = int.Parse(cmb_codeAnalytique.SelectedValue.ToString());
                personnelBL.Update_Personnel(personnel);
                GetALLPersonnel();
                popup.TitleText = "";
                popup.ContentText = "Enregistrement Modifié ";
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            ResetForm();
        }
        void ResetForm()
        {
            txt_activiteservice.Text = "";
            txt_mat.Text = "";
            txt_nom.Text = "";
            cmb_codeAnalytique.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Personnel personnel = new Personnel();
                //personnel.ID_Personnel = int.Parse(lblidPersonnel.Text);
                personnel.Matricule =txt_mat.Text;
                personnel.Nom = txt_nom.Text;
                personnel.Activite_Service = txt_activiteservice.Text;
                personnel.Analytique_id = int.Parse(cmb_codeAnalytique.SelectedValue.ToString());
                personnelBL.Insert_Personnel(personnel);
                popup.TitleText = "";
                popup.ContentText = "Enregistrement Ajouté ";
                popup.Popup();
                GetALLPersonnel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_Personnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_Personnel.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_Personnel.Rows[e.RowIndex];
                row.Selected = true;
                int IdPersonnel = int.Parse(dg_Personnel.Rows[e.RowIndex].Cells["ID_Personnel"].Value.ToString());
                if ((column == "btnDelete"))
                {
                    DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer l'enregistrement  ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        personnelBL.Delete_Personnel(IdPersonnel);
                        MessageBox.Show("Enregistrement Supprimé avec succés ");
                    }
                    popup.TitleText = "";
                    popup.ContentText = "Enregistrement supprimé ";
                    popup.Popup();
                    GetALLPersonnel();
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
                dg_Personnel.Columns.Clear();
                dg_Personnel.DataSource = personnelBL.GetPersonnel(txt_recherch.Text);
                DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Image = Properties.Resources.DELETE2;
                dg_Personnel.Columns.Add(btnDelete);
                if (dg_Personnel.Rows.Count > 0)
                {
                    dg_Personnel.Columns["ID_Personnel"].Visible = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
