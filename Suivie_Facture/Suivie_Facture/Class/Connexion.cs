using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.Class
{
    public class Connexion
    {
        //SI-TALSSI\TALSSI
        //DESKTOP-263UF4M\TALSSI
        //public static string ConnectionString = @"Data Source=SI-TALSSI\TALSSI;Initial Catalog=Suivie_Factures;Integrated Security=True";
        public static string ConnectionString_FarisDeplacement = @"Data Source=PcTalssiM\TALSSI;Initial Catalog=Frais_deplacement;Integrated Security=True";
        public static string ConnectionString = @"Data Source=srv-cluster01\dimatitha; Network Library = DBMSSOCN;
        Initial Catalog = Suivie_Factures; User ID = sage; Password=sage;";

        //public static string ConnectionStringDimaGest = @"Data Source=srv-cluster01\dimatitha; Network Library = DBMSSOCN;
        //Initial Catalog = StrCristalDB; User ID = sage; Password=sage;";

    }
}
