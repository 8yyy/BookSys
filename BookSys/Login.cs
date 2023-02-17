using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.Common;
using Books.BLL;

namespace BookSys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //1.获取用户输入的值
            string userName=UserNameTB.Text;
            string password=PasswordTB.Text;

            //2.加密密码
            string md5pwd = MD5Helper.GenerateMD5(password);

            //3.请求登录
            if(new AdmininfoBll().Login(userName, md5pwd))
            {
                ReadForm rf = new ReadForm();
                rf.Show();
                this.Hide();
            }
        }
    }
}
