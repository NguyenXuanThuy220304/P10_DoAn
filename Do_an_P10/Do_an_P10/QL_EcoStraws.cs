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

        private void btnthem_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham
            {
                Tensanpham = t.Text,
                Loai = l.Text,
                Kichthuoc = kt.Text,
                Mausac = m.Text,
                Dongia = decimal.Parse(g.Text)
            };
            sp.MaSP = modify.ThemSanPham(sp);
            msp.Text = sp.MaSP.ToString(); // ✅ Hiển thị mã vừa tạo vào ô textbox msp
            ds.Add(sp);
            datasp.DataSource = null;
            datasp.DataSource = ds;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            foreach (var sp in ds)
            {
                string query = $"INSERT INTO sanpham (TenSP, Loai, Kichthuoc, Mausac, Giaban) " +
                               $"VALUES (N'{sp.Tensanpham}', N'{sp.Loai}', N'{sp.Kichthuoc}', N'{sp.Mausac}', {sp.Dongia})";
                modify.Commad(query);

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

        private void ThemBtnKH_Click(object sender, EventArgs e)
        {

        }

        private void SuaBtnKH_Click(object sender, EventArgs e)
        {

        }

        private void XoaBtnKH_Click(object sender, EventArgs e)
        {

        }

        private void LamMoiBtnKH_Click(object sender, EventArgs e)
        {

        }

        private void TimKiemBtnKH_Click(object sender, EventArgs e)
        {

        }

        private void LuuBtn_Click(object sender, EventArgs e)
        {

        }

        private void linkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }
    }
}
