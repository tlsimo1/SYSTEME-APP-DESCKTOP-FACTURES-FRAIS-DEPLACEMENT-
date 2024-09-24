using Suivie_Facture.Class;
using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class Brd_BL
    {
        public Brd_DAL BrdDAL;

        public void InsertFacture(Facture facture)
        {
            BrdDAL = new Brd_DAL();
            BrdDAL.Insert_Facture(facture);
        }
    }
}
