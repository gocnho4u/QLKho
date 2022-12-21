using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class TaoPNhapBUS
    {
        private static TaoPNhapBUS instance;

        public static TaoPNhapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaoPNhapBUS();
                return instance;
            }
        }
        private TaoPNhapBUS() { }

        //Load
        public void Load(TextBox mapn,ComboBox nhacc)
        {
            //dt.DataSource = QLPNDAL.Instance.LoadChitiet();
            //mapn.Text=TaoPNhapDAL.Instance.Sothutuid();
            nhacc.DataSource = TaoPNhapDAL.Instance.LoadNhaCungCap();
            nhacc.DisplayMember = "TenNCC";
            nhacc.ValueMember = "MaNCC";
        }

        //Thêm phiếu nhập
        public bool ThemPhieuNhap(TextBox mapn,string manv,ComboBox nhacc)
        {
            try
            {
                if (TaoPNhapDAL.Instance.LuuPhieuNhap(mapn.Text, manv, nhacc.SelectedValue.ToString()))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Thêm chi tiết phiếu nhập
        public void ThemChiTietNhap(DataGridView data,int vitri,TextBox mapn)
        {
            string id = data.Rows[vitri].Cells[0].Value.ToString();
            string tenhh = data.Rows[vitri].Cells[1].Value.ToString();
            int soluong = Int32.Parse(data.Rows[vitri].Cells[2].Value.ToString());
            int tien = Int32.Parse(data.Rows[vitri].Cells[3].Value.ToString());
            TaoPNhapDAL.Instance.LuuChitietPhieuNhap(id, mapn.Text, tenhh, soluong,tien);
        }

        //Gợi ý tìm kiếm như google
        public void Hotrotimkiem(AutoCompleteStringCollection cmd)
        {
            CSDLDataContext db = new CSDLDataContext();
            var query = from n in db.HangHoas
                        select n.TenHangHoa.Trim();
            foreach (var item in query)
            {
                cmd.Add(item);
            }
            
        }

        //Reset Form
        public void ResetForm(DataGridView data)
        {
            data.DataSource = null;

        }
    }
}
