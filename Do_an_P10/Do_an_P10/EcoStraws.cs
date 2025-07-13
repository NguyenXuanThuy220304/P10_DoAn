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
    public partial class EcoStraws : Form
    {
        private string tentk;
        public EcoStraws(string tentk)
        {
            InitializeComponent();
            this.tentk = tentk;
        }
        Modify modify = new Modify();
        private void phi45_Click(object sender, EventArgs e)
        {
            Button phi45 = sender as Button;
            sanpham sp = phi45.Tag as sanpham;

            tt_muahang form = new tt_muahang(sp, tentk);
            form.Show();
            this.Hide();
        }

        private void EcoStraws_Load(object sender, EventArgs e)
        {
            //  t.Text = tentk;
            //  phi45.Tag = new sanpham(1, "Ống hút phi 4,5", 45000, 5000, Properties.Resources.Ong_hut_gao_phi_4_5, "Gạo", "phi 4.5", "trắng");
            //  phi6.Tag = new sanpham(2, "Ống hút phi 6", 55000, 5000, Properties.Resources.Ong_hut_gao_phi_6, "Gạo", "phi 6", "Vàng");
            //  phi8.Tag = new sanpham(3, "Ống hút phi 8", 65000, 5000, Properties.Resources.Ong_hut_gao_phi_8, "Gạo", "phi 8", "hồng");
            //  phi13.Tag = new sanpham(4, "Ống hút phi 13", 75000, 5000, Properties.Resources.Ong_hut_gao_phi_13, "Gạo", "phi 13", "nâu");
            t.Text = tentk;

            // Lấy từ database (không có cột hình ảnh
            string p45 = "SELECT MaSP, TenSP, GiaBan , SoLuongTon, Loai, KichThuoc, MauSac FROM sanpham WHERE KichThuoc LIKE '%phi 4.5%'";
            var list = modify.sp(p45);

            if (list.Count > 0)
            {
                var sp1 = list[0];

                // tự gán hình ảnh
                sp1.Hinhanh = Properties.Resources.Ong_hut_gao_phi_4_5;

                // gán vào Tag
                phi45.Tag = sp1;
            }
            string p6 = "SELECT MaSP, TenSP, GiaBan , SoLuongTon, Loai, KichThuoc, MauSac FROM sanpham WHERE KichThuoc LIKE '%phi 6%'";
            var list1 = modify.sp(p6);

            if (list1.Count > 0)
            {
                var sp2 = list1[0];

                // tự gán hình ảnh
                sp2.Hinhanh = Properties.Resources.Ong_hut_gao_phi_6;

                // gán vào Tag
                phi6.Tag = sp2;
            }
            string p8 = "SELECT MaSP, TenSP, GiaBan , SoLuongTon, Loai, KichThuoc, MauSac FROM sanpham WHERE KichThuoc LIKE '%phi 8%'";
            var list2 = modify.sp(p8);

            if (list2.Count > 0)
            {
                var sp3 = list2[0];

                // tự gán hình ảnh
                sp3.Hinhanh = Properties.Resources.Ong_hut_gao_phi_8;

                // gán vào Tag
                phi8.Tag = sp3;
            }
            string p13 = "SELECT MaSP, TenSP, GiaBan , SoLuongTon, Loai, KichThuoc, MauSac FROM sanpham WHERE KichThuoc LIKE '%phi 13%'";
            var list3 = modify.sp(p13);

            if (list3.Count > 0)
            {
                var sp4 = list3[0];

                // tự gán hình ảnh
                sp4.Hinhanh = Properties.Resources.Ong_hut_gao_phi_13;

                // gán vào Tag
                phi13.Tag = sp4;
            }
        }

        private void phi6_Click(object sender, EventArgs e)
        {
            Button phi6 = sender as Button;
            sanpham sp = phi6.Tag as sanpham;

            tt_muahang form = new tt_muahang(sp, tentk);
            form.Show();
            this.Hide();
        }

        private void phi8_Click(object sender, EventArgs e)
        {
            Button phi8 = sender as Button;
            sanpham sp = phi8.Tag as sanpham;

            tt_muahang form = new tt_muahang(sp, tentk);
            form.Show();
            this.Hide();
        }

        private void phi13_Click(object sender, EventArgs e)
        {
            Button phi13 = sender as Button;
            sanpham sp = phi13.Tag as sanpham;

            tt_muahang form = new tt_muahang(sp, tentk);
            form.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.Show();
        }

        private void gio_Click(object sender, EventArgs e)
        {
            GioHangForm gio = new GioHangForm(tentk);
            gio.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
