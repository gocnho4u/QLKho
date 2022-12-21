using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaoPXuatDAL
    {
        private static TaoPXuatDAL instance;

        public static TaoPXuatDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaoPXuatDAL();
                return instance;
            }
        }
        private TaoPXuatDAL() { }

       
       
        //Lấy thông tin đơn hàng
        public List<DonHang> LayDH()
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from n in db.DonHangs
                        select n;
            List<DonHang> ds = new List<DonHang>();
            foreach (var item in query)
            {
                ds.Add(item);
            }
            return ds;
        }

        //Lấy chi tiết đơn hàng
        public List<ChitietDonHang> LayCtDH(string madh)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from n in db.ChitietDonHangs
                        where n.MaDH.Contains(madh)
                        select n;
            List<ChitietDonHang> ds = new List<ChitietDonHang>();
            foreach (var item in query)
            {
                ds.Add(item);
            }
            return ds;
        }

        //Lấy chi tiết đơn hàng ver2
        public object LayCtDHv2(string madh)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from n in db.ChitietDonHangs
                        where n.MaDH.Contains(madh)
                        select new { n.MaDH, n.HangHoa.TenHangHoa, n.Soluong, n.ThanhTien,
                        duthua = ((from n1 in db.HangHoas where n1.MaHH==n.MaHH select n1.Soluong).FirstOrDefault() - n.Soluong) < 0 ? "Thiếu" + "(" + ((from n1 in db.HangHoas where n1.MaHH == n.MaHH select n1.Soluong).FirstOrDefault() - n.Soluong).ToString() + ")" : "Đủ",
        };
            return query;
        }

        //Xác định có thiếu hàng không
        public int ThieuDu(string madh)
        {
            CSDLDataContext db = new CSDLDataContext();
            int sodem = 0;
            var query = from n in db.ChitietDonHangs
                        where n.MaDH.Contains(madh)
                        select new { duthua = ((from n1 in db.HangHoas where n1.MaHH == n.MaHH select n1.Soluong).FirstOrDefault() - n.Soluong) < 0 ? "Thiếu" + "(" + ((from n1 in db.HangHoas where n1.MaHH == n.MaHH select n1.Soluong).FirstOrDefault() - n.Soluong).ToString() + ")" : "Đủ", };
            foreach (var item in query)
            {
                if (item.duthua != "Đủ")
                {
                    sodem++;
                }
            }
            return sodem;
        }
        

        //Lưu phiếu xuất
        public void LuuPxuat(string madx,string madh,string manv,string diachi)
        {
            CSDLDataContext db = new CSDLDataContext();
            //madx = "DX-" + madh;
            PhieuXuat px = new PhieuXuat();
            px.MaPX = madx;
            px.MaDH = madh;
            px.MaNV = manv;
            px.DiaChi = diachi;
            px.ThoiGian = DateTime.Now;
            db.PhieuXuats.InsertOnSubmit(px);
            db.SubmitChanges();
        }

        //Lưu chi tiết phiếu xuất
        public void LuuCtPxuat(string mact, string madx, string mahh, int soluong)
        {
            CSDLDataContext db = new CSDLDataContext();
            HangHoa hh = (from n in db.HangHoas
                          where n.MaHH.Contains(mahh)
                          select n).Single<HangHoa>();
            hh.Soluong -= soluong;
            db.SubmitChanges();

            ChitietPhieuXuat ct = new ChitietPhieuXuat();
            ct.IdChitiet = mact;
            ct.MaPX = madx;
            ct.MaHH = mahh;
            ct.Soluong = soluong;
            db.ChitietPhieuXuats.InsertOnSubmit(ct);
            db.SubmitChanges();
        }

        //Cập nhật lại trang thái đơn hàng sau khi đã lập phiếu xuất
        public void CapNhatTinhTrangDH(string madh)
        {
            CSDLDataContext db = new CSDLDataContext();
            var dh = (from n in db.DonHangs
                     where n.MaDH==madh
                     select n).FirstOrDefault();
            dh.TrangThai = "Đã giao";
            db.SubmitChanges();
        }
    }
}
