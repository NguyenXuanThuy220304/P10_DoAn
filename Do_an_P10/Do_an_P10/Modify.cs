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
            int maSP = -1;
            using (SqlConnection conn = ketnoi.GetSqlConnection())
            {
                conn.Open();

                // Kiểm tra MaSP có bị trùng không
                string checkQuery = "SELECT COUNT(*) FROM sanpham WHERE MaSP = @MaSP";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!");
                    return false;
                }

                string sql = @"INSERT INTO sanpham (MaSP, TenSP, Loai, Kichthuoc, Mausac, Giaban)
                       OUTPUT INSERTED.MaSP
                       VALUES (@MaSP, @Ten, @Loai, @Kichthuoc, @Mausac, @Dongia)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                cmd.Parameters.AddWithValue("@Ten", sp.Tensanpham);
                cmd.Parameters.AddWithValue("@Loai", sp.Loai);
                cmd.Parameters.AddWithValue("@Kichthuoc", sp.Kichthuoc);
                cmd.Parameters.AddWithValue("@Mausac", sp.Mausac);
                cmd.Parameters.AddWithValue("@Dongia", sp.Dongia);

                cmd.ExecuteNonQuery(); // Không cần lấy lại ID nữa
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
    }
}