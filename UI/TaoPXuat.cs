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
    public partial class frm_TaoPXuat : Form
    {
        public frm_TaoPXuat()
        {
            InitializeComponent();
            TaoPXuatBUS.Instance.loadDH(flp_DH,Btn_Click);
        }
        //Lưu thông tin đơn hàng để tạo đơn xuất
       
        private void Btn_Click(object sender, EventArgs e)
        {
            TaoPXuatBUS.Instance.ClickVaoDH(sender, bt_duyet);
            TaoPXuatBUS.Instance.ChuyenThongTin(dataGridView1);
        }

        private void bt_duyet_Click(object sender, EventArgs e)
        {
            try
            {
                TaoPXuatBUS.Instance.LuuPXuat(frm_Login.ten);
                TaoPXuatBUS.Instance.LuuCtPXuat();
                TaoPXuatBUS.Instance.CapnhatTinhtrangDH();
                TaoPXuatBUS.Instance.loadDH(flp_DH, Btn_Click);
                MessageBox.Show("Bạn đã duyệt thành công hóa đơn số " + TaoPXuatBUS.Instance.idduyet, "WELLDONE");

            }
            catch (Exception)
            {
                MessageBox.Show("HÓA ĐƠN DUYỆT KHÔNG THÀNH CÔNG");
            }
        }
    }
}
