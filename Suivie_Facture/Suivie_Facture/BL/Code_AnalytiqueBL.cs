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
    public class Code_AnalytiqueBL
    {
        public Code_AnalytiqueDAL Code_AnalytiqueDALL;

        public DataTable GetAll_CodeAnalytique()
        {
            Code_AnalytiqueDALL = new Code_AnalytiqueDAL();
            return Code_AnalytiqueDALL.GetAll_CodeAnalytique();
        }
        public void Update_CodeAnalytique(Code_Analytique code_analytique)
        {
            Code_AnalytiqueDALL = new Code_AnalytiqueDAL();
            Code_AnalytiqueDALL.Update_CodeAnalytique(code_analytique);
        }
        public void Delete_CodeAnalytique(int id_CodeAnalytique)
        {
            Code_AnalytiqueDALL = new Code_AnalytiqueDAL();
            Code_AnalytiqueDALL.Delete_CodeAnalytique(id_CodeAnalytique);
        }
        public DataTable GetCodeAnalytique(string Code)
        {
            Code_AnalytiqueDALL = new Code_AnalytiqueDAL();
            return Code_AnalytiqueDALL.GetCodeAnalytique(Code);
        }
        public void Insert_CodeAnalytique(Code_Analytique code_Analytique)
        {
            Code_AnalytiqueDALL = new Code_AnalytiqueDAL();
            Code_AnalytiqueDALL.Insert_CodeAnalytique(code_Analytique);
        }
    }
}
