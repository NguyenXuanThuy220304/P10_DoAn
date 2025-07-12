using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Do_an_P10
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlCommand;// truy vaans
        SqlDataReader dataReader; //dùng để đặt dữ liệu trong bảng

        public List<khachhang> kh(string query)
        {
            List<khachhang> kh = new List<khachhang>();
            using (SqlConnection sqlConnection = ketnoi.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    kh.Add(new khachhang(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5)));
                }

                sqlConnection.Close();
            }
            return kh;
        }
        public List<taikhoan> tk(string query)
        {
            List<taikhoan> tk = new List<taikhoan>();
            using (SqlConnection sqlConnection = ketnoi.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tk.Add(new taikhoan(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2)));
                }

                sqlConnection.Close();
            }
            return tk;
        }
        public int ThemDonHang(donhang dh)
        {
            int maDH = -1;
            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO DonHang (NgayLap, MaKH, TongTien) 
                       OUTPUT INSERTED.MaDH 
                       VALUES (@ngaylap, @makh, @tongtien)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ngaylap", dh.NgayLap);
                cmd.Parameters.AddWithValue("@makh", dh.MaKH);
                cmd.Parameters.AddWithValue("@tongtien", dh.TongTien);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    maDH = Convert.ToInt32(result);
                }
            }
            return maDH;
        }
        public List<donhang> dh(string query)
        {
            List<donhang> dh = new List<donhang>();
            using (SqlConnection sqlConnection = ketnoi.GetSqlConnection())
            {

                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    dh.Add(new donhang(dataReader.GetDateTime(0), dataReader.GetInt32(1), dataReader.GetDecimal(2)));
                }
                sqlConnection.Close();

            }
            return dh;
        }
        public DataTable GetDataTable(string query)
        {
            using (SqlConnection sqlConnection = ketnoi.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public bool ThemSanPham(sanpham sp)
        {
            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                conn.Open();

                // Kiểm tra mã sản phẩm trùng
                string checkQuery = "SELECT COUNT(*) FROM sanpham WHERE MaSP = @MaSP";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại!");
                        return false;
                    }
                }

                string sql = @"INSERT INTO sanpham (MaSP, TenSP, Loai, Kichthuoc, Mausac, Giaban, NgayNhap, SoLuongNhap)
                       VALUES (@MaSP, @Ten, @Loai, @Kichthuoc, @Mausac, @Dongia, @NgayNhap, @SoLuongNhap)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@Ten", sp.Tensanpham);
                    cmd.Parameters.AddWithValue("@Loai", sp.Loai);
                    cmd.Parameters.AddWithValue("@Kichthuoc", sp.Kichthuoc);
                    cmd.Parameters.AddWithValue("@Mausac", sp.Mausac);
                    cmd.Parameters.AddWithValue("@Dongia", sp.Dongia);
                    cmd.Parameters.AddWithValue("@NgayNhap", sp.NgayNhap);
                    cmd.Parameters.AddWithValue("@SoLuongNhap", sp.SoLuongNhap);

                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool ThemKhachHang(khachhang kh)
        {
            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                conn.Open();

                // 1. Kiểm tra MaKH trùng
                string checkMaKHQuery = "SELECT COUNT(*) FROM khachhang WHERE MaKH = @MaKH";
                using (SqlCommand checkCmd = new SqlCommand(checkMaKHQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại!");
                        return false;
                    }
                }
                // 2. Nếu có tài khoản, kiểm tra tồn tại trong bảng taikhoan
                if (!string.IsNullOrEmpty(kh.Tentaikhoan))
                {
                    string checkTKQuery = "SELECT COUNT(*) FROM taikhoan WHERE Tentaikhoan = @tk";
                    using (SqlCommand checkTKCmd = new SqlCommand(checkTKQuery, conn))
                    {
                        checkTKCmd.Parameters.AddWithValue("@tk", kh.Tentaikhoan);
                        int countTK = (int)checkTKCmd.ExecuteScalar();
                        // Nếu chưa có thì thêm mới tài khoản
                        if (countTK == 0)
                        {
                            string insertTK = "INSERT INTO taikhoan (Tentaikhoan, Matkhau, Email) VALUES (@tk, @pass, @email)";
                            using (SqlCommand insertTKCmd = new SqlCommand(insertTK, conn))
                            {
                                insertTKCmd.Parameters.AddWithValue("@tk", kh.Tentaikhoan);
                                insertTKCmd.Parameters.AddWithValue("@pass", "123"); // Mật khẩu mặc định
                                insertTKCmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(kh.Email) ? "unknown@email.com" : kh.Email);
                                insertTKCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                // 3. Thêm khách hàng
                string insertKH = @"INSERT INTO khachhang (MaKH, Hoten, SDT, Diachi, Email, Tentaikhoan)
                            VALUES (@MaKH, @HoTen, @SDT, @Diachi, @Email, @Tentaikhoan)";
                using (SqlCommand cmd = new SqlCommand(insertKH, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                    cmd.Parameters.AddWithValue("@HoTen", kh.Hoten);
                    cmd.Parameters.AddWithValue("@SDT", string.IsNullOrEmpty(kh.SDT) ? (object)DBNull.Value : kh.SDT);
                    cmd.Parameters.AddWithValue("@Diachi", string.IsNullOrEmpty(kh.Diachi) ? (object)DBNull.Value : kh.Diachi);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(kh.Email) ? (object)DBNull.Value : kh.Email);
                    cmd.Parameters.AddWithValue("@Tentaikhoan", string.IsNullOrEmpty(kh.Tentaikhoan) ? (object)DBNull.Value : kh.Tentaikhoan);
                    cmd.ExecuteNonQuery();
                }
            }

            return true;
        }
        public void Commad(string query)// dùng để đăng ký tài khoản
        {
            using (SqlConnection sqlConnection = ketnoi.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public static DataRow LayThongTinKhachHang(string tenTaiKhoan)
        {
            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                string query = "SELECT * FROM khachhang WHERE Tentaikhoan = @tk";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tk", tenTaiKhoan);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
                else
                    return null;
            }
        }
        public static int ThemDonHangVaLayMa(DateTime ngayLap, int maKH, decimal tongTien)
        {
            string query = "INSERT INTO DonHang (NgayLap, MaKH, TongTien, TrangThai) " +
                           "OUTPUT INSERTED.MaDH " +
                           "VALUES (@ngayLap, @maKH, @tongTien, N'Chưa thanh toán!')";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                cmd.Parameters.AddWithValue("@maKH", maKH);
                cmd.Parameters.AddWithValue("@tongTien", tongTien);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public static void ThemChiTietDonHang(int maDonHang, int maSP, string tensp, int soLuong, decimal donGia)
        {
            string query = "INSERT INTO CT_DonHang (MaDH, MaSP, Tensanpham, SoLuong, DonGia) " +
                           "VALUES (@maDonHang, @maSP, @tensp, @soLuong, @donGia)";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@maDonHang", maDonHang);
                cmd.Parameters.AddWithValue("@maSP", maSP);
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.Parameters.AddWithValue("@donGia", donGia);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static int LayMaKhachHang(string tenTaiKhoan)
        {
            int maKH = -1;

            string query = "SELECT MaKH FROM khachhang WHERE Tentaikhoan = @tk";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tk", tenTaiKhoan);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    maKH = Convert.ToInt32(result);
                }
            }

            return maKH;
        }
        public static DataTable LayDonHang(int maDonHang)
        {
            DataTable dt = new DataTable();

            string query = "SELECT MaDH, NgayLap, MaKH, TongTien, TrangThai FROM DonHang WHERE MaDH = @maDonHang";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@maDonHang", maDonHang);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
        public static DataTable LayChiTietDonHang(int maDonHang)
        {
            DataTable dt = new DataTable();

            string query = "SELECT MaSP, Tensanpham, SoLuong, DonGia FROM CT_DonHang WHERE MaDH = @maDonHang";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@maDonHang", maDonHang);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
        public static DataTable LayThongTinKhachHang(int maKH)
        {
            DataTable dt = new DataTable();

            string query = "SELECT Hoten, SDT, Diachi, Email FROM khachhang WHERE MaKH = @maKH";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@maKH", maKH);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
        public static void CapNhatTrangThaiDonHang(int maDH, string trangThai)
        {
            string query = "UPDATE DonHang SET TrangThai = @trangThai WHERE MaDH = @maDH";

            using (SqlConnection conn = ketnoi.GetSqlConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@trangThai", trangThai);
                cmd.Parameters.AddWithValue("@maDH", maDH);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public object ExecuteScalar(string query)
        {
            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    return cmd.ExecuteScalar(); // Trả về giá trị duy nhất
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message);
                    return null;
                }
            }
        }
        public SanPhamInfo LayThongTinSanPham(string maSP)
        {
            SanPhamInfo spInfo = new SanPhamInfo();
            string query = "SELECT Loai, KichThuoc FROM sanpham WHERE MaSP = @maSP";

            try
            {
                using (SqlConnection conn = ketnoi.GetSqlConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maSP", maSP);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                spInfo.Loai = reader["Loai"].ToString();
                                spInfo.KichThuoc = reader["KichThuoc"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin sản phẩm: " + ex.Message);
            }

            return spInfo;
        }
    }
}