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
    public partial class Imp_ModReg : Form
    {
        string Mode = string.Empty;
        public Imp_ModReg(string Mod)
        {
            InitializeComponent();
            this.Mode = Mod;
            Get_Etat(Mode);
        }

        void Get_Etat(string mode)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Get_EtatParMod", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Mode", mode);
                    da.Fill(dt);
                    rpt_ModReg rpt_Reglement = new rpt_ModReg();
                    rpt_Reglement.Database.Tables["Get_EtatParVirement"].SetDataSource(dt);
                    crv_modReg.ReportSource = rpt_Reglement;
                    crv_modReg.Refresh();
                    this.Close();
                    string name2 = Environment.UserName;
                    string file = ($"C:\\Users\\{name2}\\Downloads\\Etat_ParModeRegelemnt.pdf");
                    rpt_Reglement.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, file);
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
