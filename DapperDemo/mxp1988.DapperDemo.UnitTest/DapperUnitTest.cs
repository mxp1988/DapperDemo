using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mxp1988.DapperDemo.Models;
using mxp1988.DapperDemo.Dao;

namespace mxp1988.DapperDemo.UnitTest
{
    /// <summary>
    /// DapperUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class DapperUnitTest
    {
        /// <summary>
        /// 批量插入用户
        /// </summary>
        [TestMethod]
        public void TestBatchInsert()
        {
            try
            {
                List<User> list = new List<User>();
                for (int i = 1; i < 100; i++)
                {
                    User user = new User();
                    user.Code = DateTime.Now.ToString("yyyyMMdd") + i.ToString().PadLeft(4, '0');
                    user.Name="员工"+ i.ToString().PadLeft(4, '0');
                    user.DeleteTag = false;
                    user.DepartmentId = 1;
                    user.Sex = i%2;
                    user.Email = user.Code + "@dapperDemo.com";
                    user.Phone = "1861207" + new Random().Next(1001, 9999);
                    list.Add(user);
                }
                int count = new UserDao().InsertBatch(list);
                Console.WriteLine(string.Format("本次共插入{0}位",count));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("插入员工出错,原因：{0}",ex.Message.ToString()));
            }
        }
    }
}
