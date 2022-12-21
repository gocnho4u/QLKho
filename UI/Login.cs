using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace UI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        //biến dùng để xác định tên nhân viên ở mainform
        public static string ten;

        private void Login_Load(object sender, EventArgs e)
        {
            ten = "";
        }

        //Buttom Đăng nhập
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginBUS.Instance.dangnhap(txt_manv, txt_matkhau) == 1)
                {
                    ten = txt_manv.Text;
                    frm_MainForm frm = new frm_MainForm();
                    this.Hide();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();
                    this.Show();
                }
                else { MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông báo"); }
            }
            catch(Exception) { MessageBox.Show("Lỗi hệ thống \nVui lòng liên hệ với phòng CNTT"); }
        }

    }
}
