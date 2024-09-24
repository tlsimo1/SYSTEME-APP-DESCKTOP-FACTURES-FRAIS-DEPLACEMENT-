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
    public class Com_DAL
    {
        public DataTable GetAllFactureCom()
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
                         where (c.Statut_Cmp = 0 and cf.Statut_ChefCMP = 1) or 
                         (c.Statut_Cmp = 1 and cf.Statut_ChefCMP = 1 and a.Statut_Achat = 1 and b.Statut_ORD = 1 
                          and  ad.Statut_AssDaf = 1 and c.Statut_Final=0) ; ", connection);

                    da.Fill(dt);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            return dt;
        }
        public DataTable GetFactureCmp(string facNum)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($@"

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
                         where (c.Statut_Cmp = 0 and cf.Statut_ChefCMP = 1 AND f.Num_Fac  like '%{facNum}%') or 
                         (c.Statut_Cmp = 1 and cf.Statut_ChefCMP = 1 and a.Statut_Achat = 1 and b.Statut_ORD = 1 
                          and  ad.Statut_AssDaf = 1 and c.Statut_Final=0 AND f.Num_Fac  like '%{facNum}%')  ", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void Edit_StatusCom(string facNum)
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
                    cmd2.CommandText = "UPDATE Cmp SET Statut_Cmp = 1 , Date_Saisie= '" + DateTime.Now.ToString("dd/MM/yyyy") + "' WHERE fac_id = '" + facNum + "'";
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

        public DataTable GetAllFactureComNonComptabilisee()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"select f.Num_Fac as 'Numero Facture',f.Fournisseur,f.Date_Fac,b.Date_Saisie,
                         b.Date_Saisie as [Date Saisie ORD],f.Designation as [Total TTC],c.Date_Comptabilisation as [Date Comptabilisation],
						 case when b.Statut_ORD = 1 then 'Validé' else 'Non Valide' end as [Statut ORD],
						 ad.Date_Saisie as [Date Saisie Assistante DAF], 
						 case when ad.Statut_AssDaf = 1 then 'Validé'  else 'Non Valide' end as [Statut Assistante DAF] ,
						 c.Date_Saisie as [Date Saisie CMP] ,
						 case when c.Statut_Cmp = 1 then 'Validé'  else 'Non Valide' end as [Statut CMP] ,
						 a.Date_Saisie as [Date Saisie Achat],
						 case when a.Statut_Achat = 1 then 'Validé'  else 'Non Valide' end as [Statut Achat],
                         cf.Date_Saisie as [Date Saisie Chef Comptable],
						 case when cf.Statut_ChefCMP = 1 then 'Validé'  else 'Non Valide' end as [Statut Chef Comptable],
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
                         where c.Statut_Cmp = 1 and a.Statut_Achat = 1 and
                         b.Statut_ORD = 1 and c.Statut_Final = 0 and ad.Statut_AssDaf = 1 and cf.Statut_ChefCMP = 1; ", connection);

                    da.Fill(dt);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }

        public int GetStatutAchat(string numFac)
        {
            int Statut = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("Select Statut_Achat From Achat where fac_id='" + numFac + "' ", connection))
                    {
                        Statut = (Int32)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            return Statut;
        }
        public void Edit_StatusFinal(string facNum)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "UPDATE Cmp SET Statut_Final = 1 , Date_Comptabilisation= '" + DateTime.Now.ToString("dd/MM/yyyy") + "' WHERE fac_id = '" + facNum + "'";
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

        public DataTable GetFactureParDateCmp(DateTime date)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($@"

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
                         where (c.Statut_Cmp = 0 and cf.Statut_ChefCMP = 1 AND f.Date_Fac  = '{date}') or 
                         (c.Statut_Cmp = 1 and cf.Statut_ChefCMP = 1 and a.Statut_Achat = 1 and b.Statut_ORD = 1 
                          and  ad.Statut_AssDaf = 1 and c.Statut_Final=0 AND f.Date_Fac  = '{date}')  ", connection);

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
