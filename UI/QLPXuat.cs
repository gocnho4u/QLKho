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
    public partial class QLPXuat : Form
    {
        public QLPXuat()
        {
            InitializeComponent();
            QLPNhapBUS.Instance.MacdinhTextbox(rd_mapn, tb_manv);
        }

        #region BienLoadChiTietNhap
        public static string mapn;
        #endregion

        #region Bat-Tat-TextboxTimkiem
        private void rd_mapn_Click(object sender, EventArgs e)
        {
            tb_manv.Enabled = false;
            tb_mapn.Enabled = true;
        }

        private void rd_manv_Click(object sender, EventArgs e)
        {
            tb_mapn.Enabled = false;
            tb_manv.Enabled = true;
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
            if (tb_mapn.Text == "")
            {
                tb_mapn.Text = "Tìm kiếm theo mã phiếu xuất";
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
            QLPXuatBUS.Instance.TimKiem(rd_mapn, rd_manv, tb_mapn, tb_manv, dt_qlpn, lb_mpn);
        }

        //Button Xóa Phiếu Xuất
        private void bt_xoapn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult qd = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (qd == DialogResult.Yes)
                {
                    try
                    {
                        QLPXuatBUS.Instance.XoaPhieuNhap(lb_mpn);
                        dt_qlpn.DataSource = null;
                        //QLPXuatBUS.Instance.BatTat(dt_qlpn, lb_mpn, tb_mapn);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể thực hiện!", "Lỗi");
                    }
                }
                else return;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thực hiện!", "Lỗi");
            }
        }

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
    }
}
