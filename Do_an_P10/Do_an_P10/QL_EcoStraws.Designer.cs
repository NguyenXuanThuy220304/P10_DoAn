namespace Do_an_P10
{
    partial class QL_EcoStraws
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
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(12, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 208);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 320);
            button1.Name = "button1";
            button1.Size = new Size(257, 32);
            button1.TabIndex = 2;
            button1.Text = "Khách hàng";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 282);
            button2.Name = "button2";
            button2.Size = new Size(257, 32);
            button2.TabIndex = 2;
            button2.Text = "Sản phẩm";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 358);
            button3.Name = "button3";
            button3.Size = new Size(257, 32);
            button3.TabIndex = 2;
            button3.Text = "Đơn hàng";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 396);
            button4.Name = "button4";
            button4.Size = new Size(257, 32);
            button4.TabIndex = 2;
            button4.Text = "Kho";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 434);
            button5.Name = "button5";
            button5.Size = new Size(257, 32);
            button5.TabIndex = 2;
            button5.Text = "Doanh thu";
            button5.UseVisualStyleBackColor = true;
            // 
            // QL_EcoStraws
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 552);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QL_EcoStraws";
            Text = "QL_EcoStraws";
            TransparencyKey = Color.Black;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}