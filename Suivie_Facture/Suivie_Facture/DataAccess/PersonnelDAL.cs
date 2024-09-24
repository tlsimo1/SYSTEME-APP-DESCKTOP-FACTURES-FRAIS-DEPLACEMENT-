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
    public class PersonnelDAL
    {
        public DataTable GetAllPersonnel()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"select ID_Personnel, p.Matricule,p.Nom,p.Activite_Service,ca.Code_Analytique 
                                                          from Personnel p left join Code_Analytique ca 
                                                          on p.[Analytique_id] = ca.ID_Analytique ", connection);

                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public DataTable Get_Mat_CA(int idPersonnel)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter($@"SELECT p.Nom,ca.Code_Analytique 
                                        from [dbo].[Personnel] p inner join 
                                        [dbo].[Code_Analytique] ca on p.Analytique_id=ca.ID_Analytique
                                        where ID_Personnel={idPersonnel}", connection);

                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void Update_Personnel(Personnel personnel)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"UPDATE [dbo].[Personnel]
                                          SET [Matricule] = '{personnel.Matricule}'
                                         ,[Nom] ='{personnel.Nom}'
                                         ,[Activite_Service] = '{personnel.Activite_Service}'
                                         ,[Analytique_id] = {personnel.Analytique_id}
                                          where ID_Personnel ='{personnel.ID_Personnel}' ", connection);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }

        }
        public void Delete_Personnel(int id_Personnel)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"delete from [dbo].[Personnel] where ID_Personnel ={id_Personnel}", connection);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }

        }
        public DataTable GetPersonnel(string Mat_Nom_Ca)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"select ID_Personnel, p.Matricule,p.Nom,p.Activite_Service,ca.Code_Analytique 
                                                          from Personnel p left join Code_Analytique ca 
                                                          on p.[Analytique_id] = ca.ID_Analytique where p.Matricule like '%" + Mat_Nom_Ca + "%' or ca.Code_Analytique like '%" + Mat_Nom_Ca + "%' or  p.Nom like '%" + Mat_Nom_Ca + "%' ", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void Insert_Personnel(Personnel personnel)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"insert into  [dbo].[Personnel]values(
                                          '{personnel.Matricule}',
                                          '{personnel.Nom}',
                                         '{personnel.Activite_Service}',
                                          {personnel.Analytique_id})", connection);

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
