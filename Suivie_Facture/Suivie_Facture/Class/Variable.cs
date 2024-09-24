using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.Class
{
    public static class Variable
    {
        private static string userName; 
        public static string UserName  
        {
            get { return userName.ToLower(); }  
            set { userName = value; }  
        }
        public static string GetRol { get; set; }
        public static bool IsConnected { get; set; }
        public static int Compteur { get; set; } = 1;
        public static bool IsLoadData { get; set; } = false;
        public static bool IsLoadDataByDate { get; set; } = false;
        public static string UserNameAdmin { get; set; } = "admin";

        public static bool IsExist { get; set; } = false;
        public static bool IsSelected { get; set; } = false;

    }
}
