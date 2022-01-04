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
    public partial class frmTKPhong : Form
    {
        public frmTKPhong()
        {
            InitializeComponent();
        }
        PhongTro pt = new PhongTro();
        IEnumerable<tblPhong> dsP;
        private void frmTKPhong_Load(object sender, EventArgs e)
        {
            dsP = pt.layPhongTro();
            dgvPhong.DataSource = dsP.ToList();
            FormatDGV(dgvPhong);
            //để hỗ trợ autocomplet ta phải chỉ rõ 2 thuộc tính
            txtCanTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCanTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            radTheoTenPhong.Checked = true;
        }
        void FormatDGV(DataGridView dgv)
        {
            try
            {
                dgv.Columns["IDPhong"].Visible = false;
                dgv.Columns["IDChuTro"].HeaderText = "ID Chủ Trọ";
                dgv.Columns["IDChuTro"].Width = 150;
                dgv.Columns["TenPhong"].HeaderText = "Tên Phòng";
                dgv.Columns["TenPhong"].Width = 150;
                dgv.Columns["TrangThaiPhong"].HeaderText = "Trạng thái";
                dgv.Columns["TrangThaiPhong"].Width = 150;
                dgv.Columns["GiaPhong"].HeaderText = "Giá Phòng";
                dgv.Columns["GiaPhong"].Width = 150;
                dgv.Columns["SoLuongSVSong"].HeaderText = "Số lượng Sinh Viên Có Thể Ở";
                dgv.Columns["SoLuongSVSong"].Width = 150;
                dgv.Columns["tblChuTro"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: " + ex.Message, "Thông báo");
            }
        }
        private void btnOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radTheoTenPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheoTenPhong.Checked)
            {
                txtCanTim.AutoCompleteCustomSource.Clear();
                foreach (tblPhong pt in dsP)
                {
                    txtCanTim.AutoCompleteCustomSource.Add(pt.TenPhong.Trim());
                }
            }
        }

        private void radIDChuTro_CheckedChanged(object sender, EventArgs e)
        {
            if (radIDChuTro.Checked)
            {
                txtCanTim.AutoCompleteCustomSource.Clear();
                foreach (tblPhong pt in dsP)
                {
                    txtCanTim.AutoCompleteCustomSource.Add(pt.IDChuTro.Trim());
                }
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            IEnumerable<tblPhong> dsPLoc = pt.timKiemPhongTro(txtCanTim.Text, radTheoTenPhong.Checked);
            dgvPhong.DataSource = dsPLoc;
            FormatDGV(dgvPhong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsP = pt.layPhongTro();
            dgvPhong.DataSource = dsP.ToList();
        }
    }
}
