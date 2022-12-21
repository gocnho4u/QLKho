using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class LoginBUS
    {
        private static LoginBUS instance;
        public static LoginBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginBUS();
                return instance;
            }
        }
        private LoginBUS() { }

        //Đăng nhập
        public int dangnhap(TextBox tentk, TextBox matkhau)
        {
            int login =  LoginDAL.Instance.login(tentk.Text, matkhau.Text);
            return login;
        }
    }
}
