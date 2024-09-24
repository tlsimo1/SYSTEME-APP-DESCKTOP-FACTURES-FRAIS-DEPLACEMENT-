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
    public class Frais_DeplacementDAL
    {
        public DataTable GetAllFraisDeplacement()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT fr.ID_Frais,p.Matricule,p.Nom,ca.Code_Analytique as 'Code Analytique',
                                        fr.Frais_Kilometre as 'Frais kilometrique',fr.Frais_Deplacement as 'Frais Deplacement',
                                        fr.Periode_Deplacement as 'Periode',fr.Circulation_Frais_Dplacement as 'Circulation',
                                        fr.Date_Regelement_Frais as 'Date Reglement',fr.Reprise_Frais as 'Reprise Frais',
                                        fr.Date_Avancement as 'Date Avance',fr.Montant_Avancement as 'Montant Avance',fr.Ville_Region as 'Ville Region',
                                        fr.Mode_Reglement as 'Mode Reglement',fr.Date_Preparation as 'Date Preparation'
                                        FROM [dbo].[Frais_Deplacement] fr INNER JOIN [dbo].[Personnel] p
                                        on fr.Personnel_id = p.ID_Personnel inner join 
                                        [dbo].[Code_Analytique] ca on p.Analytique_id=ca.ID_Analytique", connection);

                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public void Update_FraisDeplacement(Frais_Deplacement frais_deplacement )
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"UPDATE Frais_Deplacement
                                         SET Date_Saisie = '{DateTime.Now}'
                                         ,Frais_Kilometre = {frais_deplacement.Frais_Kilometrique.ToString().Replace(',', '.')},
                                         Frais_Deplacement = {frais_deplacement.FraisDeplacement.ToString().Replace(',', '.')}
                                         ,Periode_Deplacement = '{frais_deplacement.Periode_Deplacement }',
                                         Circulation_Frais_Dplacement = '{frais_deplacement.Circulation}'
                                         ,Date_Regelement_Frais =  '{frais_deplacement.Date_Regelement }',
                                         Reprise_Frais = '{frais_deplacement.Reprise_Frais}'
                                         ,Date_Avancement =  '{frais_deplacement.Date_Avancement }',
                                         Montant_Avancement ={frais_deplacement.Montant_Avance.ToString().Replace(',', '.')} ,
                                         Mat_PER = '{frais_deplacement.Mat_PER}',
                                          Ville_Region = '{frais_deplacement.Ville_Region}'
                                         ,Mode_Reglement = '{frais_deplacement.Mode_Reglement}',
                                         Date_Preparation = '{frais_deplacement.Date_Preparation }',
                                         Periode_De = '{frais_deplacement.Periode_De}',
                                         Periode =  '{frais_deplacement.Periode}',
                                         Personnel_id = {frais_deplacement.Personnel_id}
		                                 where ID_Frais={frais_deplacement.ID_Frais}", connection);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
           
        }
        public void Delete_FraisDeplacement(int id_Frais)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"delete from Frais_Deplacement where ID_Frais ={id_Frais}", connection);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }

        }
        public void Insert_FraisDeplacement(Frais_Deplacement frais_deplacement)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($@"insert into  Frais_Deplacement values(
                                          '{DateTime.Now}'
                                         ,{frais_deplacement.Frais_Kilometrique.ToString().Replace(',', '.')},
                                          {frais_deplacement.FraisDeplacement.ToString().Replace(',', '.')}
                                         ,'{frais_deplacement.Periode_Deplacement}',
                                          '{frais_deplacement.Circulation}'
                                         ,'{frais_deplacement.Date_Regelement}',
                                          '{frais_deplacement.Reprise_Frais}'
                                         ,'{frais_deplacement.Date_Avancement}',
                                          {frais_deplacement.Montant_Avance.ToString().Replace(',', '.')} ,
                                          '{frais_deplacement.Mat_PER}',
                                          '{frais_deplacement.Ville_Region}'
                                         ,'{frais_deplacement.Mode_Reglement}',
                                          '{frais_deplacement.Date_Preparation}',
                                          '{frais_deplacement.Periode_De}',
                                          '{frais_deplacement.Periode}',
                                          {frais_deplacement.Personnel_id}
		                                 )", connection);

                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }

        }
        public DataTable GetFraisDeplacement(string Mat_Nom)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT fr.ID_Frais,p.Matricule,p.Nom,ca.Code_Analytique as 'Code Analytique',
                                        fr.Frais_Kilometre as 'Frais kilometrique',fr.Frais_Deplacement as 'Frais Deplacement',
                                        fr.Periode_Deplacement as 'Periode',fr.Circulation_Frais_Dplacement as 'Circulation',
                                        fr.Date_Regelement_Frais as 'Date Reglement',fr.Reprise_Frais as 'Reprise Frais',
                                        fr.Date_Avancement as 'Date Avance',fr.Montant_Avancement as 'Montant Avance',fr.Ville_Region as 'Ville Region',
                                        fr.Mode_Reglement as 'Mode Reglement',fr.Date_Preparation as 'Date Preparation'
                                        FROM [dbo].[Frais_Deplacement] fr INNER JOIN [dbo].[Personnel] p
                                        on fr.Personnel_id = p.ID_Personnel inner join 
                                        [dbo].[Code_Analytique] ca on p.Analytique_id=ca.ID_Analytique
                         where p.Matricule like '%" + Mat_Nom + "%' or p.Nom like '%" + Mat_Nom + "%' or ca.Code_Analytique like '%" + Mat_Nom + "%' ",  connection);
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e);
            }
            return dt;
        }
        public DataTable GetFarisDeplacementParDate(DateTime date)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString_FarisDeplacement))
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT fr.ID_Frais,p.Matricule,p.Nom,ca.Code_Analytique as 'Code Analytique',
                                        fr.Frais_Kilometre as 'Frais kilometrique',fr.Frais_Deplacement as 'Frais Deplacement',
                                        fr.Periode_Deplacement as 'Periode',fr.Circulation_Frais_Dplacement as 'Circulation',
                                        fr.Date_Regelement_Frais as 'Date Reglement',fr.Reprise_Frais as 'Reprise Frais',
                                        fr.Date_Avancement as 'Date Avance',fr.Montant_Avancement as 'Montant Avance',fr.Ville_Region as 'Ville Region',
                                        fr.Mode_Reglement as 'Mode Reglement',fr.Date_Preparation as 'Date Preparation'
                                        FROM [dbo].[Frais_Deplacement] fr INNER JOIN [dbo].[Personnel] p
                                        on fr.Personnel_id = p.ID_Personnel inner join 
                                        [dbo].[Code_Analytique] ca on p.Analytique_id=ca.ID_Analytique where  fr.Date_Saisie = '" + date + "' ", connection);

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
