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
        Modify modify = new Modify();

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void QL_EcoStraws_Load(object sender, EventArgs e)
        {
            loaddata(); // Gọi hàm tải dữ liệu khi mở form
        }

        private void sp_Click(object sender, EventArgs e)
        {
            // Toggle panel sản phẩm
            sanp.Visible = !sanp.Visible;

            // Nếu đang mở sản phẩm thì tắt các panel khác
            if (sanp.Visible)
            {
                panelKhachHang.Visible = false;
                panelkho.Visible = false;
            }
        }

        private void k_Click(object sender, EventArgs e)
        {
            panelkho.Visible = !panelkho.Visible;
        }
        private void loaddata()
        {
            string query = "Select * from sanpham";
            datasp.DataSource = modify.GetDataTable(query);
        }
        List<sanpham> ds = new List<sanpham>();
        private void loadKhachHang()
        {
            string query = "SELECT * FROM khachhang";
            dGVKhachHang.DataSource = modify.GetDataTable(query);
        }
        List<khachhang> dskh = new List<khachhang>();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(msp.Text, out int masp))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!");
                return;
            }

            if (string.IsNullOrWhiteSpace(t.Text) || string.IsNullOrWhiteSpace(g.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên sản phẩm và giá.");
                return;
            }

            if (!decimal.TryParse(g.Text, out decimal gia))
            {
                MessageBox.Show("Giá không hợp lệ!");
                return;
            }

            sanpham sp = new sanpham
            {
                MaSP = masp,
                Tensanpham = t.Text,
                Loai = l.Text,
                Kichthuoc = kt.Text,
                Mausac = m.Text,
                Dongia = gia
            };

            ds.Add(sp); // ➕ Lưu vào danh sách tạm

            datasp.DataSource = null;
            datasp.DataSource = ds;

            rs_Click(sender, e); // Xoá trắng các textbox nhập
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (ds.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để lưu.");
                return;
            }

            foreach (var sp in ds)
            {
                modify.ThemSanPham(sp); // ✅ Chỉ cần gọi hàm này là đủ!
            }

            MessageBox.Show("Lưu thành công vào cơ sở dữ liệu!");

            ds.Clear(); // Xóa danh sách tạm
            datasp.DataSource = null;
            loaddata();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tk.Text, out int masp))
            {
                string query = $"SELECT * FROM sanpham WHERE MaSP = {masp}";
                datasp.DataSource = modify.GetDataTable(query);
            }
            else
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(msp.Text, out int masp)) { MessageBox.Show("Chọn sản phẩm để sửa!"); return; }

            if (!decimal.TryParse(g.Text, out decimal dongia))
            {
                MessageBox.Show("Giá không hợp lệ!"); return;
            }

            string query = $"UPDATE sanpham SET TenSP = N'{t.Text}', Loai = N'{l.Text}', Kichthuoc = N'{kt.Text}', Mausac = N'{m.Text}', Giaban = {dongia.ToString(System.Globalization.CultureInfo.InvariantCulture)} WHERE MaSP = {masp}";
            modify.Commad(query);

            MessageBox.Show("Cập nhật thành công!");
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(msp.Text, out int masp)) { MessageBox.Show("Chọn sản phẩm để xóa!"); return; }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM sanpham WHERE MaSP = {masp}";
                modify.Commad(query);
                MessageBox.Show("Xóa thành công!");
                loaddata();
            }
        }

        private void datasp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datasp.Rows[e.RowIndex];

                msp.Text = row.Cells["MaSP"].Value.ToString();
                t.Text = row.Cells["TenSP"].Value.ToString();
                l.Text = row.Cells["Loai"].Value.ToString();
                kt.Text = row.Cells["Kichthuoc"].Value.ToString();
                m.Text = row.Cells["Mausac"].Value.ToString();
                g.Text = row.Cells["Giaban"].Value.ToString();
            }
        }

        private void rs_Click(object sender, EventArgs e)
        {
            msp.Text = "";
            t.Text = "";
            l.Text = "";
            kt.Text = "";
            m.Text = "";
            g.Text = "";

            // Nếu cần, đưa focus về ô nhập đầu tiên
            t.Focus();
            datasp.ClearSelection();
        }

        private void kh_Click(object sender, EventArgs e)
        {
            panelKhachHang.Visible = !panelKhachHang.Visible;

            if (panelKhachHang.Visible)
            {
                sanp.Visible = false;
                panelkho.Visible = false;
                loadKhachHang();
            }
        }

        private void SuaBtnKH_Click(object sender, EventArgs e)
        {

        }

        private void XoaBtnKH_Click(object sender, EventArgs e)
        {

        }

        private void LamMoiBtnKH_Click(object sender, EventArgs e)
        {
            msp.Text = "";
            t.Text = "";
            l.Text = "";
            kt.Text = "";
            m.Text = "";
            g.Text = "";

            // Nếu cần, đưa focus về ô nhập đầu tiên
            t.Focus();
            datasp.ClearSelection();
        }

        private void TimKiemBtnKH_Click(object sender, EventArgs e)
        {

        }
        private void linkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }

        private void ThemKHBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaKH.Text, out int makh))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng.");
                return;
            }

            // Tạo đối tượng khách hàng, chấp nhận null cho tài khoản
            khachhang kh = new khachhang
            {
                MaKH = makh,
                Hoten = txtHoTen.Text,
                SDT = txtSDT.Text,
                Diachi = txtDiaChi.Text,
                Email = txtEmail.Text,
                Tentaikhoan = string.IsNullOrWhiteSpace(txtTenTK.Text) ? null : txtTenTK.Text
            };

            dskh.Add(kh); // Thêm vào danh sách tạm

            dGVKhachHang.DataSource = null;
            dGVKhachHang.DataSource = dskh;

            LamMoiBtnKH_Click(sender, e); // Xoá trắng các ô nhập
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            if (dskh.Count == 0)
            {
                MessageBox.Show("Không có khách hàng nào để lưu.");
                return;
            }

            foreach (var kh in dskh)
            {
                bool thanhCong = modify.ThemKhachHang(kh);
                if (!thanhCong)
                {
                    MessageBox.Show($"Không thể thêm khách hàng có mã: {kh.MaKH}");
                }
            }

            MessageBox.Show("Lưu thành công vào cơ sở dữ liệu!");

            dskh.Clear(); // Xoá danh sách tạm
            dGVKhachHang.DataSource = null;
            loadKhachHang(); // Load lại danh sách từ DB
        }
    }
}
