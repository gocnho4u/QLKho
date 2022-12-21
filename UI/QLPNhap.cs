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
    public partial class frm_QLPNhap : Form
    {
        public frm_QLPNhap()
        {
            InitializeComponent();
            QLPNhapBUS.Instance.MacdinhTextbox(rd_mapn, tb_manv);
            bt_Sua.Enabled = false;
            bt_Xoa.Enabled = false;
        }

        #region BienLoadChiTietNhap
        public static string mapn ;
        public static string ctcxoa = ""; //Chi tiết cần xóa
        public static string tenhh;
        public static int soluong;
        public static long thanhtien;
        #endregion

        //RowEnter
        private void dt_qlpn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ctcxoa = dt_qlpn.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                mapn = lb_mpn.Text;              
                tenhh = dt_qlpn.Rows[e.RowIndex].Cells[1].Value.ToString();
                soluong = Int32.Parse(dt_qlpn.Rows[e.RowIndex].Cells[2].Value.ToString());
                thanhtien = Int32.Parse(dt_qlpn.Rows[e.RowIndex].Cells[3].Value.ToString());
                
            }
            catch (Exception) { }
        }
        #region Bat-Tat-TextboxTimkiem
        private void rd_mapn_Click(object sender, EventArgs e)
        {
            tb_manv.Enabled = false;
            tb_mapn.Enabled = true;
            txt_timkiem.Enabled = true;

        }

        private void rd_manv_Click(object sender, EventArgs e)
        {
            tb_mapn.Enabled = false;
            tb_manv.Enabled = true;
            txt_timkiem.Enabled = false;
        }

        #endregion

        #region Bat-Tat-ChuGoiYTimKiem
        private void tb_mapn_Click(object sender, EventArgs e)
        {
            tb_mapn.Text = "";
        }

        private void tb_manv_Click(object sender, EventArgs e)
        {
            tb_manv.Text = "";
        }

        private void tb_mapn_Leave(object sender, EventArgs e)
        {
            if (tb_mapn.Text=="")
            {
                tb_mapn.Text= "Tìm kiếm theo mã phiếu nhập";
            }
        }

        private void tb_manv_Leave(object sender, EventArgs e)
        {
            if (tb_manv.Text == "")
            {
                tb_manv.Text = "Tìm kiếm theo mã nhân viên";
            }
        }

        #endregion

        //Button Tìm kiếm
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            QLPNhapBUS.Instance.TimKiem(rd_mapn,rd_manv,tb_mapn, tb_manv, dt_qlpn,lb_mpn,bt_Sua,bt_Xoa);
        }

        //Button Xóa Chi tiết
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                    QLPNhapBUS.Instance.Xoa(ctcxoa, lb_mpn.Text);
                }
                else return;
                QLPNhapBUS.Instance.LoadCt(lb_mpn, dt_qlpn);
                QLPNhapBUS.Instance.BatTat(dt_qlpn, lb_mpn, tb_mapn, bt_Sua, bt_Xoa);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thực hiện!", "Lỗi");
            }
        }

        //Button Xóa Phiếu Nhập
        private void bt_xoapn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                    try
                    {
                        QLPNhapBUS.Instance.XoaPhieuNhap(lb_mpn);
                        dt_qlpn.DataSource = null;
                        QLPNhapBUS.Instance.BatTat(dt_qlpn, lb_mpn, tb_mapn, bt_Sua, bt_Xoa);
                        MessageBox.Show(this, "thanh cong");
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Không thể thực hiện!", "Lỗi");
                    }
                }
                else return;
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể thực hiện!", "Lỗi");
            }
        }

        //Button Sửa
        private void bt_Sua_Click(object sender, EventArgs e)
        {
            mapn = lb_mpn.Text;
            frm_ChiTietNhap frm = new frm_ChiTietNhap();
            frm.Show();
        }

        #region Tìm Kiếm
        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text ="";
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "") txt_timkiem.Text = "Nhập tên hàng hóa ở chi tiết cần tìm";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "" || txt_timkiem.Text == "Nhập tên hàng hóa ở chi tiết cần tìm")
            {
                QLPNhapBUS.Instance.LoadCt(lb_mpn, dt_qlpn);
            }
            else
                dt_qlpn.DataSource=QLPNhapBUS.Instance.TimKiemNhanh(txt_timkiem.Text,lb_mpn);
        }
        #endregion

        //Button Thoát
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (qd == DialogResult.Yes)
            {
                this.Dispose();
            }
            else return;
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            
            QLPNhapBUS.Instance.hienthihet(dt_qlpn);

        }

        private void dt_qlpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
