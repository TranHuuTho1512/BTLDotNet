using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap frm = new QuanLyPhongTro.frmDangNhap();
            TaiKhoan tmp = new TaiKhoan();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                tmp.UserName = frm.txtUser.Text;
                tmp.PassWord = frm.txtPass.Text;
                Application.Run(new frmChuTroQLy(tmp));

            }
            if (frm.a == 1)
            {
                Application.Run(new frmQly());
            }
        }
    }
}
