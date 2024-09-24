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
        public int GetStatutAchat(string facNum)
        {
            AssDAFDAL = new Com_DAL();
            return AssDAFDAL.GetStatutAchat(facNum);
        }
        public DataTable GetFactureCmp(string facNum)
        {
            AssDAFDAL = new Com_DAL();
            return AssDAFDAL.GetFactureCmp(facNum);
        }
        public void Edit_StatusFinal(string facNum)
        {
            AssDAFDAL = new Com_DAL();
            AssDAFDAL.Edit_StatusFinal(facNum);
        }
        public DataTable GetFactureParDateCmp(DateTime date)
        {
            AssDAFDAL = new Com_DAL();
            return AssDAFDAL.GetFactureParDateCmp(date);
        }
        
    }
}
