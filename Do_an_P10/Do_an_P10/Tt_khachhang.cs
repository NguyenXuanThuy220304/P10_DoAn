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
        private void label2_Click(object sender, EventArgs e)
        {

        }
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
            String diachi = add.Text;
            List<taikhoan> emails = modify.tk($"SELECT Email FROM taikhoan WHERE tentaikhoan = '{tentk}'");

            if (emails.Count > 0)
            {
                string Email = emails[0].Email;  // Lấy email đầu tiên
                mail.Text = Email;

                string insert = $"INSERT INTO khachhang (email) VALUES ('{Email}')";
                modify.Commad(insert);
            }
            else
            {
                MessageBox.Show("Không tìm thấy email.");
            }

            if (hoten.Trim() == "") { MessageBox.Show("Vui long nhap ho va ten!"); return; }
            else if (sodt.Trim() == "") { MessageBox.Show("Vui long nhap so dien thoai!"); return; }
            else if (diachi.Trim() == "") { MessageBox.Show("Vui long nhap dia chi!"); return; }
            else 
            {
                String query = "Insert into khachhang (Hoten, SDT, Diachi,Email, tentaikhoan) values ('" + hoten + "','" + sodt + "','" + diachi + "','"+mail+"', '" + tentk + "')";
                modify.Commad(query);
                if (MessageBox.Show("Lưu thông tin thành công! Bạn có muốn đăng nhập ngay", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    EcoStraws ecoStraws = new EcoStraws(tentk);
                    ecoStraws.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("luu that bai!");
                }
            }
        }

        private void Tt_khachhang_Load_1(object sender, EventArgs e)
        {
            ttk.Text = tentk; // nếu có label để hiển thị
            ttk.ReadOnly = true;
        }

    }
}
