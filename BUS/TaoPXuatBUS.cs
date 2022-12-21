using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class TaoPXuatBUS
    {
        private static TaoPXuatBUS instance;

        public static TaoPXuatBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaoPXuatBUS();
                return instance;
            }
        }
        private TaoPXuatBUS() { }

        public string idduyet = "";
        private string diachiduyet = "";
        private string donxuat;

        

        //Load đơn hàng chưa giao
        public void loadDH(FlowLayoutPanel dsdh,EventHandler Btn_Click)
        {
            dsdh.Controls.Clear();
            List<DonHang> dhlist = TaoPXuatDAL.Instance.LayDH();
            foreach (DonHang itemdh in dhlist)
            {

                switch (itemdh.TrangThai)
                {
                    case "Chưa giao":
                        Button btn = new Button() { Width = 80, Height = 80 };
                        btn.Text = itemdh.MaDH + Environment.NewLine + itemdh.TrangThai;
                        btn.Click += Btn_Click;
                        btn.Tag = itemdh;
                        dsdh.Controls.Add(btn);
                        break;
                    default:
                        break;
                }

            }
        }

        //Event Click vào đơn hàng
        public void ClickVaoDH(object sender, DevExpress.XtraEditors.SimpleButton duyet)
        {           
            string idmadh = ((sender as Button).Tag as DonHang).MaDH;
            String diachigiao = ((sender as Button).Tag as DonHang).DiaChi;
            DateTime ngaydat = ((sender as Button).Tag as DonHang).ThoiGian;
            idduyet = idmadh;
            diachiduyet = diachigiao;
            donxuat = "DX-" + idduyet;
            if (TaoPXuatDAL.Instance.ThieuDu(idduyet) > 0)
            {
                duyet.Enabled = false;
            }
            else duyet.Enabled = true;
            
        }

        //Lấy thông tin đơn hàng hiện thị qua DataGridview
        public void ChuyenThongTin(DataGridView dt_gridview)
        {
            //listView1.Items.Clear();
            //List<ChitietDonHang> DDHinfo = TaoPXuatDAL.Instance.LayCtDH(idduyet);
            //foreach (ChitietDonHang item in DDHinfo)
            //{
            //    ListViewItem lsvitem = new ListViewItem(item.MaDH);
            //    lsvitem.SubItems.Add(item.HangHoa.TenHangHoa);
            //    lsvitem.SubItems.Add(item.HangHoa.DonGia.ToString());
            //    lsvitem.SubItems.Add(item.Soluong.ToString());
            //    lsvitem.SubItems.Add(item.ThanhTien.ToString());
            //    listView1.Items.Add(lsvitem);
            //}
            dt_gridview.DataSource = TaoPXuatDAL.Instance.LayCtDHv2(idduyet);
            dt_gridview.Columns[0].HeaderText = "Mã đơn hàng";
            dt_gridview.Columns[1].HeaderText = "Tên hàng hóa";
            dt_gridview.Columns[2].HeaderText = "Số lượng";
            dt_gridview.Columns[3].HeaderText = "Thành tiền";
            dt_gridview.Columns[4].HeaderText = "Tình trạng (Số lượng thiếu)";
        }

        //Lưu chi tiết phiếu xuất
        public void LuuCtPXuat()
        {
            List<ChitietDonHang> CHTIDH = TaoPXuatDAL.Instance.LayCtDH(idduyet) ;
            string IDDX = donxuat;
            int mact = 1;
            foreach (ChitietDonHang item in CHTIDH)
            {
                
                string mahh = item.MaHH;
                int slx = item.Soluong;

                TaoPXuatDAL.Instance.LuuCtPxuat(mact.ToString(),donxuat,mahh,slx);
                mact++;
            }
        }
        //Lưu Phiếu Xuất
        public void LuuPXuat(string manv)
        {
            TaoPXuatDAL.Instance.LuuPxuat(donxuat, idduyet, manv,diachiduyet);
        }

        //Cập nhật lại Đơn hàng
        public void CapnhatTinhtrangDH()
        {
            TaoPXuatDAL.Instance.CapNhatTinhTrangDH(idduyet);
        }
    }
}
