using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_P10
{
    public partial class quenmatkhau : Form
    {
        public quenmatkhau()
        {
            InitializeComponent();
        }

        private void mkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            Dangnhap d = new Dangnhap();
            d.Show();
            this.Hide();

        }
    }
}
