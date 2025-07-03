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
            dn = new Button();
            qmk = new LinkLabel();
            dk = new LinkLabel();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
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
            tk.Anchor = AnchorStyles.None;
            tk.Location = new Point(282, 159);
            tk.Name = "tk";
            tk.Size = new Size(281, 27);
            tk.TabIndex = 0;
            // 
            // mk
            // 
            mk.Anchor = AnchorStyles.None;
            mk.Location = new Point(282, 206);
            mk.Name = "mk";
            mk.Size = new Size(281, 27);
            mk.TabIndex = 1;
            mk.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 164);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 213);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // dn
            // 
            dn.Anchor = AnchorStyles.None;
            dn.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dn.Location = new Point(330, 309);
            dn.Name = "dn";
            dn.Size = new Size(111, 38);
            dn.TabIndex = 5;
            dn.Text = "Đăng nhập";
            dn.UseVisualStyleBackColor = true;
            dn.Click += dn_Click;
            // 
            // qmk
            // 
            qmk.Anchor = AnchorStyles.None;
            qmk.AutoSize = true;
            qmk.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qmk.Location = new Point(212, 259);
            qmk.Name = "qmk";
            qmk.Size = new Size(98, 17);
            qmk.TabIndex = 6;
            qmk.TabStop = true;
            qmk.Text = "Quên mật khẩu";
            qmk.LinkClicked += qmk_LinkClicked;
            // 
            // dk
            // 
            dk.Anchor = AnchorStyles.None;
            dk.AutoSize = true;
            dk.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dk.Location = new Point(469, 259);
            dk.Name = "dk";
            dk.Size = new Size(58, 17);
            dk.TabIndex = 7;
            dk.TabStop = true;
            dk.Text = "Đăng ký";
            dk.LinkClicked += dk_LinkClicked_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dn);
            panel1.Controls.Add(dk);
            panel1.Controls.Add(tk);
            panel1.Controls.Add(qmk);
            panel1.Controls.Add(mk);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(56, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 400);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(302, 62);
            label3.Name = "label3";
            label3.Size = new Size(178, 38);
            label3.TabIndex = 8;
            label3.Text = "Đăng nhập";
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.lua;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(901, 463);
            Controls.Add(panel1);
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Dangnhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private ImageList imageList2;
        private TextBox tk;
        private TextBox mk;
        private Label label1;
        private Label label2;
        private Button dn;
        private LinkLabel qmk;
        private LinkLabel dk;
        private Panel panel1;
        private Label label3;
    }
}
