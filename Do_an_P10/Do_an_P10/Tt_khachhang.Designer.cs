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
            add = new TextBox();
            luu = new Button();
            tentaikhoan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bg;
            pictureBox1.Location = new Point(461, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 560);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.eco;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 159);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 2;
            label1.Text = "Thông tin khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 224);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Họ tên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 293);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 361);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // ht
            // 
            ht.Location = new Point(132, 217);
            ht.Name = "ht";
            ht.Size = new Size(309, 27);
            ht.TabIndex = 4;
            // 
            // sdt
            // 
            sdt.Location = new Point(132, 286);
            sdt.Name = "sdt";
            sdt.Size = new Size(309, 27);
            sdt.TabIndex = 4;
            // 
            // add
            // 
            add.Location = new Point(132, 354);
            add.Name = "add";
            add.Size = new Size(309, 27);
            add.TabIndex = 4;
            // 
            // luu
            // 
            luu.Location = new Point(347, 427);
            luu.Name = "luu";
            luu.Size = new Size(94, 29);
            luu.TabIndex = 5;
            luu.Text = "Lưu";
            luu.UseVisualStyleBackColor = true;
            luu.Click += luu_Click;
            // 
            // tentaikhoan
            // 
            tentaikhoan.Location = new Point(224, 163);
            tentaikhoan.Name = "tentaikhoan";
            tentaikhoan.Size = new Size(121, 27);
            tentaikhoan.TabIndex = 6;
            // 
            // Tt_khachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 553);
            Controls.Add(tentaikhoan);
            Controls.Add(luu);
            Controls.Add(add);
            Controls.Add(sdt);
            Controls.Add(ht);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Tt_khachhang";
            Text = " ";
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
        private TextBox tentaikhoan;
    }
}