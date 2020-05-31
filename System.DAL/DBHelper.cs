using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;

namespace System.DAL
{
    /// <summary>
    /// 数据库操作类
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        static string sqlconn = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;
        /// <summary>
        /// 获取打开数据库连接对象属性
        /// </summary>
        static SqlConnection conn
        {
            get
            {
                SqlConnection connection = new SqlConnection(sqlconn);
                connection.Open();
                if(connection.State==ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }
        /// <summary>
        /// 执行SQL读取数据
        /// </summary>
        /// <param name="strsql"></param>
        /// <param name="sqls"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string strsql,params SqlParameter[] sqls)
        {
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand(strsql, conn);
                cmd.Parameters.AddRange(sqls);
                dr=cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }
            return dr;
        }
        /// <summary>
        /// 执行SQL并查询受影响记录数
        /// </summary>
        /// <param name="strsql"></param>
        /// <param name="sqls"></param>
        /// <returns></returns> 
        public static int ExecuteNonQuery(string strsql, SqlParameter[] sqls)
        {
            int count = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(strsql, conn);
                cmd.Parameters.AddRange(sqls);
                count=cmd.ExecuteNonQuery();                
            }
            catch (Exception)
            {

                throw;
            }
            return count;
        }


    }
}
