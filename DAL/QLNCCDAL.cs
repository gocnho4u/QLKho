using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLNCCDAL
    {
        private static QLNCCDAL instance;

        public static QLNCCDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLNCCDAL();
                return instance;
            }
        }
        private QLNCCDAL() { }

        

        //Load dữ liệu
        public object load()
        {
            CSDLDataContext db = new CSDLDataContext();
            var ncc = from cc in db.NhaCungCaps
                      select new { cc.MaNCC,cc.TenNCC,cc.DiaChi,cc.SoDienThoai,cc.Fax};
            return ncc;
        }

        //Lấy mã nhà cc tự tăng khi thêm
        public string sothutuid()
        {
            CSDLDataContext db = new CSDLDataContext();
            int sttt = (from n in db.NhaCungCaps
                        select n).Count() + 1;
            string stt = "NCC00" + sttt.ToString();
            return stt;
        }
        ////Lấy tên nhân viên từ mã nhân viên
        //public string xdtennv(string manv)
        //{
        //    string tennv;
        //    var ten = (from n in db.NhanViens
        //               where n.MaNV == manv
        //               select n.HoTen).Single();
        //    return tennv = ten.ToString();
        //}

        //Thêm
        public NhaCungCap LuuThem(string mancc, string tenncc, string diachi, string sdt,string fax)
        {
            CSDLDataContext db = new CSDLDataContext();
            NhaCungCap cc = new NhaCungCap();
            cc.MaNCC = mancc;
            cc.TenNCC = tenncc;
            cc.DiaChi = diachi;
            cc.SoDienThoai = sdt;
            cc.Fax = fax;
            db.NhaCungCaps.InsertOnSubmit(cc);
            db.SubmitChanges();
            return cc;
        }

        //Sửa
        public NhaCungCap LuuSua(string mancc, string tenncc, string diachi, string sdt, string fax)
        {
            CSDLDataContext db = new CSDLDataContext();
            var cc = (from n in db.NhaCungCaps
                      where n.MaNCC == mancc
                      select n).Single<NhaCungCap>();
            cc.MaNCC = mancc;
            cc.TenNCC = tenncc;
            cc.DiaChi = diachi;
            cc.SoDienThoai = sdt;
            cc.Fax = fax;
            db.SubmitChanges();
            return cc;
        }

        //Xóa
        public NhaCungCap Xoa(string mancc)
        {
            CSDLDataContext db = new CSDLDataContext();
            var nhacungcap = (from cc in db.NhaCungCaps
                            where cc.MaNCC == mancc
                            select cc).FirstOrDefault();
            db.NhaCungCaps.DeleteOnSubmit(nhacungcap);
            db.SubmitChanges();
            return nhacungcap;
        }

        //Tìm kiếm 
        public object TimKiem(string ten)
        {
            CSDLDataContext db = new CSDLDataContext();
            var tkiem = from cc in db.NhaCungCaps
                        where cc.TenNCC.Contains(ten)
                        select new { cc.MaNCC, cc.TenNCC, cc.DiaChi, cc.SoDienThoai, cc.Fax };
            return tkiem;
        }

        // lấy dữ liệu cho chức năng hỗ trợ tìm kiếm
        public object HotroTimkiem()
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from cc in db.NhaCungCaps
                        select cc.TenNCC;
            return query;
        }
    }
}
