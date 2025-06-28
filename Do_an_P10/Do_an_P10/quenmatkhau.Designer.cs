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
            // xacnhan
            // 
            xacnhan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xacnhan.Location = new Point(297, 139);
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
        private Button xacnhan;
    }
}