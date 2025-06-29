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
                    kh.Add(new khachhang(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2)));
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
                    tk.Add(new taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }

                sqlConnection.Close();
            }
            return tk;
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





