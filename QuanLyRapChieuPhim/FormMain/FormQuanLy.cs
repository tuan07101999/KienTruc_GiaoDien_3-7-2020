using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien frm = new DanhSachNhanVien();
            frm.ShowDialog();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThuTheoNgay frm = new DoanhThuTheoNgay();
            frm.ShowDialog();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
