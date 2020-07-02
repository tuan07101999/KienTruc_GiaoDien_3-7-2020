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
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;
            dialogResult = MessageBox.Show("Bạn chắc chắn muốn thay đổi mật khẩu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
