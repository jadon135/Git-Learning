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
    public class UserDA
    {
        internal static string GetConnectionString()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["CONNECTIONSTRING"].ConnectionString;
            return ConnectionString;
        }
       

        public bool saveData(UserBO Bo)
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

                cmd.CommandText = "USP_SAVE_USER";


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@F_NAME", Bo.F_Name);
                cmd.Parameters.AddWithValue("@L_NAME", Bo.L_Name);
                cmd.Parameters.AddWithValue("@EMAIL", Bo.Email);
                cmd.Parameters.AddWithValue("@STATUS", Bo.Status);
                cmd.Parameters.AddWithValue("@PROFILE_ID", Bo.Profile_Id);
                cmd.Parameters.AddWithValue("@PASSWORD", Bo.Password);
                cmd.Parameters.AddWithValue("@DATE_CREATED", Bo.Created_Date);
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
        public  DataTable AUTH_USER(UserBO BO)
        {
            DataTable dtUserDte = null;
            SqlConnection con = null;
            try
            {
                dtUserDte = new DataTable();
                string PConnectionString = GetConnectionString();
                con = new SqlConnection(PConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.CommandText = "USP_USER_AUTH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMAIL", BO.Email);
                cmd.Parameters.AddWithValue("@PASSWORD", BO.Password);
                cmd.CommandTimeout = 900;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtUserDte);
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                con.Close();
            }
            return dtUserDte;
        }
    }
}