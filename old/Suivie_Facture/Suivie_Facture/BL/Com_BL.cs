using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class Com_BL
    {
        public Com_DAL AssDAFDAL;
        public DataTable GetAllComFacture()
        {
            AssDAFDAL = new Com_DAL();
            return AssDAFDAL.GetAllFactureCom();
        }
        public void Edit_StatusCom(string facNum)
        {
            AssDAFDAL = new Com_DAL();
            AssDAFDAL.Edit_StatusCom(facNum);
        }
    }
}
