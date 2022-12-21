using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class LoginDAL
    {
        private static LoginDAL instance;

        public static LoginDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginDAL();
                return instance;
            }
        }
        private LoginDAL() { }

        

        //Đăng nhập
        public int login(string tentk, string matkhau)
        {
            CSDLDataContext db = new CSDLDataContext();
            int query = (from n in db.TaiKhoans
                         where n.MaNV == tentk && n.MatKhau == matkhau
                         select n).Count();
            return query;
        }

        
    }
}
