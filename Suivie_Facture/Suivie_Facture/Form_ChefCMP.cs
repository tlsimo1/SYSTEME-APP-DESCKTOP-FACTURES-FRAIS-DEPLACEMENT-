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
    public partial class Form_ChefCMP : Form
    {
        ChefCmp_BL Chefcmp_BL = new ChefCmp_BL();
        Facture_BL facture_BL = new Facture_BL();
        string numFac = string.Empty;
        public Form_ChefCMP()
        {
            InitializeComponent();
        }
        void LoadDate()
        {
            try
            {
                dg_chefcmp.DataSource = Chefcmp_BL.GetAllChefComFacture();
                dg_chefcmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg_chefcmp.AllowUserToOrderColumns = true;
                dg_chefcmp.AllowUserToResizeRows = true;
                dg_chefcmp.AllowUserToAddRows = false;
                if(dg_chefcmp.Rows.Count>0)
                {
                    dg_chefcmp.Columns["Numero Facture"].Frozen = true;
                    dg_chefcmp.Columns["Fournisseur"].Frozen = true;
                }
                dg_chefcmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void Form_ChefCMP_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDate();
                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";
                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_chefcmp.Columns.Add(btnValide);

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                dg_chefcmp.Columns.Add(btnDetail);
                dg_chefcmp.Columns["Numero Facture"].Frozen = true;
                dg_chefcmp.Columns["Fournisseur"].Frozen = true;
                dg_chefcmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dg_chefcmp_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_chefcmp.Columns[e.ColumnIndex].Name;
                if (column != "btnValide" && column != "btnDetail")
                    dg_chefcmp.Cursor = Cursors.Default;
                else
                    dg_chefcmp.Cursor = Cursors.Hand;
            }
            catch (Exception)
            {

                return;
            }
            //dg_chefcmp.Columns["ID_FAC"].Visible = false;
        }

        private void dg_chefcmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_chefcmp.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_chefcmp.Rows[e.RowIndex];
                row.Selected = true;
                string numFac = Convert.ToString(row.Cells["ID_FAC"].Value);

                if ((column == "btnValide" && Variable.UserName != Variable.UserNameAdmin) || (column == "btnValide" && Variable.UserName == Variable.UserNameAdmin))
                {
                    Chefcmp_BL.Edit_StatusChefCom(numFac);
                    LoadDate();
                }
                if (column == "btnDetail")
                {
                    DataTable detailFacture = new DataTable();
                    detailFacture = facture_BL.GetDetail(numFac);


                    Form_Detail fr_detail = new Form_Detail(detailFacture);
                    fr_detail.Show();


                }
                dg_chefcmp.Columns["Numero Facture"].Frozen = true;
                dg_chefcmp.Columns["Fournisseur"].Frozen = true;
                dg_chefcmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;

            }
            
        }

        private void dg_chefcmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_chefcmp.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_chefcmp.Rows[e.RowIndex];
                row.Selected = true;
                numFac = Convert.ToString(row.Cells["ID_FAC"].Value);

                DataTable detailFacture = new DataTable();
                detailFacture = facture_BL.GetDetail(numFac);


                Form_Detail fr_detail = new Form_Detail(detailFacture);
                fr_detail.Show();
                //dg_chefcmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
           
        }

        private void txt_recherch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dg_chefcmp.Columns.Clear();
                dg_chefcmp.DataSource = Chefcmp_BL.GetFactureChefCmp(txt_recherch.Text);
                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";
                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_chefcmp.Columns.Add(btnValide);

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                dg_chefcmp.Columns.Add(btnDetail);
                dg_chefcmp.Columns["Numero Facture"].Frozen = true;
                dg_chefcmp.Columns["Fournisseur"].Frozen = true;
                dg_chefcmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void dt_recherch_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dg_chefcmp.Columns.Clear();
                dg_chefcmp.DataSource = Chefcmp_BL.GetFactureParDateChefCmp(DateTime.Parse(dt_recherch.Text));

                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";

                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_chefcmp.Columns.Add(btnValide);
                dg_chefcmp.Columns["Numero Facture"].Frozen = true;
                dg_chefcmp.Columns["Fournisseur"].Frozen = true;

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

                dg_chefcmp.Columns.Add(btnDetail);
                dg_chefcmp.Columns["Numero Facture"].Frozen = true;
                dg_chefcmp.Columns["Fournisseur"].Frozen = true;
                dg_chefcmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
