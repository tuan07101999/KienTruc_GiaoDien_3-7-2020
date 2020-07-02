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
    public partial class FormTaoVe : Form
    {
        public FormTaoVe()
        {
            InitializeComponent();
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;
            dialogResult = MessageBox.Show("Xác Nhận In Vé", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
