using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLNDDAL
    {
        private static QLNDDAL instance;

        public static QLNDDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLNDDAL();
                return instance;
            }
        }
        private QLNDDAL() { }

       

        //Load dữ liệu
        public object load()
        {
            CSDLDataContext db = new CSDLDataContext();
            var tkk = from tk in db.TaiKhoans
                      select new { tk.UserID, tk.MaNV, tk.MatKhau, tk.Admin, tk.NhanVien.HoTen };
            return tkk;
        }

        //Lấy userid tự tăng khi thêm
        public string sothutuid()
        {
            CSDLDataContext db = new CSDLDataContext();
            int sttt = (from n in db.TaiKhoans
                        select n).Count() + 1;
            string stt = "00" + sttt.ToString();
            return stt;
        }
        //Lấy tên nhân viên từ mã nhân viên
        public string xdtennv(string manv)
        {
            CSDLDataContext db = new CSDLDataContext();
            string tennv;
            var ten = (from n in db.NhanViens
                       where n.MaNV == manv
                       select n.HoTen).Single();
            return tennv = ten.ToString();
        }
        //Thêm
        public TaiKhoan LuuThem(string userid, string matkhau, bool admin, string manv)
        {
            CSDLDataContext db = new CSDLDataContext();
            TaiKhoan tk = new TaiKhoan();
            tk.UserID = userid;    
            tk.MatKhau = matkhau;
            tk.Admin = admin;
            tk.MaNV = manv;
            db.TaiKhoans.InsertOnSubmit(tk);
            db.SubmitChanges();
            return tk;
        }
        //kiểm tra trước khi thêm
        public int KiemtraThem(string manv)
        {
            CSDLDataContext db = new CSDLDataContext();
            int tkiem = (from tk in db.TaiKhoans
                         where tk.MaNV.Contains(manv)
                         select tk).Count();
            return tkiem;
        }

        //Sửa
        public TaiKhoan LuuSua(string userid, string matkhau, bool admin, string manv)
        {
            CSDLDataContext db = new CSDLDataContext();
            var tk = (from n in db.TaiKhoans
                      where n.UserID == userid
                      select n).Single<TaiKhoan>();
            tk.MatKhau = matkhau;
            tk.Admin = admin;
            tk.MaNV = manv;
            db.SubmitChanges();
            return tk;
        }

        //Xóa
        public TaiKhoan Xoa(string userid)
        {
            CSDLDataContext db = new CSDLDataContext();
            var taikhoan = (from tk in db.TaiKhoans
                            where tk.UserID == userid
                            select tk).FirstOrDefault();
            
            db.TaiKhoans.DeleteOnSubmit(taikhoan);
            db.SubmitChanges();
            return taikhoan;
        }

        //Tìm kiếm 
        public object TimKiem(string ten)
        {
            CSDLDataContext db = new CSDLDataContext();
            var tkiem = from tk in db.TaiKhoans
                        where tk.MaNV.Contains(ten)
                        select new { tk.UserID, tk.MaNV,tk.MatKhau, tk.Admin, tk.NhanVien.HoTen};
            return tkiem;
        }

        // lấy dữ liệu cho chức năng hỗ trợ tìm kiếm
        public object HotroTimkiem()
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from tk in db.TaiKhoans
                        select tk.MaNV;
            return query;
        }
    }
}
