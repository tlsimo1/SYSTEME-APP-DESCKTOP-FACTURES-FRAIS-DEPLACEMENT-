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
    public partial class Form_consultation : Form
    {
        public Form_consultation()
        {
            InitializeComponent();
            LoadDate();
            //DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
            //btnValide.Name = "btnValide";
            //btnValide.HeaderText = "";

            //btnValide.Image = Properties.Resources.icons8_in_progress_24px;
            //dg_Facture.Columns.Add(btnValide);

            DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
            btnDetail.Name = "btnDetail";
            btnDetail.HeaderText = "";
            btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;

            dg_Facture.Columns.Add(btnDetail);
        }
        Facture_BL facture_BL = new Facture_BL();
        private void Form_consultation_Load(object sender, EventArgs e)
        {
            //LoadDate();
            

            //dg_Facture.RowTemplate.Height = 30;

        }
        void LoadDate()
        {
            dg_Facture.DataSource = facture_BL.GetAllFacture();
            dg_Facture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_Facture.AllowUserToOrderColumns = true;
            dg_Facture.AllowUserToResizeRows = true;
            dg_Facture.AllowUserToAddRows = false;
            
        }

        private void dg_Facture_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_Facture.Columns[e.ColumnIndex].Name;
                if (column != "btnValide" && column != "btnDetail")
                    dg_Facture.Cursor = Cursors.Default;
                else
                    dg_Facture.Cursor = Cursors.Hand;

            }
            catch (Exception)
            {

                
            }
            
        }

        private void dg_Facture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = dg_Facture.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dg_Facture.Rows[e.RowIndex];
            string numFac = Convert.ToString(row.Cells[0].Value);
            row.Selected = true;
            if (numFac== "System.Drawing.Bitmap")
            {
                numFac = Convert.ToString(row.Cells[1].Value);
            }
            else
            {
                numFac = Convert.ToString(row.Cells[0].Value);
            }
            if (column == "btnDetail")
            {
                DataTable detailFacture = new DataTable();
                detailFacture = facture_BL.GetDetail(numFac);
                Form_Detail fr_detail = new Form_Detail(detailFacture);
                fr_detail.Show();
            }
            #region
            //string numFac = Convert.ToString(row.Cells[1].Value);
            //if(string.IsNullOrEmpty(numFac))
            //{
            //    numFac= Convert.ToString(row.Cells[0].Value);
            //}


            //if (column == "btnValide" && Variable.UserName == "assdaf")
            //{
            //    AssDAF_BL.Edit_Status(numFac);
            //    LoadDate();
            //}
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_recherch.Text))
            {
                dg_Facture.Columns.Clear();
                dg_Facture.DataSource = facture_BL.GetFacture(txt_recherch.Text);
                //DataGridViewImageColumn btnValide = new DataGridViewImageColumn();
                //btnValide.Name = "btnValide";
                //btnValide.HeaderText = "";

                //btnValide.Image = Properties.Resources.icons8_in_progress_24px;
                //dg_Facture.Columns.Add(btnValide);

                DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                btnDetail.Name = "btnDetail";
                btnDetail.HeaderText = "";
                btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                dg_Facture.Columns.Add(btnDetail);

                //dg_assdaf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //dg_assdaf.AllowUserToOrderColumns = true;
                //dg_assdaf.AllowUserToResizeRows = true;
                //dg_assdaf.AllowUserToAddRows = false;
            }
        }
    }
}
