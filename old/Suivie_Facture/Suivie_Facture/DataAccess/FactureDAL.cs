using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Suivie_Facture.DataAccess
{
    public class FactureDAL
    {

        public  DataTable GetAllFacture()
        {
            DataTable dt = new DataTable();
            try
            {
                
                using (SqlConnection connection = new SqlConnection( Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "select f.Num_Fac as 'Numero Facture' ,f.Fournisseur,f.Date_Fac,b.Date_Saisie,b.Date_Saisie as Date_Saisi_ORD," +
                        "\r\na.Date_Saisie as Date_Saisi_Achat,ad.Date_Saisie as Date_Saisi_AssDAF,c.Date_Saisie as Date_Saisi_Cmp" +
                        "\r\n,case when b.Statut_ORD=1 then 'Valide' else 'Non Valide' end as statut_ord " +
                        "\r\n,case when a.Statut_Achat=1 then 'Valide' \r\nelse 'Non Valide' end as statut_achat" +
                        "\r\n,case when ad.Statut_AssDaf=1 then 'Valide' \r\nelse 'Non Valide' end as statut_AssDAF " +
                        "\r\n,case when c.Statut_Cmp=1 then 'Valide' \r\nelse 'Non Valide' end as statut_Cmp" +
                        "\r\nfrom Factures f left join Bureau_Ord b\r\non f.Num_Fac =b.Fac_Num left join Achat a " +
                        "\r\non  a.Fac_Num=f.Num_Fac left join Ass_DAF ad\r\non ad.Fac_Num =f.Num_Fac left join Cmp c" +
                        "\r\non c.Fac_Num =f.Num_Fac", connection);
                    
                    da.Fill(dt);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            return dt;
        }

        public DataTable GetDetail(string num_Fac)
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select  f.Num_Fac as 'Num Facture',f.Fournisseur,f.Date_Fac,b.Date_Saisie," +
                        "b.Date_Saisie as Date_Saisi_ORD," +
                        "\r\na.Date_Saisie as Date_Saisi_Achat,ad.Date_Saisie as Date_Saisi_AssDAF," +
                        "c.Date_Saisie as Date_Saisi_Cmp" +
                        "\r\n,case when b.Statut_ORD=1 then 'Valide' else 'Non Valide' end as statut_ord " +
                        "\r\n,case when a.Statut_Achat=1 then 'Valide' " +
                        "\r\nelse 'Non Valide' end as statut_achat\r\n," +
                        "case when ad.Statut_AssDaf=1 then 'Valide' " +
                        "\r\nelse 'Non Valide' end as statut_AssDAF " +
                        "\r\n,case when c.Statut_Cmp=1 then 'Valide' " +
                        "\r\nelse 'Non Valide' end as statut_Cmp" +
                        "\r\nfrom Factures f left join Bureau_Ord b" +
                        "\r\non f.Num_Fac =b.Fac_Num left join Achat a " +
                        "\r\non  a.Fac_Num=f.Num_Fac left join Ass_DAF ad" +
                        "\r\non ad.Fac_Num =f.Num_Fac left join Cmp c" +
                        "\r\non c.Fac_Num =f.Num_Fac where f.Num_Fac= '"+ num_Fac + "' ", connection);

                    da.Fill(dt);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            return dt;
        }
        public DataTable GetFacture(string facNum)
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select \r\nf.Num_Fac,\r\nf.Fournisseur,\r\nf.Date_Fac,\r\nb.Date_Saisie,\r\nisnull( b.Date_Saisie ,null) as Date_Saisi_ORD,\r\nisnull( a.Date_Saisie ,'') as Date_Saisi_Achat,\r\nad.Date_Saisie as Date_Saisi_AssDAF,\r\nc.Date_Saisie  as Date_Saisi_Cmp\r\n,case when b.Statut_ORD=1 then 'Valide' else 'Non Valide' end as statut_ord \r\n,case when a.Statut_Achat=1 then 'Valide' else 'Non Valide' end as statut_achat\r\n,case when ad.Statut_AssDaf=1 then 'Valide' else 'Non Valide' end as statut_AssDAF \r\n,case when c.Statut_Cmp=1 then 'Valide' else 'Non Valide' end as statut_Cmp\r\nfrom Factures f left join Bureau_Ord b\r\non f.Num_Fac =b.Fac_Num left join Achat a \r\non  a.Fac_Num=f.Num_Fac left join Ass_DAF ad\r\non ad.Fac_Num =f.Num_Fac left join Cmp c\r\non" +
                        " c.Fac_Num =f.Num_Fac where f.Num_Fac like '%" + facNum + "%'", connection);

                    da.Fill(dt);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            return dt;
        }
        public bool LogIn(string login,string password)
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($"select count(*) from Users  where UserName like '{login}' and Password like '{password}' ", connection);
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString()=="1")
                        Variable.IsConnected = true;
                    else
                        Variable.IsConnected = false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            return Variable.IsConnected;
        }
    }
}
