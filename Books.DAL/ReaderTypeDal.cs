using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL
{
    // 一张表一个Dal类
    public class ReaderTypeDal
    {
        #region 查询
        public static DataTable SelectReaderList()
        {
            //准备sql语句
            string query = "select rdType,rdTypeName from ReaderType";
            //找sqlhelper帮助类
            return SQLHelper.GetDataTable(query);
        }
        #endregion
    }
}
