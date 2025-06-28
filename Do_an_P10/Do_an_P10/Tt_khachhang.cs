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
        Modify modify= new Modify();
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Tt_khachhang_Load(object sender, EventArgs e)
        {
            tentaikhoan.Text = tentk; // nếu có label để hiển thị
        }
        private void luu_Click(object sender, EventArgs e)
        {
            String hoten = ht.Text;
            String sodt = sdt.Text;
            String diachi = add.Text;
            if(hoten.Trim() == "") { MessageBox.Show("Vui long nhap ho va ten!"); return; }
            else if (sodt.Trim() == "") { MessageBox.Show("Vui long nhap so dien thoai!"); return; }
            else if (diachi.Trim() == "") { MessageBox.Show("Vui long nhap dia chi!"); return; }
            else
            {
                String query = "Insert into khachhang (Hoten, SDT, Diachi, tentaikhoan) values ('"+hoten+"','"+sodt+"','"+diachi+"','"+tentk+"')";
                if (modify.kh(query).Count != 0)
                {
                    MessageBox.Show("Luu thong tin thanh cong!");
                    EcoStraws ecoStraws = new EcoStraws();
                    ecoStraws.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("luu that bai!");
                }
            }
        }
    }
}
