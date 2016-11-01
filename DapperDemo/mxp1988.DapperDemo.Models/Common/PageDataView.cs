using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxp1988.DapperDemo.Models.Common
{
    /// <summary>
    /// 分页查询获取数据实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageDataView<T>
    {
        private int _TotalNum;
        public PageDataView()
        {
            this._Items = new List<T>();
        }
        /// <summary>
        /// 总数
        /// </summary>
        public int TotalNum
        {
            get { return _TotalNum; }
            set { _TotalNum = value; }
        }

        private IList<T> _Items;
        /// <summary>
        /// 具体数据列表
        /// </summary>
        public IList<T> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }
        /// <summary>
        /// 当前页数
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPageCount { get; set; }
    }
}
