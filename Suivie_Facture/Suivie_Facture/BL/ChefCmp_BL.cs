using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class ChefCmp_BL
    {
        public ChefCmp_DAL chefComDAL;
        public DataTable GetAllChefComFacture()
        {
            chefComDAL = new ChefCmp_DAL();
            return chefComDAL.GetAllFactureChefCom();
        }
        public DataTable GetFactureChefCmp(string facNum)
        {
            chefComDAL = new ChefCmp_DAL();
            return chefComDAL.GetFacturechefCmp(facNum);
        }
        public void Edit_StatusChefCom(string facNum)
        {
            chefComDAL = new ChefCmp_DAL();
            chefComDAL.Edit_StatusChefCom(facNum);
        }
        public DataTable GetFactureParDateChefCmp(DateTime date)
        {
            chefComDAL = new ChefCmp_DAL();
            return chefComDAL.GetFactureParDateCmp(date);
        }
        
    }
}
