using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DevExpress.XtraEditors;

namespace BUS
{
    public class QLPNhapBUS
    {
        private static QLPNhapBUS instance;

        public static QLPNhapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLPNhapBUS();
                return instance;
            }
        }
        private QLPNhapBUS() { }

        //Mặc định TextBox khi mở form
        public void MacdinhTextbox(RadioButton mpn,TextBox manv)
        {
            mpn.Checked = true;
            manv.Enabled = false;
        }
        
        //Load Chi tiết phiếu nhập
        public void LoadCt(Label mapn,DataGridView data)
        {
            data.DataSource = QLPNhapDAL.Instance.TimKiemPhieunhapTheoMPN(mapn.Text);
            data.Columns[0].HeaderText = "STT";
            data.Columns[1].HeaderText = "Tên hàng hóa";
            data.Columns[2].HeaderText = "Số lượng";
            data.Columns[3].HeaderText = "Thành tiền";
        }

        //Tìm kiếm
        public void TimKiem(RadioButton mpn,RadioButton mnv,TextBox mapn,TextBox manv,DataGridView data,Label ma,SimpleButton sua,SimpleButton xoa)
        {
            if (mpn.Checked == true)
            {
                try
                {
                    data.DataSource = QLPNhapDAL.Instance.TimKiemPhieunhapTheoMPN(mapn.Text);
                    data.Columns[0].HeaderText = "STT";
                    data.Columns[1].HeaderText = "Tên hàng hóa";
                    data.Columns[2].HeaderText = "Số lượng";
                    data.Columns[3].HeaderText = "Thành tiền";
                    if (data.Rows[0].Cells[1].Value.ToString() != null)
                    {
                        ma.Text = mapn.Text; sua.Enabled = true;xoa.Enabled = true;
                    }
                    else
                    {
                        xoa.Enabled = false;
                        sua.Enabled = false;
                        ma.Text = "...";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!");
                }

            }
            else
            {
                data.DataSource = QLPNhapDAL.Instance.TimKiemPhieunhapTheoMNV(manv.Text);
                data.Columns[0].HeaderText = "Mã nhân viên";
                data.Columns[1].HeaderText = "Mã phiếu nhập";
                data.Columns[2].HeaderText = "Thời gian";
            }
        }

        //Xóa chi tiết phiếu nhập
        public void Xoa(string id,string mapn)
        {
            QLPNhapDAL.Instance.XoaChiTiet(id, mapn);
            
        }

        //Bật tắt button sửa và xóa
        public void BatTat(DataGridView data,Label ma, TextBox mapn,SimpleButton sua,SimpleButton xoa)
        {
            if (data.DataSource != null)
            {
                ma.Text = mapn.Text; sua.Enabled = true; xoa.Enabled = true;
            }
            else
            {
                xoa.Enabled = false;
                sua.Enabled = false;
                ma.Text = "...";
            }
        }
        //Xóa Phiếu nhập
        public void XoaPhieuNhap(Label mapn)
        {
            QLPNhapDAL.Instance.XoaPhieuNhap(mapn.Text);
        }

        //Sửa Chi tiết phiếu nhập
        public void SuaChiTietNhap(Label id,Label mapn, TextBox tenhh, TextBox soluong,TextBox thanhtien)
        {
            QLPNhapDAL.Instance.SuaChiTietNhap(id.Text,mapn.Text, tenhh.Text, Int32.Parse(soluong.Text),Int32.Parse(thanhtien.Text));
        }

        //Tìm kiếm nhanh
        public object TimKiemNhanh(string tenhh,Label mapn)
        {
            var query = QLPNhapDAL.Instance.TimKiemChiTietNhanh(tenhh,mapn.Text.Trim());
            return query;
        }

        //Gợi ý tìm kiếm như google
        public void Hotrotimkiem(TextBox a)
        {
            CSDLDataContext db = new CSDLDataContext();
            AutoCompleteStringCollection cmd = new AutoCompleteStringCollection();
            var query = from n in db.HangHoas
                        select n.TenHangHoa.Trim();
            foreach (var item in query)
            {
                cmd.Add(item);
            }
            a.AutoCompleteCustomSource = cmd;
        }
        public void hienthihet(DataGridView data)
        {
            data.DataSource=QLPNhapDAL.Instance.timkiemhet();
        }
    }
}
