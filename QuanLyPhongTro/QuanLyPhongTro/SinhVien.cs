using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class SinhVien
    {
        QLyTroDataContext db;
        public SinhVien()
        {
            db = new QLyTroDataContext();
        }
        //lấy sinh viên
        public IEnumerable<tblSinhVien> laySinhvien()
        {
            IEnumerable<tblSinhVien> q = from n in db.tblSinhViens
                                         select n;
            return q;
        }
        //Lấy tất cả sinh viên bên trong Phòng
        public IEnumerable<tblSinhVien> laySVThuocPhong(string strPhong)
        {
            //??
            IEnumerable<tblSinhVien> q = from n in db.tblSinhViens
                                         where n.IDPhong == strPhong
                                         orderby n.IDPhong
                                       select n;

            return q;
        }
        public IEnumerable<tblSinhVien> laySVThuocChuTro(string strChuTro)
        {
            //??
            IEnumerable<tblSinhVien> q = from n in db.tblSinhViens
                                         join pt in db.tblPhongs on n.IDPhong equals pt.IDPhong
                                         join ct in db.tblChuTros on pt.IDChuTro equals ct.IDChuTro
                                         where ct.IDChuTro == strChuTro
                                         //orderby n.MSSV
                                         select n;
            return q;
        }
        //Tìm kiếm sinh viên
        public IEnumerable<tblSinhVien> timKiemSinhvien(string giaTriTim, bool TheoMSSV, bool TheoTen,bool TheoKhoa)
        {
            //??
            IEnumerable<tblSinhVien> q;
            if (TheoMSSV)//chọn mssv
            {
                q = from n in db.tblSinhViens
                    where n.MSSV.StartsWith(giaTriTim)
                    orderby n.MSSV ascending
                    select n;
            }   
            else  //theo tên sinh viên
            {
                if (TheoTen)
                {
                    q = from n in db.tblSinhViens
                        where n.TenSV.Equals(giaTriTim)
                        orderby n.MSSV ascending
                        select n;
                }
                else
                {
                    if(TheoKhoa)
                    {
                        q = from n in db.tblSinhViens
                            where n.KhoaSV.Equals(giaTriTim)
                            orderby n.MSSV ascending
                            select n;
                    }
                    else
                    {
                        q = from n in db.tblSinhViens
                            where n.QueQuanSV.Equals(giaTriTim)
                            orderby n.MSSV ascending
                            select n;
                    }
                }
            }
            return q;
        }
        public List<object> HonLoanNhieuBangAdmin()
        {
            var n = from sv in db.tblSinhViens
                    join p in db.tblPhongs on sv.IDPhong equals p.IDPhong
                    join ct in db.tblChuTros on p.IDChuTro equals ct.IDChuTro
                    select new
                    {
                        MSSV = sv.MSSV,
                        TenSV = sv.TenSV,
                        QueQuanSV = sv.QueQuanSV,
                        SDTSV = sv.SDTSV,
                        NamSinhSV = sv.NamSinhSV,
                        TruongHoc = sv.TruongHoc,
                        KhoaSV = sv.KhoaSV,
                        TenPhong = p.TenPhong,
                        IDPhong = sv.IDPhong,
                        IDChuTro =ct.IDChuTro
                    };
            List<object> lst = new List<object>();
            foreach (var item in n)
            {
                lst.Add(item);
            }

            return lst;
        }
        public List<object> TimKiemTenSVAdmin(string txtCanTim)
        {
            var n = from sv in db.tblSinhViens
                    join p in db.tblPhongs on sv.IDPhong equals p.IDPhong
                    where sv.TenSV.Contains(txtCanTim)//Chọn tên gần giống
                    select new
                    {
                        MSSV = sv.MSSV,
                        TenSV = sv.TenSV,
                        QueQuanSV = sv.QueQuanSV,
                        SDTSV = sv.SDTSV,
                        NamSinhSV = sv.NamSinhSV,
                        TruongHoc = sv.TruongHoc,
                        KhoaSV = sv.KhoaSV,
                        TenPhong = p.TenPhong,
                        IDPhong = sv.IDPhong
                    };
            List<object> lst = new List<object>();
            foreach (var item in n)
            {
                lst.Add(item);
            }
            return lst;
        }
        public List<object> TimKiemMSSVAdmin(string txtCanTim)
        {
            var n = from sv in db.tblSinhViens
                    join p in db.tblPhongs on sv.IDPhong equals p.IDPhong
                    where sv.MSSV.Contains(txtCanTim)//Chọn tên gần giống
                    select new
                    {
                        MSSV = sv.MSSV,
                        TenSV = sv.TenSV,
                        QueQuanSV = sv.QueQuanSV,
                        SDTSV = sv.SDTSV,
                        NamSinhSV = sv.NamSinhSV,
                        TruongHoc = sv.TruongHoc,
                        KhoaSV = sv.KhoaSV,
                        TenPhong = p.TenPhong,
                        IDPhong = sv.IDPhong
                    };
            List<object> lst = new List<object>();
            foreach (var item in n)
            {
                lst.Add(item);
            }
            return lst;
        }
        public List<object> TimKiemKhoaSVAdmin(string txtCanTim)
        {
            var n = from sv in db.tblSinhViens
                    join p in db.tblPhongs on sv.IDPhong equals p.IDPhong
                    where sv.KhoaSV.Contains(txtCanTim)//Chọn tên gần giống
                    select new
                    {
                        MSSV = sv.MSSV,
                        TenSV = sv.TenSV,
                        QueQuanSV = sv.QueQuanSV,
                        SDTSV = sv.SDTSV,
                        NamSinhSV = sv.NamSinhSV,
                        TruongHoc = sv.TruongHoc,
                        KhoaSV = sv.KhoaSV,
                        TenPhong = p.TenPhong,
                        IDPhong = sv.IDPhong
                    };
            List<object> lst = new List<object>();
            foreach (var item in n)
            {
                lst.Add(item);
            }
            return lst;
        }
        public List<object> TimKiemQQSVAdmin(string txtCanTim)
        {
            var n = from sv in db.tblSinhViens
                    join p in db.tblPhongs on sv.IDPhong equals p.IDPhong
                    where sv.QueQuanSV.Contains(txtCanTim)//Chọn tên gần giống
                    select new
                    {
                        MSSV = sv.MSSV,
                        TenSV = sv.TenSV,
                        QueQuanSV = sv.QueQuanSV,
                        SDTSV = sv.SDTSV,
                        NamSinhSV = sv.NamSinhSV,
                        TruongHoc = sv.TruongHoc,
                        KhoaSV = sv.KhoaSV,
                        TenPhong = p.TenPhong,
                        IDPhong = sv.IDPhong
                    };
            List<object> lst = new List<object>();
            foreach (var item in n)
            {
                lst.Add(item);
            }
            return lst;
        }
        //Kiểm tra sinh viên có tồn tại hay không
        public bool KtraTonTaiSinhvien(tblSinhVien SinhVien)
        {
            tblSinhVien mttemp = db.tblSinhViens.Where(x => x.MSSV == SinhVien.MSSV).FirstOrDefault();
            if (mttemp != null)// đã có
                return true;
            return false;
        }
        //Sửa sinh viên
        public void suaSinhVien(tblSinhVien SinhVienDaSua)
        {
                IQueryable<tblSinhVien> tam = (from n in db.tblSinhViens
                                               where n.MSSV == SinhVienDaSua.MSSV
                                               select n);
                if (tam.First().MSSV.Length > 0)
                {
                    tam.First().TenSV = SinhVienDaSua.TenSV;
                    tam.First().QueQuanSV = SinhVienDaSua.QueQuanSV;
                    tam.First().SDTSV = SinhVienDaSua.SDTSV;
                    tam.First().NamSinhSV = SinhVienDaSua.NamSinhSV;
                    tam.First().TruongHoc = SinhVienDaSua.TruongHoc;
                    tam.First().KhoaSV = SinhVienDaSua.KhoaSV;
                    db.SubmitChanges();
                }
        }
        //Xóa sinh viên
        public void xoaSinhVien(tblSinhVien xoaSinhvien)
        {
            if (KtraTonTaiSinhvien(xoaSinhvien))
            {
                db.tblSinhViens.DeleteOnSubmit(xoaSinhvien);
                db.SubmitChanges();
            }

        }
        public tblSinhVien GetObjSinhVienDeXoa(string IDSV)
        {
            var sv = (from a in db.tblSinhViens
                      where a.MSSV == IDSV
                      select a).FirstOrDefault();
            return sv;
        }
        //Thêm sinh viên
        public void themSinhVien(tblSinhVien themsinhvien)
        {
                if (!KtraTonTaiSinhvien(themsinhvien))
                {
                    db.tblSinhViens.InsertOnSubmit(themsinhvien);
                    db.SubmitChanges();
                }
                else
                    throw new Exception("Đã tồn tại ==> Trùng MSSV");
        }
    }
}
