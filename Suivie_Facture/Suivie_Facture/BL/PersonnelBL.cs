using Suivie_Facture.Class;
using Suivie_Facture.DataAccess;
using Suivie_Facture.Frais_deplacement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class PersonnelBL
    {
        public PersonnelDAL personnelDAL;
        public DataTable GetAllPesonnel()
        {
            personnelDAL = new PersonnelDAL();
            return personnelDAL.GetAllPersonnel();
        }
        public DataTable Get_Mat_CA(int personnelID)
        {
            personnelDAL = new PersonnelDAL();
            return personnelDAL.Get_Mat_CA(personnelID);
        }
        public DataTable GetAllPersonnel()
        {
            personnelDAL = new PersonnelDAL();
            return personnelDAL.GetAllPersonnel();
        }
        public void Update_Personnel(Personnel personnel)
        {
            personnelDAL = new PersonnelDAL();
            personnelDAL.Update_Personnel(personnel);
        }
        public void Delete_Personnel(int id_Personnel)
        {
            personnelDAL = new PersonnelDAL();
            personnelDAL.Delete_Personnel(id_Personnel);
        }
        public DataTable GetPersonnel(string Mat_Nom)
        {
            personnelDAL = new PersonnelDAL();
           return personnelDAL.GetPersonnel(Mat_Nom);
        }
        public void Insert_Personnel(Personnel personnel)
        {
            personnelDAL = new PersonnelDAL();
            personnelDAL.Insert_Personnel(personnel);
        }
    }
}
