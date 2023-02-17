using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Books.Common
{
    public class MD5Helper
    {
        /// <summary>
        /// md5字符串加密
        /// </summary>
        /// <param name="pwd">加密的字符串</param>
        /// <returns></returns>
        public static string GenerateMD5(string pwd)
        {
            using (MD5 mi = MD5.Create())
            {
                byte[] buffer = Encoding.Default.GetBytes(pwd);
                //开始加密
                byte[] newBuffer = mi.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
