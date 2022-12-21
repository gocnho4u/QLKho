using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class QLNCCBUS
    {
        private static QLNCCBUS instance;

        public static QLNCCBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLNCCBUS();
                return instance;
            }
        }
        private QLNCCBUS() { }

        //Load dữ liệu nhà cung cấp
        public void load(DataGridView data)
        {
            data.DataSource = QLNCCDAL.Instance.load();
            data.Columns[0].HeaderText = "Mã nhà cung cấp";
            data.Columns[1].HeaderText = "Tên nhà cung cấp";
            data.Columns[2].HeaderText = "Đại chỉ";
            data.Columns[3].HeaderText = "Số điện thoại";
            data.Columns[4].HeaderText = "Fax";

        }


        //Xóa text khi thêm
        public void xoatext(TextBox mancc, TextBox tenncc, TextBox diachi, TextBox sdt, TextBox fax, DataGridView qlncc)
        {
            mancc.Text = QLNCCDAL.Instance.sothutuid().ToString();
            tenncc.Text = ""; diachi.Text = ""; sdt.Text = "";
            fax.Text=""; qlncc.Enabled = false;
            //mancc.Enabled = false;

        }

        ////Thiết lập chế độ readonly cho textbox (chưa sử dụng)
        //public void readonlytext(TextBox matkhau, TextBox manv)
        //{
        //    matkhau.ReadOnly = false; manv.ReadOnly = false;
        //}

        //Thêm
        public void LuuThem(TextBox mancc, TextBox tenncc, TextBox diachi, TextBox sdt, TextBox fax, DataGridView qlncc)
        {
            QLNCCDAL.Instance.LuuThem(mancc.Text, tenncc.Text, diachi.Text, sdt.Text,fax.Text);
            qlncc.Enabled = true;
        }


        //Sửa
        public void LuuSua(TextBox mancc, TextBox tenncc, TextBox diachi, TextBox sdt, TextBox fax, DataGridView qlncc)
        {
            QLNCCDAL.Instance.LuuSua(mancc.Text, tenncc.Text, diachi.Text, sdt.Text, fax.Text);
            qlncc.Enabled = true;
        }
        //Tắt textbox khi sửa
        public void TatSua(TextBox mancc)
        {
            mancc.Enabled = false;
        }
        //Bật textbox khi đã sửa xong
        public void BatSua(TextBox mancc)
        {
            mancc.Enabled = true; 
        }

        //Xóa
        public void Xoa(TextBox mancc)
        {
            QLNCCDAL.Instance.Xoa(mancc.Text.Trim());
        }

        //Tìm kiếm
        public void TimKiem(TextBox mancc, DataGridView qlncc)
        {
            qlncc.DataSource = QLNCCDAL.Instance.TimKiem(mancc.Text);
        }

        //Gợi ý tìm kiếm như google
        public void Hotrotimkiem(TextBox a)
        {
            CSDLDataContext db = new CSDLDataContext();
            AutoCompleteStringCollection cmd = new AutoCompleteStringCollection();
            var query = from n in db.NhaCungCaps
                        select n.MaNCC.Trim();
            foreach (var item in query)
            {
                cmd.Add(item);
            }
            a.AutoCompleteCustomSource = cmd;
        }
    }
}
