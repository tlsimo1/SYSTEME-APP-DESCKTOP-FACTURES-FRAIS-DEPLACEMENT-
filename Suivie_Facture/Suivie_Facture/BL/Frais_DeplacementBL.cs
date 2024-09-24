using Suivie_Facture.Class;
using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class Frais_DeplacementBL
    {
        public Frais_DeplacementDAL fraisDeplacementDAL;

        public DataTable GetAllFraisDeplacement()
        {
            fraisDeplacementDAL = new Frais_DeplacementDAL();
            return fraisDeplacementDAL.GetAllFraisDeplacement();
        }
        public void Update_fraisDeplacement(Frais_Deplacement frais_Deplacement)
        {
            fraisDeplacementDAL = new Frais_DeplacementDAL();
            fraisDeplacementDAL.Update_FraisDeplacement(frais_Deplacement);
        }
        public void Delete_fraisDeplacement(int id_Frais)
        {
            fraisDeplacementDAL = new Frais_DeplacementDAL();
            fraisDeplacementDAL.Delete_FraisDeplacement(id_Frais);
        }
        public void Insert_fraisDeplacement(Frais_Deplacement frais_Deplacement)
        {
            fraisDeplacementDAL = new Frais_DeplacementDAL();
            fraisDeplacementDAL.Insert_FraisDeplacement(frais_Deplacement);
        }
        public DataTable GetFraisDeplacement(string Mat_Nom)
        {
            fraisDeplacementDAL = new Frais_DeplacementDAL();
            return fraisDeplacementDAL.GetFraisDeplacement(Mat_Nom);
        }
        public DataTable GetFarisDeplacementParDate(DateTime date)
        {
            fraisDeplacementDAL = new Frais_DeplacementDAL();
            return fraisDeplacementDAL.GetFarisDeplacementParDate(date);
        }
    }
}
