using Suivie_Facture.BL;
using Suivie_Facture.Class;
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
        public Form_ASSDAF()
        {
            InitializeComponent();
        }
        void LoadDate()
        {
            dg_cmp.DataSource = AssDAF_BL.GetAllAssDAFFacture();
            dg_cmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_cmp.AllowUserToOrderColumns = true;
            dg_cmp.AllowUserToResizeRows = true;
            dg_cmp.AllowUserToAddRows = false;

        }

        private void Form_ASSDAF_Load(object sender, EventArgs e)
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

                
            }
            
        }

        private void dg_assdaf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = dg_cmp.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dg_cmp.Rows[e.RowIndex];
            row.Selected = true;
            string numFac = Convert.ToString(row.Cells["Numero Facture"].Value);

            if ((column == "btnValide" && Variable.UserName == "assdaf") || (column == "btnValide" && Variable.UserName == "admin"))
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

        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
           
        }

        //private void btn_serch_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txt_serch.Text))
        //    {
        //        dg_assdaf.DataSource = facture_BL.GetFacture(txt_serch.Text);
        //        //dg_assdaf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //        //dg_assdaf.AllowUserToOrderColumns = true;
        //        //dg_assdaf.AllowUserToResizeRows = true;
        //        //dg_assdaf.AllowUserToAddRows = false;
        //    }
        //}
    }
}
