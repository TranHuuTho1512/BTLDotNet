using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyPhongTro
{
    public partial class frmChuTro : Form
    {
        public frmChuTro()
        {
            InitializeComponent();
        }
        ChuTro ct = new ChuTro();
        private void frmChuTro_Load(object sender, EventArgs e)
        {
            //lấy toàn bộ User
            IEnumerable<tblChuTro> tkdn = ct.layChuTro();
            CreateColumnCT(lvwCT);
            txtTenCT.Focus();
            IEnumerable<tblChuTro> dsCT = ct.layChuTro();
            LoadToanBoChuTro(lvwCT, dsCT);
        }
        void text_false()
        {
            txtCMNDCT.Enabled = false;
            txtDiaChiCT.Enabled = false;
            txtEmailCT.Enabled = false;
            txtIDCT.Enabled = false;
            txtSDTCT.Enabled = false;
            txtTenCT.Enabled = false;
            cboTTCT.Enabled = false;
        }
        void text_true()
        {
            txtCMNDCT.Enabled = true;
            txtDiaChiCT.Enabled = true;
            txtEmailCT.Enabled = true;
            txtIDCT.Enabled = true;
            txtSDTCT.Enabled = true;
            txtTenCT.Enabled = true;
            cboTTCT.Enabled = true;
        }
        void CreateColumnCT(ListView lvw)
        {
            lvw.Columns.Clear();// xoa het column
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("ID Chủ Trọ", 150);
            lvw.Columns.Add("Họ và Tên", 200);
            lvw.Columns.Add("CMND", 150);
            lvw.Columns.Add("Địa chỉ ", 150);
            lvw.Columns.Add("Số điện thoại", 150);
            lvw.Columns.Add("Email", 150);
            lvw.Columns.Add("Trạng Thái", 150);
        }
        void LoadToanBoChuTro(ListView lvw, IEnumerable<tblChuTro> dsChuTro)
        {
            lvw.Items.Clear();
            foreach (tblChuTro ct in dsChuTro)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = ct.IDChuTro;
                lvwItem.SubItems.Add(ct.TenChuTro);
                lvwItem.SubItems.Add(ct.CMNDChuTro);
                lvwItem.SubItems.Add(ct.DiaChiChuTro);
                lvwItem.SubItems.Add(ct.SDTChuTro.ToString());
                lvwItem.SubItems.Add(ct.EmailChuTro);
                lvwItem.SubItems.Add(ct.TrangThaiChoThue);
                // lvwItem.ImageIndex = 0;//lấy hình đầu tiên trong tập img
                lvwItem.Tag = ct;//phục vụ xóa
                lvw.Items.Add(lvwItem);
            }
        }
        private void lvwCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblChuTro ct = null;
            if (lvwCT.SelectedItems.Count > 0)// co item đang chọn
            {
                ct = (tblChuTro)lvwCT.SelectedItems[lvwCT.SelectedItems.Count - 1].Tag;
                ThongTinChuTro(ct);
                btnSuaChu.Enabled = true;
                btnXoaChu.Enabled = true;
                txtIDCT.Enabled = false;
                btnLuuChu.Enabled = false;
                btnThem.Text = "Thêm";
            }
        }
        void ThongTinChuTro(tblChuTro ct)
        {
            txtIDCT.Text = ct.IDChuTro.Trim();
            txtTenCT.Text = ct.TenChuTro.Trim();
            txtCMNDCT.Text = ct.CMNDChuTro.Trim();
            txtDiaChiCT.Text = ct.DiaChiChuTro.Trim();
            txtSDTCT.Text = ct.SDTChuTro.ToString().Trim();
            txtEmailCT.Text = ct.EmailChuTro.Trim();
            cboTTCT.Text = ct.TrangThaiChoThue.Trim();
        }

        tblChuTro CreateCT()
        {
            tblChuTro ct = new tblChuTro();
            ct.IDChuTro = txtIDCT.Text;
            ct.TenChuTro = txtTenCT.Text;
            ct.CMNDChuTro = txtCMNDCT.Text;
            ct.DiaChiChuTro = txtDiaChiCT.Text;
            ct.SDTChuTro = Convert.ToInt32(txtSDTCT.Text.ToString());
            ct.EmailChuTro = txtEmailCT.Text;
            ct.TrangThaiChoThue = cboTTCT.Text;
            return ct;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                txtIDCT.Enabled = true;
                btnLuuChu.Enabled = true;
                btnThem.Text = "Hủy Thêm";
            }
            else// hủy
            {
                txtIDCT.Enabled = false;
                btnLuuChu.Enabled = false;
                btnThem.Text = "Thêm";
            }
        }
        private void btnLuuChu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDCT.Text.Length<=0||txtTenCT.Text.Length<=0||txtCMNDCT.Text.Length<=0||txtDiaChiCT.Text.Length<=0||txtSDTCT.Text.Length<=0||txtEmailCT.Text.Length<=0|| cboTTCT==null)
                {
                    MessageBox.Show("Phải điền đầy đủ", "Thông báo", MessageBoxButtons.OK);
                }
                DialogResult hoiThoat;
                hoiThoat = MessageBox.Show("Bạn có muốn lưu hay không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoiThoat == DialogResult.Yes)
                {
                    IEnumerable<tblChuTro> dsChuTro;
                    //viết hàm kiểm tra đúng dữ liệu ? các em tự viết
                    tblChuTro Chutroobj = CreateCT();
                    ct.themChuTro(Chutroobj);
                    //thêm xong load lại CSDL
                    dsChuTro = ct.layChuTro();
                    //Đưa vào listview
                    LoadToanBoChuTro(lvwCT, dsChuTro);
                    btnLuuChu.Enabled = false;
                    btnThem.Text = "Thêm";
                }
                else
                {
                    btnLuuChu.Enabled = false;
                    btnThem.Text = "Thêm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }
        private void btnSuaChu_Click(object sender, EventArgs e)
        {
            DialogResult hoiThoat;
            hoiThoat = MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoiThoat == DialogResult.Yes)
            {
                btnSuaChu.Enabled = false;
                btnXoaChu.Enabled = false;
                string strCT;
                IEnumerable<tblChuTro> dsCT;
                tblChuTro ctobjSua = CreateCT();
                ct.suaChuTro(ctobjSua);
                //thêm xong load lại CSDL
                strCT = lvwCT.SelectedItems.Count.ToString();//ho trợ chọn tên lấy mã
                dsCT = ct.layChuTroThuocTaiKhoan(strCT);
                //Đưa vào listview
                LoadToanBoChuTro(lvwCT, dsCT);
            }
            else
            {
                btnSuaChu.Enabled = false;
                btnXoaChu.Enabled = false;
            }
        }
        private void btnXoaChu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    IEnumerable<tblChuTro> dsChuTro;
                    tblChuTro ChuTroDeXoa = null;
                    //luôn luon hỏi
                    //sinh vietn tu lam
                    if (lvwCT.SelectedItems.Count > 0)
                    {
                        ChuTroDeXoa = (tblChuTro)lvwCT.SelectedItems[lvwCT.SelectedItems.Count - 1].Tag;
                        ct.xoaChuTro(ChuTroDeXoa);
                        //xóa xong load lại CSDL
                        dsChuTro = ct.layChuTro();
                        //Đưa vào listview
                        LoadToanBoChuTro(lvwCT, dsChuTro);
                    }
                    btnXoaChu.Enabled = false;
                    btnSuaChu.Enabled = false;
                }
                else
                {
                    btnXoaChu.Enabled = false;
                    btnSuaChu.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chủ trọ vẫn còn chứa phòng và sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoiThoat;
            hoiThoat = MessageBox.Show("Bạn sẽ thoát đó ?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoiThoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtSDTCT_Leave(object sender, EventArgs e)
        {
            if (txtSDTCT.Text.Length > 0)
            {
                string s = txtSDTCT.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
                if (!s.PhoneCheck())
                {
                    MessageBox.Show("Nhập SDT không hợp lệ!!", "Thông báo");
                }
            }
        }

        private void txtEmailCT_Leave(object sender, EventArgs e)
        {
            string s = txtEmailCT.Text.Trim();
            if (!s.EmailCheck())
            {
                MessageBox.Show("Nhập email không hợp lệ!!", "Thông báo");
            }
        }

        private void txtIDCT_Leave(object sender, EventArgs e)
        {
            if (txtIDCT.Text.Length > 0)
            {
                string s = txtIDCT.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
                if (!s.IsNumber())
                {
                    MessageBox.Show("Số id không hợp lệ!!", "Thông báo");
                }
            }
        }

        private void txtCMNDCT_Leave(object sender, EventArgs e)
        {
            if (txtCMNDCT.Text.Length > 0)
            {
                string s = txtCMNDCT.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
                if (!s.WordAndNumberCheck())
                {
                    MessageBox.Show("Số CMND không hợp lệ!!", "Thông báo");
                }
            }
        }

        private void txtTenCT_Leave(object sender, EventArgs e)
        {
            if (txtTenCT.Text.Length > 0)
            {
                string s = txtTenCT.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
                if (!s.FulNameCheck())
                {
                    MessageBox.Show("Tên không hợp lệ!!", "Thông báo");
                }
            }
        }
    }
}
