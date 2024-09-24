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
        public Form_ACHAT()
        {
            InitializeComponent();
        }
        void LoadDate()
        {
            dg_achat.DataSource = achat_BL.GetAllFactureAchat();
            dg_achat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_achat.AllowUserToOrderColumns = true;
            dg_achat.AllowUserToResizeRows = true;
            dg_achat.AllowUserToAddRows = false;

        }

        private void Form_ACHAT_Load(object sender, EventArgs e)
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
        }

        private void dg_achat_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
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


            }
        }

        private void dg_achat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = dg_achat.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dg_achat.Rows[e.RowIndex];
            row.Selected = true;
            string numFac = Convert.ToString(row.Cells["Numero Facture"].Value);

            if ((column == "btnValide" && Variable.UserName == "assdaf") || (column == "btnValide" && Variable.UserName == "admin"))
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
        }
    }
}
