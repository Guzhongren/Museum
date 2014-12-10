using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalHelper
{
     public static class SqlHelper
    {
         private static readonly string configStr = ConfigurationManager.ConnectionStrings["constr"].ToString();
        public static int ExecuteNoQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(configStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static object ExecutScale(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(configStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }
        public static DataTable ExecuteDataTabel(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(configStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    SqlDataAdapter adater = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adater.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
        }
    }
}
