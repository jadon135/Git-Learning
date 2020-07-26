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
    public class ProfileDA
    {
        internal static string GetConnectionString()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CONNECTIONSTRING"].ConnectionString;
            return ConnectionString;
        }
        public bool saveData(ProfileBO Bo)
        {
            bool ret = false;

            var result = 0;
            SqlConnection con = null;
            try
            {
                string PConnectionString = GetConnectionString();
                con = new SqlConnection(PConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.CommandText = "USP_SAVE_PROFILE";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", Bo.Name);
                cmd.Parameters.AddWithValue("@Status", Bo.Status);
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
    }
}