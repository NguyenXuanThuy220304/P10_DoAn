namespace Do_an_P10
{
    partial class EcoStraws
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
            gio = new Button();
            linkLabel1 = new LinkLabel();
            t = new TextBox();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panelmathang = new FlowLayoutPanel();
            Tk = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gio
            // 
            gio.BackgroundImage = Properties.Resources.giohanganh;
            gio.BackgroundImageLayout = ImageLayout.Stretch;
            gio.ImageAlign = ContentAlignment.BottomRight;
            gio.Location = new Point(921, 3);
            gio.Name = "gio";
            gio.Size = new Size(43, 43);
            gio.TabIndex = 4;
            gio.UseVisualStyleBackColor = true;
            gio.Click += gio_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(1085, 32);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 22);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = " Đăng xuất";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // t
            // 
            t.BorderStyle = BorderStyle.FixedSingle;
            t.Location = new Point(1016, 5);
            t.Name = "t";
            t.ReadOnly = true;
            t.Size = new Size(153, 27);
            t.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.avt;
            pictureBox2.Location = new Point(969, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(3, 7);
            label10.Name = "label10";
            label10.Size = new Size(346, 53);
            label10.TabIndex = 0;
            label10.Text = "Ecostraws HKT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 63);
            label1.Name = "label1";
            label1.Size = new Size(260, 38);
            label1.TabIndex = 0;
            label1.Text = "Trang mua hàng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(gio);
            panel1.Controls.Add(t);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(21, 23);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 133);
            panel1.TabIndex = 5;
            // 
            // panelmathang
            // 
            panelmathang.AutoScroll = true;
            panelmathang.Location = new Point(21, 214);
            panelmathang.Name = "panelmathang";
            panelmathang.Size = new Size(1178, 700);
            panelmathang.TabIndex = 15;
            // 
            // Tk
            // 
            Tk.Location = new Point(120, 172);
            Tk.Name = "Tk";
            Tk.Size = new Size(1070, 27);
            Tk.TabIndex = 16;
            Tk.TextChanged += Tk_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 175);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 17;
            label11.Text = "Tìm kiếm";
            // 
            // EcoStraws
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1208, 914);
            Controls.Add(label11);
            Controls.Add(Tk);
            Controls.Add(panelmathang);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "EcoStraws";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoStraws";
            Load += EcoStraws_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label10;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private TextBox t;
        private Button gio;
        private Panel panel1;
        private FlowLayoutPanel panelmathang;
        private TextBox Tk;
        private Label label11;
    }
}