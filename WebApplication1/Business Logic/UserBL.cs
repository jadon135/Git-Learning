using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.Business_Object;
using WebApplication1.Data__Access;

namespace WebApplication1.Business_Logic
{
    public class UserBL
    {
        UserBO BO = new UserBO();

        public bool SaveData(UserBO BO)
        {
            bool ret = false;
            UserDA DA = new UserDA();
            ret = DA.saveData(BO);
            return ret;

        }
        public DataTable AUTHUSER(UserBO BO)
        {
            DataTable userdt = new DataTable();
            UserDA DA = new UserDA();
            userdt = DA.AUTH_USER(BO);
            return userdt;

        }
    }
}