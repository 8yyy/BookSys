using Books.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL
{
    //SQL帮助类：用来发送增删改查操作
    public class SQLHelper
    {
        //准备连接数据库的字符串
        private static string sqlConn = "Data Source=.\\sqlexpress;Initial Catalog=BooksDb;Integrated Security=True";

        //1.发送增删改
        public static int SQLCommand(string sql)
        {
            using (SqlConnection conn = new SqlConnection(sqlConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }
            }
        }

        //2.查询
        public static DataTable GetDataTable(string sql)
        {
            using (SqlConnection conn = new SqlConnection(sqlConn))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn))
                {
                    //创建容器
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
