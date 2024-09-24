using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Suivie_Facture.DataAccess
{
    public class User_DAL
    {
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"select * from Users", connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void AjouterUser(string username,string password,string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {

                    SqlCommand cmd = new SqlCommand($"INSERT INTO Users (UserName, Password, Role) values ('{username}','{password}','{role}') ", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
        }
        public void UpdateUser(string username, string password, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {

                    SqlCommand cmd = new SqlCommand($"update  Users set Password='{password}' ,Role ='{role}' where UserName='{username}'", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void DeleteUser(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {

                    SqlCommand cmd = new SqlCommand($"delete from Users where UserName='{username}'", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public bool ChekIfExist(string login)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($"select count(*) from Users  where UserName like '{login}' ", connection);
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                        Variable.IsExist = true;
                    else
                        Variable.IsExist = false;

                    connection.Close();

                }
            }
            catch (Exception e)
            {
                throw;
            }
            return Variable.IsExist;
        }
        public DataTable RemplirComBox()
        
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"select distinct(Role) from Users", connection);
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
