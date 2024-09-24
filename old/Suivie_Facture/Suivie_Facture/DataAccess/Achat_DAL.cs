using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.DataAccess
{
    public class Achat_DAL
    {
        public DataTable GetAllFactureAchat()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select f.Num_Fac as 'Numero Facture',f.Fournisseur,f.Date_Fac,b.Date_Saisie," +
                        "b.Date_Saisie as Date_Saisi_ORD, a.Date_Saisie as Date_Saisi_Achat,ad.Date_Saisie as Date_Saisi_AssDAF," +
                        "c.Date_Saisie as Date_Saisi_Cmp ,case when b.Statut_ORD=1 then 'Valide' else 'Non Valide' end as statut_ord  ," +
                        "case when a.Statut_Achat=1 then 'Valide'  else 'Non Valide' end as statut_achat ," +
                        "case when ad.Statut_AssDaf=1 then 'Valide'  else 'Non Valide' end as statut_AssDAF  ," +
                        "case when c.Statut_Cmp=1 then 'Valide'  else 'Non Valide' end as statut_Cmp " +
                        "from Factures f left join Bureau_Ord b on f.Num_Fac =b.Fac_Num " +
                        "left join Achat a  on  a.Fac_Num=f.Num_Fac left join Ass_DAF ad on ad.Fac_Num =f.Num_Fac" +
                        " left join Cmp c on c.Fac_Num =f.Num_Fac where a.Statut_Achat =0;", connection);

                    da.Fill(dt);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            return dt;
        }
        public void Edit_StatusAchat(string facNum)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = $"INSERT INTO Ass_DAF (Fac_Num, Date_Saisie, Statut_AssDaf) VALUES('{facNum}','{DateTime.Now.ToString("dd/MM/yyyy")}',{1})";
                    //cmd.Connection = connection;
                    //connection.Open();
                    //cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "UPDATE Achat SET Statut_Achat = 1  , Date_Saisie= '" + DateTime.Now.ToString("dd/MM/yyyy") + "' WHERE Fac_Num = '" + facNum + "'";
                    cmd2.Connection = connection;
                    connection.Open();
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
        }
    }
}
