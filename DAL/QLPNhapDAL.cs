using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLPNhapDAL
    {
        private static QLPNhapDAL instance;

        public static QLPNhapDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLPNhapDAL();
                return instance;
            }
        }
        private QLPNhapDAL() { }

        

        //Tìm kiếm nhanh
        public object TimKiemChiTietNhanh(string tenhh,string mapn)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = (from ctpn in db.ChitietPhieuNhaps
                        where ctpn.HangHoa.TenHangHoa.Contains(tenhh) && ctpn.MaPN.Contains(mapn)
                        select new { ctpn.IdChitiet, ctpn.HangHoa.TenHangHoa, ctpn.Soluong, ctpn.ThanhTien }).FirstOrDefault();
            return query;
        }

        //Tìm kiếm phiếu nhập theo mã phiếu nhập
        public object TimKiemPhieunhapTheoMPN(string mapn)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from ctpn in db.ChitietPhieuNhaps
                        where ctpn.MaPN.Contains(mapn)
                        select new { ctpn.IdChitiet, ctpn.HangHoa.TenHangHoa, ctpn.Soluong, ctpn.ThanhTien };
            return query;
        }

        //Tìm kiếm phiếu nhập theo mã nhân viên
        public object TimKiemPhieunhapTheoMNV(string manv)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from pn in db.PhieuNhaps
                            where pn.MaNV.Contains(manv)
                            select new {pn.MaNV,pn.MaPN,pn.ThoiGian};
            return query;
        }

        ////Tìm kiếm phiếu nhập theo ngày
        //public object TimKiemPhieunhapTheoNgay(string manv, DateTime dt)
        //{
        //    var query = from pn in db.PhieuNhaps
        //                where pn.MaNV.Contains(manv) && pn.ThoiGian.DayOfYear==dt.DayOfYear
        //                select new { pn.MaNV, pn.MaPN, pn.ThoiGian };
        //    return query;
        //}

        ////Load dữ liệu Combox ngày
        //public object ngay()
        //{
        //    var query = from n in db.PhieuNhaps
        //                select n.ThoiGian.Date.;
        //    return query;
        //}

        //Xóa Chi tiết phiếu nhập
        public void XoaChiTiet(string id,string mapn)
        {
            CSDLDataContext db = new CSDLDataContext();
            var chitiet = (from ct in db.ChitietPhieuNhaps
                           where ct.IdChitiet.Contains(id) && ct.MaPN.Contains(mapn)
                           select ct).FirstOrDefault();
            var hanghoa = (from n in db.HangHoas
                           where n.MaHH.Contains(chitiet.MaHH)
                           select n).FirstOrDefault();
            hanghoa.Soluong -= chitiet.Soluong;
            db.ChitietPhieuNhaps.DeleteOnSubmit(chitiet);
            db.SubmitChanges();
            var chitiet2 = from ct in db.ChitietPhieuNhaps
                           where ct.MaPN.Contains(mapn)
                           select ct;
            if (chitiet2.Count()==0)
            {
                var phieunhap = (from ct in db.PhieuNhaps
                               where ct.MaPN.Contains(mapn)
                               select ct).FirstOrDefault();
                db.PhieuNhaps.DeleteOnSubmit(phieunhap);
                db.SubmitChanges();
            }
            else return;
        }

        //Xóa Phiếu nhập
        public void XoaPhieuNhap(string mapn)
        {
            CSDLDataContext db = new CSDLDataContext();
            //Xác định chi tiết phiếu nhập
            var ctpn = from n in db.ChitietPhieuNhaps
                                          where n.MaPN == mapn
                                          select n;
            foreach (var item in ctpn)
            {
                var hanghoa = (from n in db.HangHoas
                            where n.MaHH==item.MaHH.Trim()
                            select n).FirstOrDefault<HangHoa>();
                hanghoa.Soluong -= item.Soluong;
                db.SubmitChanges();
            }

            var chitiet = (from ct in db.PhieuNhaps
                           where ct.MaPN.Contains(mapn)
                           select ct).FirstOrDefault();
            db.PhieuNhaps.DeleteOnSubmit(chitiet);
            db.SubmitChanges();
        }

        //Sửa Chitietphieunhap
        public void SuaChiTietNhap(string stt,string mapn,string tenhh,int soluong,int thanhtien)
        {
            CSDLDataContext db = new CSDLDataContext();
            //Xác định Mã hàng hóa
            string mahh = (from n in db.HangHoas
                           where n.TenHangHoa.Contains(tenhh)
                           select n.MaHH).FirstOrDefault();
            //Xóa bớt hàng hóa phiếu cũ
            var hh = (from n in db.HangHoas
                      where n.MaHH == mahh
                      select n).FirstOrDefault();
            int sl = (from n in db.ChitietPhieuNhaps
                      where n.IdChitiet.Contains(stt) && n.MaPN.Contains(mapn)
                      select n.Soluong).FirstOrDefault();
            hh.Soluong -= sl;
            db.SubmitChanges();

            //Sửa Chi tiết phiếu nhập
            var ctpn = (from ct in db.ChitietPhieuNhaps
                     where ct.IdChitiet == stt && ct.MaPN==mapn
                     select ct).SingleOrDefault();
            ctpn.MaHH = mahh;
            ctpn.Soluong = soluong;
            ctpn.ThanhTien = thanhtien;
            db.SubmitChanges();

            //Cộng thêm hàng hóa
            var hht = (from n in db.HangHoas
                      where n.MaHH == mahh
                      select n).FirstOrDefault();
            hht.Soluong += soluong;
            db.SubmitChanges();
        }
        public object timkiemhet()
        {
            CSDLDataContext db = new CSDLDataContext();
            var timhet = from n in db.PhieuNhaps
                         select n;
            return timhet;
        }
        //public object soluongnhap(DateTime fromdate, DateTime toDate)
        //{
        //    CSDLDataContext db = new CSDLDataContext();
        //    var pn = from n in db.PhieuNhaps
        //                 where n.ThoiGian >= fromdate && n.ThoiGian <= toDate 
        //                 select n;
        //    int sum = 0;
        //    foreach (PhieuNhap item in pn)
        //    {
        //        sum+=item.
        //    }
        //}
    }
}
