using Books.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BLL
{
    public class ReaderTypeBll
    {
        public static DataTable GetReaderList()
        {
            //接收从DAL层查回来的数据
            DataTable dt = ReaderTypeDal.SelectReaderList();
            //业务逻辑处理
            if (dt.Rows.Count > 0)  //判断是否存在数据
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
    }
}
