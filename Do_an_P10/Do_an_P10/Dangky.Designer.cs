namespace Do_an_P10
{
    partial class Dangky
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
            label2 = new Label();
            tk = new TextBox();
            mk = new TextBox();
            label3 = new Label();
            nlmk = new TextBox();
            label4 = new Label();
            label5 = new Label();
            email = new TextBox();
            dk = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 133);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản";
            // 
            // tk
            // 
            tk.Location = new Point(268, 125);
            tk.Name = "tk";
            tk.Size = new Size(335, 27);
            tk.TabIndex = 1;
            // 
            // mk
            // 
            mk.Location = new Point(268, 166);
            mk.Name = "mk";
            mk.Size = new Size(335, 27);
            mk.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 174);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // nlmk
            // 
            nlmk.Location = new Point(268, 255);
            nlmk.Name = "nlmk";
            nlmk.Size = new Size(335, 27);
            nlmk.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 263);
            label4.Name = "label4";
            label4.Size = new Size(147, 19);
            label4.TabIndex = 4;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 220);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(268, 212);
            email.Name = "email";
            email.Size = new Size(335, 27);
            email.TabIndex = 5;
            // 
            // dk
            // 
            dk.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dk.Location = new Point(330, 351);
            dk.Name = "dk";
            dk.Size = new Size(94, 29);
            dk.TabIndex = 6;
            dk.Text = "Đăng ký";
            dk.UseVisualStyleBackColor = true;
            dk.Click += dk_Click;
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(dk);
            Controls.Add(email);
            Controls.Add(nlmk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(mk);
            Controls.Add(label3);
            Controls.Add(tk);
            Controls.Add(label2);
            Name = "Dangky";
            Text = "Dangky";
            Load += Dangky_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Button dk;
        private TextBox tk;
        private TextBox mk;
        private TextBox email;
        private TextBox nlmk;
    }
}