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
    public partial class Form_BDR : Form
    {
        Brd_BL bdr_bl = new Brd_BL();
        public Form_BDR()
        {
            InitializeComponent();
        }

        private void Form_BDR_Load(object sender, EventArgs e)
        {
            dte_saisie.Value = DateTime.Now;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                Facture facture = new Facture();
                facture.NumFacture = txt_facture.Text;
                facture.Fournisseur = txt_fournisseur.Text;
                facture.Date_Facture =Convert.ToDateTime(dte_facture.Text);
                facture.Date_Saisie= Convert.ToDateTime(dte_saisie.Text);
                bdr_bl.InsertFacture(facture);
                MessageBox.Show("Facture Ajouter avec succés");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
