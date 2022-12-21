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
    public partial class frm_QLHHoa : Form
    {
        public frm_QLHHoa()
        {
            InitializeComponent();
        }

        private void QLHHoa_Load(object sender, EventArgs e)
        {
            QLHHBUS.Instance.load(dt_qlhh,cb_tenlhh);
            
        }

        #region TienIch
        int xd; // Xác định người dùng đang sửa hay thêm mới
        void tatbutton(SimpleButton luu, SimpleButton huy, SimpleButton kiemtra, SimpleButton them, SimpleButton sua, SimpleButton xoa,  System.Windows.Forms.ComboBox loaihh,TextBox timkiem)
        {
            luu.Enabled = false; huy.Enabled = true; kiemtra.Enabled = true; loaihh.Enabled = true;
            them.Enabled = false; sua.Enabled = false; xoa.Enabled = false; timkiem.Enabled = false;
        } //tắt button khi nhấn vào thêm và sửa và mở button lưu, hủy
        void batbutton(SimpleButton luu, SimpleButton huy, SimpleButton kiemtra, SimpleButton them, SimpleButton sua, SimpleButton xoa,  System.Windows.Forms.ComboBox loaihh, TextBox timkiem)
        {
            luu.Enabled = false; huy.Enabled = false; kiemtra.Enabled = false; loaihh.Enabled = false;
            them.Enabled = true; sua.Enabled = true; xoa.Enabled = true; timkiem.Enabled = true;
        }   //ngược lại cái trên

        #endregion

        private void dt_qlhh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                txt_mahh.Text = dt_qlhh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenhh.Text = dt_qlhh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_dvtinh.Text = dt_qlhh.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_dongia.Text = dt_qlhh.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_soluong.Text = dt_qlhh.Rows[e.RowIndex].Cells[4].Value.ToString();
                cb_tenlhh.Text = dt_qlhh.Rows[e.RowIndex].Cells[5].Value.ToString();
                QLHHBUS.Instance.Canhbao(lb_report, txt_soluong);
        }

        //Button Thêm
        private void bt_them2_Click(object sender, EventArgs e)
        {
            QLHHBUS.Instance.load(dt_qlhh,cb_tenlhh);
            xd = 0;
            tatbutton(bt_luu2, bt_huy2, bt_kiemtra, bt_them2, bt_sua2, bt_xoa2,cb_tenlhh,txt_timkiem2); //bt_luu.Enabled = false;
            QLHHBUS.Instance.xoatext(txt_mahh, txt_tenhh, txt_dvtinh, txt_dongia, txt_soluong, cb_tenlhh, dt_qlhh);
        }
        //Button Lưu
        private void bt_luu2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn lưu?", "Thông báo", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                    if (xd == 0)
                    {
                        QLHHBUS.Instance.LuuThem(txt_mahh, txt_tenhh, txt_dvtinh, txt_dongia, txt_soluong, cb_tenlhh);
                    }
                    else QLHHBUS.Instance.LuuSua(txt_mahh, txt_tenhh, txt_dvtinh, txt_dongia, txt_soluong, cb_tenlhh);
                }
                else return;
            }
            catch (Exception) { MessageBox.Show("Hãy kiểm tra lại!", "Có lỗi!!!");
                return;
            }
            batbutton(bt_luu2, bt_huy2, bt_kiemtra, bt_them2, bt_sua2, bt_xoa2,cb_tenlhh,txt_timkiem2);
            QLHHBUS.Instance.bat(txt_mahh, dt_qlhh);
            QLHHBUS.Instance.load(dt_qlhh,cb_tenlhh);
        }
        //Button Sửa
        private void bt_sua2_Click(object sender, EventArgs e)
        {
            xd = 1;
            tatbutton(bt_luu2, bt_huy2, bt_kiemtra, bt_them2, bt_sua2, bt_xoa2,cb_tenlhh,txt_timkiem2); bt_luu2.Enabled = true;
            QLHHBUS.Instance.tat(txt_mahh, cb_tenlhh);

        }
        //Button Hủy
        private void bt_huy2_Click(object sender, EventArgs e)
        {
            txt_mahh.Enabled = true; dt_qlhh.Enabled = true;
            batbutton(bt_luu2, bt_huy2, bt_kiemtra, bt_them2, bt_sua2, bt_xoa2, cb_tenlhh,txt_timkiem2);
            QLHHBUS.Instance.bat(txt_mahh, dt_qlhh);
        }

        //Button Xóa
        private void bt_xoa2_Click(object sender, EventArgs e)
        {
            DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (qd == DialogResult.Yes)
            {
                QLHHBUS.Instance.Xoa(txt_mahh);
            }
            else return;
            QLHHBUS.Instance.load(dt_qlhh,cb_tenlhh);
        }
        //Button Kiểm tra
        private void bt_kiemtra2_Click(object sender, EventArgs e)
        {
                if (QLHHBUS.Instance.KiemtraThem(txt_mahh) == 1 || txt_mahh.Text=="")
                {
                    MessageBox.Show("Mã hàng hóa đã tồn tại hoặc bạn chưa điền", "Thông báo");
                    bt_luu2.Enabled = false;
                    txt_mahh.Text = "";
                }
                else if (txt_dongia.Text=="" || txt_dvtinh.Text=="" ||txt_mahh.Text==""||txt_soluong.Text==""||txt_tenhh.Text=="")
                {
                MessageBox.Show("Còn nội dung chưa được điền", "Thông báo");
                    bt_luu2.Enabled = false;
                }
                else   bt_luu2.Enabled = true;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (qd == DialogResult.Yes)
            {
                this.Dispose();
            }
            else return;
            QLHHBUS.Instance.load(dt_qlhh,cb_tenlhh);
        }
        //Chức năng tìm kiếm và các tiện ích khác 
        #region  FunctionTimKiem  

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem2.Text = "";
        }
        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (txt_timkiem2.Text == "Nhập tên hàng hóa cần tìm") txt_timkiem2.Text = "";
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem2.Text == "") txt_timkiem2.Text = "Nhập tên hàng hóa cần tìm";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem2.Text == "" || txt_timkiem2.Text == "Nhập tên hàng hóa cần tìm")
            {
                QLHHBUS.Instance.load(dt_qlhh, cb_tenlhh);
            }
            else
                QLHHBUS.Instance.TimKiem(txt_timkiem2, dt_qlhh);
        }


        #endregion

        
    }
}
