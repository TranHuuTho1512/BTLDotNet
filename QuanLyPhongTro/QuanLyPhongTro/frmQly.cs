using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyPhongTro
{
    public partial class frmQly : Form
    {
        public frmQly()
        {
            InitializeComponent();
        }
       
        TreeNode nodeCha = null;
        ChuTro ct = new ChuTro();
        PhongTro pt = new PhongTro();
        SinhVien sv = new SinhVien();
        private void btnQlyTro_Click(object sender, EventArgs e)
        {
            Form frmtro = new frmChuTro();
            frmtro.ShowDialog();
            frmtro.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            nodeCha = new TreeNode("Danh sách chủ trọ");
            LoadTree(tVadmin);
            CreateColumnCT(lvwChuTro);
            IEnumerable<tblChuTro> dsCT = ct.layChuTro();
            LoadToanBoChuTro(lvwChuTro, dsCT);
            CreateColumnPhong(lvwPhongTro);
            IEnumerable<tblPhong> dsPT = pt.layPhongTro();
            LoadToanBoPhongTro(lvwPhongTro, dsPT);
            CreateColumnSinhVien(lvwSinhvien);
            IEnumerable<tblSinhVien> dsSV = sv.laySinhvien();
            LoadToanBoSinhVien(lvwSinhvien, dsSV);
        }
        
        //Tạo cột cho listview chủ trọ
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
        //Tạo cột cho listview phòng
        void CreateColumnPhong(ListView lvw)
        {
            lvw.Columns.Clear();// xoa het column
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("ID Phòng", 150);
            lvw.Columns.Add("Tên Phòng", 150);
            lvw.Columns.Add("ID Chủ Trọ", 150);
            lvw.Columns.Add("Giá Phòng", 200);
            lvw.Columns.Add("Số lượng sinh viên/Phòng", 200);
            lvw.Columns.Add("Trạng Thái", 150);
        }
        //Tạo cột cho listview Sinh Viên
        void CreateColumnSinhVien(ListView lvw)
        {
            lvw.Columns.Clear();// xoa het column
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("MSSV", 150);
            lvw.Columns.Add("Họ và Tên", 200);
            lvw.Columns.Add("Quê quán ", 200);
            lvw.Columns.Add("Số điện thoại", 150);
            lvw.Columns.Add("Năm sinh", 100);
            lvw.Columns.Add("Trường học", 150);
            lvw.Columns.Add("Khoa sinh viên", 150);
            lvw.Columns.Add("ID Phòng", 150);
            lvw.Columns.Add("Tên Phòng", 150);
        }
        //Hiện thị khung cây
        void LoadTree(TreeView tree)
        {
            IEnumerable<tblChuTro> dsct = ct.layChuTro();
            string strCT;
            tVadmin.Nodes.Clear();//xóa hết node
            nodeCha.Nodes.Clear();
            TreeNode nodeCT;
            IEnumerable<tblPhong> dsPhongTro;
            foreach(tblChuTro ctdn in dsct)
            {
                nodeCT = new TreeNode();
                nodeCT.Text = "Chủ Trọ: "+ ctdn.TenChuTro.ToString();
                if (nodeCT.IsExpanded)
                {
                    nodeCT.ImageKey = "chutromo.png";
                }
                nodeCT.SelectedImageIndex = 1;
                nodeCT.Tag = ctdn.IDChuTro;//để đó
                strCT = ctdn.IDChuTro;
                dsPhongTro = pt.layPhongTroThuocChuTro(strCT);
                //Đưa vào listview
                TaoNodePhongTro(nodeCT, dsPhongTro);
                nodeCha.Nodes.Add(nodeCT);
            }
            tree.Nodes.Add(nodeCha);
        }
        //Tạo node Phòng Trọ
        void TaoNodePhongTro(TreeNode nodeTK, IEnumerable<tblPhong> dsPhong)
        {
            TreeNode nodePhong;
            string strPhong;
            IEnumerable<tblSinhVien> dsSinhvien;
            foreach (tblPhong phongTro in dsPhong)
            {
                nodePhong = new TreeNode();
                nodePhong.Text = "Phòng: "+phongTro.TenPhong;
                nodePhong.ImageKey = "house close.png";
                if (nodePhong.IsExpanded)
                {
                    nodePhong.ImageKey = "house open.png";
                }
                nodePhong.SelectedImageIndex = 3;
                nodePhong.Tag = phongTro;
                nodeTK.Nodes.Add(nodePhong);
                strPhong = phongTro.IDPhong;
                dsSinhvien = sv.laySVThuocPhong(strPhong);
                TaoNodeSV(nodePhong, dsSinhvien);
            }
        }
        //Tạo node Phòng Trọ
        void TaoNodeSV(TreeNode nPhong, IEnumerable<tblSinhVien> dsSV)
        {
            TreeNode nSV;
            tVadmin.Nodes.Clear();
            foreach (tblSinhVien sVien in dsSV)
            {
                nSV = new TreeNode();
                nSV.Text = "Sinh viên: " + sVien.TenSV;
                nSV.ImageKey = "sv.png";
                nSV.Tag = sVien;
                nPhong.Nodes.Add(nSV);
            }
        }
        //Hiển thị danh sách chủ trọ lên list view
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
        //Hiển thị danh sách phòng trọ lên list view
        void LoadToanBoPhongTro(ListView lvw, IEnumerable<tblPhong> dsPhong)
        {
            lvw.Items.Clear();
            foreach (tblPhong pt in dsPhong)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = pt.IDPhong;
                lvwItem.SubItems.Add(pt.TenPhong);
                lvwItem.SubItems.Add(pt.IDChuTro);
                lvwItem.SubItems.Add(pt.GiaPhong.ToString());
                lvwItem.SubItems.Add(pt.SoLuongSVSong.ToString());
                lvwItem.SubItems.Add(pt.TrangThaiPhong);
                // lvwItem.ImageIndex = 0;//lấy hình đầu tiên trong tập img
                lvwItem.Tag = pt;//phục vụ xóa
                lvw.Items.Add(lvwItem);
            }
        }
        //Hiển thị danh sách sinh viên lên list view
        void LoadToanBoSinhVien(ListView lvw, IEnumerable<tblSinhVien> dsSV)
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
                lvwItem.SubItems.Add(sv.IDPhong);
                // lvwItem.ImageIndex = 0;//lấy hình đầu tiên trong tập img
                lvwItem.Tag = sv;//phục vụ xóa
                lvw.Items.Add(lvwItem);
            }
        }
        //Hiển thị danh sách sinh viên của chủ trọ lên list view
        void LoadToanBoSinhVienThuocChuTro(ListView lvw, IEnumerable<tblSinhVien> dsSV)
        {
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
                lvwItem.SubItems.Add(sv.IDPhong);
                // lvwItem.ImageIndex = 0;//lấy hình đầu tiên trong tập img
                lvwItem.Tag = sv;//phục vụ xóa
                lvw.Items.Add(lvwItem);
            }
        }
        //Bắt đầu chạy treevew
        private void tVadmin_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            string strCT;
            string strPhong;
            IEnumerable<tblPhong> dsPhongTrothuocChuTro;
            IEnumerable<tblSinhVien> dsSinhvienthuocPhong;
            if (tVadmin.SelectedNode != null)//có chon
            {
                if (tVadmin.SelectedNode.Level == 1)//node Chu Tro
                {
                    foreach (ListViewItem tmp in lvwChuTro.Items)
                    {
                        tmp.Selected = false;
                    }
                    string stridct = (string)tVadmin.SelectedNode.Tag;
                    foreach (ListViewItem tmp in lvwChuTro.Items)
                    {
                        if (tmp.Text.Equals(stridct))
                        {
                            tmp.Selected = true;
                            break;
                        }
                    }
                    strCT = (string)tVadmin.SelectedNode.Tag;// đưa vào lúc tạo node
                    dsPhongTrothuocChuTro = pt.layPhongTroThuocChuTro(strCT);
                    //Đưa vào listview Phòng trọ
                    LoadToanBoPhongTro(lvwPhongTro, dsPhongTrothuocChuTro);
                    string phongtro = "";
                    //Load vô listview SV
                    lvwSinhvien.Items.Clear();
                    foreach (tblPhong phong in dsPhongTrothuocChuTro)
                    {
                        phongtro = phong.IDPhong;
                        dsSinhvienthuocPhong = sv.laySVThuocPhong(phongtro);
                        //Đưa vào listview
                        LoadToanBoSinhVienThuocChuTro(lvwSinhvien, dsSinhvienthuocPhong);
                    }
                }
                else if (tVadmin.SelectedNode.Level == 2)//node Phong
                {
                    tblPhong phongtag = (tblPhong)tVadmin.SelectedNode.Tag;
                    strPhong = phongtag.IDPhong;// đưa vào lúc tạo node
                    dsSinhvienthuocPhong = sv.laySVThuocPhong(strPhong);
                    //Đưa vào listview
                    LoadToanBoSinhVien(lvwSinhvien, dsSinhvienthuocPhong);
                    tblPhong ptLayDuoc = null;
                    ptLayDuoc = (tblPhong)tVadmin.SelectedNode.Tag;
                    foreach (ListViewItem tmp in lvwPhongTro.Items)
                    {
                        tmp.Selected = false;
                    }
                    foreach (ListViewItem tmp in lvwPhongTro.Items)
                    {
                        if (tmp.Text.Equals(ptLayDuoc.IDPhong))
                        {
                            tmp.Selected = true;
                            break;
                        }
                    }
                }
                else if (tVadmin.SelectedNode.Level == 3)//node Sinh Vien
                {
                    tblSinhVien svLayDuoc = null;
                    svLayDuoc = (tblSinhVien)tVadmin.SelectedNode.Tag;
                    foreach (ListViewItem tmp in lvwSinhvien.Items)
                    {
                        tmp.Selected = false;
                    }
                    foreach (ListViewItem tmp in lvwSinhvien.Items)
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
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ptbMenu_Click_1(object sender, EventArgs e)
        {
            if(lblMenu.Text.Equals("Menu"))
            {
                pnlMenu.Width = 186;
                lblMenu.Text = "Back";
            } 
            else if(lblMenu.Text.Equals("Back"))
            {
                pnlMenu.Width = 1;
                lblMenu.Text = "Menu";
            }  
        }
        //Load lại listview
        private void btnreset_Click(object sender, EventArgs e)
        {
            IEnumerable<tblChuTro> dsCT = ct.layChuTro();
            LoadToanBoChuTro(lvwChuTro, dsCT);
            IEnumerable<tblPhong> dsPT = pt.layPhongTro();
            LoadToanBoPhongTro(lvwPhongTro, dsPT);
            IEnumerable<tblSinhVien> dsSV = sv.laySinhvien();
            LoadToanBoSinhVien(lvwSinhvien, dsSV);
            tVadmin.Nodes.Clear();//xóa hết node
            LoadTree(tVadmin);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lvwChuTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPhong;
            IEnumerable<tblPhong> dsPhongTrothuocChuTro;
            IEnumerable<tblSinhVien> dsSinhvienthuocChuTro;
            if (lvwChuTro.SelectedItems.Count > 0)
            {
                strPhong = lvwChuTro.SelectedItems[0].Text;
                dsPhongTrothuocChuTro = pt.layPhongTroThuocChuTro(strPhong);
                //Đưa vào listview
                LoadToanBoPhongTro(lvwPhongTro, dsPhongTrothuocChuTro);
                string ctLayDuoc = "";
                ctLayDuoc = lvwChuTro.SelectedItems[0].Text;
                lvwSinhvien.Items.Clear();
                foreach (tblPhong phong in dsPhongTrothuocChuTro)
                {
                    strPhong = phong.IDPhong;
                    dsSinhvienthuocChuTro = sv.laySVThuocPhong(strPhong);
                    //Đưa vào listview
                    LoadToanBoSinhVienThuocChuTro(lvwSinhvien, dsSinhvienthuocChuTro);
                }
            }
        }

        private void lvwPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPhong;
            IEnumerable<tblSinhVien> dsSinhvienthuocPhong;
            if(lvwPhongTro.SelectedItems.Count > 0)
            {
                strPhong = lvwPhongTro.SelectedItems[0].Text;// đưa vào lúc tạo node
                dsSinhvienthuocPhong = sv.laySVThuocPhong(strPhong);
                //Đưa vào listview
                LoadToanBoSinhVien(lvwSinhvien, dsSinhvienthuocPhong);
                string ptLayDuoc = null;
                ptLayDuoc = lvwPhongTro.SelectedItems[0].Text;
            }
        }

        private void btntkSV_Click(object sender, EventArgs e)
        {
            frmTKSVAdmin frm = new frmTKSVAdmin();
            frm.ShowDialog();
        }

        private void btntkPhong_Click(object sender, EventArgs e)
        {
            frmTKPhong frm = new frmTKPhong();
            frm.ShowDialog();
        }

        private void btntkChuTro_Click(object sender, EventArgs e)
        {
            frmTKCT frm = new frmTKCT();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToLongTimeString();
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            frmThongTin frm = new frmThongTin();
            frm.ShowDialog();
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tVadmin_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var hitTest = e.Node.TreeView.HitTest(e.Location);
            if (hitTest.Location == TreeViewHitTestLocations.PlusMinus)
                return;

            if (e.Node.IsExpanded)
                e.Node.Collapse();
            else
                e.Node.Expand();
        }
    }
}
