using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Transactions;
using Books.Model;

namespace Books.DAL
{
    public class ReaderDal
    {
        //增删改查，分为两大类，增删改一类，查一类

        // 折叠注释
        #region 查询
        /// <summary>
        /// 无条件查询
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectReaderList()
        {
            //准备sql语句
            string query = "select * from Reader";
            //找sqlhelper帮助类
            return SQLHelper.GetDataTable(query);
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable SelectReaderByName(string name)
        {
            string query = $"select * from Reader where rdName like '%{name}%';";
            return SQLHelper.GetDataTable(query);
        }
        #endregion

        #region 添加
        public static int InsertReader(Reader reader)
        {
            string query = $"insert into Reader Values('{reader.rdID}','{reader.rdType}','{reader.rdName}','{reader.rdDept}','{reader.rdQQ}','{reader.rdborrowQty}');";
            return SQLHelper.SQLCommand(query);
        }

        #endregion

        #region 删除
        public static int DeleteReader(string rdID)
        {
            //1.创建好来连接对象
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=BooksDb;Integrated Security=True"))
            {
                //2.准备sql语句   
                string query = $"delete from Reader where rdID='{rdID}';";
                // 操作数据库
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //执行语句并返回受影响行数
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }

            }
        }
        #endregion

        #region 修改
        public static int EditReader(Reader reader)
        {
            string query = $"update Reader set rdType='{reader.rdType}',rdName='{reader.rdName}',rdDept='{reader.rdDept}',rdQQ='{reader.rdQQ}',rdBorrovQty='{reader.rdborrowQty}' where rdID='{reader.rdID}';";
            return SQLHelper.SQLCommand(query);
        }
        #endregion
    }
}
