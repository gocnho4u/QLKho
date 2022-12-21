using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLPXuatDAL
    {
        private static QLPXuatDAL instance;

        public static QLPXuatDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLPXuatDAL();
                return instance;
            }
        }
        private QLPXuatDAL() { }


        //Tìm kiếm nhanh
        public object TimKiemChiTietNhanh(string tenhh, string mapx)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = (from ctpn in db.ChitietPhieuXuats
                         where ctpn.HangHoa.TenHangHoa.Contains(tenhh) && ctpn.MaPX.Contains(mapx)
                         select new { ctpn.IdChitiet, ctpn.HangHoa.TenHangHoa, ctpn.Soluong}).FirstOrDefault();
            return query;
        }

        //Tìm kiếm phiếu nhập theo mã phiếu nhập
        public object TimKiemPhieunhapTheoMPX(string mapx)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from ctpn in db.ChitietPhieuXuats
                        where ctpn.MaPX.Contains(mapx)
                        select new { ctpn.IdChitiet, ctpn.HangHoa.TenHangHoa, ctpn.Soluong};
            return query;
        }

        //Tìm kiếm phiếu nhập theo mã nhân viên
        public object TimKiemPhieunhapTheoMNV(string manv)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from pn in db.PhieuXuats
                        where pn.MaNV.Contains(manv)
                        select new { pn.MaNV, pn.MaPX, pn.ThoiGian };
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
        //public void XoaChiTiet(string id, string mapn)
        //{

        //    var chitiet = (from ct in db.ChitietPhieuNhaps
        //                   where ct.IdChitiet.Contains(id) && ct.MaPN.Contains(mapn)
        //                   select ct).FirstOrDefault();
        //    var hanghoa = (from n in db.HangHoas
        //                   where n.MaHH.Contains(chitiet.MaHH)
        //                   select n).FirstOrDefault();
        //    hanghoa.Soluong -= chitiet.Soluong;
        //    db.ChitietPhieuNhaps.DeleteOnSubmit(chitiet);
        //    db.SubmitChanges();
        //    var chitiet2 = from ct in db.ChitietPhieuNhaps
        //                   where ct.MaPN.Contains(mapn)
        //                   select ct;
        //    if (chitiet2.Count() == 0)
        //    {
        //        var phieunhap = (from ct in db.PhieuNhaps
        //                         where ct.MaPN.Contains(mapn)
        //                         select ct).FirstOrDefault();
        //        db.PhieuNhaps.DeleteOnSubmit(phieunhap);
        //        db.SubmitChanges();
        //    }
        //    else return;
        //}

        //Xóa Phiếu nhập
        public void XoaPhieuNhap(string mapx)
        {
            CSDLDataContext db = new CSDLDataContext();
            //Xác định chi tiết phiếu xuất
            List<ChitietPhieuXuat> ctpn = (from n in db.ChitietPhieuXuats
                                           where n.MaPX.Contains(mapx)
                                           select n).ToList<ChitietPhieuXuat>();
            foreach (var item in ctpn)
            {
                var hanghoa = (from n in db.HangHoas
                               where n.MaHH.Contains(item.MaHH)
                               select n).FirstOrDefault();
                hanghoa.Soluong += item.Soluong;
                db.SubmitChanges();
            }
            string madh = (from n in db.PhieuXuats
                           where n.MaPX == mapx
                           select  n.MaDH).FirstOrDefault();
            DonHang dh = (from n in db.DonHangs
                          where n.MaDH.Contains(madh)
                          select n).FirstOrDefault();
            dh.TrangThai = "Chưa giao";
            db.SubmitChanges();

            var chitiet = (from ct in db.PhieuXuats
                           where ct.MaPX.Contains(mapx)
                           select ct).FirstOrDefault();
            db.PhieuXuats.DeleteOnSubmit(chitiet);
            db.SubmitChanges();
        }

        //Sửa Chitietphieunhap
        public void SuaChiTietNhap(string stt, string mapn, string tenhh, int soluong, int thanhtien)
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
                        where ct.IdChitiet == stt && ct.MaPN == mapn
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
    }
}
