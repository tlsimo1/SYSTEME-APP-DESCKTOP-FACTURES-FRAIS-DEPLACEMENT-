using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Suivie_Facture.BL;
using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Suivie_Facture
{
    public partial class Imprimer : Form
    {
        Facture_BL facture_BL = new Facture_BL();
        Factures FacturesDS = new Factures();
        Imprimer_Factures imp = new Imprimer_Factures();
        Imprimer_Factures_Achats imp_Achats = new Imprimer_Factures_Achats();
        DataTable datatable = new DataTable();
        DataTable datatable_Fournisseur = new DataTable();

        public Imprimer()
        {
            string name2 = Environment.UserName;
            string file = ($"C:\\Users\\{name2}\\Downloads\\Factures.pdf");
            try
            {
                InitializeComponent();
                if (Variable.IsSelected == true)
                {
                    datatable = facture_BL.GetFactureImp2(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));
                    int count = datatable.Rows.Count;
                    DataTableReader reader = datatable.CreateDataReader();
                    DataSet ds = new DataSet();
                    ds = new Factures();
                    ds.Tables["Factures"].Load(reader);
                    imp_Achats.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = imp_Achats;
                    crystalReportViewer1.Refresh();
                    imp_Achats.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, file);
                    System.Diagnostics.Process.Start(file);
                }
                else
                {
                    datatable = facture_BL.GetFactureImp(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));
                    int count = datatable.Rows.Count;
                    DataTableReader reader = datatable.CreateDataReader();
                    DataSet ds = new DataSet();
                    ds = new Factures();
                    ds.Tables["Factures"].Load(reader);
                    imp.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = imp;
                    crystalReportViewer1.Refresh();
                    imp.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, file);
                    System.Diagnostics.Process.Start(file);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
