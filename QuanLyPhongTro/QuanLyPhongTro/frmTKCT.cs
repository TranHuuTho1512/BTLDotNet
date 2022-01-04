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
    public partial class frmTKCT : Form
    {
        public frmTKCT()
        {
            InitializeComponent();
        }
        ChuTro ct = new ChuTro();
        IEnumerable<tblChuTro> dsCT;
        private void frmTKCT_Load(object sender, EventArgs e)
        {
            dsCT = ct.layChuTro();
            dgvChuTro.DataSource = dsCT.ToList();
            FormatDGV(dgvChuTro);
            //để hỗ trợ autocomplet ta phải chỉ rõ 2 thuộc tính
            txtCanTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCanTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            radDiaChiCT.Checked = true;
        }
        void FormatDGV(DataGridView dgv)
        {
            try
            {
                dgv.Columns["IDChuTro"].HeaderText = "ID Chủ Trọ";
                dgv.Columns["IDChuTro"].Width = 150;
                dgv.Columns["TenChuTro"].HeaderText = "Tên Chủ Trọ";
                dgv.Columns["TenChuTro"].Width = 150;
                dgv.Columns["CMNDChuTro"].HeaderText = "Chứng Minh Thư";
                dgv.Columns["CMNDChuTro"].Width = 150;
                dgv.Columns["DiaChiChuTro"].HeaderText = "Địa chỉ";
                dgv.Columns["DiaChiChuTro"].Width = 150;
                dgv.Columns["SDTChuTro"].HeaderText = "Số điện thoại";
                dgv.Columns["SDTChuTro"].Width = 150;
                dgv.Columns["EmailChuTro"].HeaderText = "Email";
                dgv.Columns["EmailChuTro"].Width = 150;
                dgv.Columns["TrangThaiChoThue"].HeaderText = "Trạng Thái";
                dgv.Columns["TrangThaiChoThue"].Width = 150;
                dgv.Columns["Pass"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: " + ex.Message, "Thông báo");
            }
        }
        private void radDiaChiCT_CheckedChanged(object sender, EventArgs e)
        {
            if (radDiaChiCT.Checked)
            {
                txtCanTim.AutoCompleteCustomSource.Clear();
                foreach (tblChuTro ct in dsCT)
                {
                    txtCanTim.AutoCompleteCustomSource.Add(ct.DiaChiChuTro.Trim());
                }
            }
        }

        private void radSDTCT_CheckedChanged(object sender, EventArgs e)
        {
            if (radSDTCT.Checked)
            {
                txtCanTim.AutoCompleteCustomSource.Clear();
                foreach (tblChuTro ct in dsCT)
                {
                    txtCanTim.AutoCompleteCustomSource.Add(ct.SDTChuTro.ToString());
                }
            }
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            IEnumerable<tblChuTro> dsCTLoc = ct.timKiemChuTro(txtCanTim.Text, radDiaChiCT.Checked);
            dgvChuTro.DataSource = dsCTLoc;
            FormatDGV(dgvChuTro);
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsCT = ct.layChuTro();
            dgvChuTro.DataSource = dsCT.ToList();
        }
    }
}
