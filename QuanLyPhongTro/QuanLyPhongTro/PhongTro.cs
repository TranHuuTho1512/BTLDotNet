using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class PhongTro
    {
        QLyTroDataContext db;
        public PhongTro()
        {
            db = new QLyTroDataContext();
        }
        //Lấy phòng trọ
        public IEnumerable<tblPhong> layPhongTro()
        {
            IEnumerable<tblPhong> q = from n in db.tblPhongs
                                        select n;
            return q;
        }
        //Lấy tất cả phòng trọ sở hữu bởi 1 chủ trọ
        public IEnumerable<tblPhong> layPhongTroThuocChuTro(string stridChuTro)
        {
            IEnumerable<tblPhong> q = from n in db.tblPhongs
                                        where n.IDChuTro == stridChuTro
                                        orderby n.TenPhong
                                        select n;
            return q;
        }
        //Tìm kiếm phòng
        public IEnumerable<tblPhong> timKiemPhongTro(string giaTriTim, bool TheoTenPhong)
        {
            IEnumerable<tblPhong> q;
            if (TheoTenPhong)//  theo tên phòng
                q = from n in db.tblPhongs
                    where n.TenPhong.StartsWith(giaTriTim)
                    orderby n.IDPhong ascending
                    select n;
            else  //theo id chủ trọ
                q = from n in db.tblPhongs
                    where n.IDChuTro.Equals(giaTriTim)
                    orderby n.IDPhong ascending
                    select n;
            return q;
        }
        //Kiểm tra phòng có tồn tại hay không
        public bool KtraTonTaiTenPhong(tblPhong Phong)
        {
            tblPhong pttemp = db.tblPhongs.Where(x => x.IDPhong == Phong.IDPhong).FirstOrDefault();
           if (pttemp != null)// đã có
                return true;
            return false;
        }
        //Sửa phòng
        public void suaPhog(tblPhong PhongDaSua)
        {
           
                IQueryable<tblPhong> tam = (from n in db.tblPhongs
                                            where n.IDPhong == PhongDaSua.IDPhong
                                            select n);
                
                if (tam.First().IDPhong.ToString().Length > 0)
                {                  
                    tam.First().TrangThaiPhong = PhongDaSua.TrangThaiPhong;
                    tam.First().GiaPhong = PhongDaSua.GiaPhong;
                    tam.First().SoLuongSVSong = PhongDaSua.SoLuongSVSong;
                    db.SubmitChanges();                
                }
            
        }
        //Xóa phòng
        public void xoaPhong(tblPhong xoaPhong)
        {
            if (KtraTonTaiTenPhong(xoaPhong))
            {
                db.tblPhongs.DeleteOnSubmit(xoaPhong);
                db.SubmitChanges();
            }

        }
        //Thêm phòng
        public void themPhong(tblPhong themPhong)
        {
            //  System.Data.Common.DbTransaction myTran = db.Connection.BeginTransaction();
                if (!KtraTonTaiTenPhong(themPhong))
                {
                    //  db.Transaction = myTran;
                    db.tblPhongs.InsertOnSubmit(themPhong);
                    db.SubmitChanges();
                    //    db.Transaction.Commit();
                }
                else
                    throw new Exception("Đã tồn tại ==> trùng ID Phòng");
        }
    }
}
