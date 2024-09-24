using Suivie_Facture.BL;
using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.DataAccess
{
    public class Code_AnalytiqueDAL
    {
        public DataTable GetAll_CodeAnalytique()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"select  * from Code_Analytique", connection);

                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void Update_CodeAnalytique(Code_Analytique code_analytique)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"UPDATE Code_Analytique
                                          SET Activite_Service = '{code_analytique.Activite_Service}'
                                         ,Code_Analytique ='{code_analytique.CodeAnalytique}'
                                          where ID_Analytique ='{code_analytique.ID_Analytique}' ", connection);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }

        }
        public void Delete_CodeAnalytique(int id_CodeAnalytique)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"delete from Code_Analytique where  ID_Analytique ={id_CodeAnalytique} ", connection);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }

        }
        public DataTable GetCodeAnalytique(string Code)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT * from Code_Analytique
                         where Code_Analytique like '%" + Code + "%' or Activite_Service like '%" + Code + "%' ", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void Insert_CodeAnalytique(Code_Analytique code_Analytique)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"INSERT INTO [dbo].[Code_Analytique]
                                                   ([Activite_Service]
                                                   ,[Code_Analytique])
                                                    VALUES
                                                     ('{code_Analytique.Activite_Service}',
                                                       '{code_Analytique.CodeAnalytique}')", connection);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }

        }
    }
}
