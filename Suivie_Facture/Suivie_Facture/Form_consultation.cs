using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Suivie_Facture.BL;
using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture
{
    public partial class Form_consultation : Form
    {
        float Somme = 0;
        string numFac = string.Empty;
        bool AddCrudOperation = true;
        int PageSize = 5;
        BackgroundWorker bgw = new BackgroundWorker();
        public Form_consultation()
        {
            InitializeComponent();
            AddCrudOperation = false;
            

        }
        Facture_BL facture_BL = new Facture_BL();
        private void Form_consultation_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDate();
                
            }
            catch (Exception ex)
            {
                return;
            }
        }
     
        void LoadDate()
        {
            try
            {
                Somme = 0;
                dg_Facture.LoadData(Connexion.ConnectionString, false);
                #region calculer total TTC
                //if(dg_Facture.Rows.Count>0)
                //{
                //    dg_Facture.Columns["Numero Facture"].Frozen = true;
                //    dg_Facture.Columns["Fournisseur"].Frozen = true;
                //    foreach (DataGridViewRow ROW in dg_Facture.Rows)
                //    {
                //        float value = float.Parse(ROW.Cells["Total TTC"].Value.ToString().Replace(".", ","));
                //        if (value < 0)
                //        {
                //            Somme -= value;
                //        }
                //        else
                //        {
                //            Somme += value;
                //        }

                //    }
                //    //lbl_total.Text = Somme.ToString() + " DH ";
                //}
                #endregion
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void dg_Facture_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string column = dg_Facture.Columns[e.ColumnIndex].Name;
                if (column != "btnValide" && column != "btnDetail" && column != "btnDelete")
                    dg_Facture.Cursor = Cursors.Default;
                else
                    dg_Facture.Cursor = Cursors.Hand;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dg_Facture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Somme = 0;
            try
            {
                string column = dg_Facture.Columns[e.ColumnIndex].Name;
                DataGridViewRow row = dg_Facture.Rows[e.RowIndex];

                if (Variable.UserName != Variable.UserNameAdmin)
                {
                    numFac = dg_Facture.Rows[e.RowIndex].Cells["ID_FAC"].Value.ToString();
                    row.Selected = true;
                    if (column == "btnDetail")
                    {
                        System.Data.DataTable detailFacture = new System.Data.DataTable();
                        detailFacture = facture_BL.GetDetail(numFac);
                        Form_Detail fr_detail = new Form_Detail(detailFacture);
                        fr_detail.Show();
                    }
                }
                else
                {
                    if (column == "btnDetail")
                    {
                        numFac = dg_Facture.Rows[e.RowIndex].Cells["ID_FAC"].Value.ToString();
                        System.Data.DataTable detailFacture = new System.Data.DataTable();
                        detailFacture = facture_BL.GetDetail(numFac);
                        Form_Detail fr_detail = new Form_Detail(detailFacture);
                        fr_detail.Show();
                    }
                    if (column == "btnDelete")
                    {
                        numFac = dg_Facture.Rows[e.RowIndex].Cells["ID_FAC"].Value.ToString();
                        string fac = dg_Facture.Rows[e.RowIndex].Cells["Numero Facture"].Value.ToString();
                        DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer la facture " + fac + " ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            facture_BL.DeleteFacture(numFac);
                            MessageBox.Show("Supprimer avec succés ");
                        }
                        int rowIndex = dg_Facture.CurrentCell.RowIndex;
                        dg_Facture.Rows.RemoveAt(rowIndex);

                    }
                    if (column == "btnUpdate")
                    {
                        numFac = dg_Facture.Rows[e.RowIndex].Cells["ID_FAC"].Value.ToString();
                        System.Data.DataTable detailFacture = new System.Data.DataTable();
                        detailFacture = facture_BL.GetDetail(numFac);
                        Form_UpdateFacture updateFacture = new Form_UpdateFacture(detailFacture);
                        updateFacture.ShowDialog();
                        LoadDate();
                    }
                }
                dg_Facture.Columns["ID_FAC"].Visible = false;
                #region calculer total TTC
                //if(dg_Facture.Rows.Count>0)
                //{
                //    dg_Facture.Columns["Numero Facture"].Frozen = true;
                //    dg_Facture.Columns["Fournisseur"].Frozen = true;
                //    foreach (DataGridViewRow ROW in dg_Facture.Rows)
                //    {
                //        float value = float.Parse(ROW.Cells["Total TTC"].Value.ToString().Replace(".", ","));
                //        if (value < 0)
                //        {
                //            Somme -= value;
                //        }
                //        else
                //        {
                //            Somme += value;
                //        }

                //    }
                //    //lbl_total.Text = Somme.ToString() + " DH ";
                //}
                #endregion
            }
            catch (Exception)
            {
                return;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Somme = 0;
            Variable.IsLoadDataByDate = false;
            try
            {
                if (!string.IsNullOrEmpty(txt_recherch.Text))
                {
                    dg_Facture.Columns.Clear();
                    dg_Facture.DataSource = facture_BL.GetFacture(txt_recherch.Text);
                    DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                    btnDetail.Name = "btnDetail";
                    btnDetail.HeaderText = "Detail";
                    btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                    dg_Facture.Columns.Add(btnDetail);
                    if (Variable.UserName == Variable.UserNameAdmin)
                    {
                        DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                        btnDelete.Name = "btnDelete";
                        btnDelete.HeaderText = "Delete";
                        btnDelete.Image = Properties.Resources.DELETE2;
                        dg_Facture.Columns.Add(btnDelete);
                        dg_Facture.Columns["Numero Facture"].Frozen = true;
                        dg_Facture.Columns["Fournisseur"].Frozen = true;

                        DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.HeaderText = "Update";
                        btnUpdate.Image = Properties.Resources.edit1;
                        dg_Facture.Columns.Add(btnUpdate);
                        dg_Facture.Columns["Numero Facture"].Frozen = true;
                        dg_Facture.Columns["Fournisseur"].Frozen = true;
                    }
                    dg_Facture.Columns["Numero Facture"].Frozen = true;
                    dg_Facture.Columns["Fournisseur"].Frozen = true;
                    AddCrudOperation = true;
                    #region calculer total TTC
                    //if(dg_Facture.Rows.Count>0)
                    //{
                    //    dg_Facture.Columns["Numero Facture"].Frozen = true;
                    //    dg_Facture.Columns["Fournisseur"].Frozen = true;
                    //    foreach (DataGridViewRow ROW in dg_Facture.Rows)
                    //    {
                    //        float value = float.Parse(ROW.Cells["Total TTC"].Value.ToString().Replace(".", ","));
                    //        if (value < 0)
                    //        {
                    //            Somme -= value;
                    //        }
                    //        else
                    //        {
                    //            Somme += value;
                    //        }

                    //    }
                    //    //lbl_total.Text = Somme.ToString() + " DH ";
                    //}
                    #endregion
                    dg_Facture.Columns["ID_FAC"].Visible = false;
                }
                if (string.IsNullOrEmpty(txt_recherch.Text))
                {
                    Somme = 0;
                    dg_Facture.Columns.Clear();
                    AddCrudOperation = false;
                    LoadDate();
                    AddCrudOperation = false;
                    #region calculer total TTC
                    //if(dg_Facture.Rows.Count>0)
                    //{
                    //    dg_Facture.Columns["Numero Facture"].Frozen = true;
                    //    dg_Facture.Columns["Fournisseur"].Frozen = true;
                    //    foreach (DataGridViewRow ROW in dg_Facture.Rows)
                    //    {
                    //        float value = float.Parse(ROW.Cells["Total TTC"].Value.ToString().Replace(".", ","));
                    //        if (value < 0)
                    //        {
                    //            Somme -= value;
                    //        }
                    //        else
                    //        {
                    //            Somme += value;
                    //        }

                    //    }
                    //    //lbl_total.Text = Somme.ToString() + " DH ";
                    //}
                    #endregion
                }
                
            }
            catch (Exception)
            {
                return;
            }
            
            //dg_Facture.Columns["ID_FAC"].Visible = false;
        }
        private void btn_recherch_Click(object sender, EventArgs e)
        {
            Somme = 0;
            Variable.IsLoadDataByDate = true;
            txt_recherch.Text = "";
            try
            {
                if (dt_recherch.Text != null)
                {
                    dg_Facture.Columns.Clear();
                    dg_Facture.DataSource = facture_BL.GetFactureParDate(DateTime.Parse(dt_recherch.Text));
                    DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                    btnDetail.Name = "btnDetail";
                    btnDetail.HeaderText = "Detail";
                    btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                    dg_Facture.Columns.Add(btnDetail);
                    dg_Facture.Columns["Numero Facture"].Frozen = true;
                    dg_Facture.Columns["Fournisseur"].Frozen = true;
                    if (Variable.UserName == Variable.UserNameAdmin)
                    {
                        DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                        btnDelete.Name = "btnDelete";
                        btnDelete.HeaderText = "Delete";
                        btnDelete.Image = Properties.Resources.DELETE2;
                        dg_Facture.Columns.Add(btnDelete);
                        dg_Facture.Columns["Numero Facture"].Frozen = true;
                        dg_Facture.Columns["Fournisseur"].Frozen = true;

                        DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.HeaderText = "Update";
                        btnUpdate.Image = Properties.Resources.edit1;
                        dg_Facture.Columns.Add(btnUpdate);
                        dg_Facture.Columns["Numero Facture"].Frozen = true;
                        dg_Facture.Columns["Fournisseur"].Frozen = true;
                    }
                    #region calculer total TTC
                    //if(dg_Facture.Rows.Count>0)
                    //{
                    //    dg_Facture.Columns["Numero Facture"].Frozen = true;
                    //    dg_Facture.Columns["Fournisseur"].Frozen = true;
                    //    foreach (DataGridViewRow ROW in dg_Facture.Rows)
                    //    {
                    //        float value = float.Parse(ROW.Cells["Total TTC"].Value.ToString().Replace(".", ","));
                    //        if (value < 0)
                    //        {
                    //            Somme -= value;
                    //        }
                    //        else
                    //        {
                    //            Somme += value;
                    //        }

                    //    }
                    //    //lbl_total.Text = Somme.ToString() + " DH ";
                    //}
                    #endregion
                    dg_Facture.Columns["ID_FAC"].Visible = false;
                }
            }
            catch (Exception)
            {
                return;
            }
            //AddCrudOperation = true;
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            try
            {
                dg_Facture.Columns["ID_FAC"].Visible = false;
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);


                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string name2 = Environment.UserName;
                if (!System.IO.File.Exists($"C:\\Users\\{name2}\\Downloads\\factures.xlsx"))
                {
                    xlWorkBook.SaveAs($"C:\\Users\\{name2}\\Downloads\\factures.xlsx");
                }
                else
                {
                    xlWorkBook.SaveAs($@"C:\Users\\{name2}\Downloads\ .xlsx");
                }
                
            }
            catch (Exception)
            {
                return;
            }
        }
        private void copyAlltoClipboard()
        {
            try
            {
                dg_Facture.SelectAll();
                DataObject dataObj = dg_Facture.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void dg_Facture_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numFac = dg_Facture.Rows[e.RowIndex].Cells["ID_FAC"].Value.ToString();
                System.Data.DataTable detailFacture = new System.Data.DataTable();
                detailFacture = facture_BL.GetDetail(numFac);
                Form_Detail fr_detail = new Form_Detail(detailFacture);
                fr_detail.Show();
            }
            catch (Exception)
            {
                return;
            }
        }
        void RefreshData()
        {
            int count = dg_Facture.Rows.Count;
            dg_Facture.Columns.Clear();
            if (count == 1)
            {
                dg_Facture.DataSource = facture_BL.GetDetail(numFac);
                Variable.IsLoadData = true;
            }
            else
            {
                if (Variable.IsLoadDataByDate == true)
                {
                    dg_Facture.DataSource = facture_BL.GetFactureParDate(DateTime.Parse(dt_recherch.Text));
                    Variable.IsLoadData = true;
                }
                else
                {
                    dg_Facture.DataSource = facture_BL.GetDetail(numFac);
                    LoadDate();
                    Variable.IsLoadData = true;
                    Variable.IsLoadDataByDate = false;
                }
            }
            if (txt_recherch.Text == "")
            {
                if (Variable.IsLoadData == false)
                {
                    dg_Facture.DataSource = facture_BL.GetFactureParDate(DateTime.Parse(dt_recherch.Text));
                    Variable.IsLoadDataByDate = false;
                }
                Variable.IsLoadData = false;
            }

            DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
            btnDetail.Name = "btnDetail";
            btnDetail.HeaderText = "";
            btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
            dg_Facture.Columns.Add(btnDetail);
            if (Variable.UserName == Variable.UserNameAdmin)
            {
                DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = "";
                btnDelete.Image = Properties.Resources.DELETE2;
                dg_Facture.Columns.Add(btnDelete);

                DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = "";
                btnUpdate.Image = Properties.Resources.edit1;
                dg_Facture.Columns.Add(btnUpdate);
                dg_Facture.Columns["Numero Facture"].Frozen = true;
                dg_Facture.Columns["Fournisseur"].Frozen = true;
            }
            dg_Facture.Columns["Numero Facture"].Frozen = true;
            dg_Facture.Columns["Fournisseur"].Frozen = true;
            dg_Facture.Columns["ID_FAC"].Visible = false;
        }

        private void dg_Facture_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                if (AddCrudOperation == false)
                {
                    dg_Facture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dg_Facture.AllowUserToOrderColumns = true;
                    dg_Facture.AllowUserToResizeRows = true;
                    dg_Facture.AllowUserToAddRows = false;

                    DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                    btnDetail.Name = "btnDetail";
                    btnDetail.HeaderText = "Detail";
                    btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                    dg_Facture.Columns.Add(btnDetail);
                    if (dg_Facture.Rows.Count > 1)
                    {
                        dg_Facture.Columns["Numero Facture"].Frozen = true;
                        dg_Facture.Columns["Fournisseur"].Frozen = true;
                    }
                    if ((Variable.GetRol == "admin") && Variable.UserName == Variable.GetRol)
                    {
                        DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                        btnDelete.Name = "btnDelete";
                        btnDelete.HeaderText = "Delete";
                        btnDelete.Image = Properties.Resources.DELETE2;
                        dg_Facture.Columns.Add(btnDelete);


                        DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.HeaderText = "Update";
                        btnUpdate.Image = Properties.Resources.edit1;
                        dg_Facture.Columns.Add(btnUpdate);
                        if (dg_Facture.Rows.Count > 1)
                        {
                            dg_Facture.Columns["Numero Facture"].Frozen = true;
                            dg_Facture.Columns["Fournisseur"].Frozen = true;
                        }

                    }
                    AddCrudOperation = true;
                    dg_Facture.Columns["ID_FAC"].Visible = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txt_fournisseur_TextChanged(object sender, EventArgs e)
        {
            Somme = 0;
            Variable.IsLoadDataByDate = false;
            try
            {
                if (!string.IsNullOrEmpty(txt_fournisseur.Text))
                {
                    dg_Facture.Columns.Clear();
                    dg_Facture.DataSource = facture_BL.GetFactureParFournisseur(txt_fournisseur.Text);
                    DataGridViewImageColumn btnDetail = new DataGridViewImageColumn();
                    btnDetail.Name = "btnDetail";
                    btnDetail.HeaderText = "Detail";
                    btnDetail.Image = Properties.Resources.icons8_opened_folder_24px;
                    dg_Facture.Columns.Add(btnDetail);
                    if (Variable.UserName == Variable.UserNameAdmin)
                    {
                        DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                        btnDelete.Name = "btnDelete";
                        btnDelete.HeaderText = "Delete";
                        btnDelete.Image = Properties.Resources.DELETE2;
                        dg_Facture.Columns.Add(btnDelete);
                        dg_Facture.Columns["Numero Facture"].Frozen = true;
                        dg_Facture.Columns["Fournisseur"].Frozen = true;

                        DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.HeaderText = "Update";
                        btnUpdate.Image = Properties.Resources.edit1;
                        dg_Facture.Columns.Add(btnUpdate);
                        dg_Facture.Columns["Numero Facture"].Frozen = true;
                        dg_Facture.Columns["Fournisseur"].Frozen = true;
                    }
                    dg_Facture.Columns["Numero Facture"].Frozen = true;
                    dg_Facture.Columns["Fournisseur"].Frozen = true;
                    AddCrudOperation = true;
                    #region calculer total TTC
                    //if(dg_Facture.Rows.Count>0)
                    //{
                    //    dg_Facture.Columns["Numero Facture"].Frozen = true;
                    //    dg_Facture.Columns["Fournisseur"].Frozen = true;
                    //    foreach (DataGridViewRow ROW in dg_Facture.Rows)
                    //    {
                    //        float value = float.Parse(ROW.Cells["Total TTC"].Value.ToString().Replace(".", ","));
                    //        if (value < 0)
                    //        {
                    //            Somme -= value;
                    //        }
                    //        else
                    //        {
                    //            Somme += value;
                    //        }

                    //    }
                    //    //lbl_total.Text = Somme.ToString() + " DH ";
                    //}
                    #endregion
                    dg_Facture.Columns["ID_FAC"].Visible = false;
                }
                if (string.IsNullOrEmpty(txt_fournisseur.Text))
                {
                    Somme = 0;
                    dg_Facture.Columns.Clear();
                    AddCrudOperation = false;
                    LoadDate();
                    AddCrudOperation = false;
                    #region calculer total TTC
                    //if(dg_Facture.Rows.Count>0)
                    //{
                    //    dg_Facture.Columns["Numero Facture"].Frozen = true;
                    //    dg_Facture.Columns["Fournisseur"].Frozen = true;
                    //    foreach (DataGridViewRow ROW in dg_Facture.Rows)
                    //    {
                    //        float value = float.Parse(ROW.Cells["Total TTC"].Value.ToString().Replace(".", ","));
                    //        if (value < 0)
                    //        {
                    //            Somme -= value;
                    //        }
                    //        else
                    //        {
                    //            Somme += value;
                    //        }

                    //    }
                    //    //lbl_total.Text = Somme.ToString() + " DH ";
                    //}
                    #endregion
                    //dg_Facture.Columns["ID_FAC"].Visible =null?0:1 ;
                }
            }
            
            catch (Exception)
            {
                return;
            }
            //dg_Facture.Columns["ID_FAC"].Visible = false;
        }

        private void btn_imp_Click(object sender, EventArgs e)
        {
            Variable.IsSelected = chek_dept.Checked;
            //if (bgw == null)
            //{
                bgw = new BackgroundWorker();
                bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
                bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
                bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            //}
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.RunWorkerAsync();
            //Imprimer imp = new Imprimer();
            // imp.ShowDialog();
        }
        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new System.Action(() =>
            {
                btn_imp.Enabled = false;
            }));

            int total = 100; //some number (this is your variable to change)!!
            for (int i = 0; i <= total; i++) //some number (total)
            {
                System.Threading.Thread.Sleep(100);
                int percents = (i * 100) / total;
                bgw.ReportProgress(percents, i);
                //2 arguments:
                //1. procenteges (from 0 t0 100) - i do a calcumation 
                //2. some current value!
                //Imprimer imp = new Imprimer();
            }
           
            
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
           // lblStatus.Text = String.Format("Progress: {0} %", e.ProgressPercentage);
           // lblStatus.Text = String.Format("Total items transfered: {0}", e.UserState);
        }
        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Imprimer imp = new Imprimer();
           btn_imp.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(1000);
            //    backgroundWorker1.ReportProgress(i);

            //    //Check if there is a request to cancel the process
            //    if (backgroundWorker1.CancellationPending)
            //    {
            //        e.Cancel = true;
            //        backgroundWorker1.ReportProgress(0);
            //        return;
            //    }
            //}
            ////If the process exits the loop, ensure that progress is set to 100%
            ////Remember in the loop we set i < 100 so in theory the process will complete at 99%
            //backgroundWorker1.ReportProgress(100);

            int totalSteps = 100;

            for (int i = 0; i < totalSteps; i++)
            {
                // Do something...

                // Report progress, hint: sender is your worker
                (sender as BackgroundWorker).ReportProgress((int)(100 / 100) * i, null);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
               // lblStatus.Text = "Process was cancelled";
            }
            else if (e.Error != null)
            {
               // lblStatus.Text = "There was an error running the process. The thread aborted";
            }
            else
            {
              //  lblStatus.Text = "Process was completed";
            }
        }
    }
}
