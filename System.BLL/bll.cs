using System;
using System.Collections.Generic;
using System.DAL;
using System.Data.SqlClient;
using System.Linq;
using System.Model;
using System.Text;
using System.Threading.Tasks;

namespace System.BLL
{
    public class bll
    {
        /// <summary>
        /// 注册信息查询
        /// </summary>
        /// <param name="sqls"></param>
        /// <returns></returns>
        public static List<register_info> Register_info_Query(params SqlParameter[] sqls)
        {
            return dal.Register_info_Query(sqls);
        }
        /// <summary>
        /// 泛型T数据查询方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vs"></param>
        /// <returns></returns>
        public static List<T> DataQueryMethod<T>(params string[]vs)where T:new ()
        {
            return dal.DataQueryMethod<T>(vs);
        }
    }
}
