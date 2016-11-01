using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxp1988.DapperDemo.Models
{
    /// <summary>
    /// 部门
    /// </summary>
    public class Department
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 上级部门id
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool DeleteTag { get; set; }
    }
}
