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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDN frm = new FormDN();
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNhanVien frm = new FormNhanVien();
            frm.ShowDialog();
        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            FormDoiMK frm = new FormDoiMK();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormQuanLy frm = new FormQuanLy();
            frm.ShowDialog();
        }
    }
}
