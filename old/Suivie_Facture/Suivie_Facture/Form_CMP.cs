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
        public Form_CMP()
        {
            InitializeComponent();
            LoadDate();
        }
        void LoadDate()
        {
            dg_assdaf.DataSource = com_BL.GetAllComFacture();
            dg_assdaf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_assdaf.AllowUserToOrderColumns = true;
            dg_assdaf.AllowUserToResizeRows = true;
            dg_assdaf.AllowUserToAddRows = false;

        }

        private void Form_CMP_Load(object sender, EventArgs e)
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


            }
        }

        private void dg_assdaf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = dg_assdaf.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dg_assdaf.Rows[e.RowIndex];
            row.Selected = true;
            string numFac = Convert.ToString(row.Cells["Numero Facture"].Value);

            if ((column == "btnValide" && Variable.UserName == "assdaf") || (column == "btnValide" && Variable.UserName == "admin"))
            {
                com_BL.Edit_StatusCom(numFac);
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
    }
}
