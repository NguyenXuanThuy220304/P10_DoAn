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
        private void QL_EcoStraws_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelkhachhang.Visible = !panelkhachhang.Visible;
        }
    }
}
