using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class QLNDBUS
    {
        private static QLNDBUS instance;

        public static QLNDBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLNDBUS();
                return instance;
            }
        }
        private QLNDBUS() { }

        //Load dữ liệu tài khoản
        public void load(DataGridView data)
        {
            data.DataSource = QLNDDAL.Instance.load();
            data.Columns[0].HeaderText = "UserID";
            data.Columns[1].HeaderText = "Mã nhân viên";
            data.Columns[2].HeaderText = "Mật khẩu";
            data.Columns[3].HeaderText = "Quyền Admin";
            data.Columns[4].HeaderText = "Tên nhân viên";

        }

        // Xác định nút radio quyền admin
        public bool xdradio(RadioButton a, RadioButton b)

        {
            bool d = false;
            if (a.Checked == true)
            {
                d = true;
            }
            else d = false;
            return d;

        }

        //Xóa text khi thêm
        public void xoatext(TextBox id, TextBox mk, TextBox manv, TextBox tennv, RadioButton khong, DataGridView qlnd)
        {
            id.Text = QLNDDAL.Instance.sothutuid().ToString();
            mk.Text = ""; manv.Text = ""; tennv.Text = "";
            khong.Checked = true; qlnd.Enabled = false;
            id.Enabled = false;

        }

        //Thiết lập chế độ readonly cho textbox (chưa sử dụng)
        public void readonlytext(TextBox matkhau, TextBox manv)
        {
            matkhau.ReadOnly = false; manv.ReadOnly = false;
        }

        // Xác định tên nhân viên khi nhấn nút kiểm tra
        public void xdtennv(TextBox a, TextBox b)
        {
            b.Text = QLNDDAL.Instance.xdtennv(a.Text);
        }

        //Thêm
        public void LuuThem(TextBox a,TextBox matkhau, bool admin, TextBox manv, DataGridView f)
        {
            QLNDDAL.Instance.LuuThem(a.Text, matkhau.Text, admin, manv.Text);
            f.Enabled = true;
        }

        // Kiểm tra mã nhân viên có tồn tại không hay mã nhân viên đã có tài khoản chưa khi tiến hành thêm
        public int KiemtraThem(TextBox manv) //kiểm tra trước khi thêm tài khoản
        {
            int sodem = QLNDDAL.Instance.KiemtraThem(manv.Text);
            return sodem;
        }

        //Sửa
        public void LuuSua(TextBox userid, TextBox matkhau, bool admin, TextBox manv, DataGridView f)
        {
            QLNDDAL.Instance.LuuSua(userid.Text, matkhau.Text, admin, manv.Text);
            f.Enabled = true;
        }
        //Tắt textbox khi sửa
        public void TatSua( TextBox manv, Panel radio)
        {
            manv.Enabled = false; radio.Enabled = true;
        }
        //Bật textbox khi đã sửa xong
        public void BatSua(TextBox manv, Panel radio)
        {
            manv.Enabled = true; radio.Enabled = false;
        }

        //Xóa
        public void Xoa(TextBox a)
        {
            QLNDDAL.Instance.Xoa(a.Text.Trim());
        }

        //Tìm kiếm
        public void TimKiem(TextBox manv, DataGridView b)
        {
            b.DataSource = QLNDDAL.Instance.TimKiem(manv.Text);
        }

        //Gợi ý tìm kiếm như google
        public void Hotrotimkiem(TextBox a)
        {
            CSDLDataContext db = new CSDLDataContext();
            AutoCompleteStringCollection cmd = new AutoCompleteStringCollection();
            var query = from n in db.TaiKhoans
                        select n.MaNV.Trim();
            foreach (var item in query)
            {
                cmd.Add(item);
            }
            a.AutoCompleteCustomSource = cmd;
        }  

        
    }
}
