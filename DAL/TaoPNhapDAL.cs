using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaoPNhapDAL
    {
        private static TaoPNhapDAL instance;

        public static TaoPNhapDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaoPNhapDAL();
                return instance;
            }
        }
        private TaoPNhapDAL() { }


        //Lấy số thứ tự phiếu nhập
        public string Sothutuid()
        {
            CSDLDataContext db = new CSDLDataContext();
            int sttt = (from n in db.PhieuNhaps
                        select n).Count() + 1;
            return sttt.ToString();
        }

        //Load Nhà cung cấp
        public object LoadNhaCungCap()
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from ncc in db.NhaCungCaps
                        select ncc;
            return query;
        }
        
        //Thêm Phiếu nhập
        public bool LuuPhieuNhap(string mapn, string manv,string nhacc)
        {
            CSDLDataContext db = new CSDLDataContext();
            PhieuNhap pn = new PhieuNhap();
            pn.MaPN = mapn;
            pn.MaNV = manv;
            pn.MaNCC = nhacc;
            pn.ThoiGian = DateTime.Now;
            try
            {
                db.PhieuNhaps.InsertOnSubmit(pn);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
            
        }

        //Thêm Chi tiết phiếu nhập
        public ChitietPhieuNhap LuuChitietPhieuNhap(string id,string mapn,string tenhh,int soluong, int tien)
        {
            CSDLDataContext db = new CSDLDataContext();
            string mahh = (from n in db.HangHoas
                           where n.TenHangHoa.Contains(tenhh)
                           select n.MaHH).FirstOrDefault();
            ChitietPhieuNhap ct = new ChitietPhieuNhap();
            ct.IdChitiet = id;
            ct.MaPN = mapn;
            ct.MaHH = mahh;
            ct.Soluong = soluong;
            ct.ThanhTien = tien;
            db.ChitietPhieuNhaps.InsertOnSubmit(ct);
            db.SubmitChanges();

            var hh = (from n in db.HangHoas
                     where n.MaHH == mahh
                     select n).FirstOrDefault();
            hh.Soluong += soluong;
            db.SubmitChanges();
            return ct;
        }
    }
}
