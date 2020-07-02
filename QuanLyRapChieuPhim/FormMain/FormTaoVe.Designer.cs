namespace FormMain
{
    partial class FormTaoVe
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
            this.btnInVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbxTenPhim = new System.Windows.Forms.ComboBox();
            this.CBXSuatChieu = new System.Windows.Forms.ComboBox();
            this.CBXSoGhe = new System.Windows.Forms.ComboBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtKhungGio = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInVe
            // 
            this.btnInVe.Location = new System.Drawing.Point(446, 415);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(75, 23);
            this.btnInVe.TabIndex = 0;
            this.btnInVe.Text = "In vé";
            this.btnInVe.UseVisualStyleBackColor = true;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Phim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suất Chiếu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Ghế :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khung giờ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số Lượng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thành Tiền : ";
            // 
            // CbxTenPhim
            // 
            this.CbxTenPhim.FormattingEnabled = true;
            this.CbxTenPhim.Location = new System.Drawing.Point(109, 30);
            this.CbxTenPhim.Name = "CbxTenPhim";
            this.CbxTenPhim.Size = new System.Drawing.Size(209, 21);
            this.CbxTenPhim.TabIndex = 2;
            // 
            // CBXSuatChieu
            // 
            this.CBXSuatChieu.FormattingEnabled = true;
            this.CBXSuatChieu.Location = new System.Drawing.Point(109, 56);
            this.CBXSuatChieu.Name = "CBXSuatChieu";
            this.CBXSuatChieu.Size = new System.Drawing.Size(209, 21);
            this.CBXSuatChieu.TabIndex = 2;
            // 
            // CBXSoGhe
            // 
            this.CBXSoGhe.FormattingEnabled = true;
            this.CBXSoGhe.Location = new System.Drawing.Point(109, 82);
            this.CBXSoGhe.Name = "CBXSoGhe";
            this.CBXSoGhe.Size = new System.Drawing.Size(209, 21);
            this.CBXSoGhe.TabIndex = 2;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(229, 109);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(89, 20);
            this.txtSL.TabIndex = 3;
            // 
            // txtKhungGio
            // 
            this.txtKhungGio.Enabled = false;
            this.txtKhungGio.Location = new System.Drawing.Point(416, 56);
            this.txtKhungGio.Name = "txtKhungGio";
            this.txtKhungGio.Size = new System.Drawing.Size(105, 20);
            this.txtKhungGio.TabIndex = 3;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(142, 159);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(176, 20);
            this.txtThanhTien.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = ".000 VND";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 180);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sơ đồ ghế ngồi";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<< Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormTaoVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtKhungGio);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.CBXSoGhe);
            this.Controls.Add(this.CBXSuatChieu);
            this.Controls.Add(this.CbxTenPhim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInVe);
            this.Name = "FormTaoVe";
            this.Text = "TaoVe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbxTenPhim;
        private System.Windows.Forms.ComboBox CBXSuatChieu;
        private System.Windows.Forms.ComboBox CBXSoGhe;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtKhungGio;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
    }
}