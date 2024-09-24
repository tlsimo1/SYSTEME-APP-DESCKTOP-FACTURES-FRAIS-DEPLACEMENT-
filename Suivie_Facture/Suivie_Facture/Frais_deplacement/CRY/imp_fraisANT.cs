using Suivie_Facture.Class;
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
    public partial class imp_fraisANT : Form
    {
        public imp_fraisANT()
        {
            InitializeComponent();
            get_fraisANT();
        }
        void get_fraisANT()
        {
            DataTable dt2 = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Get_Frais_ANT", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dt2);
                    rpt_fraisANT cryFraisANT = new rpt_fraisANT();
                    cryFraisANT.Database.Tables["Get_Frais_ANT"].SetDataSource(dt2);
                    crv_fraisANT.ReportSource = cryFraisANT;
                    crv_fraisANT.Refresh();
                    this.Close();
                    string name2 = Environment.UserName;
                    string file = ($"C:\\Users\\{name2}\\Downloads\\Etat_FraisANT.pdf");
                    cryFraisANT.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, file);
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
