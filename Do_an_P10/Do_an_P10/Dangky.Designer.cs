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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
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
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(268, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(268, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 27);
            textBox3.TabIndex = 3;
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
            // textBox4
            // 
            textBox4.Location = new Point(268, 255);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(335, 27);
            textBox4.TabIndex = 5;
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
            // textBox5
            // 
            textBox5.Location = new Point(268, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(335, 27);
            textBox5.TabIndex = 5;
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
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Name = "Dangky";
            Text = "Dangky";
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
    }
}