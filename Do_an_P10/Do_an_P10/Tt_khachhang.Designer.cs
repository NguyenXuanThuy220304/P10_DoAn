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
            pictureBox1.Location = new Point(576, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(729, 700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.eco;
            pictureBox2.Location = new Point(15, 15);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 199);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 2;
            label1.Text = "Thông tin khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 280);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Họ tên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 366);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 441);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // ht
            // 
            ht.Location = new Point(165, 271);
            ht.Margin = new Padding(4);
            ht.Name = "ht";
            ht.Size = new Size(385, 31);
            ht.TabIndex = 4;
            // 
            // sdt
            // 
            sdt.Location = new Point(165, 358);
            sdt.Margin = new Padding(4);
            sdt.Name = "sdt";
            sdt.Size = new Size(385, 31);
            sdt.TabIndex = 4;
            // 
            // mail
            // 
            mail.Location = new Point(165, 432);
            mail.Margin = new Padding(4);
            mail.Name = "mail";
            mail.Size = new Size(385, 31);
            mail.TabIndex = 4;
            // 
            // luu
            // 
            luu.Location = new Point(435, 606);
            luu.Margin = new Padding(4);
            luu.Name = "luu";
            luu.Size = new Size(118, 36);
            luu.TabIndex = 5;
            luu.Text = "Lưu";
            luu.UseVisualStyleBackColor = true;
            luu.Click += luu_Click;
            // 
            // ttk
            // 
            ttk.Location = new Point(291, 204);
            ttk.Margin = new Padding(4);
            ttk.Name = "ttk";
            ttk.ReadOnly = true;
            ttk.Size = new Size(155, 31);
            ttk.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 528);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ";
            // 
            // ad
            // 
            ad.Location = new Point(165, 525);
            ad.Name = "ad";
            ad.Size = new Size(385, 31);
            ad.TabIndex = 7;
            // 
            // Tt_khachhang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 691);
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
            Margin = new Padding(4);
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