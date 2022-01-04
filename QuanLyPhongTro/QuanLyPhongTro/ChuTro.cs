using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class ChuTro
    {
        QLyTroDataContext db;
        public ChuTro()
        {
            db = new QLyTroDataContext();
        }
        //lấy chủ trọ
        public IEnumerable<tblChuTro> layChuTro()
        {
            IEnumerable<tblChuTro> q = from n in db.tblChuTros
                                       select n;
            return q;
        }
        //Lấy tất cả chủ trọ sở hữu bởi admin
        public IEnumerable<tblChuTro> layChuTroThuocTaiKhoan(string strCTro)
        {
            //??
            IEnumerable<tblChuTro> q = from n in db.tblChuTros
                                      select n;

            return q;
        }
        //Tìm kiếm chủ trọ
        public IEnumerable<tblChuTro> timKiemChuTro(string giaTriTim, bool TheoDiachi)
        {
            IEnumerable<tblChuTro> q;
            if (TheoDiachi)//  theo địa chỉ chủ trọ
                q = from n in db.tblChuTros
                    where n.DiaChiChuTro.StartsWith(giaTriTim)
                    orderby n.IDChuTro ascending
                    select n;
            else  //theo SDT chủ trọ
                q = from n in db.tblChuTros
                    where n.SDTChuTro.Equals(giaTriTim)
                    orderby n.IDChuTro ascending
                    select n;
            return q;
        }
        public void suaChuTro(tblChuTro CTroDaSua)
        {
            IQueryable<tblChuTro> tam = (from n in db.tblChuTros
                                         where n.IDChuTro == CTroDaSua.IDChuTro
                                         select n);
            if (tam.First().IDChuTro.Length > 0)
            {

                tam.First().TenChuTro = CTroDaSua.TenChuTro;
                tam.First().CMNDChuTro = CTroDaSua.CMNDChuTro;
                tam.First().DiaChiChuTro = CTroDaSua.DiaChiChuTro;
                tam.First().SDTChuTro = CTroDaSua.SDTChuTro;
                tam.First().EmailChuTro = CTroDaSua.EmailChuTro;
                tam.First().TrangThaiChoThue = CTroDaSua.TrangThaiChoThue;
                db.SubmitChanges();
            }
        }

        //Kiểm tra phòng có tồn tại hay không
        public bool KtraTonTaiChuTro(tblChuTro chuTro)
        {
            tblChuTro pttemp = db.tblChuTros.Where(x => x.IDChuTro == chuTro.IDChuTro).FirstOrDefault();
            if (pttemp != null)// đã có
                return true;
            return false;
        }
        //Xóa phòng
        public void xoaChuTro(tblChuTro xoaChuTro)
        {
            if (KtraTonTaiChuTro(xoaChuTro))
            {
                db.tblChuTros.DeleteOnSubmit(xoaChuTro);
                db.SubmitChanges();
            }

        }
        //Thêm phòng
        public void themChuTro(tblChuTro themChuTro)
        {
            //  System.Data.Common.DbTransaction myTran = db.Connection.BeginTransaction();
            if (!KtraTonTaiChuTro(themChuTro))
            {
                //  db.Transaction = myTran;
                db.tblChuTros.InsertOnSubmit(themChuTro);
                db.SubmitChanges();
                //    db.Transaction.Commit();
            }
            else
                throw new Exception("Đã tồn tại ==> trùng ID Chủ trọ");
        }
    }
}
