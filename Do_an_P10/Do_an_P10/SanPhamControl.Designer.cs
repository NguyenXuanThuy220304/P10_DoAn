﻿namespace Do_an_P10
{
    partial class SanPhamControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblTenSP = new Label();
            lblGia = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(29, 251);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(50, 20);
            lblTenSP.TabIndex = 1;
            lblTenSP.Text = "label1";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(58, 287);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(50, 20);
            lblGia.TabIndex = 2;
            lblGia.Text = "label1";
            // 
            // SanPhamControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblGia);
            Controls.Add(lblTenSP);
            Controls.Add(pictureBox1);
            Name = "SanPhamControl";
            Size = new Size(219, 331);
            Load += SanPhamControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTenSP;
        private Label lblGia;
    }
}
