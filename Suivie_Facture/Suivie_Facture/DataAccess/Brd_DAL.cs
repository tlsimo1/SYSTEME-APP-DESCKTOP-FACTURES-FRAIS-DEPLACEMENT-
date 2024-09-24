using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.DataAccess
{
    public class Brd_DAL
    {
        SqlDateTime sqldatenull;
        public void Insert_Facture(Facture facture)
        {
            
            string fournisseur = string.Empty;
            fournisseur = facture.Fournisseur;
            using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {

                    SqlCommand cmdord = new SqlCommand($"select count(*) from Factures ", connection, transaction);
                    var Order = cmdord.ExecuteScalar().ToString();


                    SqlCommand cmd = new SqlCommand($"INSERT INTO Factures (Num_Fac, Fournisseur, Date_Fac, Date_Saisie,Designation,ID_FAC,[Order],Departement) " +
                                                    $" VALUES('{facture.NumFacture}','{fournisseur.Trim().Replace("'", "''")}'," +
                                                    $"'{facture.Date_Facture.ToString("dd/MM/yyyy")}'," +
                                                    $"'{Convert.ToDateTime(facture.Date_Saisie.ToString("dd/MM/yyyy hh:mm:ss.fffffff"))}','{facture.Designation}','{facture.GuidVal}',{Order},'{facture.Departement}')", connection, transaction);
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = new SqlCommand($"INSERT INTO Bureau_Ord (Fac_Num, Date_Saisie, Statut_ORD,fac_id) " +
                                                     $"VALUES('{facture.NumFacture}','{DateTime.Now.ToString("dd/MM/yyyy")}'," +
                                                     $"{1},'{facture.GuidVal}')", connection, transaction);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd6 = new SqlCommand($"INSERT INTO Chef_Cmp (Fac_Num, Date_Saisie, Statut_ChefCMP,fac_id) " +
                                                         $"VALUES('{facture.NumFacture}',{sqldatenull}," +
                                                         $"{0},'{facture.GuidVal}')", connection, transaction);
                    sqldatenull = SqlDateTime.Null;
                    cmd6.ExecuteNonQuery();


                    SqlCommand cmd3 = new SqlCommand($"INSERT INTO Ass_DAF (Fac_Num, Date_Saisie, Statut_AssDaf,fac_id) " +
                                                         $"VALUES('{facture.NumFacture}',{sqldatenull},{0},'{facture.GuidVal}')", connection, transaction);
                    sqldatenull = SqlDateTime.Null;
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd4 = new SqlCommand($"INSERT INTO Cmp (Fac_Num, Date_Saisie, Statut_Cmp,Date_Comptabilisation,Statut_Final,fac_id) " +
                                                     $"VALUES('{facture.NumFacture}',{sqldatenull},{0},{sqldatenull},{0},'{facture.GuidVal}')", connection, transaction);
                    sqldatenull = SqlDateTime.Null;
                    cmd4.ExecuteNonQuery();

                    SqlCommand cmd5 = new SqlCommand($"INSERT INTO Achat (Fac_Num, Date_Saisie, Statut_Achat,fac_id) " +
                                                     $"VALUES('{facture.NumFacture}',{sqldatenull},{0},'{facture.GuidVal}')", connection, transaction);
                    sqldatenull = SqlDateTime.Null;
                    cmd5.ExecuteNonQuery();

                    transaction.Commit();
                    

                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                        throw;
                    }
                    catch (Exception)
                    {
                        connection.Close();
                        throw;
                    }
                }
            }

        }
    }
}
