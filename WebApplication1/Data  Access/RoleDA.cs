using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Business_Object;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Data__Access
{
    public class RoleDA
    {
        internal static string GetConnectionString()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CONNECTIONSTRING"].ConnectionString;
            return ConnectionString;
        }


        public bool saveData(RoleBO Bo)
        {
            bool ret = false;

            var result = 0;
            SqlConnection con = null;
            try
            {
                string rolestr = "";
                DataTable dt = returnRole_ID();
                if (dt.Rows.Count > 0)
                {
                    string roleID = dt.Rows[0]["Role_ID"].ToString();
                    string[] rolearr = roleID.Split('-');
                    rolestr = "Role-" + Convert.ToInt32(rolearr[1]) + 1;
                }
                else
                {
                    rolestr = "Role-001";
                }
                string PConnectionString = GetConnectionString();
                con = new SqlConnection(PConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.CommandText = "USP_SAVE_ROLE";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Role_ID", rolestr);
                cmd.Parameters.AddWithValue("@Name", Bo.Name);
                cmd.Parameters.AddWithValue("@Task", "SaveRole");
                cmd.Parameters.AddWithValue("@STATUS", Convert.ToBoolean(Bo.Status));
                var returnID = cmd.Parameters.Add("@ID", SqlDbType.Int);
                returnID.Value = Bo.ID;
                returnID.Direction = ParameterDirection.InputOutput;
                cmd.CommandTimeout = 900;
                cmd.ExecuteNonQuery();
                //SqlParameter param;
                //param = cmd.Parameters.Add("@DCN", SqlDbType.Int);
                //param.Value = DCN;
                // erCon.Open();
                //SqlDataReader dr = cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
                //while (dr.Read())
                //{
                //    result = int.Parse(dr.GetValue(0).ToString());
                //}
                if ((int)returnID.Value != 0)
                {
                    ret = true;
                }
                else
                {
                    ret = false;

                }
            
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                con.Dispose();
            }



            return ret;
        }

        internal static DataTable returnRole_ID()
        {
            DataTable dtspBatchData = null;
            SqlConnection con = null;
            try
            {
                dtspBatchData = new DataTable();
                string PConnectionString = GetConnectionString();
                con = new SqlConnection(PConnectionString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.CommandText = "USP_GET_ROLE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Task", "GetRoleID");
                cmd.CommandTimeout = 900;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtspBatchData);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }
            return dtspBatchData;
        }

       
    }
}