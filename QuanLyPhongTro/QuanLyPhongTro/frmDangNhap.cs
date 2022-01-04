using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class frmDangNhap : Form
    {
        QLyTroDataContext db = new QLyTroDataContext();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public void dangNhap()
        {
            if (txtUser.Text.Length == 0 && txtPass.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập UserID và Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                if (txtUser.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập UserID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                        if (txtPass.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public int a = 0;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangNhap();
            tblChuTro ct = new tblChuTro();
                IQueryable<tblChuTro> tam = (from n in db.tblChuTros
                                             where n.IDChuTro == txtUser.Text && n.Pass == txtPass.Text
                                             select n);
            if (tam.Any())
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (txtUser.Text.Equals("admin") && txtPass.Text.Equals("admin"))
                {
                    this.Close();
                    a = 1;
                }
                else if(txtUser.Text != ct.IDChuTro || txtPass.Text != ct.Pass)
                    MessageBox.Show("Kiểm tra lại UserName hoặc PassWord!", "Thông báo", MessageBoxButtons.OK);         
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoiThoat;
            hoiThoat = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoiThoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
