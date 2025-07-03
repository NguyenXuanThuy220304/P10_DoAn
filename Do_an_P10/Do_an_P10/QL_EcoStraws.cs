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
        private void anpanel()
        {
            panelkhachhang.Visible = false;
            sp.Visible = false;
        }
        private void QL_EcoStraws_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            anpanel();
            panelkhachhang.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anpanel();
            sp.Visible = true;
        }
    }
}
