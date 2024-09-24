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
    public class ChefCmp_DAL
    {
        public DataTable GetAllFactureChefCom()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"
                         select f.Num_Fac as [Numero Facture],
                         f.Fournisseur as [Fournisseur],
                         f.Date_Fac as [Date Facture],
                         b.Date_Saisie as [Date Saisie],
                         f.Designation as [Total TTC],

                         b.Date_Saisie as [Bureau d'ordre],
                         case when b.Statut_ORD = 1 then 'Validé' else 'Non Valide' end as [Statut Bureau d'ordre],
                         ad.Date_Saisie as [Assistante DAF], 
                         case when ad.Statut_AssDaf = 1 then 'Validé'  else 'Non Valide' end as [Statut Assistante DAF],
                         cf.Date_Saisie as [Chef Comptable],
						 case when cf.Statut_ChefCMP = 1 then 'Validé'  else 'Non Valide' end as [Statut Chef Comptable],
                         c.Date_Saisie as [Comptabilité] ,
						 case when c.Statut_Cmp = 1 then 'Validé'  else 'Non Valide' end as [Statut Comptabilité] ,
                         a.Date_Saisie as [Achat],
						 case when a.Statut_Achat = 1 then 'Validé'  else 'Non Valide' end as [Statut Achat],
                         c.Date_Comptabilisation as [Date Comptabilisation],
                         case when c.Statut_Final = 1 then 'Validé'  else 'Non Valide' end as [Statut Final],f.ID_FAC

                         from Factures f 
						 left
                         join Bureau_Ord b on f.ID_FAC = b.fac_id
                         left
                         join Achat a  on a.fac_id = f.ID_FAC 
						 left
                         join Ass_DAF ad on ad.fac_id = f.ID_FAC
                         left
                         join Cmp c on c.fac_id = f.ID_FAC
                         left
                         join Chef_Cmp cf on cf.fac_id = f.ID_FAC
                         where cf.Statut_ChefCMP = 0 and ad.Statut_AssDaf = 1; ", connection);

                    da.Fill(dt);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void Edit_StatusChefCom(string facNum)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "UPDATE Chef_Cmp SET Statut_ChefCMP = 1 , Date_Saisie= '" + DateTime.Now.ToString("dd/MM/yyyy") + "' WHERE fac_id = '" + facNum + "'";
                    cmd2.Connection = connection;
                    connection.Open();
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
        }

        public DataTable GetFacturechefCmp(string facNum)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"
                         select f.Num_Fac as [Numero Facture],
                         f.Fournisseur as [Fournisseur],
                         f.Date_Fac as [Date Facture],
                         b.Date_Saisie as [Date Saisie],
                         f.Designation as [Total TTC],

                         b.Date_Saisie as [Bureau d'ordre],
                         case when b.Statut_ORD = 1 then 'Validé' else 'Non Valide' end as [Statut Bureau d'ordre],
                         ad.Date_Saisie as [Assistante DAF], 
                         case when ad.Statut_AssDaf = 1 then 'Validé'  else 'Non Valide' end as [Statut Assistante DAF],
                         cf.Date_Saisie as [Chef Comptable],
						 case when cf.Statut_ChefCMP = 1 then 'Validé'  else 'Non Valide' end as [Statut Chef Comptable],
                         c.Date_Saisie as [Comptabilité] ,
						 case when c.Statut_Cmp = 1 then 'Validé'  else 'Non Valide' end as [Statut Comptabilité] ,
                         a.Date_Saisie as [Achat],
						 case when a.Statut_Achat = 1 then 'Validé'  else 'Non Valide' end as [Statut Achat],
                         c.Date_Comptabilisation as [Date Comptabilisation],
                         case when c.Statut_Final = 1 then 'Validé'  else 'Non Valide' end as [Statut Final],f.ID_FAC

                         from Factures f 
						 left
                         join Bureau_Ord b on f.ID_FAC = b.fac_id
                         left
                         join Achat a  on a.fac_id = f.ID_FAC 
						 left
                         join Ass_DAF ad on ad.fac_id = f.ID_FAC
                         left
                         join Cmp c on c.fac_id = f.ID_FAC
                         left
                         join Chef_Cmp cf on cf.fac_id = f.ID_FAC
                         where cf.Statut_ChefCMP = 0 and ad.Statut_AssDaf = 1 and f.Num_Fac  like '%" + facNum + "%'", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }

        public DataTable GetFactureParDateCmp(DateTime date)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"
                         select f.Num_Fac as [Numero Facture],
                         f.Fournisseur as [Fournisseur],
                         f.Date_Fac as [Date Facture],
                         b.Date_Saisie as [Date Saisie],
                         f.Designation as [Total TTC],

                         b.Date_Saisie as [Bureau d'ordre],
                         case when b.Statut_ORD = 1 then 'Validé' else 'Non Valide' end as [Statut Bureau d'ordre],
                         ad.Date_Saisie as [Assistante DAF], 
                         case when ad.Statut_AssDaf = 1 then 'Validé'  else 'Non Valide' end as [Statut Assistante DAF],
                         cf.Date_Saisie as [Chef Comptable],
						 case when cf.Statut_ChefCMP = 1 then 'Validé'  else 'Non Valide' end as [Statut Chef Comptable],
                         c.Date_Saisie as [Comptabilité] ,
						 case when c.Statut_Cmp = 1 then 'Validé'  else 'Non Valide' end as [Statut Comptabilité] ,
                         a.Date_Saisie as [Achat],
						 case when a.Statut_Achat = 1 then 'Validé'  else 'Non Valide' end as [Statut Achat],
                         c.Date_Comptabilisation as [Date Comptabilisation],
                         case when c.Statut_Final = 1 then 'Validé'  else 'Non Valide' end as [Statut Final],f.ID_FAC

                         from Factures f 
						 left
                         join Bureau_Ord b on f.ID_FAC = b.fac_id
                         left
                         join Achat a  on a.fac_id = f.ID_FAC 
						 left
                         join Ass_DAF ad on ad.fac_id = f.ID_FAC
                         left
                         join Cmp c on c.fac_id = f.ID_FAC
                         left
                         join Chef_Cmp cf on cf.fac_id = f.ID_FAC
                         where cf.Statut_ChefCMP = 0 and ad.Statut_AssDaf = 1 and f.Date_Fac = '" + date + "' ", connection);

                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
    }
}
