﻿namespace Client
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtOTP = new TextBox();
            btnAuthen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(301, 276);
            label1.Name = "label1";
            label1.Size = new Size(1406, 81);
            label1.TabIndex = 3;
            label1.Text = "Nhập mã xác thực OTP đã gửi đến Email của bạn";
            // 
            // txtOTP
            // 
            txtOTP.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOTP.ForeColor = Color.Chocolate;
            txtOTP.Location = new Point(647, 515);
            txtOTP.Multiline = true;
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(625, 78);
            txtOTP.TabIndex = 4;
            txtOTP.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAuthen
            // 
            btnAuthen.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuthen.ForeColor = Color.Chocolate;
            btnAuthen.Location = new Point(647, 732);
            btnAuthen.Name = "btnAuthen";
            btnAuthen.Size = new Size(625, 117);
            btnAuthen.TabIndex = 5;
            btnAuthen.Text = "Xác thực";
            btnAuthen.UseVisualStyleBackColor = true;
            btnAuthen.Click += btnAuthen_Click;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 950);
            Controls.Add(btnAuthen);
            Controls.Add(txtOTP);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Authentication";
            Text = "Authentication";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtOTP;
        private Button btnAuthen;
    }
}