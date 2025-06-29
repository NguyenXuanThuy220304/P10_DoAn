using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_P10
{
    public partial class tt_muahang : Form
    {
        private sanpham Sanpham;
        private string tentk;
        public tt_muahang(sanpham sp, string tentk)
        {
            InitializeComponent();
            this.tentk = tentk;
            Sanpham = sp;
            gia.Text = sp.Dongia.ToString();
            sl.Text = sp.Soluong.ToString();
            tensp.Text = sp.Tensanpham;
            anh.Image = sp.Hinhanh;
            this.tentk = tentk;
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            EcoStraws eco = new EcoStraws(tentk);
            eco.Show();
            this.Hide();
        }

        private void dh_Click_1(object sender, EventArgs e)
        {
            String query = "Select Hoten, SDT, Diachi from khachhang where tentaikhoan ='" + tentk + "'";
            List<khachhang> ds = modify.kh(query); // trả về List<khachhang>

            if (ds.Count > 0)
            {
                string hoten = ds[0].Hoten;
                string sdt = ds[0].Sdt;
                string tensp = Sanpham.Tensanpham;
                decimal dongia = Sanpham.Dongia;
                int soluong = Sanpham.Soluong;
                decimal thanhtien = dongia * soluong;
                String sql = "Insert into sanpham (Hoten, SDT, Tensanpham, Dongia, Soluong, Thanhtien) values ('" + hoten + "','" + sdt + "','" + tensp + "','" + dongia + "','" + soluong + "','" + thanhtien + "')";
                modify.Commad(sql);
                if (MessageBox.Show("đã lưu thành công giao dịch!", $"Bạn có chắc mua:{tensp}, số lượng:{soluong},Thành tiền:{thanhtien}", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                     {
                        // thêm sản phẩm vào danh sách giỏ hàng (giả sử bạn có List<GioHangItem> gioHang)
                        Giohang item = new Giohang
                        {
                            TenSanPham = Sanpham.Tensanpham,
                            DonGia = Sanpham.Dongia,
                            SoLuong = int.Parse(sl.Text) // hoặc Sanpham.Soluong nếu đã nhập đúng
    }
                        ;
                        GioHangData.Instance.ThemSanPham(item);

                        // mở form giỏ hàng
                            GioHangForm rd = new GioHangForm(tentk); // truyền tên tài khoản nếu cần
                            rd.Show();
                            this.Hide();
        }

    }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }else MessageBox.Show("Không tìm thấy tài khoản khách hàng.");
        }
    }
}
