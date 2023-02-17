using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL
{
    public class AdmininfoDal
    {
        public DataTable SelectAdminList(string userName,string passWord)
        {
            //准备sql语句
            string query = $"select UserName,PassWord from Admin where UserName='{userName}' and PassWord='{passWord}'";
            //找sqlhelper帮助类
            return SQLHelper.GetDataTable(query);
        }
    }
}
