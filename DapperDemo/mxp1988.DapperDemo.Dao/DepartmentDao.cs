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
    /// 部门操作类
    /// </summary>
    public class DepartmentDao : BaseDao
    {
        /// <summary>
        /// 批量插入部门
        /// </summary>
        /// <param name="departments"></param>
        /// <returns></returns>
        public int InsertBatch(List<Department> departments)
        {
            string sql = @"INSERT  INTO dbo.Department
        ( DepartmentName ,
          ParentID ,
          DeleteTag
        )
VALUES  ( @DepartmentName ,
          @ParentID ,
          @DeleteTag
        )";
            return DatabaseHelper<SqlConnection>.ExecuteNonQuery(ConnectionStr, sql, departments);
        }
    }
}
