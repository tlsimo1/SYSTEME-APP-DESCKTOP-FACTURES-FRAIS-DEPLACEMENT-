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
        public DataTable AutoCompletTextBox()
        {
            factureDAL = new FactureDAL();
            return factureDAL.AutoCompletTextBox();
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
        public DataTable GetFactureImp(DateTime date)
        {
            factureDAL = new FactureDAL();
            return factureDAL.GetFactureImp(date);
        }
        public DataTable GetFactureImp2(DateTime date)
        {
            factureDAL = new FactureDAL();
            return factureDAL.GetFactureImp3(date);
        }
        public DataTable GetFactureParFournisseur(string Nom_Fournisseur)
        {
            factureDAL = new FactureDAL();
            return factureDAL.GetFactureParFournisseur(Nom_Fournisseur);
        }
        public DataTable GetFactureParDate(DateTime date)
        {
            factureDAL = new FactureDAL();
            return factureDAL.GetFactureParDate(date);
        }
        public void DeleteFacture(string facNum )
        {
            factureDAL = new FactureDAL();
            factureDAL.DeleteFacture(facNum);
        }
        public void UpdateFacture(dynamic facture)
        {
            factureDAL = new FactureDAL();
            factureDAL.UpdateFacture(facture);
        }
    }
}
