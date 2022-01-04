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
    public partial class frmTKSV : Form
    {
        public frmTKSV()
        {
            InitializeComponent();
        }
        public string idtksv = "";
        public frmTKSV(string id)
        {
            InitializeComponent();
            idtksv = id;
        }
        private void btnOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SinhVien sv = new SinhVien();
        IEnumerable<tblSinhVien> dsSV;
        private void frmTKSV_Load(object sender, EventArgs e)
        {
            dsSV = sv.laySVThuocChuTro(idtksv);
            dgvSV.DataSource = dsSV.ToList();
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
                dgv.Columns["tblphong"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: " + ex.Message, "Thông báo");
            }
        }

        private void radTheoMSSV_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheoMSSV.Checked)
            {
                txtCanTim.AutoCompleteCustomSource.Clear();
                foreach (tblSinhVien sv in dsSV)
                {
                    txtCanTim.AutoCompleteCustomSource.Add(sv.MSSV.Trim());
                }
            }
        }

        private void radTheoTenSV_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheoTenSV.Checked)
            {
                txtCanTim.AutoCompleteCustomSource.Clear();
                foreach (tblSinhVien sv in dsSV)
                {
                    txtCanTim.AutoCompleteCustomSource.Add(sv.TenSV.Trim());
                }
            }
        }

        private void radLop_CheckedChanged(object sender, EventArgs e)
        {
            if (radLop.Checked)
            {
                txtCanTim.AutoCompleteCustomSource.Clear();
                foreach (tblSinhVien sv in dsSV)
                {
                    txtCanTim.AutoCompleteCustomSource.Add(sv.KhoaSV.Trim());
                }
            }
        }

        private void radTehoQQ_CheckedChanged(object sender, EventArgs e)
        {
            if (radTehoQQ.Checked)
            {
                txtCanTim.AutoCompleteCustomSource.Clear();
                foreach (tblSinhVien sv in dsSV)
                {
                    txtCanTim.AutoCompleteCustomSource.Add(sv.QueQuanSV.Trim());
                }
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            IEnumerable<tblSinhVien> dsSVLoc = sv.timKiemSinhvien(txtCanTim.Text, radTheoMSSV.Checked, radTheoTenSV.Checked, radLop.Checked);
            dgvSV.DataSource = dsSVLoc;
            FormatDGV(dgvSV);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsSV = sv.laySVThuocChuTro(idtksv);
            dgvSV.DataSource = dsSV.ToList();
        }
    }
}
