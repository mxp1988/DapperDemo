using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxp1988.DapperDemo.Models
{
    /// <summary>
    /// 用户表
    /// </summary>
   public class User
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 部门id
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool DeleteTag { get; set; }
    }
}
