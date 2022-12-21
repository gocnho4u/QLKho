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
    public partial class frm_ChiTietNhap : Form
    {
        public frm_ChiTietNhap()
        {
            InitializeComponent();
        }

        private void frm_ChiTietNhap_Load(object sender, EventArgs e)
        {
            lb_mapn.Text = frm_QLPNhap.mapn;
            lb_stt.Text = frm_QLPNhap.ctcxoa;
            tb_tenhh.Text = frm_QLPNhap.tenhh;
            tb_Soluong.Text = frm_QLPNhap.soluong.ToString();
            tb_Thanhtien.Text = frm_QLPNhap.thanhtien.ToString();
            QLPNhapBUS.Instance.Hotrotimkiem(tb_tenhh);
        }

        //Button Lưu
        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                QLPNhapBUS.Instance.SuaChiTietNhap(lb_stt, lb_mapn, tb_tenhh, tb_Soluong, tb_Thanhtien);
                MessageBox.Show("Lưu thành công");
                this.Dispose();
            }
            catch(Exception) { MessageBox.Show("Lưu thất bại"); }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
