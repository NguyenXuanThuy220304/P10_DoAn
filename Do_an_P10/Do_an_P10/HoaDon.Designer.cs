namespace Do_an_P10
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            trangt = new TextBox();
            label6 = new Label();
            thanht = new TextBox();
            label5 = new Label();
            date = new TextBox();
            label4 = new Label();
            mad = new TextBox();
            label3 = new Label();
            mak = new TextBox();
            label2 = new Label();
            xuat = new LinkLabel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 7);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 0;
            label1.Text = "Hoá đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(trangt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(thanht);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(date);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(mak);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 38);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(332, 214);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "EcoStrawsHKT";
            // 
            // trangt
            // 
            trangt.Location = new Point(74, 179);
            trangt.Margin = new Padding(3, 2, 3, 2);
            trangt.Name = "trangt";
            trangt.ReadOnly = true;
            trangt.Size = new Size(245, 29);
            trangt.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 187);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 0;
            label6.Text = "Trạng thái";
            label6.Click += label3_Click;
            // 
            // thanht
            // 
            thanht.Location = new Point(74, 129);
            thanht.Margin = new Padding(3, 2, 3, 2);
            thanht.Name = "thanht";
            thanht.ReadOnly = true;
            thanht.Size = new Size(245, 29);
            thanht.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 136);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 0;
            label5.Text = "Thành tiền";
            label5.Click += label3_Click;
            // 
            // date
            // 
            date.Location = new Point(74, 80);
            date.Margin = new Padding(3, 2, 3, 2);
            date.Name = "date";
            date.ReadOnly = true;
            date.Size = new Size(245, 29);
            date.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 0;
            label4.Text = "Ngày";
            label4.Click += label3_Click;
            // 
            // mad
            // 
            mad.Location = new Point(240, 32);
            mad.Margin = new Padding(3, 2, 3, 2);
            mad.Name = "mad";
            mad.ReadOnly = true;
            mad.Size = new Size(79, 29);
            mad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(172, 40);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã đơn";
            label3.Click += label3_Click;
            // 
            // mak
            // 
            mak.Location = new Point(74, 32);
            mak.Margin = new Padding(3, 2, 3, 2);
            mak.Name = "mak";
            mak.ReadOnly = true;
            mak.Size = new Size(79, 29);
            mak.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã khách";
            // 
            // xuat
            // 
            xuat.AutoSize = true;
            xuat.LinkColor = Color.Black;
            xuat.Location = new Point(258, 450);
            xuat.Name = "xuat";
            xuat.Size = new Size(78, 15);
            xuat.TabIndex = 2;
            xuat.TabStop = true;
            xuat.Text = "Xuất hoá đơn";
            xuat.LinkClicked += xuat_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.qr_tt;
            pictureBox1.Location = new Point(98, 256);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(98, 395);
            label7.Name = "label7";
            label7.Size = new Size(150, 15);
            label7.TabIndex = 0;
            label7.Text = "MB Bank: 020722032722411";
            label7.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(108, 410);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 0;
            label8.Text = "Cửa hàng EcoStrawsHKT";
            label8.Click += label3_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 472);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(xuat);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaDon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox mak;
        private Label label2;
        private TextBox mad;
        private Label label3;
        private TextBox trangt;
        private Label label6;
        private TextBox thanht;
        private Label label5;
        private TextBox date;
        private Label label4;
        private LinkLabel xuat;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
    }
}