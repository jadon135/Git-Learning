using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Business_Logic;
using WebApplication1.Business_Object;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Uid = "";
            DataTable userData = new DataTable();
            UserBO BO = new UserBO();
            UserBL BL = new UserBL();
            BO.Email = txtEmail.Value;
            BO.Password = txtPass.Value;
            if (txtEmail.Value != "")
            {
                if (txtPass.Value != ""){
                    userData= BL.AUTHUSER(BO);
                    if (userData.Rows.Count > 0)
                    {
                         Uid = Convert.ToString(userData.Rows[0][0]);
                        Session["ID"] = Uid;
                        Response.Redirect("/Admin/index.aspx?UID=" + Session["ID"]);
                    }

                }
            }
        }
    }
}