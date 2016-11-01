using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mxp1988.DapperDemo.Models;

namespace mxp1988.DapperDemo.Dao
{
    /// <summary>
    /// 用户数据库操作类
    /// </summary>
    public class UserDao : BaseDao
    {
        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int InsertBatch(List<User> users)
        {
            string sql = @"INSERT INTO dbo.DeviceUser
        ( Code ,
          Name ,
          DepartmentId ,
          Sex ,
          Email ,
          Phone ,
          DeleteTag
        )
VALUES  ( @Code ,
          @Name ,
          @DepartmentId ,
          @Sex ,
          @Email ,
          @Phone ,
          @DeleteTag
        )";
            return DatabaseHelper<SqlConnection>.ExecuteNonQuery(ConnectionStr, sql, users);
        }
        /// <summary>
        /// 根据部门id获取次部门的员工
        /// </summary>
        /// <param name="departments"></param>
        /// <returns></returns>
        public List<User> GetUsersByDepartmentIds(List<int> departments)
        {
            string sql = @"select * from DeviceUser where departmentid in @ids";
            return DatabaseHelper<SqlConnection>.Query<User>(ConnectionStr, sql, new {ids = departments}).ToList();
        }
    }
}
