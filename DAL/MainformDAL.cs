using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MainformDAL
    {
        private static MainformDAL instance;

        public static MainformDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainformDAL();
                return instance;
            }
        }
        private MainformDAL() { }

        

        //lưu tên nhân viên sau khi đăng nhập thành công
        public string tennv(string manv)
        {
            CSDLDataContext db = new CSDLDataContext();
            string query = (from n in db.TaiKhoans
                            where n.MaNV == manv
                            select n.NhanVien.HoTen).FirstOrDefault();
            return query;
        }
        
        //lưu quyền admin sau khi đăng nhập thành công
        public bool admin(string manv)
        {
            CSDLDataContext db = new CSDLDataContext();
            bool query = (from n in db.TaiKhoans
                          where n.MaNV == manv
                          select n.Admin).FirstOrDefault();
            return query;
        }
    }
}
