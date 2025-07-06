namespace Do_an_P10
{
    partial class Tt_khachhang
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ht = new TextBox();
            sdt = new TextBox();
            mail = new TextBox();
            luu = new Button();
            ttk = new TextBox();
            label5 = new Label();
            ad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bg;
            pictureBox1.Location = new Point(403, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.eco;
            pictureBox2.Location = new Point(10, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 119);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 2;
            label1.Text = "Thông tin khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 168);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Họ tên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 220);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 265);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // ht
            // 
            ht.BorderStyle = BorderStyle.FixedSingle;
            ht.Location = new Point(116, 163);
            ht.Margin = new Padding(3, 2, 3, 2);
            ht.Name = "ht";
            ht.Size = new Size(271, 23);
            ht.TabIndex = 4;
            // 
            // sdt
            // 
            sdt.BorderStyle = BorderStyle.FixedSingle;
            sdt.Location = new Point(116, 215);
            sdt.Margin = new Padding(3, 2, 3, 2);
            sdt.Name = "sdt";
            sdt.Size = new Size(271, 23);
            sdt.TabIndex = 4;
            // 
            // mail
            // 
            mail.BorderStyle = BorderStyle.FixedSingle;
            mail.Location = new Point(116, 259);
            mail.Margin = new Padding(3, 2, 3, 2);
            mail.Name = "mail";
            mail.Size = new Size(271, 23);
            mail.TabIndex = 4;
            // 
            // luu
            // 
            luu.Location = new Point(304, 364);
            luu.Margin = new Padding(3, 2, 3, 2);
            luu.Name = "luu";
            luu.Size = new Size(83, 22);
            luu.TabIndex = 5;
            luu.Text = "Lưu";
            luu.UseVisualStyleBackColor = true;
            luu.Click += luu_Click;
            // 
            // ttk
            // 
            ttk.Location = new Point(204, 122);
            ttk.Margin = new Padding(3, 2, 3, 2);
            ttk.Name = "ttk";
            ttk.ReadOnly = true;
            ttk.Size = new Size(110, 23);
            ttk.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 317);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ";
            // 
            // ad
            // 
            ad.BorderStyle = BorderStyle.FixedSingle;
            ad.Location = new Point(116, 315);
            ad.Margin = new Padding(2, 2, 2, 2);
            ad.Name = "ad";
            ad.Size = new Size(271, 23);
            ad.TabIndex = 7;
            // 
            // Tt_khachhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 415);
            Controls.Add(ad);
            Controls.Add(ttk);
            Controls.Add(luu);
            Controls.Add(mail);
            Controls.Add(sdt);
            Controls.Add(ht);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Tt_khachhang";
            Text = " ";
            Load += Tt_khachhang_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ht;
        private TextBox sdt;
        private TextBox add;
        private Button luu;
        private TextBox ttk;
        private TextBox mail;
        private Label label5;
        private TextBox textBox1;
        private TextBox ad;
    }
}