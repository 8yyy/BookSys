using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.DAL;

namespace Books.BLL
{
    public class AdmininfoBll
    {
        public bool Login(string userName,string passWord)
        {
            return new AdmininfoDal().SelectAdminList(userName, passWord).Rows.Count > 0;   
        }
    }
}
