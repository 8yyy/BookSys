using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  //datatable\dataset\datarow
using Books.DAL;
using Books.Model;

namespace Books.BLL
{
    /* 1、在BLL层创建对应的类
     * 2、添加应用
     * 3、写代码
     * 4、在BLL层查询返回类型是DataTable,增删改用布尔类型
     */
    public class ReaderBll
    {
        public static DataTable GetReaderList()
        {
            //接收从DAL层查回来的数据
            DataTable dt = ReaderDal.SelectReaderList();
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

        //模糊查询
        public static DataTable GetReaderByName(string name)
        {
            //接收从DAL层查回来的数据
            DataTable dt = ReaderDal.SelectReaderByName(name);
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

        //添加
        public static bool AddReader(Reader reader)
        {
            int i = ReaderDal.InsertReader(reader);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //删除
        public static bool DeleteReader(string rdID)
        {
            int i = ReaderDal.DeleteReader(rdID);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //修改
        public static bool EditReader(Reader reader)
        {
            int i = ReaderDal.EditReader(reader);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
