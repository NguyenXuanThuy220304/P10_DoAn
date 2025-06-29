namespace Do_an_P10
{
    partial class tt_muahang
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
            groupBox1 = new GroupBox();
            dh = new Button();
            tensp = new TextBox();
            gia = new TextBox();
            ql = new Button();
            label3 = new Label();
            sl = new ListBox();
            label2 = new Label();
            label1 = new Label();
            anh = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anh).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dh);
            groupBox1.Controls.Add(tensp);
            groupBox1.Controls.Add(gia);
            groupBox1.Controls.Add(ql);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(sl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(anh);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phiếu đặt hàng";
            // 
            // dh
            // 
            dh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dh.Location = new Point(870, 219);
            dh.Name = "dh";
            dh.Size = new Size(91, 29);
            dh.TabIndex = 6;
            dh.Text = "Đặt hàng";
            dh.UseVisualStyleBackColor = true;
            dh.Click += dh_Click_1;
            // 
            // tensp
            // 
            tensp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tensp.Location = new Point(285, 123);
            tensp.Name = "tensp";
            tensp.Size = new Size(240, 30);
            tensp.TabIndex = 5;
            // 
            // gia
            // 
            gia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gia.Location = new Point(285, 39);
            gia.Name = "gia";
            gia.Size = new Size(240, 30);
            gia.TabIndex = 5;
            // 
            // ql
            // 
            ql.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ql.Location = new Point(770, 219);
            ql.Name = "ql";
            ql.Size = new Size(94, 29);
            ql.TabIndex = 4;
            ql.Text = "Quay lại";
            ql.UseVisualStyleBackColor = true;
            ql.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(196, 130);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 3;
            label3.Text = "Mô tả";
            // 
            // sl
            // 
            sl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sl.FormattingEnabled = true;
            sl.ItemHeight = 23;
            sl.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            sl.Location = new Point(285, 82);
            sl.Name = "sl";
            sl.Size = new Size(240, 27);
            sl.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(196, 86);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 42);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 1;
            label1.Text = "Đơn giá";
            // 
            // anh
            // 
            anh.BackgroundImageLayout = ImageLayout.Stretch;
            anh.Location = new Point(31, 42);
            anh.Name = "anh";
            anh.Size = new Size(159, 194);
            anh.SizeMode = PictureBoxSizeMode.StretchImage;
            anh.TabIndex = 0;
            anh.TabStop = false;
            // 
            // tt_muahang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 278);
            Controls.Add(groupBox1);
            Name = "tt_muahang";
            Text = "tt_muahang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox anh;
        private Label label1;
        private ListBox sl;
        private Label label2;
        private Label label3;
        private TextBox tensp;
        private TextBox gia;
        private Button ql;
        private Button dh;
    }
}