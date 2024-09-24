using Microsoft.Office.Interop.Excel;
using Suivie_Facture.BL;
using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Suivie_Facture
{
    public partial class Form_BDR : Form
    {
        Brd_BL bdr_bl = new Brd_BL();
        Facture_BL factureBl = new Facture_BL();
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        System.Data.DataTable dtAutoComplet = new System.Data.DataTable();
        public Form_BDR()
        {
            InitializeComponent();
            dtAutoComplet = factureBl.AutoCompletTextBox();
        }
        private void Form_BDR_Load(object sender, EventArgs e)
        {
            Auto();
            dte_saisie.Value = Convert.ToDateTime(DateTime.Now.ToString("d/M/yy hh:mm:ss.fffffff"));
            cmb_dept.Text = "Comptabilité";
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            
            var Guid_val= Guid.NewGuid().ToString();
            try
            {
                if (txt_facture.Text == "" || txt_fr.Text == "" || dte_facture.Text == "" || txt_des.Text=="")
                {
                    MessageBox.Show("Merci de remplir tous les champs");
                }
                else
                {
                     Facture facture = new Facture();
                    facture.NumFacture = txt_facture.Text;
                    facture.Fournisseur = txt_fr.Text;
                    facture.Date_Facture = Convert.ToDateTime(dte_facture.Text);
                    facture.Date_Saisie = Convert.ToDateTime(dte_saisie.Value);
                    facture.Designation = txt_des.Text;
                    facture.GuidVal = Guid_val;
                    facture.Departement = cmb_dept.Text;
                    bdr_bl.InsertFacture(facture);
                    MessageBox.Show("Facture Ajouter avec succés");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SetTextBox();
        }
        void SetTextBox()
        {
            txt_des.Text = "";
            txt_facture.Text = "";
            txt_fr.Text = "";
            dte_facture.Value = DateTime.Now;
            dte_saisie.Value = DateTime.Now;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            SetTextBox();
        }
        public void Auto()
        {
            for (int i = 0; i < dtAutoComplet.Rows.Count; i++)
            {
                coll.Add(dtAutoComplet.Rows[i]["raisonsocial"].ToString());
            }
            txt_fr.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_fr.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_fr.AutoCompleteCustomSource = coll;
        }

        private void txt_des_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as System.Windows.Forms.TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
            //if (System.Text.RegularExpressions.Regex.IsMatch(txt_des.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Merci de saisir un nombre numéric");
            //    txt_des.Text = txt_des.Text.Remove(txt_des.Text.Length - 1);
            //}
        }
    }
}
