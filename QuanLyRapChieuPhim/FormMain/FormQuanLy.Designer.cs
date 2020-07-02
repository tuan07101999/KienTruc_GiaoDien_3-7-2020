namespace FormMain
{
    partial class FormQuanLy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnThemSuatChieu = new System.Windows.Forms.Button();
            this.BtnThemPhim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(539, 342);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(132, 23);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnThemSuatChieu
            // 
            this.btnThemSuatChieu.Location = new System.Drawing.Point(420, 303);
            this.btnThemSuatChieu.Name = "btnThemSuatChieu";
            this.btnThemSuatChieu.Size = new System.Drawing.Size(108, 23);
            this.btnThemSuatChieu.TabIndex = 1;
            this.btnThemSuatChieu.Text = "Thêm Suất Chiếu";
            this.btnThemSuatChieu.UseVisualStyleBackColor = true;
            // 
            // BtnThemPhim
            // 
            this.BtnThemPhim.Location = new System.Drawing.Point(15, 303);
            this.BtnThemPhim.Name = "BtnThemPhim";
            this.BtnThemPhim.Size = new System.Drawing.Size(93, 23);
            this.BtnThemPhim.TabIndex = 1;
            this.BtnThemPhim.Text = "Thêm Phim";
            this.BtnThemPhim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phim đươc chiếu trong ngày";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(420, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(390, 272);
            this.dataGridView2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ">>>>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Suất chiếu trong ngày";
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(677, 342);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(132, 23);
            this.btnThongKeDoanhThu.TabIndex = 1;
            this.btnThongKeDoanhThu.Text = "Thông Kê Doanh Thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(12, 342);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(93, 23);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "<< Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.BtnThemPhim);
            this.Controls.Add(this.btnThemSuatChieu);
            this.Controls.Add(this.btnThongKeDoanhThu);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormQuanLy";
            this.Text = "FormQuanLy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnThemSuatChieu;
        private System.Windows.Forms.Button BtnThemPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnQuayLai;
    }
}