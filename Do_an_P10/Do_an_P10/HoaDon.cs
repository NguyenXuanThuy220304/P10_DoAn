using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Do_an_P10
{
    public partial class HoaDon : Form
    {
        private int maKH;
        private int maDH;
        private string tentk;
        public HoaDon(int maKH, int maDH, string tentk)
        {
            InitializeComponent();
            this.maKH = maKH;
            this.maDH = maDH;
            this.tentk = tentk;
            LoadHoaDon();
        }
        private void LoadHoaDon()
        {
            var dtDonHang = Modify.LayDonHang(maDH);
            var dtChiTiet = Modify.LayChiTietDonHang(maDH);
            var dtKhachHang = Modify.LayThongTinKhachHang(maKH);

            if (dtDonHang.Rows.Count > 0)
            {
                var rowDH = dtDonHang.Rows[0];
                mak.Text = rowDH["maKH"].ToString();
                mad.Text = rowDH["maDH"].ToString();
                date.Text = Convert.ToDateTime(rowDH["NgayLap"]).ToString("dd/MM/yyyy");
                thanht.Text = string.Format("{0:N0} đ", rowDH["TongTien"]);
                trangt.Text = rowDH["TrangThai"].ToString();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void xuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modify.CapNhatTrangThaiDonHang(maDH, "Đã thanh toán");

            MessageBox.Show("Hóa đơn đã được xuất và cập nhật trạng thái thành 'Đã thanh toán'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // (Tùy chọn) làm mới lại giao diện nếu cần:
            LoadHoaDon();
            EcoStraws eco = new EcoStraws(tentk);
            eco.Show();
            this.Close();   
        }
    }
}
