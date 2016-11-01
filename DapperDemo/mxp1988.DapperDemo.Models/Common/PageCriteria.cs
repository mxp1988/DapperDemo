using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxp1988.DapperDemo.Models.Common
{
    /// <summary>
    /// 分页实体
    /// </summary>
    public class PageCriteria
    {
        public PageCriteria()
        {
            ParameterList = new List<ParameterDict>();
        }
        /// <summary>
        /// 查询的表名
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 字段集合
        /// </summary> 
        public string Fields { get; set; }

        /// <summary>
        /// 主键名称
        /// </summary>
        public string PrimaryKey { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        public int RecordCount { get; set; }
        /// <summary>
        /// 传入的参数列表
        /// </summary>
        public IList<ParameterDict> ParameterList { get; set; }
    }
}
