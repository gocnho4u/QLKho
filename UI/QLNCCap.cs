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
    public partial class frm_QLNCCap : Form
    {
        public frm_QLNCCap()
        {
            InitializeComponent();
        }

        private void QLNCCap_Load(object sender, EventArgs e)
        {
            QLNCCBUS.Instance.load(dt_qlncc);
            txt_mancc.ReadOnly = true;
        }

        #region TienIch
        int xd=-1; // Xác định người dùng đang sửa hay thêm mới
        //tắt button khi nhấn vào thêm và sửa và mở button lưu, hủy
        void tatbutton(SimpleButton luu, SimpleButton huy, SimpleButton them, SimpleButton sua, SimpleButton xoa,TextBox timkiem)
        {
            luu.Enabled = true; huy.Enabled = true;
            them.Enabled = false; sua.Enabled = false; xoa.Enabled = false; timkiem.Enabled = false;
        }
        //ngược lại cái trên
        void batbutton(SimpleButton luu, SimpleButton huy, SimpleButton them, SimpleButton sua, SimpleButton xoa, TextBox timkiem)
        {
            luu.Enabled = false; huy.Enabled = false; 
            them.Enabled = true; sua.Enabled = true; xoa.Enabled = true; timkiem.Enabled = true;
        }

        #endregion

        #region TabQuanLyNguoiDung
        //RowEnter đổ dữ liệu vào các textbox
        private void dt_qlncc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = dt_qlncc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tenncc.Text = dt_qlncc.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_diachi.Text = dt_qlncc.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_sdt.Text = dt_qlncc.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_fax.Text = dt_qlncc.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        //Thêm
        private void bt_them_Click(object sender, EventArgs e)
        {
            QLNCCBUS.Instance.load(dt_qlncc);
            xd = 0;
            tatbutton(bt_luu, bt_huy, bt_them, bt_sua, bt_xoa,txt_timkiem); 
            
            QLNCCBUS.Instance.xoatext(txt_mancc, txt_tenncc, txt_diachi, txt_sdt, txt_fax, dt_qlncc);
        }

        //Lưu
        private void bt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn lưu?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    if (xd == 0)
                    { QLNCCBUS.Instance.LuuThem(txt_mancc, txt_tenncc, txt_diachi, txt_sdt, txt_fax, dt_qlncc); }
                    else
                    {
                        QLNCCBUS.Instance.LuuSua(txt_mancc, txt_tenncc, txt_diachi, txt_sdt, txt_fax, dt_qlncc);
                    }
                }
                else return;
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy kiểm tra lại!", "Có lỗi!!!");
                return;
            }
            batbutton(bt_luu, bt_huy, bt_them, bt_sua, bt_xoa,txt_timkiem);
            dt_qlncc.Enabled = true;
            QLNCCBUS.Instance.BatSua(txt_mancc);
            QLNCCBUS.Instance.load(dt_qlncc);
        }

        //Hủy
        private void bt_huy_Click(object sender, EventArgs e)
        {
            batbutton(bt_luu, bt_huy,bt_them, bt_sua, bt_xoa,txt_timkiem);
            dt_qlncc.Enabled = true;
            txt_mancc.Text = "";
            QLNCCBUS.Instance.BatSua(txt_mancc);
        }

        //Sửa
        private void bt_sua_Click(object sender, EventArgs e)
        {
            QLNCCBUS.Instance.load(dt_qlncc);
            xd = 1;
            tatbutton(bt_luu, bt_huy,bt_them, bt_sua, bt_xoa,txt_timkiem); 
            QLNCCBUS.Instance.TatSua(txt_mancc);
        }

        //Xóa
        private void bt_xoa_Click(object sender, EventArgs e)
        {

            DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (qd == DialogResult.Yes)
            {
                //QLNCCBUS.Instance.readonlytext(txt_matkhau, txt_manv);
                QLNCCBUS.Instance.Xoa(txt_mancc);
            }
            else return;
            QLNCCBUS.Instance.load(dt_qlncc);
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
            QLNCCBUS.Instance.load(dt_qlncc);
        }
        #endregion

        //Chức năng tìm kiếm và các tiện ích khác 
        #region  FunctionTimKiem  

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
        }

        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "Nhập tên nhà cung cấp cần tìm") txt_timkiem.Text = "";
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "") txt_timkiem.Text = "Nhập tên nhà cung cấp cần tìm";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "" || txt_timkiem.Text == "Nhập tên nhà cung cấp cần tìm")
            {
                QLNCCBUS.Instance.load(dt_qlncc);
            }
            else
                QLNCCBUS.Instance.TimKiem(txt_timkiem, dt_qlncc);
        }

        #endregion

    }
}
