using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txt_dess.Enabled = false;
            txt_chefcmp.Enabled = false;
            txt_dtchefcmp.Enabled = false;
            txt_comptabilisation.Enabled = false;
            txt_dtComptabilisation.Enabled= false;
        }
        void loadData()
        {
            try
            {
                DisabledTextBox();
                foreach (DataRow row in dt_deatl.Rows)
                {
                    txt_numfac.Text = row["Numero Facture"].ToString();
                    txt_numfac.TextAlign = HorizontalAlignment.Center;
                    txt_fournisseur.Text = row["Fournisseur"].ToString();
                    txt_dtfac.Text = row["Date Facture"].ToString();
                    txt_dtsaisi.Text = row["Date Saisie"].ToString();

                    txt_dtbr.Text = (row["Bureau d'ordre"].ToString() == "01/01/1900 00:00:00") ? " " : row["Bureau d'ordre"].ToString();
                    txt_br.Text = row["Statut Bureau d'ordre"].ToString();

                    txt_dtassdaf.Text = (row["Assistante DAF"].ToString() == "01/01/1900 00:00:00") ? " " : row["Assistante DAF"].ToString();
                    txt_assdaf.Text = row["Statut Assistante DAF"].ToString();

                    txt_dtcmp.Text = (row["Comptabilité"].ToString() == "01/01/1900 00:00:00") ? " " : row["Comptabilité"].ToString();
                    txt_cmp.Text = row["Statut Comptabilité"].ToString();

                    txt_dtachat.Text = (row["Achat"].ToString() == "01/01/1900 00:00:00") ? " " : row["Achat"].ToString();
                    txt_achat.Text = row["Statut Achat"].ToString();

                    txt_dtchefcmp.Text = (row["Chef Comptable"].ToString() == "01/01/1900 00:00:00") ? " " : row["Chef Comptable"].ToString();
                    txt_chefcmp.Text = row["Statut Chef Comptable"].ToString();

                    txt_dtComptabilisation.Text = (row["Date Comptabilisation"].ToString() == "01/01/1900 00:00:00") ? " " : row["Date Comptabilisation"].ToString();
                    txt_comptabilisation.Text = row["Statut Final"].ToString();

                    txt_dess.Text = row["Total TTC"].ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
