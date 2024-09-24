using Suivie_Facture.Class;
using Suivie_Facture.Frais_deplacement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture.Frais_deplacement.CRY
{
    public partial class Etat_Avancement : Form
    {
        rpt_FraisAvancment cryFraisAvancement = new rpt_FraisAvancment();
        public Etat_Avancement()
        {
            InitializeComponent();
            get_Frais_Avancement();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        void get_Frais_Avancement()
        {
            
            DataTable dt2 = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Get_EtatDesAvances", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dt2);
                    
                    cryFraisAvancement.Database.Tables["Get_Frais_Avancement"].SetDataSource(dt2);
                    crv_avancement.ReportSource = cryFraisAvancement;
                    crv_avancement.Refresh();
                    this.Close();
                    string name2 = Environment.UserName;
                    string file = ($"C:\\Users\\{name2}\\Downloads\\Etat_Avancement.pdf");
                    cryFraisAvancement.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, file);
                    System.Diagnostics.Process.Start(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
            }
        }
    }
}
