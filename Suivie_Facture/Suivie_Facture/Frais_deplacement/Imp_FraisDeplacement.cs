using Microsoft.Office.Interop.Excel;
using Suivie_Facture.BL;
using Suivie_Facture.Class;
using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls.Expressions;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Suivie_Facture.Frais_deplacement
{
    public partial class Imp_FraisDeplacement : Form
    {
        PopupNotifier popup = new PopupNotifier();
        Frais_DeplacementBL frais_Deplacement_BL = new Frais_DeplacementBL();
        PersonnelBL personnel_BL = new PersonnelBL();

        
        public Imp_FraisDeplacement()
        {
            InitializeComponent();
            btn_save.Enabled = false;
            cmb_matricule.TextChanged += Cmb_matricule_TextChanged;
        }

        private void Cmb_matricule_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_matricule.SelectedValue == null)
                {
                    return;
                }
                else
                {
                    System.Data.DataTable dtPerosnnel = new System.Data.DataTable();
                    int personnelID = int.Parse(cmb_matricule.SelectedValue.ToString());
                    dtPerosnnel = personnel_BL.Get_Mat_CA(personnelID);
                    DataRow[] rows = dtPerosnnel.Select();
                    txt_nom.Text = rows[0].ItemArray[0].ToString();
                    txt_ca.Text = rows[0].ItemArray[1].ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        void ReplirComBobox()
        {
            cmb_matricule.DataSource = personnel_BL.GetAllPesonnel();
            cmb_matricule.DisplayMember = "Matricule";
            cmb_matricule.ValueMember = "ID_Personnel";
            //Set AutoCompleteMode.
            cmb_matricule.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_matricule.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void GetALLFraisDeplacement()
        {
            try
            {
                dg_fraisDeplacement.DataSource = frais_Deplacement_BL.GetAllFraisDeplacement();
                dg_fraisDeplacement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg_fraisDeplacement.AllowUserToOrderColumns = true;
                dg_fraisDeplacement.AllowUserToResizeRows = true;
                dg_fraisDeplacement.AllowUserToAddRows = false;
                if (dg_fraisDeplacement.Rows.Count > 0)
                {
                    dg_fraisDeplacement.Columns["Matricule"].Frozen = true;
                    dg_fraisDeplacement.Columns["Nom"].Frozen = true;
                    dg_fraisDeplacement.Columns["Code Analytique"].Frozen = true;
                    dg_fraisDeplacement.Columns["ID_Frais"].Visible = false;
                }
                double sumKM = 0;
                double sumFR = 0;
                double sumAV = 0;
                for (int i = 0; i < dg_fraisDeplacement.Rows.Count; ++i)
                {
                    sumKM += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Frais kilometrique"].Value);
                    sumFR += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Frais Deplacement"].Value);
                    sumAV += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Montant Avance"].Value);
                }
                lbl_sumKM.Text = sumKM.ToString();
                lbl_sumFrai.Text = sumFR.ToString();
                lbl_avance.Text = sumAV.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Imp_FraisDeplacement_Load(object sender, EventArgs e)
        {
            try
            {
                GetALLFraisDeplacement();
                ReplirComBobox();
                DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Image = Properties.Resources.DELETE2;
                dg_fraisDeplacement.Columns.Add(btnDelete);

                if (dg_fraisDeplacement.Rows.Count > 0)
                {
                    dg_fraisDeplacement.Columns["Matricule"].Frozen = true;
                    dg_fraisDeplacement.Columns["Nom"].Frozen = true;
                    dg_fraisDeplacement.Columns["Code Analytique"].Frozen = true;
                    dg_fraisDeplacement.Columns["ID_Frais"].Visible = false;
                    //dg_fraisDeplacement.Columns["btnDelete"].Frozen = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_fraisDeplacement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_fraisDeplacement.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_fraisDeplacement.Rows[e.RowIndex];
                row.Selected = true;
                int numFac = int.Parse(dg_fraisDeplacement.Rows[e.RowIndex].Cells["ID_Frais"].Value.ToString());

                if ((column == "btnDelete"))
                {
                    DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer l'enregistrement  ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        frais_Deplacement_BL.Delete_fraisDeplacement(numFac);
                        MessageBox.Show("Enregistrement Supprimé avec succés ");
                    }
                    
                    popup.TitleText = "";
                    popup.ContentText = "Enregistrement supprimé ";
                    popup.Popup(); 
                    GetALLFraisDeplacement();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_fraisDeplacement_SelectionChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            DateTime currentTime = DateTime.Now;
            try
            {
                if (dg_fraisDeplacement.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dg_fraisDeplacement.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dg_fraisDeplacement.Rows[selectedrowindex];
                    lbl_idFrais.Text= Convert.ToString(selectedRow.Cells["ID_Frais"].Value);
                    cmb_matricule.Text = Convert.ToString(selectedRow.Cells["Matricule"].Value);
                    txt_nom.Text = Convert.ToString(selectedRow.Cells["Nom"].Value);
                    txt_ca.Text = Convert.ToString(selectedRow.Cells["Code Analytique"].Value);
                    txt_km.Text = Convert.ToString(selectedRow.Cells["Frais kilometrique"].Value).Replace(',', '.');
                    txt_fr.Text = Convert.ToString(selectedRow.Cells["Frais Deplacement"].Value).Replace(',', '.');
                    txt_dteperiode.Text = selectedRow.Cells["Periode"].Value.ToString() == "" ? "" : Convert.ToDateTime(selectedRow.Cells["Periode"].Value.ToString()).ToString("dd/MM/yyyy");
                    cmb_circulation.Text = Convert.ToString(selectedRow.Cells["Circulation"].Value);
                    txt_dtereglement.Text = selectedRow.Cells["Date Reglement"].Value.ToString() == "" ? "" : Convert.ToDateTime(selectedRow.Cells["Date Reglement"].Value.ToString()).ToString("dd/MM/yyyy");
                    txt_reprise.Text = Convert.ToString(selectedRow.Cells["Reprise Frais"].Value);
                    txt_dteavance.Text = selectedRow.Cells["Date Avance"].Value.ToString() == ""?"": Convert.ToDateTime(selectedRow.Cells["Date Avance"].Value.ToString()).ToString("dd/MM/yyyy");
                    txt_mt_avance.Text = Convert.ToString(selectedRow.Cells["Montant Avance"].Value).Replace(',', '.');
                    txt_ville.Text = Convert.ToString(selectedRow.Cells["Ville Region"].Value);
                    cmb_modeReglement.Text = Convert.ToString(selectedRow.Cells["Mode Reglement"].Value);
                    txt_dtepreparation.Text= selectedRow.Cells["Date Preparation"].Value.ToString() == ""? "":Convert.ToDateTime(selectedRow.Cells["Date Preparation"].Value.ToString()).ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ResetForm()
        {
            cmb_matricule.Text = "";
            txt_nom.Text = "";
            txt_ca.Text = "";
            txt_km.Text = "";
            txt_fr.Text = "";
            //lbl_idFrais.Text = "";
            txt_dteperiode.Text = "";
            cmb_circulation.Text = "";
            txt_dtereglement.Text = "";
            txt_reprise.Text = "";
            txt_dteavance.Text = "";
            txt_mt_avance.Text = "";
            txt_ville.Text = "";
            cmb_modeReglement.Text = "";
            txt_dtepreparation.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
           
            btn_save.Enabled = true;
            ResetForm();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlDateTime sqldatenull;
            sqldatenull = SqlDateTime.Null;
            try
            {
                Frais_Deplacement fraisDeplacement = new Frais_Deplacement();
                fraisDeplacement.ID_Frais = int.Parse(lbl_idFrais.Text);
                fraisDeplacement.Date_Saisie = DateTime.Now;
                fraisDeplacement.Mat_PER = cmb_matricule.Text;
                fraisDeplacement.Frais_Kilometrique = float.Parse(txt_km.Text.Replace('.', ','));
                fraisDeplacement.FraisDeplacement = float.Parse(txt_fr.Text.Replace('.', ','));
                fraisDeplacement.Periode_Deplacement = DateTime.Parse(txt_dteperiode.Text);
                fraisDeplacement.Circulation = cmb_circulation.Text;
                fraisDeplacement.Date_Regelement = DateTime.Parse(txt_dtereglement.Text);
                fraisDeplacement.Reprise_Frais = txt_reprise.Text;
                fraisDeplacement.Date_Avancement = DateTime.Parse(txt_dteavance.Text);
                fraisDeplacement.Montant_Avance = float.Parse(txt_mt_avance.Text.Replace('.', ','));
                fraisDeplacement.Ville_Region = txt_ville.Text;
                fraisDeplacement.Mode_Reglement = cmb_modeReglement.Text;
                //fraisDeplacement.Date_Preparation = DateTime.Parse(dte_preparation .Value.ToString());
                fraisDeplacement.Date_Preparation = DateTime.Parse(txt_dtepreparation.Text);
                fraisDeplacement.Periode = null;
                fraisDeplacement.Periode_De = null;
                fraisDeplacement.Personnel_id = int.Parse(cmb_matricule.SelectedValue.ToString());
                frais_Deplacement_BL.Update_fraisDeplacement(fraisDeplacement);
                GetALLFraisDeplacement();
                popup.TitleText = "";
                popup.ContentText = "Enregistrement Modifié ";
                popup.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


            try
            {
                Frais_Deplacement fraisDeplacement = new Frais_Deplacement();
                //fraisDeplacement.ID_Frais = int.Parse(lbl_idFrais.Text);
                fraisDeplacement.Date_Saisie = DateTime.Now;
                fraisDeplacement.Mat_PER = cmb_matricule.Text;
                fraisDeplacement.Frais_Kilometrique = float.Parse(txt_km.Text.Replace('.', ','));
                fraisDeplacement.FraisDeplacement = float.Parse(txt_fr.Text.Replace('.', ','));
                fraisDeplacement.Periode_Deplacement = DateTime.Parse(txt_dteperiode.Text);
                fraisDeplacement.Circulation = cmb_circulation.Text;
                fraisDeplacement.Date_Regelement = DateTime.Parse(txt_dtereglement.Text);
                fraisDeplacement.Reprise_Frais = txt_reprise.Text;
                fraisDeplacement.Date_Avancement = DateTime.Parse(txt_dteavance.Text);
                fraisDeplacement.Montant_Avance = float.Parse(txt_mt_avance.Text.Replace('.', ','));
                fraisDeplacement.Ville_Region = txt_ville.Text;
                fraisDeplacement.Mode_Reglement = cmb_modeReglement.Text;
                //fraisDeplacement.Date_Preparation = DateTime.Parse(dte_preparation .Value.ToString());
                fraisDeplacement.Date_Preparation = DateTime.Parse(txt_dtepreparation.Text);
                fraisDeplacement.Periode = null;
                fraisDeplacement.Periode_De = null;
                fraisDeplacement.Personnel_id = int.Parse(cmb_matricule.SelectedValue.ToString());
                frais_Deplacement_BL.Insert_fraisDeplacement(fraisDeplacement);
                popup.TitleText = "";
                popup.ContentText = "Enregistrement Ajouté ";
                popup.Popup();
                GetALLFraisDeplacement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }    
        }

       

        private void txt_dteperiode_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9] | 1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(txt_dteperiode.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(txt_dteperiode.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
             MessageBox.Show("Invalid Date  exemple (xx/xx/xxxx)");
        }

        private void txt_dtereglement_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9] | 1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(txt_dtereglement.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(txt_dtereglement.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
                MessageBox.Show("Invalid Date  exemple (xx/xx/xxxx)");
        }

        private void txt_dteavance_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9] | 1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(txt_dteavance.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(txt_dteavance.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
                MessageBox.Show("Invalid Date  exemple (xx/xx/xxxx)");
        }

        private void txt_dtepreparation_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9] | 1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(txt_dtepreparation.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(txt_dtepreparation.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
                MessageBox.Show("Invalid Date  exemple (xx/xx/xxxx)");
        }

        private void txt_km_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt_fr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt_mt_avance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt_recherch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                dg_fraisDeplacement.Columns.Clear();
                dg_fraisDeplacement.DataSource = frais_Deplacement_BL.GetFraisDeplacement(txt_recherch.Text);
                DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Image = Properties.Resources.DELETE2;
                dg_fraisDeplacement.Columns.Add(btnDelete);

                if (dg_fraisDeplacement.Rows.Count > 0)
                {
                    dg_fraisDeplacement.Columns["Matricule"].Frozen = true;
                    dg_fraisDeplacement.Columns["Nom"].Frozen = true;
                    dg_fraisDeplacement.Columns["Code Analytique"].Frozen = true;
                    dg_fraisDeplacement.Columns["ID_Frais"].Visible = false;
                    //dg_fraisDeplacement.Columns["btnDelete"].Frozen = true;
                }
                double sumKM = 0;
                double sumFR = 0;
                double sumAV = 0;
                for (int i = 0; i < dg_fraisDeplacement.Rows.Count; ++i)
                {
                    sumKM += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Frais kilometrique"].Value);
                    sumFR += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Frais Deplacement"].Value);
                    sumAV += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Montant Avance"].Value);
                }
                lbl_sumKM.Text = sumKM.ToString();
                lbl_sumFrai.Text = sumFR.ToString();
                lbl_avance.Text = sumAV.ToString();
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
                dg_fraisDeplacement.Columns.Clear();
                dg_fraisDeplacement.DataSource = frais_Deplacement_BL.GetFarisDeplacementParDate(DateTime.Parse(dt_recherch.Text));
                DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Image = Properties.Resources.DELETE2;
                dg_fraisDeplacement.Columns.Add(btnDelete);

                if (dg_fraisDeplacement.Rows.Count > 0)
                {
                    dg_fraisDeplacement.Columns["Matricule"].Frozen = true;
                    dg_fraisDeplacement.Columns["Nom"].Frozen = true;
                    dg_fraisDeplacement.Columns["Code Analytique"].Frozen = true;
                    dg_fraisDeplacement.Columns["ID_Frais"].Visible = false;
                    //dg_fraisDeplacement.Columns["btnDelete"].Frozen = true;
                }
                double sumKM = 0;
                double sumFR = 0;
                double sumAV = 0;
                for (int i = 0; i < dg_fraisDeplacement.Rows.Count; ++i)
                {
                    sumKM += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Frais kilometrique"].Value);
                    sumFR += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Frais Deplacement"].Value);
                    sumAV += Convert.ToDouble(dg_fraisDeplacement.Rows[i].Cells["Montant Avance"].Value);
                }
                lbl_sumKM.Text = sumKM.ToString();
                lbl_sumFrai.Text = sumFR.ToString();
                lbl_avance.Text = sumAV.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
