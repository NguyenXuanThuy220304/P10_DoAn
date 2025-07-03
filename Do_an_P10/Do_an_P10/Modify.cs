using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Do_an_P10
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlCommand;// truy vaans
        SqlDataReader dataReader; //dùng để đặt dữ liệu trong bảng
        
        public List<khachhang> kh(string query)
        {
            List<khachhang>  kh= new List<khachhang>();
            using (SqlConnection sqlConnection = ketnoi.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query , sqlConnection);
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
            List<donhang> dh= new List<donhang>();
            using(SqlConnection sqlConnection = ketnoi.GetSqlConnection())
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
    }
}





