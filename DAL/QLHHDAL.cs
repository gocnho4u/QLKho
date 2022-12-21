using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLHHDAL
    {
        private static QLHHDAL instance;

        public static QLHHDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLHHDAL();
                return instance;
            }
        }
        private QLHHDAL() { }

        

        // load dữ liệu hàng hóa
        public object load()
        {
            CSDLDataContext db = new CSDLDataContext();
            var hhh = from hh in db.HangHoas
                      select new { hh.MaHH, hh.TenHangHoa, hh.DonViTinh, hh.DonGia, hh.Soluong, hh.LoaiHangHoa.TenLoai };
            return hhh;
        }
        // load dữ liệu loại hàng hóa
        public object loadloaihh()
        {
            CSDLDataContext db = new CSDLDataContext();
            var loaihh = from hh in db.LoaiHangHoas
                         select hh;
            return loaihh;
        }

        // xác định mã loại ở ô loại hàng hóa
        public string xdmaloai(string tenloaihh)
        {
            CSDLDataContext db = new CSDLDataContext();
            string query = (from loai in db.LoaiHangHoas
                            where loai.TenLoai == tenloaihh
                            select loai.MaLoai).FirstOrDefault().ToString();
            return query;
        }

        // Thêm hàng hóa
        public HangHoa LuuThem(string mahh, string tenhh, string dvtinh, int dongia, int soluong, string maloai)
        {
            CSDLDataContext db = new CSDLDataContext();
            HangHoa hh = new HangHoa();
            hh.MaHH = mahh;
            hh.TenHangHoa = tenhh;
            hh.DonViTinh = dvtinh;
            hh.DonGia = dongia;
            hh.Soluong = soluong;
            hh.MaLoai = maloai;
            db.HangHoas.InsertOnSubmit(hh);
            db.SubmitChanges();
            return hh;
        }

        // Sửa hàng hóa
        public HangHoa LuuSua(string mahh, string tenhh, string dvtinh, int dongia, int soluong, string maloai)
        {
            CSDLDataContext db = new CSDLDataContext();
            var hh = (from hh1 in db.HangHoas
                      where hh1.MaHH == mahh
                      select hh1).SingleOrDefault();
            hh.TenHangHoa = tenhh;
            hh.DonViTinh = dvtinh;
            hh.DonGia = dongia;
            hh.Soluong = soluong;
            hh.MaLoai = maloai;
            db.SubmitChanges();
            return hh;
        }


        //Xóa hàng hóa
        public HangHoa Xoa(string mahh)
        {
            CSDLDataContext db = new CSDLDataContext();
            var hanghoa = (from hh in db.HangHoas
                            where hh.MaHH == mahh
                            select hh).FirstOrDefault();
            db.HangHoas.DeleteOnSubmit(hanghoa);
            db.SubmitChanges();
            return hanghoa;
        }

        //Kiem tra ma hang hoa
        public int Kiemtra(string mahh)
        {
            CSDLDataContext db = new CSDLDataContext();
            var tontai = (from hh in db.HangHoas
                           where hh.MaHH == mahh
                           select hh).Count();
            return tontai;
        }

        //Tìm kiếm
        public object Timkiem(string tenhang)
        {
            CSDLDataContext db = new CSDLDataContext();
            var hanghoa = from hh in db.HangHoas
                          where hh.TenHangHoa.Contains(tenhang)
                          select new { hh.MaHH, hh.TenHangHoa, hh.DonViTinh, hh.DonGia, hh.Soluong, hh.LoaiHangHoa.TenLoai };
            return hanghoa;
        }

        //kiểm tra trước khi thêm
        public int KiemtraThem(string mahh)
        {
            CSDLDataContext db = new CSDLDataContext();
            int tkiem = (from hh in db.HangHoas
                         where hh.MaHH.Contains(mahh)
                         select hh).Count();
            return tkiem;
        }
    }
}
