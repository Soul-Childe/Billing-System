using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Model;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace System.DAL
{

    public class dal
    {
        /// <summary>
        /// 注册信息查询
        /// </summary>
        /// <param name="sqls"></param>
        /// <returns></returns>
        public static List<register_info> Register_info_Query(params SqlParameter[] sqls)
        {
            string strsql = "select * from register_info";
            List<register_info> Modellist = new List<register_info>();
            SqlDataReader dr = DBHelper.ExecuteReader(strsql, sqls);
            while (dr.Read())
            {
                register_info register = new register_info();
                register.id = dr["id"].ToString();
                register.user_name = dr["user_name"].ToString();
                register.password = dr["password"].ToString();
                register.phone = dr["phone"].ToString();
                register.email = dr["email"].ToString();
                register.birthday = dr["birthday"].ToString();
                register.address = dr["address"].ToString();
                register.spare_item_1 = dr["spare_item_1"].ToString();
                register.spare_item_2 = dr["spare_item_2"].ToString();
                register.spare_item_3 = dr["spare_item_3"].ToString();
                register.spare_item_4 = dr["spare_item_4"].ToString();
                register.spare_item_5 = dr["spare_item_5"].ToString();
                register.spare_item_6 = dr["spare_item_6"].ToString();
                register.spare_item_7 = dr["spare_item_7"].ToString();
                register.spare_item_8 = dr["spare_item_8"].ToString();
                register.spare_item_9 = dr["spare_item_9"].ToString();
                register.spare_item_10 = dr["spare_item_10"].ToString();
                Modellist.Add(register);
            }
            dr.Close();
            return Modellist;
        }

        /// <summary>
        /// 泛型T数据查询方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqls"></param>
        /// <returns></returns>
        public static List<T> DataQueryMethod<T>(params string[] sqls) where T : new()
        {
            string strsql = "select * from " + typeof(T).Name + " where 1=1 ";
            string m_and = "";
            foreach (string item in sqls)
            {
                strsql += m_and + " " + item + " ";
                m_and = "and";
            }
            List<T> modellist = new List<T>();
            SqlDataReader dr = DBHelper.ExecuteReader(strsql);
            PropertyInfo[] info = typeof(T).GetProperties();
            while (dr.Read())
            {
                T obj = new T();
                foreach (PropertyInfo item in info)
                {
                    if (dr[item.Name] != DBNull.Value)
                    {
                        item.SetValue(obj, dr[item.Name]);

                    }
                }
                modellist.Add(obj);
            }
            dr.Close();
            return modellist;
        }
        /// <summary>
        /// T 数据查询方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vs"></param>
        /// <returns></returns>
        public static T DataQuery<T>(params string[] vs) where T : new()
        {
            string strsql="select * from "+ typeof(T).Name + " where 1=1 ";
            string m_and = "";
            foreach (string item in vs)
            {
                strsql += m_and + " " + item + " ";
                m_and = "and";
            }          
            SqlDataReader dr = DBHelper.ExecuteReader(strsql);
            PropertyInfo[] info = typeof(T).GetProperties();
            T obj = default(T);
            while (dr.Read())
            {
                obj= new T();
                foreach (PropertyInfo item in info)
                {
                    if (dr[item.Name] != DBNull.Value)
                    {
                        item.SetValue(obj, dr[item.Name]);

                    }
                }               
            }
            dr.Close();
            return obj;
        }
    }
}
