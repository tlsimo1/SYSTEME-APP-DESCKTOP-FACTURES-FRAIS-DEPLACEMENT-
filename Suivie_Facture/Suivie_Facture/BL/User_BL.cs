using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class User_BL
    {
        public User_DAL UserDAL;
        public DataTable GetAllUser()
        {
            UserDAL = new User_DAL();
            return UserDAL.GetAllUsers();
        }
        public DataTable RemplirComBox()
        {
            UserDAL = new User_DAL();
            return UserDAL.RemplirComBox();
        }
        public void AjouterUser(string username,string password,string role)
        {
            UserDAL = new User_DAL();
            UserDAL.AjouterUser(username, password, role);
        }
        public bool ChekIsExist(string username)
        {
            UserDAL = new User_DAL();
            return UserDAL.ChekIfExist(username);
        }
        public void UpdateUser(string username, string password, string role)
        {
            UserDAL = new User_DAL();
            UserDAL.UpdateUser(username, password, role);
        }
        public void DeleteUser(string username)
        {
            UserDAL = new User_DAL();
            UserDAL.DeleteUser(username);
        }
    }
}
