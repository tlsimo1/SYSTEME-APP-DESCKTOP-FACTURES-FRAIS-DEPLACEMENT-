using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Suivie_Facture.DataAccess
{
    public class FactureDAL
    {
        public DataTable GetAllFacture()
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
                         join Chef_Cmp cf on cf.fac_id = f.ID_FAC", connection);

                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
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
                    SqlDataAdapter da = new SqlDataAdapter(@"

                       select f.Num_Fac as [Numero Facture],
                       f.Fournisseur as [Fournisseur],
                       FORMAT(f.Date_Fac, 'dd-MM-yyyy' ) as [Date Facture],
                       FORMAT(f.Date_Saisie, 'dd-MM-yyyy' ) as [Date Saisie],
                       f.Designation as [Total TTC],

                       FORMAT(b.Date_Saisie, 'dd-MM-yyyy' ) as [Bureau d'ordre],
                       case when b.Statut_ORD = 1 then 'Validé' else 'Non Valide' end as [Statut Bureau d'ordre],
                       FORMAT(ad.Date_Saisie, 'dd-MM-yyyy' ) as [Assistante DAF], 
                       case when ad.Statut_AssDaf = 1 then 'Validé'  else 'Non Valide' end as [Statut Assistante DAF],
                       FORMAT(cf.Date_Saisie, 'dd-MM-yyyy' ) as [Chef Comptable],
					   case when cf.Statut_ChefCMP = 1 then 'Validé'  else 'Non Valide' end as [Statut Chef Comptable],
                       FORMAT(c.Date_Saisie, 'dd-MM-yyyy' ) as [Comptabilité] ,
					   case when c.Statut_Cmp = 1 then 'Validé'  else 'Non Valide' end as [Statut Comptabilité] ,
                       FORMAT(a.Date_Saisie, 'dd-MM-yyyy' ) as [Achat],
					   case when a.Statut_Achat = 1 then 'Validé'  else 'Non Valide' end as [Statut Achat],
                       FORMAT(c.Date_Comptabilisation, 'dd-MM-yyyy' ) as [Date Comptabilisation],
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
                       where f.ID_FAC= '" + num_Fac + "' ", connection);

                    da.Fill(dt);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
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
                                                where f.Num_Fac  like '%" + facNum + "%'", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public DataTable GetFactureParDate(DateTime date)
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
                         where f.Date_Fac = '" + date + "' ", connection);

                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public bool LogIn(string login, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($"select count(*) from Users  where UserName like '{login}' and Password like '{password}' ", connection);
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                        Variable.IsConnected = true;
                    else
                        Variable.IsConnected = false;


                    SqlCommand cmd = new SqlCommand($"select * from Users  where UserName like '{login}' and Password like '{password}' ", connection);
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                        Variable.GetRol = dr["Role"].ToString();

                    connection.Close();

                }
            }
            catch (Exception e)
            {
                throw;
            }
            return Variable.IsConnected;
        }
        public void DeleteFacture(string facNum)
        {
            using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand cmd1 = new SqlCommand($" delete from Achat where fac_id like '{facNum}' ", connection, transaction);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand($"delete from Ass_DAF  where fac_id like '{facNum}'", connection, transaction);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand($"delete from Bureau_Ord  where fac_id like '{facNum}'", connection, transaction);
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd4 = new SqlCommand($"delete from Cmp  where fac_id like '{facNum}'", connection, transaction);
                    cmd4.ExecuteNonQuery();

                    SqlCommand cmd6 = new SqlCommand($"delete from Chef_Cmp  where fac_id like '{facNum}'", connection, transaction);
                    cmd6.ExecuteNonQuery();

                    SqlCommand cmd5 = new SqlCommand($"delete from Factures  where ID_FAC like '{facNum}'", connection, transaction);
                    cmd5.ExecuteNonQuery();

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    connection.Close();
                    throw;
                }
            }
        }
        public DataTable AutoCompletTextBox()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"select [raisonsocial] from [StrCristalDB].[dbo].[Fournisseur]", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void UpdateFacture(dynamic Facture)
        {
            SqlDateTime sqldatenull;
            sqldatenull = SqlDateTime.Null;
            using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand cmd1 = new SqlCommand($"Update  Factures set Fournisseur='{Facture.Fournisseur}',Date_Fac='{Facture.DateFacture}',Date_Saisie='{Facture.DateSaisie}',Designation='{Facture.TotalTTC}' where ID_FAC like '{Facture.guidNum}' ", connection, transaction);
                    cmd1.ExecuteNonQuery();


                    if (Facture.StatutAchat == 1)
                    {
                        SqlCommand cmd2 = new SqlCommand($"Update  Achat set Date_Saisie='{Facture.DateAchat}',Statut_Achat='{Facture.StatutAchat}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand($"Update  Achat set Date_Saisie={sqldatenull},Statut_Achat='{Facture.StatutAchat}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd2.ExecuteNonQuery();
                    }


                    if (Facture.StatutAssDaf == 1)
                    {
                        SqlCommand cmd3 = new SqlCommand($"Update  Ass_DAF set Date_Saisie='{Facture.DateAssDaf}',Statut_AssDaf='{Facture.StatutAssDaf}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd3.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd3 = new SqlCommand($"Update  Ass_DAF set Date_Saisie={sqldatenull},Statut_AssDaf='{Facture.StatutAssDaf}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd3.ExecuteNonQuery();
                    }


                    if (Facture.StatutOrdre == 1)
                    {
                        SqlCommand cmd4 = new SqlCommand($"Update  Bureau_Ord set Date_Saisie='{Facture.DateBureauOrdre}',Statut_ORD='{Facture.StatutOrdre}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd4.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd4 = new SqlCommand($"Update  Bureau_Ord set Date_Saisie={sqldatenull},Statut_ORD='{Facture.StatutOrdre}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd4.ExecuteNonQuery();
                    }


                    if (Facture.StatutChefCmp == 1)
                    {
                        SqlCommand cmd6 = new SqlCommand($"Update  Chef_Cmp set Date_Saisie='{Facture.DateChefCmp}',Statut_ChefCMP='{Facture.StatutChefCmp}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd6.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd6 = new SqlCommand($"Update  Chef_Cmp set Date_Saisie={sqldatenull},Statut_ChefCMP='{Facture.StatutChefCmp}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd6.ExecuteNonQuery();
                    }


                    if (Facture.StatutCmp == 1)
                    {
                        SqlCommand cmd5 = new SqlCommand($"Update  Cmp set Date_Saisie='{Facture.DateCmp}',Statut_Cmp='{Facture.StatutCmp}',Date_Comptabilisation='{Facture.DateComptabilisation}',Statut_Final='{Facture.StatutComptabilisation}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd5.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd5 = new SqlCommand($"Update  Cmp set Date_Saisie={sqldatenull},Statut_Cmp='{Facture.StatutCmp}',Date_Comptabilisation='{Facture.DateComptabilisation}',Statut_Final='{Facture.StatutComptabilisation}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd5.ExecuteNonQuery();
                    }


                    if (Facture.StatutComptabilisation == 1)
                    {
                        SqlCommand cmd6 = new SqlCommand($"Update  Cmp set Date_Saisie='{Facture.DateCmp}',Statut_Cmp='{Facture.StatutCmp}',Date_Comptabilisation='{Facture.DateComptabilisation}',Statut_Final='{Facture.StatutComptabilisation}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                        cmd6.ExecuteNonQuery();
                    }
                    else
                    {
                        if (Facture.StatutCmp == 1)
                        {
                            SqlCommand cmd6 = new SqlCommand($"Update  Cmp set Date_Saisie='{Facture.DateCmp}',Statut_Cmp='{Facture.StatutCmp}',Date_Comptabilisation={sqldatenull},Statut_Final='{Facture.StatutComptabilisation}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                            cmd6.ExecuteNonQuery();
                        }
                        else
                        {
                            SqlCommand cmd6 = new SqlCommand($"Update  Cmp set Date_Saisie={sqldatenull},Statut_Cmp='{Facture.StatutCmp}',Date_Comptabilisation={sqldatenull},Statut_Final='{Facture.StatutComptabilisation}'  where fac_id like '{Facture.guidNum}'", connection, transaction);
                            cmd6.ExecuteNonQuery();
                        }

                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    connection.Close();
                    throw;
                }
            }
        }

        public DataTable GetFactureParFournisseur(string Nom_Fournisseur)
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
                                                where f.Fournisseur  like '%" + Nom_Fournisseur + "%'", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }

        public DataTable GetFactureImp(DateTime date)
        {
            string date2 = string.Empty;
            date2 = date.ToString("dd-MM-yy");
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($@"select * from Factures where CONVERT(VARCHAR, Date_Saisie, 5) = '{date2}'   order by [Order]", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }

        public DataTable GetFactureImp3(DateTime date)
        {
            string date2 = string.Empty;
            date2 = date.ToString("dd-MM-yy");
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($@"select * from Factures where CONVERT(VARCHAR, Date_Saisie, 5) = '{date2}'and Departement='Achats'   order by [Order]", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }

        public DataTable GetFactureImp2(DateTime date)
        {
            string date2 = string.Empty;
            date2 = date.ToString("dd-MM-yy");
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetAllFactureByDate", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Date", SqlDbType.NVarChar).Value = date2;
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.Fill(dt);
                    }
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
