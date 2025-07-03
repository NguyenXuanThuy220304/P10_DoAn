using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            String sql1 = "Select * from khachhang where Tentaikhoan = '" + tentk + "'";
            List<khachhang> k = modify.kh(sql1);
            if (k.Count != 0)
            {
                int maKH = k[0].MaKH;
                int maSP = Sanpham.MaSP;
                string tensp = Sanpham.Tensanpham;
                decimal dongia = Sanpham.Dongia;
                int soluong = Sanpham.Soluong;
                decimal tongTien = Sanpham.Dongia * soluong;
                donhang dh = new donhang(DateTime.Now, maKH, tongTien);
                int maDH = modify.ThemDonHang(dh); // ✅ lấy mã đơn hàng mới
                
                String sql = "Insert into CT_DonHang (MaDH, MaSP, Tensanpham, SoLuong, DonGia) values ('"+maDH+"','"+maSP+"','" + tensp + "','" + soluong + "','" + dongia + "')";
                modify.Commad(sql);
                if (MessageBox.Show("đã lưu thành công giao dịch!", $"Bạn có chắc mua:{tensp}, số lượng:{soluong}", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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

            }
        }
    }
}
