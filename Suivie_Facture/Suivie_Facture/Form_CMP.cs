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
    public partial class Form_CMP : Form
    {
        Com_BL com_BL = new Com_BL();
        Facture_BL facture_BL = new Facture_BL();
        int StatutAchat = 0;
        string numFac = string.Empty;
        public Form_CMP()
        {
            InitializeComponent();
            LoadDate();
        }
        void LoadDate()
        {
            try
            {
                dg_assdaf.DataSource = com_BL.GetAllComFacture();
                dg_assdaf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg_assdaf.AllowUserToOrderColumns = true;
                dg_assdaf.AllowUserToResizeRows = true;
                dg_assdaf.AllowUserToAddRows = false;
                if(dg_assdaf.Rows.Count>1)
                {
                    dg_assdaf.Columns["Numero Facture"].Frozen = true;
                    dg_assdaf.Columns["Fournisseur"].Frozen = true;
                }
                dg_assdaf.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void Form_CMP_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDate();
                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";
                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_assdaf.Columns.Add(btnValide);

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                dg_assdaf.Columns.Add(btnDetail);

                dg_assdaf.Columns["Numero Facture"].Frozen = true;
                dg_assdaf.Columns["Fournisseur"].Frozen = true;
                dg_assdaf.Columns["ID_FAC"].Visible = false;
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
                string column = dg_assdaf.Columns[e.ColumnIndex].Name;
                if (column != "btnValide" && column != "btnDetail")
                    dg_assdaf.Cursor = Cursors.Default;
                else
                    dg_assdaf.Cursor = Cursors.Hand;
            }
            catch (Exception)
            {
                return;

            }
            //dg_assdaf.Columns["ID_FAC"].Visible = false;
        }

        private void dg_assdaf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_assdaf.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_assdaf.Rows[e.RowIndex];
                row.Selected = true;
                string numFac = Convert.ToString(row.Cells["ID_FAC"].Value);

                if ((column == "btnValide" && Variable.UserName != Variable.UserNameAdmin) || (column == "btnValide" && Variable.UserName == Variable.UserNameAdmin))
                {
                    StatutAchat = com_BL.GetStatutAchat(numFac);
                    if(StatutAchat==1)
                    {
                        com_BL.Edit_StatusFinal(numFac);
                    }
                    else
                    {
                        com_BL.Edit_StatusCom(numFac);
                    }
                    
                    LoadDate();
                }
                if (column == "btnDetail")
                {
                    DataTable detailFacture = new DataTable();
                    detailFacture = facture_BL.GetDetail(numFac);

                    Form_Detail fr_detail = new Form_Detail(detailFacture);
                    fr_detail.Show();


                }
                dg_assdaf.Columns["Numero Facture"].Frozen = true;
                dg_assdaf.Columns["Fournisseur"].Frozen = true;
                dg_assdaf.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void dg_assdaf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_assdaf.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_assdaf.Rows[e.RowIndex];
                row.Selected = true;
                numFac = Convert.ToString(row.Cells["ID_FAC"].Value);

                DataTable detailFacture = new DataTable();
                detailFacture = facture_BL.GetDetail(numFac);


                Form_Detail fr_detail = new Form_Detail(detailFacture);
                fr_detail.Show();
                dg_assdaf.Columns["ID_FAC"].Visible = false;
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
                dg_assdaf.Columns.Clear();
                dg_assdaf.DataSource = com_BL.GetFactureCmp(txt_recherch.Text);

                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";
                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_assdaf.Columns.Add(btnValide);

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                dg_assdaf.Columns.Add(btnDetail);

                dg_assdaf.Columns["Numero Facture"].Frozen = true;
                dg_assdaf.Columns["Fournisseur"].Frozen = true;
                dg_assdaf.Columns["ID_FAC"].Visible = false;
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
                dg_assdaf.Columns.Clear();
                dg_assdaf.DataSource = com_BL.GetFactureParDateCmp(DateTime.Parse(dt_recherch.Text));

                DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                btnValide.Name = "btnValide";
                btnValide.HeaderText = "";

                btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                dg_assdaf.Columns.Add(btnValide);
                dg_assdaf.Columns["Numero Facture"].Frozen = true;
                dg_assdaf.Columns["Fournisseur"].Frozen = true;

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

                dg_assdaf.Columns.Add(btnDetail);
                dg_assdaf.Columns["Numero Facture"].Frozen = true;
                dg_assdaf.Columns["Fournisseur"].Frozen = true;
                dg_assdaf.Columns["ID_FAC"].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
