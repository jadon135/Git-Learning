using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Business_Object;
using WebApplication1.Business_Logic;
namespace WebApplication1.Admin
{
    public partial class manageuser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void btnSavae_Click(object sender, EventArgs e)
        {
            int c = 1;
            // int c = 1;
            ProfileBO BO = new ProfileBO();
            ProfileBL BL = new ProfileBL();
            BO.Name = txtName.Value;
            BO.Status = Convert.ToInt32(ddlStatus.SelectedValue);
            bool ret = BL.SaveData(BO);
            Console.WriteLine("REcord Saved Sucessfully!!");
        }
    }
}