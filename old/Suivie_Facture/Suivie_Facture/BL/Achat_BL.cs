﻿using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class Achat_BL
    {
        public Achat_DAL AssDAFDAL;
        public DataTable GetAllFactureAchat()
        {
            AssDAFDAL = new Achat_DAL();
            return AssDAFDAL.GetAllFactureAchat();
        }
        public void Edit_StatusAchat(string facNum)
        {
            AssDAFDAL = new Achat_DAL();
            AssDAFDAL.Edit_StatusAchat(facNum);
        }
    }
}