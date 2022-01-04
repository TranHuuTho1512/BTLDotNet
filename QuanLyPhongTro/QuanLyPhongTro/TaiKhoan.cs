using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class TaiKhoan
    {
        string userName, passWord;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public string PassWord
        {
            get
            {
                return passWord;
            }
            set
            {
                passWord = value;
            }
        }
        public TaiKhoan()
        {

        }
        public TaiKhoan(string a, string b)
        {
            a = userName;
            b = passWord;
        }
    }
}
