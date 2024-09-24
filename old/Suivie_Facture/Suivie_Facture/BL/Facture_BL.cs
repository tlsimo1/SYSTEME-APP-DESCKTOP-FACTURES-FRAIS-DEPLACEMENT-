using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class Facture_BL
    {
        public FactureDAL factureDAL;
        public DataTable GetAllFacture()
        {
            factureDAL = new FactureDAL();
            return factureDAL.GetAllFacture();
        }
        public bool LogIn(string login,string password)
        {
            factureDAL = new FactureDAL();
            return factureDAL.LogIn( login, password);
        }
        public DataTable GetDetail(string numFac)
        {
            factureDAL = new FactureDAL();
            return factureDAL.GetDetail(numFac);
        }
        public DataTable GetFacture(string numFac)
        {
            factureDAL = new FactureDAL();
            return factureDAL.GetFacture(numFac);
        }
    }
}
