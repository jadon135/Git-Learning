using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Business_Object
{
    public class UserBO
    {
        public int ID { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public int Profile_Id { get; set; }
        public string Password { get; set; }
        public string Created_Date { get; set; }

    }
}