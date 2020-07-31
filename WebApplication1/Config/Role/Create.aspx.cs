using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Business_Logic;
using WebApplication1.Business_Object;

namespace WebApplication1.Config.Role
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            RoleBO BO = new RoleBO();
            BO.Name = txtName.Text;
            BO.Status = Convert.ToInt32(ddlStatus.SelectedValue);
            bool ret = false;
            RoleBL BL = new RoleBL();
            ret = BL.SaveData(BO);
            if (ret == true)
            {

            }
            else
            {

            }
        }
    }
}