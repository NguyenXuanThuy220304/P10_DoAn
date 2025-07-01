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
    public partial class QL_EcoStraws : Form
    {
        public QL_EcoStraws()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelkhachhang.Visible= !panelkhachhang.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menukho.Visible = !menukho.Visible;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
