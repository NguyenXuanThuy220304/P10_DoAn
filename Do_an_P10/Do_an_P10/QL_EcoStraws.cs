using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            LoadKhachHang_DH();
            LoadSanPham_DH();
            LoadTrangThai();
            dgvDonHang.CellClick += dgvDonHang_CellClick;
            cbSanPham.SelectedIndexChanged += cbSanPham_SelectedIndexChanged;

        }
        private void sp_Click(object sender, EventArgs e)
        {
            // Toggle panel sản phẩm
            sanp.Visible = !sanp.Visible;

            // Nếu đang mở sản phẩm thì tắt các panel khác
            if (sanp.Visible)
            {
                panelKhachHang.Visible = false;
                panelLichSuKho.Visible = false;
                panelDonhang.Visible = false;

                loaddata();
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
        bool dangThemSanPham = false;
        private void loadKhachHang()
        {
            string query = "SELECT * FROM khachhang";
            dGVKhachHang.DataSource = modify.GetDataTable(query);
        }
        List<khachhang> dskh = new List<khachhang>();
        private void LoadKhachHang_DH()
        {
            string query = "SELECT MaKH, Hoten FROM khachhang";
            DataTable dt = modify.GetDataTable(query);
            cbKhachHang.DataSource = dt;
            cbKhachHang.DisplayMember = "Hoten";
            cbKhachHang.ValueMember = "MaKH";
        }

        private void LoadSanPham_DH()
        {
            string query = "SELECT MaSP, TenSP FROM sanpham";
            DataTable dt = modify.GetDataTable(query);
            cbSanPham.DataSource = dt;
            cbSanPham.DisplayMember = "TenSP";
            cbSanPham.ValueMember = "MaSP";
        }
        private void LoadTrangThai()
        {
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Chờ xử lý");
            cbTrangThai.Items.Add("Chưa Thanh Toán");
            cbTrangThai.Items.Add("Đã Thanh Toán");
            cbTrangThai.SelectedIndex = 0;
        }
        private void loadDonHang()
        {
            string query = @"
                SELECT dh.MaDH, kh.Hoten, dh.NgayLap, dh.TongTien, dh.TrangThai
                FROM DonHang dh
                JOIN khachhang kh ON dh.MaKH = kh.MaKH
                ORDER BY dh.MaDH DESC";
            dgvDonHang.DataSource = modify.GetDataTable(query);
        }
        List<ChiTietGioHang> gioHang = new List<ChiTietGioHang>();
        bool dangThemKhachHang = false; // Cờ xác định đang trong chế độ thêm
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

            if (ds.Any(sp => sp.MaSP == masp))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại trong danh sách tạm!");
                return;
            }

            if (!int.TryParse(txtSLTon.Text, out int soLuongTon))
            {
                MessageBox.Show("Số lượng tồn không hợp lệ!");
                return;
            }

            sanpham sp = new sanpham
            {
                MaSP = masp,
                Tensanpham = t.Text,
                Loai = l.Text,
                Kichthuoc = kt.Text,
                Mausac = m.Text,
                Dongia = gia,
                SoLuongTon = soLuongTon  // Thêm dòng này
            };

            ds.Add(sp);
            datasp.DataSource = null;
            datasp.DataSource = ds;

            dangThemSanPham = true;

            ClearSanPhamForm();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (ds.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để lưu.");
                return;
            }

            int demThanhCong = 0;
            foreach (var sp in ds)
            {
                bool thanhCong = modify.ThemSanPham(sp); // Sửa phương thức này cho phù hợp
                if (thanhCong)
                    demThanhCong++;
            }

            MessageBox.Show($"Đã lưu {demThanhCong} sản phẩm vào cơ sở dữ liệu.");

            ds.Clear();
            dangThemSanPham = false;

            datasp.DataSource = null;
            loaddata(); // Load từ CSDL

        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tk.Text, out int masp))
            {
                string query = $"SELECT * FROM sanpham WHERE MaSP = {masp}";
                datasp.DataSource = modify.GetDataTable(query);

                dangThemSanPham = false;
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

            if (!int.TryParse(txtSLTon.Text, out int soLuongTon))
            {
                MessageBox.Show("Số lượng tồn không hợp lệ!");
                return;
            }

            string query = $@"
                    UPDATE sanpham 
                    SET 
                    TenSP = N'{t.Text}', 
                    Loai = N'{l.Text}', 
                    Kichthuoc = N'{kt.Text}', 
                    Mausac = N'{m.Text}', 
                    Giaban = {dongia.ToString(System.Globalization.CultureInfo.InvariantCulture)}, 
                    SoLuongTon = {soLuongTon}
                    WHERE MaSP = {masp}";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật thành công!");
            loaddata();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(msp.Text, out int masp))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ để xóa!");
                return;
            }

            // Xác nhận người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = $"DELETE FROM sanpham WHERE MaSP = {masp}";
                    modify.Commad(query);

                    MessageBox.Show("Đã xóa sản phẩm thành công!");
                    loaddata();          // Reload DataGridView
                    ClearSanPhamForm();  // Xoá dữ liệu nhập trên form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
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
                txtSLTon.Text = row.Cells["SoLuongTon"].Value.ToString();
            }
        }
        private void ClearSanPhamForm()
        {
            msp.Text = "";
            t.Text = "";
            l.Text = "";
            kt.Text = "";
            m.Text = "";
            g.Text = "";
            tk.Text = "";
            txtSLTon.Text = "";
        }
        private void rs_Click(object sender, EventArgs e)
        {
            ClearSanPhamForm();
            datasp.ClearSelection();

            if (dangThemSanPham)
            {
                datasp.DataSource = null;
                datasp.DataSource = ds;
            }
            else
            {
                loaddata();
            }
        }
        private void kh_Click(object sender, EventArgs e)
        {
            panelKhachHang.Visible = !panelKhachHang.Visible;

            if (panelKhachHang.Visible)
            {
                sanp.Visible = false;
                panelLichSuKho.Visible = false;
                panelDonhang.Visible = false;

                loadKhachHang();
            }
        }
        private void sdGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtHoTen.Text = row.Cells["Hoten"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["Diachi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTenTK.Text = row.Cells["Tentaikhoan"].Value.ToString();
            }
        }
        private void SuaBtnKH_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaKH.Text, out int makh))
            {
                MessageBox.Show("Chọn khách để sửa!");
                return;
            }

            string query = @"UPDATE khachhang 
                     SET Hoten = @hoten, SDT = @sdt, Diachi = @diachi, Email = @email, Tentaikhoan = @tentk 
                     WHERE MaKH = @makh";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@tentk", txtTenTK.Text);
                    cmd.Parameters.AddWithValue("@makh", makh);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        loadKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng để cập nhật.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void XoaBtnKH_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaKH.Text, out int makh))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
                return;
            }

            // Kiểm tra xem khách có đơn hàng không
            string checkQuery = $"SELECT COUNT(*) FROM DonHang WHERE MaKH = {makh}";
            int count = (int)modify.ExecuteScalar(checkQuery); // Giả sử bạn có hàm này trong lớp Modify

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng vì đang có đơn hàng liên kết.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM khachhang WHERE MaKH = {makh}";
                modify.Commad(query);
                MessageBox.Show("Xóa thành công!");
                loadKhachHang();
                LamMoiBtnKH_Click(sender, e);
            }
        }
        private void ClearKhachHangForm()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtTenTK.Text = "";
            txtTimKiem.Text = "";
            txtHoTen.Focus();
        }
        private void LamMoiBtnKH_Click(object sender, EventArgs e)
        {
            ClearKhachHangForm();
            dGVKhachHang.ClearSelection();

            if (dangThemKhachHang)
            {
                dGVKhachHang.DataSource = null;
                dGVKhachHang.DataSource = dskh;
            }
            else
            {
                loadKhachHang();
            }
        }
        private void TimKiemBtnKH_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tukhoa))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc email để tìm kiếm.");
                return;
            }

            string query = $"SELECT * FROM khachhang WHERE Hoten LIKE N'%{tukhoa}%' OR Email LIKE N'%{tukhoa}%'";
            dGVKhachHang.DataSource = modify.GetDataTable(query);

            dangThemKhachHang = false;
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

            // Kiểm tra trùng mã trong danh sách tạm
            if (dskh.Any(x => x.MaKH == makh))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại trong danh sách tạm!");
                return;
            }

            khachhang kh = new khachhang
            {
                MaKH = makh,
                Hoten = txtHoTen.Text,
                SDT = txtSDT.Text,
                Diachi = txtDiaChi.Text,
                Email = txtEmail.Text,
                Tentaikhoan = string.IsNullOrWhiteSpace(txtTenTK.Text) ? null : txtTenTK.Text
            };

            dskh.Add(kh);
            dGVKhachHang.DataSource = null;
            dGVKhachHang.DataSource = dskh;

            dangThemKhachHang = true;

            ClearKhachHangForm();
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
            dangThemKhachHang = false;

            dGVKhachHang.DataSource = null;
            loadKhachHang(); // Load lại danh sách từ DB
        }

        private void panelKhachHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dh_Click(object sender, EventArgs e)
        {
            panelDonhang.Visible = !panelDonhang.Visible;

            if (panelDonhang.Visible)
            {
                sanp.Visible = false;
                panelKhachHang.Visible = false;
                panelLichSuKho.Visible = false;

                // Gọi hàm load đơn hàng nếu bạn có
                loadDonHang();
            }
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            if (cbSanPham.SelectedItem == null || string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng, đơn giá.");
                return;
            }
            int masp = (int)cbSanPham.SelectedValue;
            string tensp = cbSanPham.Text;
            int sl = int.Parse(txtSoLuong.Text);
            decimal gia = decimal.Parse(txtDonGia.Text);

            // Kiểm tra sản phẩm đã có trong giỏ chưa
            ChiTietGioHang spTonTai = gioHang.FirstOrDefault(sp => sp.MaSP == masp);

            if (spTonTai != null)
            {
                // Nếu có: cộng thêm số lượng và cập nhật thành tiền
                spTonTai.SoLuong += sl;
                spTonTai.DonGia = gia; // có thể giữ giá cũ nếu bạn muốn
            }
            else
            {
                // Nếu chưa có: thêm mới
                ChiTietGioHang spMoi = new ChiTietGioHang
                {
                    MaSP = masp,
                    TenSP = tensp,
                    SoLuong = sl,
                    DonGia = gia
                };
                gioHang.Add(spMoi);
            }

            // Refresh lại DataGridView
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang;

            // Cập nhật tổng tiền
            lbTongTien.Text = "Tổng: " + gioHang.Sum(x => x.ThanhTien).ToString("N0") + " VNĐ";
        }

        private void btLuuDH_Click(object sender, EventArgs e)
        {
            if (cbKhachHang.SelectedItem == null || gioHang.Count == 0)
            {
                MessageBox.Show("Chọn khách hàng và thêm sản phẩm!");
                return;
            }

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    int makh = (int)cbKhachHang.SelectedValue;
                    DateTime ngay = dtpNgayLap.Value;
                    decimal tong = gioHang.Sum(x => x.ThanhTien);

                    // Insert DonHang
                    SqlCommand cmd = new SqlCommand("INSERT INTO DonHang(NgayLap, MaKH, TongTien, TrangThai) OUTPUT INSERTED.MaDH VALUES (@ngay, @kh, @tong, @tt)", conn, tran);
                    cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);
                    cmd.Parameters.AddWithValue("@ngay", ngay);
                    cmd.Parameters.AddWithValue("@kh", makh);
                    cmd.Parameters.AddWithValue("@tong", tong);
                    int madh = (int)cmd.ExecuteScalar();

                    // Insert chi tiết
                    foreach (var item in gioHang)
                    {
                        SqlCommand ctdh = new SqlCommand("INSERT INTO CT_DonHang(MaDH, MaSP, Tensanpham, SoLuong, DonGia) VALUES (@madh, @masp, @ten, @sl, @gia)", conn, tran);
                        ctdh.Parameters.AddWithValue("@madh", madh);
                        ctdh.Parameters.AddWithValue("@masp", item.MaSP);
                        ctdh.Parameters.AddWithValue("@ten", item.TenSP);
                        ctdh.Parameters.AddWithValue("@sl", item.SoLuong);
                        ctdh.Parameters.AddWithValue("@gia", item.DonGia);
                        ctdh.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show("Lưu đơn hàng thành công!");

                    gioHang.Clear();
                    dgvGioHang.DataSource = null;
                    lbTongTien.Text = "Tổng: 0 VNĐ";
                    loadDonHang();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btTimKiemDH_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiemDH.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng hoặc tên khách hàng để tìm.");
                return;
            }

            string query = $@"
                SELECT dh.MaDH, kh.Hoten, dh.NgayLap, dh.TongTien, dh.TrangThai 
                FROM DonHang dh
                JOIN khachhang kh ON dh.MaKH = kh.MaKH
                WHERE dh.MaDH LIKE '%{keyword}%' OR kh.Hoten LIKE N'%{keyword}%'
                ORDER BY dh.MaDH DESC";

            dgvDonHang.DataSource = modify.GetDataTable(query);
        }

        private void btSuaDh_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow != null)
            {
                int maDH = Convert.ToInt32(dgvDonHang.CurrentRow.Cells["MaDH"].Value);
                DateTime ngayLap = dtpNgayLap.Value;
                decimal tongTien = gioHang.Sum(x => x.ThanhTien);
                string trangThai = cbTrangThai.Text;

                string query = @"UPDATE DonHang SET NgayLap = @ngay, TongTien = @tong, TrangThai = @trangthai WHERE MaDH = @madh";
                using (SqlConnection conn = ketnoi.GetSqlConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ngay", ngayLap);
                    cmd.Parameters.AddWithValue("@tong", tongTien);
                    cmd.Parameters.AddWithValue("@trangthai", trangThai);
                    cmd.Parameters.AddWithValue("@madh", maDH);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật đơn hàng thành công!");
                loadDonHang();
            }
        }

        private void btXoaDH_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow != null)
            {
                int maDH = Convert.ToInt32(dgvDonHang.CurrentRow.Cells["MaDH"].Value);

                DialogResult result = MessageBox.Show("Xác nhận xoá đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = ketnoi.GetSqlConnection())
                    {
                        conn.Open();

                        SqlCommand cmdCT = new SqlCommand("DELETE FROM CT_DonHang WHERE MaDH = @madh", conn);
                        cmdCT.Parameters.AddWithValue("@madh", maDH);
                        cmdCT.ExecuteNonQuery();

                        SqlCommand cmdDH = new SqlCommand("DELETE FROM DonHang WHERE MaDH = @madh", conn);
                        cmdDH.Parameters.AddWithValue("@madh", maDH);
                        cmdDH.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xoá đơn hàng.");
                    loadDonHang();
                }
            }
        }

        private void LoadChiTietDonHang(int maDH)
        {
            gioHang.Clear();

            string query = @"SELECT MaSP, Tensanpham, SoLuong, DonGia 
                     FROM CT_DonHang 
                     WHERE MaDH = @madh";
            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@madh", maDH);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietGioHang item = new ChiTietGioHang
                    {
                        MaSP = reader.GetInt32(0),
                        TenSP = reader.GetString(1),
                        SoLuong = reader.GetInt32(2),
                        DonGia = reader.GetDecimal(3)
                    };
                    gioHang.Add(item);
                }
            }

            // Hiển thị lên dgvGioHang
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang;

            // Cập nhật tổng tiền
            lbTongTien.Text = "Tổng: " + gioHang.Sum(x => x.ThanhTien).ToString("N0") + " VNĐ";
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonHang.Rows[e.RowIndex];
                if (row.Cells["TrangThai"].Value != null)
                {
                    cbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                }
                // Lấy mã đơn hàng
                int maDH = Convert.ToInt32(row.Cells["MaDH"].Value);

                // Load chi tiết giỏ hàng
                LoadChiTietDonHang(maDH);
            }
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSanPham.SelectedValue != null)
            {
                string maSP = cbSanPham.SelectedValue.ToString();
                Modify modify = new Modify();
                var spInfo = modify.LayThongTinSanPham(maSP);

                if (spInfo != null)
                {
                    lblLoaiDH.Text = "Loại: " + spInfo.Loai;
                    lblKichThuocDH.Text = "Kích thước: " + spInfo.KichThuoc;
                    txtDonGia.Text = spInfo.DonGia.ToString("N0"); // Hiển thị đơn giá
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panelLichSuKho_Paint(object sender, PaintEventArgs e)
        {
            tu.Value = DateTime.Now.AddMonths(-1); // mặc định từ 1 tháng trước
            den.Value = DateTime.Now;
            btntk.PerformClick(); // tự động tìm luôn
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = tu.Value;
            DateTime denNgay = den.Value;

            var dt = Modify.TimKiemLichSuKho(tuNgay, denNgay);

            dgvKho.DataSource = dt;
            ketq.Text = $"Tìm thấy {dt.Rows.Count} kết quả từ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}";
        }

        private void lsk_Click(object sender, EventArgs e)
        {
            panelLichSuKho.Visible = !panelLichSuKho.Visible;
            if(panelLichSuKho.Visible )
            {
                sanp.Visible = false;
                panelKhachHang.Visible = false;
                panelDonhang.Visible = false;
            }

        }
    }
}
