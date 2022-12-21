using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class reportHangHoa : Form
    {
        public reportHangHoa()
        {
            InitializeComponent();
        }

        private void reportHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhoDataSet.HangHoa' table. You can move, or remove it, as needed.
            this.HangHoaTableAdapter.Fill(this.qLKhoDataSet.HangHoa);

            this.reportViewer1.RefreshReport();
        }

        private void QLHH_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
