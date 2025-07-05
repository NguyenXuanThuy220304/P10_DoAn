using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Do_an_P10
{
    public partial class GioHangForm : Form
    {
        private string tentk;
        public GioHangForm(string tentk)
        {
            InitializeComponent();
            this.tentk = tentk;
            LoadGioHang();
        }
        private void HienThiThongTinKhachHang()
        {
            DataRow row = Modify.LayThongTinKhachHang(tentk);
            if (row != null)
            {
                txtHoTen.Text = row["Hoten"].ToString();
                txtSDT.Text = row["SDT"].ToString();
                txtDiaChi.Text = row["Diachi"].ToString();
                txtEmail.Text = row["Email"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadGioHang()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GioHangData.Instance.DanhSachSanPham;

            HienThiThongTinKhachHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EcoStraws eco = new EcoStraws(tentk);
            eco.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
            EcoStraws eco = new EcoStraws(tentk); eco.Show();
            this.Hide();

        }

        private void GioHangForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
