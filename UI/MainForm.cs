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
    public partial class frm_MainForm : Form
    {
        private int childFormNumber = 0;

        public frm_MainForm()
        {
            InitializeComponent();
        }

        #region 1 đống gì đó
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        bool admin;
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = "Nhân viên: " +MainformBUS.Instance.tennv(frm_Login.ten);
            if (MainformBUS.Instance.admin(frm_Login.ten) == false) //phân quyền admin
            {
                menu_Quanly.Enabled = false;
                frm_baocao.Enabled = false;
            }
            else
            {
                frm_QLTKhoan frm = new frm_QLTKhoan();
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        //Mở form QL hàng hóa
        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLHHoa frm = new frm_QLHHoa();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        //Mở form QL Người Dùng
        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLTKhoan frm = new frm_QLTKhoan();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        //Đồng hồ dưới góc phải
        private void timer1_Tick(object sender, EventArgs e)
        {
            MainformBUS.Instance.thoigianthuc(lb_time);
        }

        //Mở form Lập phiếu nhập
        private void PhieuNhap_Click(object sender, EventArgs e)
        {
            frm_TaoPNhap frm = new frm_TaoPNhap();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLNCCap frm = new frm_QLNCCap();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void QLPNhap_Click(object sender, EventArgs e)
        {
            frm_QLPNhap frm = new frm_QLPNhap();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TaoPXuat frm = new frm_TaoPXuat();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
