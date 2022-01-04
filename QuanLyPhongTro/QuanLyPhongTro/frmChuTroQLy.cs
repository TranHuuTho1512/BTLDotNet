using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class frmChuTroQLy : Form
    {
        public string id = "";
        TreeNode nGoc = null;
        PhongTro ph = new PhongTro();
        SinhVien sv = new SinhVien();
        public frmChuTroQLy()
        {
            InitializeComponent();
        }
        public frmChuTroQLy(TaiKhoan tk)
        {
            InitializeComponent();
            id = tk.UserName;
        }
        void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();// xoa het column
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã số", 150);
            lvw.Columns.Add("Tên sinh viên", 150);
            lvw.Columns.Add("Quê quán", 150);
            lvw.Columns.Add("Số điện thoại", 150);
            lvw.Columns.Add("Năm sinh", 150);
            lvw.Columns.Add("Trường", 150);
            lvw.Columns.Add("Khoa", 150);
            lvw.Columns.Add("Tên Phòng", 150);
        }
        void LoadToanBoSV(ListView lvw, IEnumerable<tblSinhVien> dsSV)
        {
            lvw.Items.Clear();
            foreach (tblSinhVien sv in dsSV)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = sv.MSSV;
                lvwItem.SubItems.Add(sv.TenSV);
                lvwItem.SubItems.Add(sv.QueQuanSV);
                lvwItem.SubItems.Add(sv.SDTSV);
                lvwItem.SubItems.Add(sv.NamSinhSV.ToString());
                lvwItem.SubItems.Add(sv.TruongHoc);
                lvwItem.SubItems.Add(sv.KhoaSV);
                IEnumerable<tblPhong> dsPhong = ph.layPhongTroThuocChuTro(id);
                foreach (tblPhong PH in dsPhong)
                {
                    if (PH.IDPhong.Equals(sv.IDPhong))
                    {
                        lvwItem.SubItems.Add(PH.TenPhong);
                    }
                }

                // lvwItem.ImageIndex = 0;//lấy hình đầu tiên trong tập img
                lvwItem.Tag = sv;//phục vụ xóa
                lvw.Items.Add(lvwItem);
            }
        }
        void TaoNutSVThuocPhong(TreeNode nPhong, IEnumerable<tblSinhVien> dsSVThuocPhong)
        {
            TreeNode nSV;
            trePhong.Nodes.Clear();
            foreach (tblSinhVien sVien in dsSVThuocPhong)
            {
                nSV = new TreeNode();
                nSV.Text = "Sinh viên: " + sVien.TenSV;
                nSV.ImageKey = "sv.png";
                nSV.Tag = sVien;
                nPhong.Nodes.Add(nSV);
            }
        }
        public void LoadTree(TreeView tre)
        {
            IEnumerable<tblPhong> dsP = ph.layPhongTroThuocChuTro(id);
            string strIDPhong;
            tre.Nodes.Clear();//xóa hết node
            nGoc.Nodes.Clear();
            TreeNode nPhong;
            IEnumerable<tblSinhVien> dsSVThuocPhong;
            cboPhong.Items.Clear();
            foreach (tblPhong phong in dsP)
            {
                cboPhong.Items.Add(phong.TenPhong);
                nPhong = new TreeNode();
                nPhong.Text = "Phòng:" + phong.TenPhong;
                nPhong.ImageKey = "house close.png";
                if (nPhong.IsExpanded)
                {
                    nPhong.ImageKey = "house open.png";
                }
                nPhong.Tag = phong.IDPhong;//để đó
                strIDPhong = phong.IDPhong.ToString();
                dsSVThuocPhong = sv.laySVThuocPhong(strIDPhong);
                //Đưa vào listviewf
                TaoNutSVThuocPhong(nPhong, dsSVThuocPhong);
                nGoc.Nodes.Add(nPhong);
            }
            tre.Nodes.Add(nGoc);
        }
        
        public string SelectPhong = "";
        private void frmChuTroQLy_Load(object sender, EventArgs e)
        {
            nGoc = new TreeNode("Danh Sách Phòng Trọ");
            LoadTree(trePhong);
            CreateColumn(lvwSinhVien);
            LoadToanBoSinhVien(lvwSinhVien, sv.laySVThuocChuTro(id));
            txtMSSV.Focus();
        }
        

        void GanObjectToField(tblSinhVien svselect)
        {
            txtMSSV.Text = svselect.MSSV.ToString().Trim();
            txtName.Text = svselect.TenSV.ToString().Trim();
            txtKhoa.Text = svselect.KhoaSV.ToString().Trim();
            txtQueQuan.Text = svselect.QueQuanSV.ToString().Trim();
            txtSchool.Text = svselect.TruongHoc.ToString().Trim();
            txtSDT.Text = svselect.SDTSV.ToString().Trim();
            IEnumerable<tblPhong> dsPhong = ph.layPhongTroThuocChuTro(id);
            foreach (tblPhong PH in dsPhong)
            {
                if (PH.IDPhong.Equals(svselect.IDPhong))
                    cboPhong.Text = PH.TenPhong.ToString().Trim();
            }
            dtpNamSinh.Value = Convert.ToDateTime(svselect.NamSinhSV.ToString());
        }
        private void trePhong_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strIDPhong;
            IEnumerable<tblSinhVien> dsSVThuocPhong;
            if (trePhong.SelectedNode != null)//có chon
            {
                if (trePhong.SelectedNode.Level == 1)//node phong
                {
                    strIDPhong = trePhong.SelectedNode.Tag.ToString();// đưa vào lúc tạo node
                    SelectPhong = strIDPhong;
                    dsSVThuocPhong = sv.laySVThuocPhong(strIDPhong);
                    //Đưa vào listview
                    LoadToanBoSV(lvwSinhVien, dsSVThuocPhong);
                    Form frm = frmChuTroQLy.ActiveForm;

                }
                else if (trePhong.SelectedNode.Level == 2)//node sinh viên
                {
                    tblSinhVien svLayDuoc = null;
                    svLayDuoc = (tblSinhVien)trePhong.SelectedNode.Tag;
                    GanObjectToField(svLayDuoc);
                    foreach (ListViewItem tmp in lvwSinhVien.Items)
                    {
                        tmp.Selected = false;
                    }
                    foreach (ListViewItem tmp in lvwSinhVien.Items)
                    {
                        if (tmp.Text.Equals(svLayDuoc.MSSV))
                        {
                            tmp.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timMenu.Start();
            if (lblMenu.Text.Equals("Menu"))
                lblMenu.Text = "Back";
            else if (lblMenu.Text.Equals("Back"))
                lblMenu.Text = "Menu";
            else if (lblMenu.Text.Equals("Back menu"))
            {
                timMenu.Stop();
                lblMenu.Text = "Back";
            }
        }

        private void timMenu_Tick(object sender, EventArgs e)
        {
            if (lblMenu.Text.Equals("Menu"))
            {
                pnlMenu.Width -= 80;
                if (pnlMenu.Width <= 0)
                    timMenu.Stop();

            }
            else if (lblMenu.Text.Equals("Back"))
            {
                pnlMenu.Width += 80;
                if (pnlMenu.Width >= 150)
                    timMenu.Stop();
            }
        }
        private void timTree_Tick(object sender, EventArgs e)
        {
            if (lblMenu.Text.Equals("Back"))
            {
                trePhong.Width -= 80;
                if (trePhong.Width <= 0)
                    timTree.Stop();
            }
            else if (lblMenu.Text.Equals("Back menu"))
            {
                trePhong.Width += 80;
                if (trePhong.Width >= 150)
                    timMenu.Stop();
            }
        }
        private void btnQlyPhong_Click(object sender, EventArgs e)
        {
            frmPhong frm = new frmPhong(id);
            frm.ShowDialog();
            frm.StartPosition = FormStartPosition.CenterParent;
        }
        private void btnTreeSV_Click(object sender, EventArgs e)
        {
            timTree.Start();
            if (lblMenu.Text.Equals("Back"))
                lblMenu.Text = "Back menu";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text.Equals("Thêm"))
            {
                btnThemSinhVien.Enabled = true;
                btnNew.Text = "Hủy Thêm";
            }
            else// hủy
            {
                btnThemSinhVien.Enabled = false;
                btnNew.Text = "Thêm";
            }
        }

        //Làm quản lý mới

        

        /// <summary>
        /// //////  SINH VIÊN
        /// </summary>
        /// <returns></returns>

        tblSinhVien CreatObject()
        {
            tblSinhVien tmpsv = new tblSinhVien();
            IEnumerable<tblPhong> dsPhong = ph.layPhongTroThuocChuTro(id);
            tmpsv.MSSV = txtMSSV.Text;
            tmpsv.TenSV = txtName.Text;
            tmpsv.QueQuanSV = txtQueQuan.Text;
            tmpsv.SDTSV = txtSDT.Text;
            tmpsv.NamSinhSV = Convert.ToDateTime(dtpNamSinh.Value.ToString("yyyy-MM-dd"));
            tmpsv.TruongHoc = txtSchool.Text;
            tmpsv.KhoaSV = txtKhoa.Text;
            foreach (tblPhong item in dsPhong)
            {
                if (item.TenPhong.Equals(cboPhong.SelectedItem.ToString()))
                {
                    tmpsv.IDPhong = item.IDPhong;
                    IEnumerable<tblSinhVien> dssvTP = sv.laySVThuocPhong(cboPhong.SelectedItem.ToString());
                    if (dssvTP.Count() == 0)
                    {
                        DateTime d = new DateTime();
                        d = DateTime.Now;
                        item.NgayBatDau = d;
                    }    

                }    
                    
                
            }
            

            return tmpsv;
        }
        void LoadToanBoSinhVien(ListView lvw, IEnumerable<tblSinhVien> dsSV)
        {
            lvw.Items.Clear();
            IEnumerable<tblPhong> dsPhong = ph.layPhongTroThuocChuTro(id);
            foreach (tblSinhVien sv in dsSV)
            {
                foreach (tblPhong PH in dsPhong)
                {
                    if (PH.IDPhong.Equals(sv.IDPhong))
                    {
                        ListViewItem lvwItem = new ListViewItem();
                        lvwItem.Text = sv.MSSV;
                        lvwItem.SubItems.Add(sv.TenSV);
                        lvwItem.SubItems.Add(sv.QueQuanSV);
                        lvwItem.SubItems.Add(sv.SDTSV);
                        lvwItem.SubItems.Add(sv.NamSinhSV.ToString());
                        lvwItem.SubItems.Add(sv.TruongHoc);
                        lvwItem.SubItems.Add(sv.KhoaSV);
                        lvwItem.SubItems.Add(PH.TenPhong);
                        lvwItem.Tag = sv;//phục vụ xóa
                        lvw.Items.Add(lvwItem);
                    }
                }
            }
        }
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text.Length <= 0 || txtName.Text.Length <= 0 || txtKhoa.Text.Length <= 0 || txtQueQuan.Text.Length <= 0 || txtSDT.Text.Length <= 0 || txtSchool.Text.Length <= 0 || dtpNamSinh.Text == null || cboPhong == null)
                {
                    MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK);
                }
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn lưu hay không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    IEnumerable<tblSinhVien> dsSVThuocPhong;
                    tblSinhVien svobj = CreatObject();
                    sv.themSinhVien(svobj);
                    //thêm xong load lại CSDL
                    dsSVThuocPhong = sv.laySVThuocChuTro(id);
                    //Đưa vào listview            
                    LoadToanBoSinhVien(lvwSinhVien, dsSVThuocPhong);
                    //Đưa vào treeview
                    LoadTree(trePhong);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn sửa hay không ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tblSinhVien svMoi = CreatObject();
                sv.suaSinhVien(svMoi);
                MessageBox.Show("Sửa thành công", "", MessageBoxButtons.OK);
                IEnumerable<tblSinhVien> dsSVThuocPhong;
                dsSVThuocPhong = sv.laySVThuocChuTro(id);
                LoadToanBoSinhVien(lvwSinhVien, dsSVThuocPhong);
                LoadTree(trePhong);
            }
            else
            {

            }
        }

        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn sắp xóa đó ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tblSinhVien svXoa = sv.GetObjSinhVienDeXoa(txtMSSV.Text);
                sv.xoaSinhVien(svXoa);
                IEnumerable<tblSinhVien> dsSVThuocPhong;
                dsSVThuocPhong = sv.laySVThuocChuTro(id);
                LoadToanBoSinhVien(lvwSinhVien, dsSVThuocPhong);
                LoadTree(trePhong);
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
            }
            else
            {

            }
            
        }
        PhongTro pt = new PhongTro();
        // 23:41 6/22/2020
        void ThongTinSV(tblSinhVien sv)
        {
            txtMSSV.Text = sv.MSSV;
            txtName.Text = sv.TenSV;
            txtQueQuan.Text = sv.QueQuanSV;
            txtSDT.Text = sv.SDTSV;
            dtpNamSinh.Text = sv.NamSinhSV.ToString();
            txtSchool.Text = sv.TruongHoc;
            txtKhoa.Text = sv.KhoaSV;
            IEnumerable<tblPhong> dsPhong = ph.layPhongTroThuocChuTro(id);
            foreach (tblPhong phong in dsPhong)
            {
                if(phong.IDPhong.Equals(sv.IDPhong))
                {
                    cboPhong.Text = phong.TenPhong.ToString();
                }    
            }
        }

        private void lvwSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblSinhVien sv = null;
            if (lvwSinhVien.SelectedItems.Count > 0)// co item đang chọn
            {
                sv = (tblSinhVien)lvwSinhVien.SelectedItems[lvwSinhVien.SelectedItems.Count - 1].Tag;
                ThongTinSV(sv);
            }
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            frmTKSV frm = new frmTKSV(id);
            frm.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadToanBoSinhVien(lvwSinhVien, sv.laySVThuocChuTro(id));
            trePhong.Nodes.Clear();
            LoadTree(trePhong);
        }

        private void lvwSinhVien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tblSinhVien sv = null;
            if (lvwSinhVien.SelectedItems.Count > 0)// co item đang chọn
            {
                sv = (tblSinhVien)lvwSinhVien.SelectedItems[lvwSinhVien.SelectedItems.Count - 1].Tag;
                ThongTinSV(sv);
                btnSuaSinhVien.Enabled = true;
            }
        }

        private void cboPhong_Click(object sender, EventArgs e)
        {
            LoadTree(trePhong);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToLongTimeString();
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void trePhong_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var hitTest = e.Node.TreeView.HitTest(e.Location);
            if (hitTest.Location == TreeViewHitTestLocations.PlusMinus)
                return;

            if (e.Node.IsExpanded)
                e.Node.Collapse();
            else
                e.Node.Expand();
        }

        private void lvwSinhVien_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            tblSinhVien sv = null;
            if (lvwSinhVien.SelectedItems.Count > 0)// co item đang chọn
            {
                sv = (tblSinhVien)lvwSinhVien.SelectedItems[lvwSinhVien.SelectedItems.Count - 1].Tag;
                GanObjectToField(sv);
            }
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                string s = txtName.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
                if (!s.FulNameCheck())
                {
                    MessageBox.Show("Tên sinh viên không hợp lệ!!", "Thông báo");
                }
            }
        }

        private void txtMSSV_Leave(object sender, EventArgs e)
        {
            if (txtMSSV.Text.Length > 0)
            {
                string s = txtMSSV.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
            }
        }

        private void txtQueQuan_Leave(object sender, EventArgs e)
        {
            if (txtQueQuan.Text.Length > 0)
            {
                string s = txtQueQuan.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length > 0)
            {
                string s = txtSDT.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
                if (!s.PhoneCheck())
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!!", "Thông báo");
                }
            }
        }

        private void txtSchool_Leave(object sender, EventArgs e)
        {
            if (txtSchool.Text.Length > 0)
            {
                string s = txtSchool.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
            }
        }

        private void txtKhoa_Leave(object sender, EventArgs e)
        {
            if (txtKhoa.Text.Length > 0)
            {
                string s = txtKhoa.Text.Trim();
                //cách gọi phương thức mở rộng RegularExpression
                s = s.PerfectString();
            }
        }
    }
}
