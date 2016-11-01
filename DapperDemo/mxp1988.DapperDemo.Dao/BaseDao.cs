using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxp1988.DapperDemo.Dao
{
    /// <summary>
    /// 数据库基类
    /// </summary>
    public class BaseDao
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionStr = "";

        public BaseDao()
        {
            ConnectionStr= System.Configuration.ConfigurationManager.ConnectionStrings["DapperDemo"].ConnectionString;
        }
    }
}
