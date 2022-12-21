using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class MainformBUS
    {
        private static MainformBUS instance;

        public static MainformBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainformBUS();
                return instance;
            }
        }
        private MainformBUS() { }

        //xd tên nhân viên
        public string tennv(string manv)
        {
            string ma = MainformDAL.Instance.tennv(manv);
            return ma;
        }

        //xd quyền admin
        public bool admin(string manv)
        {
            bool ad = MainformDAL.Instance.admin(manv);
            return ad;
        }

        //lấy thời gian để làm thời gian cho phần mềm
        public void thoigianthuc(Label datetime)
        {
            DateTime dt = DateTime.Now;
            datetime.Text = dt.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}
