using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1;
using WebApplication1.Business_Object;
using WebApplication1.Data__Access;

namespace WebApplication1.Business_Logic
{
    public class ProfileBL
    {
        ProfileBO BO = new ProfileBO();
      
        public bool SaveData(ProfileBO BO )
        {
            bool ret = false;
            ProfileDA DA = new ProfileDA();
            ret = DA.saveData(BO);
            return ret;
               
        }
    }
}