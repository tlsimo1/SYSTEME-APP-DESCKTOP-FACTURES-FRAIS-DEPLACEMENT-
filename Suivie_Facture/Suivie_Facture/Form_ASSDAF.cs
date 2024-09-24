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
    public partial class Form_ASSDAF : Form
    {
        AssDAF_BL AssDAF_BL = new AssDAF_BL();
        Facture_BL facture_BL = new Facture_BL();
        string numFac = string.Empty;
        public Form_ASSDAF()
        {
            InitializeComponent();
        }
        void LoadDate()
        {
            try
            {
                dg_cmp.DataSource = AssDAF_BL.GetAllAssDAFFacture();
                dg_cmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg_cmp.AllowUserToOrderColumns = true;
                dg_cmp.AllowUserToResizeRows = true;
                dg_cmp.AllowUserToAddRows = false;
                if(dg_cmp.Rows.Count>0)
                {
                    dg_cmp.Columns["Numero Facture"].Frozen = true;
                    dg_cmp.Columns["Fournisseur"].Frozen = true;
                }
                dg_cmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
                
            }

        }

        private void Form_ASSDAF_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDate();
                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";

                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_cmp.Columns.Add(btnValide);

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

                dg_cmp.Columns.Add(btnDetail);
                if(dg_cmp.Rows.Count>0)
                {
                    dg_cmp.Columns["Numero Facture"].Frozen = true;
                    dg_cmp.Columns["Fournisseur"].Frozen = true;
                }
                dg_cmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void dg_assdaf_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_cmp.Columns[e.ColumnIndex].Name;
                if (column != "btnValide" && column != "btnDetail")
                    dg_cmp.Cursor = Cursors.Default;
                else
                    dg_cmp.Cursor = Cursors.Hand;
            }
            catch (Exception)
            {
                return;
            }
            //dg_cmp.Columns["ID_FAC"].Visible = false;
        }

        private void dg_assdaf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_cmp.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_cmp.Rows[e.RowIndex];
                row.Selected = true;
                string numFac = dg_cmp.Rows[e.RowIndex].Cells["ID_FAC"].Value.ToString();

                if ((column == "btnValide" && Variable.UserName != Variable.UserNameAdmin || (column == "btnValide" && Variable.UserName ==Variable.UserNameAdmin)))
                {
                    AssDAF_BL.Edit_Status(numFac);
                    LoadDate();
                }
                if (column == "btnDetail")
                {
                    DataTable detailFacture = new DataTable();
                    detailFacture = facture_BL.GetDetail(numFac);

                    Form_Detail fr_detail = new Form_Detail(detailFacture);
                    fr_detail.Show();
                }
                dg_cmp.Columns["Numero Facture"].Frozen = true;
                dg_cmp.Columns["Fournisseur"].Frozen = true;
            }
            catch (Exception)
            {
                return;
            }
            

        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
        }

        private void dg_cmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_cmp.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_cmp.Rows[e.RowIndex];
                row.Selected = true;
                numFac = Convert.ToString(row.Cells["ID_FAC"].Value);

                DataTable detailFacture = new DataTable();
                detailFacture = facture_BL.GetDetail(numFac);


                Form_Detail fr_detail = new Form_Detail(detailFacture);
                fr_detail.Show();
                //dg_cmp.Columns["ID_FAC"].Visible = false;
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
                dg_cmp.Columns.Clear();
                dg_cmp.DataSource = AssDAF_BL.GetFactureAssDaf(txt_recherch.Text);
                
                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";

                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_cmp.Columns.Add(btnValide);
                dg_cmp.Columns["Numero Facture"].Frozen = true;
                dg_cmp.Columns["Fournisseur"].Frozen = true;

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

                dg_cmp.Columns.Add(btnDetail);
                dg_cmp.Columns["Numero Facture"].Frozen = true;
                dg_cmp.Columns["Fournisseur"].Frozen = true;
                dg_cmp.Columns["ID_FAC"].Visible = false;
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
                dg_cmp.Columns.Clear();
                dg_cmp.DataSource = AssDAF_BL.GetFactureParDateAssDaf(DateTime.Parse(dt_recherch.Text));

                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";

                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_cmp.Columns.Add(btnValide);
                dg_cmp.Columns["Numero Facture"].Frozen = true;
                dg_cmp.Columns["Fournisseur"].Frozen = true;

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

                dg_cmp.Columns.Add(btnDetail);
                dg_cmp.Columns["Numero Facture"].Frozen = true;
                dg_cmp.Columns["Fournisseur"].Frozen = true;
                dg_cmp.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
