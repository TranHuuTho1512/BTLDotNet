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
    public partial class frmPhong : Form
    {
        public string idChuTro = "";
        public frmPhong()
        {
            InitializeComponent();
        }
        public frmPhong(string id)
        {
            InitializeComponent();
            idChuTro = id;
        }
        ChuTro ct = new ChuTro();
        PhongTro pt = new PhongTro();
        private void frmPhong_Load(object sender, EventArgs e)
        {
          // lstPhong.DisplayMember="ten filed hen ra"            
            CreateColumnPhong(lvwPhong);
            txtTenPhong.Focus();
            IEnumerable<tblPhong> dsPT = pt.layPhongTro();
            LoadToanBoPhongTro(lvwPhong, dsPT);
        }
        void CreateColumnPhong(ListView lvw)
        {
            lvw.Columns.Clear();// xoa het column
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Tên Phòng", 150);
            lvw.Columns.Add("ID Chủ Trọ", 150);
            lvw.Columns.Add("Giá Phòng", 200);
            lvw.Columns.Add("Số lượng sinh viên/Phòng", 200);
            lvw.Columns.Add("Trạng Thái", 150);
        }

        void LoadToanBoPhongTro(ListView lvw, IEnumerable<tblPhong> dsPhong)
        {
            lvw.Items.Clear();
            IEnumerable<tblPhong> dsPhongThuocChuTro = pt.layPhongTroThuocChuTro(idChuTro);
            foreach (tblPhong pt in dsPhongThuocChuTro)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = pt.TenPhong;
                lvwItem.SubItems.Add(pt.IDChuTro);
                lvwItem.SubItems.Add(pt.GiaPhong.ToString());
                lvwItem.SubItems.Add(pt.SoLuongSVSong.ToString());
                lvwItem.SubItems.Add(pt.TrangThaiPhong);
                // lvwItem.ImageIndex = 0;//lấy hình đầu tiên trong tập img
                lvwItem.Tag = pt;//phục vụ xóa
                lvw.Items.Add(lvwItem);
            }
        }
        void ThongTinPhongTro(tblPhong pt)
        {
            txtTenPhong.Text = pt.TenPhong.Trim();
            txtGiaPhong.Text = pt.GiaPhong.ToString().Trim();
            cboTTP.Text = pt.TrangThaiPhong.ToString(); 
            cboSoLuongSV.Text = pt.SoLuongSVSong.ToString();
        }
        tblPhong CreatePhongtaomoiid(string newIDPhong)
        {
            tblPhong pt = new tblPhong();
            pt.IDPhong = newIDPhong;
            pt.IDChuTro = idChuTro;
            pt.TenPhong = txtTenPhong.Text;
            pt.GiaPhong = Convert.ToDecimal(txtGiaPhong.Text);
            pt.TrangThaiPhong = cboTTP.Text;
            pt.SoLuongSVSong = Convert.ToInt32(cboSoLuongSV.Text);          
            return pt;
        }
        public string getIDPhongTuTenPhong(string TenPhong)
        {
            string idP="";
            IEnumerable<tblPhong> dsPhongThuocChuTro = pt.layPhongTroThuocChuTro(idChuTro);
            foreach (tblPhong pt in dsPhongThuocChuTro)
            {
                if(pt.TenPhong.ToString().Equals(TenPhong))
                {
                    idP = pt.IDPhong;
                }
                
            }
            return idP;
        }
        tblPhong CreatePhong()
        {

            tblPhong pt = new tblPhong();
            pt.IDPhong = getIDPhongTuTenPhong(txtTenPhong.Text);
            pt.TenPhong = txtTenPhong.Text;
            pt.GiaPhong = Convert.ToDecimal(txtGiaPhong.Text);
            pt.TrangThaiPhong = cboTTP.Text;
            pt.SoLuongSVSong = Convert.ToInt32(cboSoLuongSV.Text);
            return pt;
        }
        private void lvwPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblPhong pt = null;
            if (lvwPhong.SelectedItems.Count > 0)// co item đang chọn
            {
                pt = (tblPhong)lvwPhong.SelectedItems[lvwPhong.SelectedItems.Count - 1].Tag;
                ThongTinPhongTro(pt);
                btnSuaPhong.Enabled = true;
                btnXoaPhong.Enabled = true;
            }   
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn sắp xóa đó ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    IEnumerable<tblPhong> dsPhongThuocChuTro;
                    tblPhong PhongDeXoa = null;
                    //luôn luon hỏi
                    //sinh vietn tu lam
                    if (lvwPhong.SelectedItems.Count > 0)
                    {
                        PhongDeXoa = (tblPhong)lvwPhong.SelectedItems[lvwPhong.SelectedItems.Count - 1].Tag;
                        pt.xoaPhong(PhongDeXoa);
                        //xóa xong load lại CSDL
                        dsPhongThuocChuTro = pt.layPhongTroThuocChuTro(idChuTro);
                        //Đưa vào listview
                        LoadToanBoPhongTro(lvwPhong, dsPhongThuocChuTro);
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        btnXoaPhong.Enabled = false;
                        btnSuaPhong.Enabled = false;
                    }
                }
                else
                {
                    btnXoaPhong.Enabled = false;
                    btnSuaPhong.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Phòng vẫn còn chứa sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                IEnumerable<tblPhong> dsPhongThuocChuTro = null;
                btnSuaPhong.Enabled = false;
                tblPhong PhongobjSua = CreatePhong();
                pt.suaPhog(PhongobjSua);
                //thêm xong load lại CSDL
                dsPhongThuocChuTro = pt.layPhongTroThuocChuTro(idChuTro);
                //Đưa vào listview
                LoadToanBoPhongTro(lvwPhong, dsPhongThuocChuTro);
                MessageBox.Show("Sửa thành công", "Thông báo");
                btnXoaPhong.Enabled = false;
                btnSuaPhong.Enabled = false;
            }
            else
            {
                btnXoaPhong.Enabled = false;
                btnSuaPhong.Enabled = false;
            }
        }
        private void btnLuuPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenPhong.Text.Length <= 0 || txtGiaPhong.Text.Length <= 0 || cboSoLuongSV == null || cboTTP == null)
                {
                    MessageBox.Show("Phải điền đầy đủ", "Thông báo", MessageBoxButtons.OK);
                }
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn lưu hay không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    IEnumerable<tblPhong> dsPhong;
                    dsPhong = pt.layPhongTro();
                    int maxid = 0;
                    foreach (tblPhong phong in dsPhong)
                    {
                        if (maxid < Convert.ToInt32(phong.IDPhong))
                        {
                            maxid = Convert.ToInt32(phong.IDPhong);
                        }
                    }
                    maxid += 1;
                    IEnumerable<tblPhong> dsPhongThuocChuTro;
                    dsPhongThuocChuTro = pt.layPhongTroThuocChuTro(idChuTro);
                    //viết hàm kiểm tra đúng dữ liệu ? các em tự viết
                    tblPhong Phongobj = null;
                    int tmp = 0;
                    foreach (tblPhong phong in dsPhongThuocChuTro)
                    {
                        if (txtTenPhong.Text.Equals(phong.TenPhong))
                        {
                            tmp = 1;
                        }
                    }
                    if (tmp == 0)
                    {
                        Phongobj = CreatePhongtaomoiid(maxid.ToString());
                        pt.themPhong(Phongobj);
                        //thêm xong load lại CSDL
                        //Đưa vào listview
                        LoadToanBoPhongTro(lvwPhong, dsPhongThuocChuTro);
                        btnLuuPhong.Enabled = false;
                        btnThem.Text = "Thêm";
                    }
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
                else
                {
                    btnLuuPhong.Enabled = false;
                    btnThem.Text = "Thêm";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                btnLuuPhong.Enabled = true;
                btnThem.Text = "Hủy Thêm";
            }
            else// hủy
            {
                btnLuuPhong.Enabled = false;
                btnThem.Text = "Thêm";
            }
        }

        private void frmPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
