using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Business_Logic;
using WebApplication1.Business_Object;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            bool ret = false;
            UserBO bo = new UserBO();
            bo.F_Name = txtFName.Text;
            bo.L_Name = txtLName.Text;
            bo.Email = txtEmail.Text;
            if (txtPass.Value == txtRepPass.Value)
            {
                bo.Password = txtPass.Value;
                bo.Profile_Id = 2;
                bo.Status = 1;
                bo.Created_Date = Convert.ToString(DateTime.Now);
                UserBL BL = new UserBL();
                ret = BL.SaveData(bo);
                if (ret == true)
                {
                    Response.Redirect("/Login.aspx");
                }
            }
            

        }
    }
}