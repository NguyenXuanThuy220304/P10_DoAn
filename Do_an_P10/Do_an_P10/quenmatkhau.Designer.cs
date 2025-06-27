namespace Do_an_P10
{
    partial class quenmatkhau
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
            label1 = new Label();
            email = new TextBox();
            mkm = new TextBox();
            label2 = new Label();
            xacnhan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 48);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 0;
            label1.Text = "Email ";
            // 
            // email
            // 
            email.Location = new Point(231, 44);
            email.Name = "email";
            email.Size = new Size(328, 27);
            email.TabIndex = 1;
            // 
            // mkm
            // 
            mkm.Location = new Point(231, 97);
            mkm.Name = "mkm";
            mkm.Size = new Size(328, 27);
            mkm.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 101);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu mới";
            // 
            // xacnhan
            // 
            xacnhan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xacnhan.Location = new Point(296, 153);
            xacnhan.Name = "xacnhan";
            xacnhan.Size = new Size(94, 29);
            xacnhan.TabIndex = 4;
            xacnhan.Text = "Xác nhận";
            xacnhan.UseVisualStyleBackColor = true;
            xacnhan.Click += xacnhan_Click;
            // 
            // quenmatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 194);
            Controls.Add(xacnhan);
            Controls.Add(mkm);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(label1);
            Name = "quenmatkhau";
            Text = "quenmatkhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox email;
        private TextBox mkm;
        private Label label2;
        private Button xacnhan;
    }
}