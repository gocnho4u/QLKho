using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class QLHHBUS
    {
        private static QLHHBUS instance;

        public static QLHHBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLHHBUS();
                return instance;
            }
        }
        private QLHHBUS() { }

        // Load dữ liệu hàng hóa
        public void load(DataGridView data, ComboBox loaihh)
        {
            data.DataSource = QLHHDAL.Instance.load();
            data.Columns[0].HeaderText = "Mã hàng hóa";
            data.Columns[1].HeaderText = "Tên hàng hóa";
            data.Columns[2].HeaderText = "Đơn vị tính";
            data.Columns[3].HeaderText = "Đơn giá";
            data.Columns[4].HeaderText = "Số lượng";
            data.Columns[5].HeaderText = "Tên loại";

            loaihh.DataSource = QLHHDAL.Instance.loadloaihh();
            loaihh.DisplayMember = "TenLoai";
            loaihh.ValueMember = "MaLoai";
        }

        // Xóa text các textbox khi nhấn nút thêm
        public void xoatext(TextBox mahh, TextBox tenhh, TextBox dvtinh, TextBox dongia, TextBox soluong, ComboBox maloai, DataGridView qlhh)
        {
            mahh.Text = ""; tenhh.Text = ""; dvtinh.Text = ""; dongia.Text = ""; soluong.Text = "";
            qlhh.Enabled = false;
        }

        // Thêm hàng hóa
        public void LuuThem(TextBox mahh, TextBox tenhh, TextBox dvtinh, TextBox dongia, TextBox soluong, ComboBox maloai)
        {
            string ma = QLHHDAL.Instance.xdmaloai(maloai.Text);
            int dongia1 = Int32.Parse(dongia.Text);
            int soluong1 = Int32.Parse(soluong.Text);
            QLHHDAL.Instance.LuuThem(mahh.Text, tenhh.Text, dvtinh.Text, dongia1, soluong1, ma);
        }

        //Sửa hàng hóa
        public void LuuSua(TextBox mahh, TextBox tenhh, TextBox dvtinh, TextBox dongia, TextBox soluong, ComboBox maloai)
        {
            string ma = QLHHDAL.Instance.xdmaloai(maloai.Text);
            int dongia1 = Int32.Parse(dongia.Text);
            int soluong1 = Int32.Parse(soluong.Text);
            QLHHDAL.Instance.LuuSua(mahh.Text, tenhh.Text, dvtinh.Text, dongia1, soluong1, ma);
        }

        //Xóa
        public void Xoa(TextBox mahh)
        {
            QLHHDAL.Instance.Xoa(mahh.Text.Trim());
        }



        // tắt text box mã hh khi sửa
        public void tat(TextBox mahh, ComboBox maloai)
        {
            mahh.Enabled = false;
            maloai.Enabled = true;
        }
        // Mở lại text box mã hh và datagridview
        public void bat(TextBox mahh, DataGridView data)
        {
            mahh.Enabled = true; data.Enabled = true;
        }
        // kiểm tra mã hàng hóa đã tồn tại hay chưa
        public void kiemtra(TextBox mahh)
        {
            if (QLHHDAL.Instance.Kiemtra(mahh.Text) != 0)
            {
                MessageBox.Show("Hàng hóa đã tồn tại");
                mahh.Text = "";
            }
            else return;
        }
        //Tìm kiếm
        public void TimKiem(TextBox tenhh, DataGridView b)
        {
            b.DataSource = QLHHDAL.Instance.Timkiem(tenhh.Text);
        }

        //Cảnh báo hết hàng
        public void Canhbao(Label canhbao, TextBox soluong)
        {
            int a = Int32.Parse(soluong.Text);
            if (a < 10)
            {
                soluong.ForeColor = System.Drawing.Color.Red;
                canhbao.ForeColor = System.Drawing.Color.Red;
                canhbao.Text = "Sắp hết hàng!!!!!";
            }
            else
            {
                canhbao.Text = "";
                soluong.ForeColor = System.Drawing.Color.Black;
            }
        }

        // Kiểm tra mã hàng h có tồn tại không hay mã nhân viên đã có tài khoản chưa khi tiến hành thêm
        public int KiemtraThem(TextBox mahh) //kiểm tra trước khi thêm tài khoản
        {
            int sodem = QLHHDAL.Instance.KiemtraThem(mahh.Text);
            return sodem;
        }

        //public void Hotrotimkiem(TextBox a)
        //{
        //    CSDLDataContext db = new CSDLDataContext();
        //    AutoCompleteStringCollection cmd = new AutoCompleteStringCollection();
        //    var query = from n in db.HangHoas
        //                select n.TenHangHoa.Trim();
        //    foreach (var item in query)
        //    {
        //        cmd.Add(item);
        //    }
        //    a.AutoCompleteCustomSource = cmd;
        //}  //gợi ý tìm kiếm như google
    }
}
