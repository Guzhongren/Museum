using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace ModalHelper
{
     public static class SqlHelper
    {
        #region MSSQL方案
         private static readonly string configStr = ConfigurationManager.ConnectionStrings["conSQLStr"].ToString();
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
        //public static DataTable ExecuteDataTabel(string sql, params SqlParameter[] parameters)
        //{
        //    using (SqlConnection conn = new SqlConnection(configStr))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = sql;
        //            cmd.Parameters.AddRange(parameters);
        //            SqlDataAdapter adater = new SqlDataAdapter(cmd);
        //            DataSet dataSet = new DataSet();
        //            adater.Fill(dataSet);
        //            return dataSet.Tables[0];
        //        }
        //    }
        //} 
        #endregion
        #region PostgreSQl方案
        private static string NpqSqlConStr = ConfigurationManager.ConnectionStrings["constr"].ToString();
        public static DataTable ExecuteDataTabel(string sql, params NpgsqlParameter[] parameters)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpqSqlConStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    NpgsqlDataAdapter adater = new NpgsqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adater.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
        }
        //private static string sqltest = "select * from historicalrelic where cultrualrelicbirthdatatime='唐' and culturalrelicname='和田玉'";

        //public static DataTable ExecuteDataTableTest()
        //{
        //    using (NpgsqlConnection conn = new NpgsqlConnection(configStr))
        //    {
        //        conn.Open();
        //        using (NpgsqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = sqltest;
        //            //cmd.Parameters.AddRange(parameters);
        //            NpgsqlDataAdapter adater = new NpgsqlDataAdapter(cmd);
        //            DataSet dataSet = new DataSet();
        //            adater.Fill(dataSet);
        //            return dataSet.Tables[0];
        //        }
        //    }
        }
        #endregion
    
}
