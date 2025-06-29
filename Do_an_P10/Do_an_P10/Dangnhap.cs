using System.Data.SqlClient;

namespace Do_an_P10
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void qmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenmatkhau qmk = new quenmatkhau();
            qmk.Show();
            this.Hide();
        }
        Modify modify = new Modify();

        private void dn_Click(object sender, EventArgs e)
        {
            String tentk = tk.Text;
            String matk = mk.Text;
            if (tentk.Trim() == "") { MessageBox.Show("vui long nhap ten tai khoan!"); return; }
            else if (matk.Trim() == "")
            {
                MessageBox.Show("Vui long nhap mat khau!");
                return;
            }
            else
            {
                string query = "select * from taikhoan where tentaikhoan= '" + tentk + "' and matkhau= '" + matk + "'";
                if (modify.tk(query).Count() != 0)
                {
                    MessageBox.Show("Dang nhap thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tentk.Equals("admin"))
                    {
                        QL_EcoStraws ql = new QL_EcoStraws();
                        ql.Show();
                        this.Hide();
                    }
                    else
                    {
                        String sql = "Select * from khachhang where tentaikhoan = '" + tentk + "' ";
                        if (modify.kh(sql).Count() != 0)
                        {
                            MessageBox.Show("Dang nhap thanh cong!");
                            EcoStraws ec = new EcoStraws(tentk);
                            ec.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Dang nhap thanh cong! Ban chua co thong tin! Vui long nhap thong tin!");
                            Tt_khachhang tt_Khachhang = new Tt_khachhang(tentk);
                            tt_Khachhang.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ten dang nhap hoac mat khau khong chinh xac!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky dk = new Dangky();
            dk.Show();
            this.Hide();
        }

        private void dk_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky dk = new Dangky();
            dk.Show();
            this.Hide();
        }
    }
}
