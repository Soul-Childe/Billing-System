using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Model;
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
    }
}
