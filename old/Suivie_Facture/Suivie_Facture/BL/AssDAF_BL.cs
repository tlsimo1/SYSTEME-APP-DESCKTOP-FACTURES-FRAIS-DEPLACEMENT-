using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class AssDAF_BL
    {
        public AssDAF_DAL AssDAFDAL;
        public DataTable GetAllAssDAFFacture()
        {
            AssDAFDAL = new AssDAF_DAL();
            return AssDAFDAL.GetAllFactureAssDAF();
        }
        public void Edit_Status(string facNum)
        {
            AssDAFDAL = new AssDAF_DAL();
            AssDAFDAL.Edit_Status(facNum);
        }
    }
}
