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
    public partial class Form_ACHAT : Form
    {
        Achat_BL achat_BL = new Achat_BL();
        Facture_BL facture_BL = new Facture_BL();
        string numFac = string.Empty;
        public Form_ACHAT()
        {
            InitializeComponent();
        }
        void LoadDate()
        {
            try
            {
                dg_achat.DataSource = achat_BL.GetAllFactureAchat();
                dg_achat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg_achat.AllowUserToOrderColumns = true;
                dg_achat.AllowUserToResizeRows = true;
                dg_achat.AllowUserToAddRows = false;
                if(dg_achat.Rows.Count>0)
                {
                    dg_achat.Columns["Numero Facture"].Frozen = true;
                    dg_achat.Columns["Fournisseur"].Frozen = true;
                }
                dg_achat.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void Form_ACHAT_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDate();
                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";

                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_achat.Columns.Add(btnValide);

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

                dg_achat.Columns.Add(btnDetail);
                dg_achat.Columns["Numero Facture"].Frozen = true;
                dg_achat.Columns["Fournisseur"].Frozen = true;
            }
            catch (Exception)
            {
                return;
                
            }
          
        }

        private void dg_achat_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dg_achat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void dg_achat_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_achat.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_achat.Rows[e.RowIndex];
                row.Selected = true;
                string numFac = Convert.ToString(row.Cells["ID_FAC"].Value);

                if ((column == "btnValide" && Variable.UserName != Variable.UserNameAdmin) || (column == "btnValide" && Variable.UserName == Variable.UserNameAdmin))
                {
                    achat_BL.Edit_StatusAchat(numFac);
                    LoadDate();
                }
                if (column == "btnDetail")
                {
                    DataTable detailFacture = new DataTable();
                    detailFacture = facture_BL.GetDetail(numFac);


                    Form_Detail fr_detail = new Form_Detail(detailFacture);
                    fr_detail.Show();
                }
                dg_achat.Columns["Numero Facture"].Frozen = true;
                dg_achat.Columns["Fournisseur"].Frozen = true;
            }
            catch (Exception)
            {

                return;
            }
           // dg_achat.Columns["ID_FAC"].Visible = false;
        }

        private void dg_achat_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_achat.Columns[e.ColumnIndex].Name;
                if (column != "btnValide" && column != "btnDetail")
                    dg_achat.Cursor = Cursors.Default;
                else
                    dg_achat.Cursor = Cursors.Hand;
            }
            catch (Exception)
            {
                return;

            }
            //dg_achat.Columns["ID_FAC"].Visible = false;
        }

        private void dg_achat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_achat.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_achat.Rows[e.RowIndex];
                row.Selected = true;
                numFac = Convert.ToString(row.Cells["ID_FAC"].Value);

                DataTable detailFacture = new DataTable();
                detailFacture = facture_BL.GetDetail(numFac);


                Form_Detail fr_detail = new Form_Detail(detailFacture);
                fr_detail.Show();
                //dg_achat.Columns["ID_FAC"].Visible = false;
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
                dg_achat.Columns.Clear();
                dg_achat.DataSource = achat_BL.GetFactureAchat(txt_recherch.Text);
                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";

                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_achat.Columns.Add(btnValide);

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

                dg_achat.Columns.Add(btnDetail);
                dg_achat.Columns["Numero Facture"].Frozen = true;
                dg_achat.Columns["Fournisseur"].Frozen = true;
                dg_achat.Columns["ID_FAC"].Visible = false;
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
                dg_achat.Columns.Clear();
                dg_achat.DataSource = achat_BL.GetFactureParDateAchat(DateTime.Parse(dt_recherch.Text));

                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";

                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_achat.Columns.Add(btnValide);
                dg_achat.Columns["Numero Facture"].Frozen = true;
                dg_achat.Columns["Fournisseur"].Frozen = true;

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

                dg_achat.Columns.Add(btnDetail);
                dg_achat.Columns["Numero Facture"].Frozen = true;
                dg_achat.Columns["Fournisseur"].Frozen = true;
                dg_achat.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
