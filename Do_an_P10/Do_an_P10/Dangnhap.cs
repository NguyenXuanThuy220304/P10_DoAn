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

        private void dn_Click(object sender, EventArgs e)
        {
            EcoStraws eco = new EcoStraws();   
            eco.Show();
            this.Hide();
        }
    }
}
