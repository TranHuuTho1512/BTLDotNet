using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class frmTKSVAdmin : Form
    {
        public frmTKSVAdmin()
        {
            InitializeComponent();
        }
        SinhVien sv = new SinhVien();
        IEnumerable<tblSinhVien> dsSV;
        private void frmTKSVAdmin_Load(object sender, EventArgs e)
        {
            List<object> dsSVHonLoan;
            dsSVHonLoan = sv.HonLoanNhieuBangAdmin();
            dgvSV.DataSource = dsSVHonLoan.ToList();
            FormatDGV(dgvSV);
            //để hỗ trợ autocomplet ta phải chỉ rõ 2 thuộc tính
            txtCanTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCanTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            radTheoMSSV.Checked = true;
        }
        void FormatDGV(DataGridView dgv)
        {
            try
            {
                dgv.Columns["MSSV"].HeaderText = "Mã Số Sinh Viên";
                dgv.Columns["MSSV"].Width = 150;
                dgv.Columns["TenSV"].HeaderText = "Họ và Tên";
                dgv.Columns["TenSV"].Width = 150;
                dgv.Columns["QueQuanSV"].HeaderText = "Nơi Sinh Sống";
                dgv.Columns["QueQuanSV"].Width = 150;
                dgv.Columns["SDTSV"].HeaderText = "Số điện thoại";
                dgv.Columns["SDTSV"].Width = 150;
                dgv.Columns["NamSinhSV"].HeaderText = "Ngày Sinh";
                dgv.Columns["NamSinhSV"].Width = 50;
                dgv.Columns["TruongHoc"].HeaderText = "Trường Học";
                dgv.Columns["TruongHoc"].Width = 100;
                dgv.Columns["KhoaSV"].HeaderText = "Khoa";
                dgv.Columns["KhoaSV"].Width = 100;
                dgv.Columns["IDPhong"].Visible = false;
                dgv.Columns["TenPhong"].HeaderText = "Tên Phòng Ở";
                dgv.Columns["TenPhong"].Width = 200;
                dgv.Columns["IDChuTro"].HeaderText = "ID Chủ Trọ";
                dgv.Columns["IDChuTro"].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: "+ex.Message, "Thông báo");
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            FormatDGV(dgvSV);
            if (radTheoTenSV.Checked)
            {
                List<object> TimKiemTenSVAdmin;
                TimKiemTenSVAdmin = sv.TimKiemTenSVAdmin(txtCanTim.Text);
                dgvSV.DataSource = TimKiemTenSVAdmin.ToList();
            }
            else if (radTheoMSSV.Checked)
            {
                List<object> TimKiemMSSVAdmin;
                TimKiemMSSVAdmin = sv.TimKiemMSSVAdmin(txtCanTim.Text);
                dgvSV.DataSource = TimKiemMSSVAdmin.ToList();
            }
            else if (radLop.Checked)
            {
                List<object> TimKiemKhoaSVAdmin;
                TimKiemKhoaSVAdmin = sv.TimKiemKhoaSVAdmin(txtCanTim.Text);
                dgvSV.DataSource = TimKiemKhoaSVAdmin.ToList();
            }
            else if (radTehoQQ.Checked)
            {
                List<object> TimKiemQQSVAdmin;
                TimKiemQQSVAdmin = sv.TimKiemQQSVAdmin(txtCanTim.Text);
                dgvSV.DataSource = TimKiemQQSVAdmin.ToList();
            }
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            List<object> dsSVHonLoan;
            dsSVHonLoan = sv.HonLoanNhieuBangAdmin();
            dgvSV.DataSource = dsSVHonLoan.ToList();
        }
    }
}
