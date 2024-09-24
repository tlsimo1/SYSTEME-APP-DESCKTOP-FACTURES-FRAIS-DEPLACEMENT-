using Microsoft.Office.Interop.Excel;
using Suivie_Facture.BL;
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
    public partial class Form_UpdateFacture : Form
    {
        Facture_BL factureBl = new Facture_BL();
        System.Data.DataTable dtUpdate;
        public Form_UpdateFacture()
        {
            InitializeComponent();
        }
        public Form_UpdateFacture(System.Data.DataTable detailFacture)
        {
            InitializeComponent();
            this.dtUpdate = detailFacture;
        }
        private void btn_qte_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form_UpdateFacture_Load(object sender, EventArgs e)
        {
            Disabled();
            
            txt_numfac.Text = dtUpdate.Rows[0]["Numero Facture"].ToString();
            txt_fournisseur.Text = dtUpdate.Rows[0]["Fournisseur"].ToString(); 
            dt_facture.Text = dtUpdate.Rows[0]["Date Facture"].ToString();  
            dt_saisie.Text = dtUpdate.Rows[0]["Date Saisie"].ToString();


            dt_br.Text = (dtUpdate.Rows[0]["Bureau d'ordre"].ToString() == "01/01/1900 00:00:00") ? " " : dtUpdate.Rows[0]["Bureau d'ordre"].ToString();
            cmb_br.Text = dtUpdate.Rows[0]["Statut Bureau d'ordre"].ToString();

            dt_ass.Text = (dtUpdate.Rows[0]["Assistante DAF"].ToString() == "01/01/1900 00:00:00") ? " " : dtUpdate.Rows[0]["Assistante DAF"].ToString();
            cmb_ass.Text = dtUpdate.Rows[0]["Statut Assistante DAF"].ToString();

            dt_cmp.Text = (dtUpdate.Rows[0]["Comptabilité"].ToString() == "01/01/1900 00:00:00") ? " " : dtUpdate.Rows[0]["Comptabilité"].ToString();
            cmb_cmp.Text = dtUpdate.Rows[0]["Statut Comptabilité"].ToString();

            dt_achat.Text = (dtUpdate.Rows[0]["Achat"].ToString() == "01/01/1900 00:00:00") ? " " : dtUpdate.Rows[0]["Achat"].ToString() ;
            cmb_achat.Text = dtUpdate.Rows[0]["Statut Achat"].ToString();

            dt_chefcmp.Text = (dtUpdate.Rows[0]["Chef Comptable"].ToString() == "01/01/1900 00:00:00") ? " " : dtUpdate.Rows[0]["Chef Comptable"].ToString();
            cmb_chefcmp.Text = dtUpdate.Rows[0]["Statut Chef Comptable"].ToString();

            dt_final.Text = (dtUpdate.Rows[0]["Date Comptabilisation"].ToString() == "01/01/1900 00:00:00") ? " " : dtUpdate.Rows[0]["Date Comptabilisation"].ToString();
            cmp_final.Text = dtUpdate.Rows[0]["Statut Final"].ToString();

            txt_TTC.Text = dtUpdate.Rows[0]["Total TTC"].ToString();
            Enabled();
        }

        private void btn_validerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic MyDynamic = new System.Dynamic.ExpandoObject();
                MyDynamic.NumFacture = txt_numfac.Text;
                MyDynamic.Fournisseur = txt_fournisseur.Text;
                MyDynamic.DateFacture = dt_facture.Text;
                MyDynamic.DateSaisie = dt_saisie.Text;
                MyDynamic.DateBureauOrdre = dt_br.Text;
                MyDynamic.StatutOrdre = cmb_br.Text == "Validé" ? 1 : 0;
                MyDynamic.DateAssDaf = dt_ass.Text;
                MyDynamic.StatutAssDaf = cmb_ass.Text == "Validé" ? 1 : 0;
                MyDynamic.DateCmp = dt_cmp.Text;
                MyDynamic.StatutCmp = cmb_cmp.Text == "Validé" ? 1 : 0;
                MyDynamic.DateAchat = dt_achat.Text;
                MyDynamic.StatutAchat = cmb_achat.Text == "Validé" ? 1 : 0;
                MyDynamic.DateChefCmp = dt_chefcmp.Text;
                MyDynamic.StatutChefCmp = cmb_chefcmp.Text == "Validé" ? 1 : 0;
                MyDynamic.DateComptabilisation = dt_final.Text;
                MyDynamic.StatutComptabilisation = cmp_final.Text == "Validé" ? 1 : 0;
                MyDynamic.TotalTTC = txt_TTC.Text;
                MyDynamic.guidNum = dtUpdate.Rows[0]["ID_FAC"].ToString();

                if (cmp_final.Text == "Validé" && cmb_achat.Text == "Non Valide")
                {
                    MessageBox.Show("Modification non éffectuée");
                }
                else if (cmb_achat.Text == "Validé" && cmb_cmp.Text == "Non Valide")
                {
                    MessageBox.Show("Modification non éffectuée");
                }
                else if (cmb_cmp.Text == "Validé" && cmb_chefcmp.Text == "Non Valide")
                {
                    MessageBox.Show("Modification non éffectuée");
                }
                else if (cmb_chefcmp.Text == "Validé" && cmb_ass.Text == "Non Valide")
                {
                    MessageBox.Show("Modification non éffectuée");
                }
                else if (cmb_ass.Text == "Validé" && cmb_br.Text == "Non Valide")
                {
                    MessageBox.Show("Modification non éffectuée");
                }
                else
                {
                    factureBl.UpdateFacture(MyDynamic);
                    MessageBox.Show("Facture modifiée ave succés");
                    this.Close();
                }
                //Enabled();
            }
            catch (Exception)
            {

                return;
            }
           

        }
        void Disabled()
        {
            txt_numfac.Enabled = false;
            txt_fournisseur.Enabled = true;
            dt_facture.Enabled = true;
            dt_saisie.Enabled = true;


            dt_br.Enabled = true;
            cmb_br.Enabled = true;

            dt_ass.Enabled = false;
            cmb_ass.Enabled = false;

            dt_cmp.Enabled = false;
            cmb_cmp.Enabled = false;

            dt_achat.Enabled = false;
            cmb_achat.Enabled = false;

            dt_chefcmp.Enabled = false;
            cmb_chefcmp.Enabled = false;

            dt_final.Enabled = false;
            cmp_final.Enabled = false;

            txt_TTC.Enabled = true;
        }
        void Enabled()
        {
            if(cmb_br.Text=="Validé")
            {
                dt_ass.Enabled = true;
                cmb_ass.Enabled = true;
            }
            else
            {
                dt_ass.Enabled = false;
                cmb_ass.Enabled = false;
            }
            if(cmb_ass.Text=="Validé")
            {
                dt_ass.Enabled = true;
                cmb_ass.Enabled = true;

                dt_chefcmp.Enabled = true;
                cmb_chefcmp.Enabled = true;
            }
            else
            {
                dt_chefcmp.Enabled = false;
                cmb_chefcmp.Enabled = false;
            }
            if (cmb_chefcmp.Text == "Validé")
            {
                dt_chefcmp.Enabled = true;
                cmb_chefcmp.Enabled = true;

                dt_cmp.Enabled = true;
                cmb_cmp.Enabled = true;
            }
            else
            {
                dt_cmp.Enabled = false;
                cmb_cmp.Enabled = false;
            }
            if (cmb_cmp.Text == "Validé")
            {
                dt_cmp.Enabled = true;
                cmb_cmp.Enabled = true;

                dt_achat.Enabled = true;
                cmb_achat.Enabled = true;
            }
            else
            {
                dt_achat.Enabled = false;
                cmb_achat.Enabled = false;
            }
            if (cmb_achat.Text == "Validé")
            {
                dt_achat.Enabled = true;
                cmb_achat.Enabled = true;

                dt_final.Enabled = true;
                cmp_final.Enabled = true;
            }
            else
            {
                dt_final.Enabled = false;
                cmp_final.Enabled = false;
            }
            if (cmp_final.Text == "Validé")
            {
                dt_final.Enabled = true;
                cmp_final.Enabled = true;
            }
        }

        private void cmb_br_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_br.Text == "Validé")
                {
                    cmb_ass.Enabled = true;
                }
                else
                {
                    cmb_ass.Enabled = false;
                }
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void cmb_ass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_ass.Text == "Validé")
                {
                    cmb_chefcmp.Enabled = true;
                }
                else
                {
                    cmb_chefcmp.Enabled = false;
                }
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void cmb_chefcmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_chefcmp.Text == "Validé")
                {
                    cmb_cmp.Enabled = true;
                }
                else
                {
                    cmb_cmp.Enabled = false;
                }
            }
            catch (Exception)
            {
                return;
            }
           
        }

        private void cmb_cmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_cmp.Text == "Validé")
                {
                    cmb_achat.Enabled = true;
                }
                else
                {
                    cmb_achat.Enabled = false;
                }
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void cmb_achat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_achat.Text == "Validé")
                {
                    cmp_final.Enabled = true;
                }
                else
                {
                    cmp_final.Enabled = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
