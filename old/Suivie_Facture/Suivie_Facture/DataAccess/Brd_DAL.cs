using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.DataAccess
{
    public class Brd_DAL
    {
        public void Insert_Facture(Facture facture)
        {
           
            try
            {

                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"INSERT INTO Factures (Num_Fac, Fournisseur, Date_Fac, Date_Saisie) VALUES('{facture.NumFacture}','{facture.Fournisseur}','{facture.Date_Facture.ToString("dd/MM/yyyy")}','{facture.Date_Saisie.ToString("dd/MM/yyyy")}')";
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    //connection.Close();

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = $"INSERT INTO Bureau_Ord (Fac_Num, Date_Saisie, Statut_ORD) VALUES('{facture.NumFacture}','{DateTime.Now.ToString("dd/MM/yyyy")}',{1})";
                    cmd2.Connection = connection;
                    //connection.Open();
                    cmd2.ExecuteNonQuery();
                    //connection.Close();
                    
                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.CommandText = $"INSERT INTO Ass_DAF (Fac_Num, Date_Saisie, Statut_AssDaf) VALUES('{facture.NumFacture}', '{DBNull.Value.ToString()} ',{0})";
                    cmd3.Connection = connection;
                    //connection.Open();
                    cmd3.ExecuteNonQuery();
                    //connection.Close();

                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.CommandText = $"INSERT INTO Cmp (Fac_Num, Date_Saisie, Statut_Cmp) VALUES('{facture.NumFacture}','{DBNull.Value.ToString()}',{0})";
                    cmd4.Connection = connection;
                    //connection.Open();
                    cmd4.ExecuteNonQuery();
                    //connection.Close();

                    SqlCommand cmd5 = new SqlCommand();
                    cmd5.CommandText = $"INSERT INTO Achat (Fac_Num, Date_Saisie, Statut_Achat) VALUES('{facture.NumFacture}','{DBNull.Value.ToString()}',{0})";
                    cmd5.Connection = connection;
                    //connection.Open();
                    cmd5.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
