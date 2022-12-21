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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKhoDataSet.ChitietPhieuNhap' table. You can move, or remove it, as needed.
            this.ChitietPhieuNhapTableAdapter.Fill(this.QLKhoDataSet.ChitietPhieuNhap);

            this.reportViewer1.RefreshReport();

         
            this.reportViewer1.RefreshReport();
        }
    }
}
