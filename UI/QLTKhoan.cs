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
using DevExpress.XtraEditors;

namespace UI
{
    public partial class frm_QLTKhoan : Form
    {
        public frm_QLTKhoan()
        {
            InitializeComponent();
        }
        private void QLTKhoan_Load(object sender, EventArgs e)
        {
            QLNDBUS.Instance.load(dt_qlnd);
        }

        #region TienIch
        int xd; // Xác định người dùng đang sửa hay thêm mới
        private string ten;

        //tắt button khi nhấn vào thêm và sửa và mở button lưu, hủy
        void tatbutton(SimpleButton luu, SimpleButton huy, SimpleButton kiemtra, SimpleButton them, SimpleButton sua, SimpleButton xoa,TextBox timkiem)
        {
            luu.Enabled = true; huy.Enabled = true; kiemtra.Enabled = true;
            them.Enabled = false; sua.Enabled = false; xoa.Enabled = false; timkiem.Enabled = false;
        }
        //ngược lại cái trên
        void batbutton(SimpleButton luu, SimpleButton huy, SimpleButton kiemtra, SimpleButton them, SimpleButton sua, SimpleButton xoa, TextBox timkiem)
        {
            luu.Enabled = false; huy.Enabled = false; kiemtra.Enabled = false;
            them.Enabled = true; sua.Enabled = true; xoa.Enabled = true;timkiem.Enabled = true;
        }

        #endregion

        #region TabQuanLyNguoiDung
        //RowEnter đổ dữ liệu vào các textbox
        private void dt_qlnd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_userid.Text = dt_qlnd.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_manv.Text = dt_qlnd.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_matkhau.Text = dt_qlnd.Rows[e.RowIndex].Cells[2].Value.ToString();
            if ((bool)dt_qlnd.Rows[e.RowIndex].Cells[3].Value == true)
            {
                rd_co.Checked = true;
            }
            else rd_khong.Checked = true;
            txt_tennv.Text = dt_qlnd.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        //Thêm
        private void bt_them_Click(object sender, EventArgs e)
        {
            QLNDBUS.Instance.load(dt_qlnd);
            xd = 0;
            tatbutton(bt_luu, bt_huy, bt_kiemtra, bt_them, bt_sua, bt_xoa,txt_timkiem); bt_luu.Enabled = false;
            panel3.Enabled = true;
            QLNDBUS.Instance.xoatext(txt_userid,txt_matkhau, txt_manv, txt_tennv, rd_khong, dt_qlnd);
        }

        //Lưu
        private void bt_luu_Click(object sender, EventArgs e)
        {
            bool d = QLNDBUS.Instance.xdradio(rd_co, rd_khong);
            try
            {
                DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn lưu?", "Thông báo", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                    if (xd == 0 && QLNDBUS.Instance.KiemtraThem(txt_manv) == 0)
                    { QLNDBUS.Instance.LuuThem(txt_userid, txt_matkhau, d, txt_manv, dt_qlnd); }
                    else
                    {
                        QLNDBUS.Instance.LuuSua(txt_userid, txt_matkhau, d, txt_manv, dt_qlnd);
                    }
                }
                else return;
            }
            catch (Exception) { MessageBox.Show("Hãy kiểm tra lại!", "Có lỗi!!!");
                return;
            }
            batbutton(bt_luu, bt_huy, bt_kiemtra, bt_them, bt_sua, bt_xoa,txt_timkiem);
            dt_qlnd.Enabled = true;
            QLNDBUS.Instance.BatSua(txt_manv, panel3);
            QLNDBUS.Instance.load(dt_qlnd);
        } 

        //Kiểm tra
        private void bt_kiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                QLNDBUS.Instance.xdtennv(txt_manv, txt_tennv);
                if (QLNDBUS.Instance.KiemtraThem(txt_manv) == 1)
                {
                    MessageBox.Show("Nhân viên đã có tài khoản kho");
                    txt_manv.Text = "";
                }
                else if (txt_matkhau.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu");
                    txt_matkhau.Focus();
                }
                else bt_luu.Enabled = true
;
            }
            catch (Exception) { MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo"); }

        }

        //Hủy
        private void bt_huy_Click(object sender, EventArgs e)
        {
            batbutton(bt_luu, bt_huy, bt_kiemtra, bt_them, bt_sua, bt_xoa,txt_timkiem);
            dt_qlnd.Enabled = true;
            txt_userid.Text = "";
            QLNDBUS.Instance.BatSua(txt_manv, panel3);
        }

        //Sửa
        private void bt_sua_Click(object sender, EventArgs e)
        {
            QLNDBUS.Instance.load(dt_qlnd);
            xd = 1;
            tatbutton(bt_luu, bt_huy, bt_kiemtra, bt_them, bt_sua, bt_xoa,txt_timkiem); bt_kiemtra.Enabled = false;
            QLNDBUS.Instance.TatSua(txt_manv, panel3);
        } 

        //Xóa
        private void bt_xoa_Click(object sender, EventArgs e)
        {

            DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (qd == DialogResult.Yes)
            {
                if (txt_manv.Text ==  frm_Login.ten)
                {
                    MessageBox.Show("Không thể xóa chính bạn", "Thông báo");
                }
                else
                {
                    QLNDBUS.Instance.readonlytext(txt_matkhau, txt_manv);
                    QLNDBUS.Instance.Xoa(txt_userid);
                }
            }
            else return;
            QLNDBUS.Instance.load(dt_qlnd);
        }

        //Thoát
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (qd == DialogResult.Yes)
            {
                this.Dispose();
            }
            else return;
            QLNDBUS.Instance.load(dt_qlnd);
        }
        #endregion

        //Chức năng tìm kiếm và các tiện ích khác 
        #region  FunctionTimKiem  

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = ""; 
        }

        //Xem xét xóa
        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "Nhập mã nhân viên cần tìm") txt_timkiem.Text = "";
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "") txt_timkiem.Text = "Nhập mã nhân viên cần tìm";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "" || txt_timkiem.Text == "Nhập mã nhân viên cần tìm")
            {
                QLNDBUS.Instance.load(dt_qlnd);
            }
            else
                QLNDBUS.Instance.TimKiem(txt_timkiem, dt_qlnd);
        }

        #endregion

        
    }
}
