namespace Do_an_P10
{
    partial class Dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            tk = new TextBox();
            mk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dn = new Button();
            qmk = new LinkLabel();
            dk = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.RosyBrown;
            // 
            // tk
            // 
            tk.Location = new Point(200, 281);
            tk.Name = "tk";
            tk.Size = new Size(281, 27);
            tk.TabIndex = 0;
            // 
            // mk
            // 
            mk.Location = new Point(200, 328);
            mk.Name = "mk";
            mk.Size = new Size(281, 27);
            mk.TabIndex = 1;
            mk.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 286);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(118, 335);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(187, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dn
            // 
            dn.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dn.Location = new Point(243, 413);
            dn.Name = "dn";
            dn.Size = new Size(111, 38);
            dn.TabIndex = 5;
            dn.Text = "Đăng nhập";
            dn.UseVisualStyleBackColor = true;
            dn.Click += dn_Click;
            // 
            // qmk
            // 
            qmk.AutoSize = true;
            qmk.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qmk.Location = new Point(130, 381);
            qmk.Name = "qmk";
            qmk.Size = new Size(98, 17);
            qmk.TabIndex = 6;
            qmk.TabStop = true;
            qmk.Text = "Quên mật khẩu";
            qmk.LinkClicked += qmk_LinkClicked;
            // 
            // dk
            // 
            dk.AutoSize = true;
            dk.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dk.Location = new Point(387, 381);
            dk.Name = "dk";
            dk.Size = new Size(58, 17);
            dk.TabIndex = 7;
            dk.TabStop = true;
            dk.Text = "Đăng ký";
            dk.LinkClicked += dk_LinkClicked_1;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(604, 463);
            Controls.Add(dk);
            Controls.Add(qmk);
            Controls.Add(dn);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mk);
            Controls.Add(tk);
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private ImageList imageList2;
        private TextBox tk;
        private TextBox mk;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button dn;
        private LinkLabel qmk;
        private LinkLabel dk;
    }
}
