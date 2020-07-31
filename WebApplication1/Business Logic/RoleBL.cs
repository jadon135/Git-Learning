using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Business_Object;
using WebApplication1.Data__Access;

namespace WebApplication1.Business_Logic
{
    public class RoleBL
    {
        RoleBO BO = new RoleBO();
        public bool SaveData(RoleBO BO)
        {
            bool ret = false;
            RoleDA DA = new RoleDA();
            ret = DA.saveData(BO);
            return ret;

        }
    }
}