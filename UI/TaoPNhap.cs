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
    public partial class frm_TaoPNhap : Form
    {
        public frm_TaoPNhap()
        {
            InitializeComponent();
        }

        //Load
        private void QLPNhap_Load(object sender, EventArgs e)
        {
            try
            {
                TaoPNhapBUS.Instance.Load(tb_mapn, cb_nhacc);
                //lb_manv.Text = frm_Login.ten;

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống khi Load!!!");
            }
        }

        //Gợi ý khi nhập tên hàng hóa
        private void dt_chitietphieuxuat_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                string text = dt_chitietphieuxuat.Columns[1].HeaderText;
                if (text.Equals("Tên hàng hóa"))
                {
                    TextBox auto_text = e.Control as TextBox;
                    if (auto_text != null)
                    {
                        auto_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                        auto_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
                        TaoPNhapBUS.Instance.Hotrotimkiem(sc);
                        auto_text.AutoCompleteCustomSource = sc;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống gợi ý nhập tên!");
            }
        }

        //Button Lưu
        private void bt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaoPNhapBUS.Instance.ThemPhieuNhap(tb_mapn, frm_Login.ten.ToString(), cb_nhacc))
                {
                    for (int i = 0; i < dt_chitietphieuxuat.RowCount - 1; i++)
                    {
                        TaoPNhapBUS.Instance.ThemChiTietNhap(dt_chitietphieuxuat, i, tb_mapn);
                    }
                    MessageBox.Show("Thêm thành công");
                    TaoPNhapBUS.Instance.ResetForm(dt_chitietphieuxuat);
                    TaoPNhapBUS.Instance.Load(tb_mapn, cb_nhacc);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Lỗi!!! \nVui lòng kiểm tra lại!");
            }
        }

        //Button Xóa
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dt_chitietphieuxuat.SelectedRows)
                    if (!item.IsNewRow)
                    {
                        dt_chitietphieuxuat.Rows.RemoveAt(item.Index);
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống khi xóa!!!");
            }
        }

        //Tự tăng STT
        private void dt_chitietphieuxuat_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                this.dt_chitietphieuxuat.Rows[e.RowIndex].Cells["sothutu"].Value = (e.RowIndex + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống tự tăng STT!");
            }
        }

        //Button làm mới form
        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            try
            {
                TaoPNhapBUS.Instance.ResetForm(dt_chitietphieuxuat);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống Reset!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
