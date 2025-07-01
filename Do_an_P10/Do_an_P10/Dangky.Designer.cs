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
            label1 = new Label();
            em = new TextBox();
            button1 = new Button();
            label6 = new Label();
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
            nlmk.Location = new Point(268, 212);
            nlmk.Name = "nlmk";
            nlmk.Size = new Size(335, 27);
            nlmk.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 220);
            label4.Name = "label4";
            label4.Size = new Size(147, 19);
            label4.TabIndex = 4;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 267);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(268, 259);
            email.Name = "email";
            email.Size = new Size(335, 27);
            email.TabIndex = 5;
            // 
            // dk
            // 
            dk.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dk.Location = new Point(457, 343);
            dk.Name = "dk";
            dk.Size = new Size(94, 29);
            dk.TabIndex = 6;
            dk.Text = "Đăng ký";
            dk.UseVisualStyleBackColor = true;
            dk.Click += dk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 267);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // em
            // 
            em.Location = new Point(268, 259);
            em.Name = "em";
            em.Size = new Size(335, 27);
            em.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(205, 343);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(231, 42);
            label6.Name = "label6";
            label6.Size = new Size(286, 38);
            label6.TabIndex = 8;
            label6.Text = "Đăng ký tài khoản";
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dk);
            Controls.Add(em);
            Controls.Add(email);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox em;
        private Button button1;
        private Label label6;
    }
}