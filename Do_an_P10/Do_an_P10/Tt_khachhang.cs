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
    public partial class Tt_khachhang : Form
    {
        private string tentk;
        public Tt_khachhang(string tentk)
        {
            InitializeComponent();
            this.tentk = tentk;
        }
        Modify modify = new Modify();

        private void Tt_khachhang_Load(object sender, EventArgs e)
        {
            MessageBox.Show("tentk: '" + tentk + "'");
            ttk.Text = tentk; // nếu có label để hiển thị
            ttk.ReadOnly = true;


        }
        private void luu_Click(object sender, EventArgs e)
        {
            String hoten = ht.Text;
            String sodt = sdt.Text;
            String diachi = ad.Text;

            if (hoten.Trim() == "") { MessageBox.Show("Vui lòng nhập họ và tên!"); return; }
            else if (sodt.Trim() == "") { MessageBox.Show("Vui lòng nhập số điện thoại!"); return; }
            else if (diachi.Trim() == "") { MessageBox.Show("Vui lòng nhập địa chỉ!"); return; }

            List<taikhoan> emails = modify.tk($"SELECT * FROM taikhoan WHERE tentaikhoan = '{tentk}'");

            if (emails.Count > 0)
            {
                string Email = emails[0].Email;
                mail.Text = Email;

                string query = $"INSERT INTO khachhang (Hoten, SDT, Diachi, Email, tentaikhoan) " +
                               $"VALUES ('{hoten}', '{sodt}', '{diachi}', '{Email}', '{tentk}')";

                modify.Commad(query);

                if (MessageBox.Show("Lưu thông tin thành công! Bạn có muốn đăng nhập ngay?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    EcoStraws ecoStraws = new EcoStraws(tentk);
                    ecoStraws.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy email.");
            }
        }

        private void Tt_khachhang_Load_1(object sender, EventArgs e)
        {
            ttk.Text = tentk; // nếu có label để hiển thị
            ttk.ReadOnly = true;
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }
    }
}
