using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Do_an_P10
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        public bool checkacc(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkemail(string e)
        {
            return Regex.IsMatch(e, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void dk_Click(object sender, EventArgs e)
        {
            String tentk = tk.Text;
            String matk = mk.Text;
            String xacnhanmk = nlmk.Text;
            String Email = email.Text;
            if (!checkacc(tentk)) { MessageBox.Show("vui long nhap ten tai khoan dai 6-24 ky tu, ky tu chu, so, chu hoa, chu thuong"); return; }
            if (!checkacc(matk)) { MessageBox.Show("vui long nhap ten mat khau dai 6-24 ky tu, ky tu chu, so, chu hoa, chu thuong"); return; }
            if (xacnhanmk != matk) { MessageBox.Show("vui long kiem tra lai mat khau"); return; }
            if (!checkemail(Email)) { MessageBox.Show("vui long nhap dung dinh dang email"); return; }
            if (modify.tk("Select * from taikhoan where email = '" + Email + "'").Count != 0) { MessageBox.Show("email nay da duoc su dung!"); return; }
            try
            {
                string query = "Insert into taikhoan values ('" + tentk + "','" + matk + "','" + Email + "')";
                modify.Commad(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập ngay", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                    Dangnhap dangnhap = new Dangnhap();
                    dangnhap.Show();
                }
            }
            catch
            {
                MessageBox.Show("ten tai khoan da duoc su dung! Vui long dang ky ten tai khoan khac.");
            }
        }

        private void Dangky_Load(object sender, EventArgs e)
        {

        }
    }
}
