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
    public partial class imp_FraisCirculation : Form
    {
       
        string Etat = string.Empty;
        public imp_FraisCirculation(string etat)
        {
            InitializeComponent();
            this.Etat = etat;
            get_Frais(Etat);
        }
        void get_Frais(string etat)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Get_Frais_Circulation", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Etat", etat);
                    da.Fill(dt);
                    rpt_FraisCirculation cryFrais = new rpt_FraisCirculation();
                    cryFrais.Database.Tables["Get_Frais_Circulation"].SetDataSource(dt);
                    crv_report.ReportSource = cryFrais;
                    crv_report.Refresh();
                    this.Close();
                    string name2 = Environment.UserName;
                    string file = ($"C:\\Users\\{name2}\\Downloads\\Etat_FraisCirculation.pdf");
                    cryFrais.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, file);
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
