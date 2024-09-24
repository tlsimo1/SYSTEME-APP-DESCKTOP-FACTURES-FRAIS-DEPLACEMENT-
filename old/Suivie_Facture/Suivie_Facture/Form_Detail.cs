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
    public partial class Form_Detail : Form
    {
        DataTable dt_deatl = new DataTable();
        public Form_Detail()
        {
            InitializeComponent();
           

        }
        public Form_Detail( DataTable dt)
        {
            InitializeComponent();
            dt_deatl = dt;
            loadData();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void DisabledTextBox()
        {
            txt_numfac.Enabled = false;
            txt_fournisseur.Enabled = false;
            txt_dtfac.Enabled = false;
            txt_dtsaisi.Enabled = false;
            txt_dtbr.Enabled = false;
            txt_br.Enabled = false;
            txt_dtassdaf.Enabled = false;
            txt_assdaf.Enabled = false;
            txt_dtcmp.Enabled = false;
            txt_cmp.Enabled = false;
            txt_dtachat.Enabled = false;
            txt_achat.Enabled = false;
        }
        void loadData()
        {
            DisabledTextBox();
            foreach (DataRow row in dt_deatl.Rows)
            {
                txt_numfac.Text = row["Num Facture"].ToString();
                txt_fournisseur.Text= row["Fournisseur"].ToString();
                txt_dtfac.Text = row["Date_Fac"].ToString();
                txt_dtsaisi.Text = row["Date_Saisie"].ToString();

                txt_dtbr.Text = (row["Date_Saisi_ORD"].ToString() == "01/01/1900 00:00:00") ? " " : row["Date_Saisi_ORD"].ToString();
                txt_br.Text = row["statut_ord"].ToString();

                txt_dtassdaf.Text = (row["Date_Saisi_AssDAF"].ToString() == "01/01/1900 00:00:00") ? " " : row["Date_Saisi_AssDAF"].ToString();
                txt_assdaf.Text = row["statut_AssDAF"].ToString();

                txt_dtcmp.Text = (row["Date_Saisi_Cmp"].ToString() == "01/01/1900 00:00:00") ? " " : row["Date_Saisi_Cmp"].ToString();  
                txt_cmp.Text = row["statut_Cmp"].ToString();

                txt_dtachat.Text = (row["Date_Saisi_Achat"].ToString() == "01/01/1900 00:00:00") ? " " : row["Date_Saisi_Achat"].ToString(); 
                txt_achat.Text = row["statut_achat"].ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form_Detail fr_detal = new Form_Detail();
            //fr_detal.Hide();
        }
    }
}
