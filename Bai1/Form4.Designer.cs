namespace Bai1
{
    partial class edit_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_form));
            this.lb_khong_tim_thay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_dtb_hien_thi = new System.Windows.Forms.TextBox();
            this.tb_malop_hien_thi = new System.Windows.Forms.TextBox();
            this.tb_hoten_hien_thi = new System.Windows.Forms.TextBox();
            this.tb_mssv_hien_thi = new System.Windows.Forms.TextBox();
            this.lb_dtb_hien_thi = new System.Windows.Forms.Label();
            this.lb_ma_lop_hien_thi = new System.Windows.Forms.Label();
            this.lb_ho_ten_hien_thi = new System.Windows.Forms.Label();
            this.lb_mssv_hien_thi = new System.Windows.Forms.Label();
            this.lb_thong_tin_sinh_vien = new System.Windows.Forms.Label();
            this.lb_edit_nhap_mssv = new System.Windows.Forms.Label();
            this.tb_tim = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_back_to_menu = new System.Windows.Forms.Button();
            this.bt_edit_luu = new System.Windows.Forms.Button();
            this.lb_edit_thanhcong = new System.Windows.Forms.Label();
            this.lb_edit_ko_thanhcong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_khong_tim_thay
            // 
            this.lb_khong_tim_thay.AutoSize = true;
            this.lb_khong_tim_thay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khong_tim_thay.ForeColor = System.Drawing.Color.Red;
            this.lb_khong_tim_thay.Location = new System.Drawing.Point(195, 25);
            this.lb_khong_tim_thay.Name = "lb_khong_tim_thay";
            this.lb_khong_tim_thay.Size = new System.Drawing.Size(383, 23);
            this.lb_khong_tim_thay.TabIndex = 15;
            this.lb_khong_tim_thay.Text = "Không tìm thấy sinh viên có MSSV vừa nhập";
            this.lb_khong_tim_thay.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_dtb_hien_thi);
            this.panel1.Controls.Add(this.tb_malop_hien_thi);
            this.panel1.Controls.Add(this.tb_hoten_hien_thi);
            this.panel1.Controls.Add(this.tb_mssv_hien_thi);
            this.panel1.Controls.Add(this.lb_dtb_hien_thi);
            this.panel1.Controls.Add(this.lb_ma_lop_hien_thi);
            this.panel1.Controls.Add(this.lb_ho_ten_hien_thi);
            this.panel1.Controls.Add(this.lb_mssv_hien_thi);
            this.panel1.Controls.Add(this.lb_thong_tin_sinh_vien);
            this.panel1.Location = new System.Drawing.Point(34, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 261);
            this.panel1.TabIndex = 20;
            // 
            // tb_dtb_hien_thi
            // 
            this.tb_dtb_hien_thi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dtb_hien_thi.Location = new System.Drawing.Point(176, 206);
            this.tb_dtb_hien_thi.Multiline = true;
            this.tb_dtb_hien_thi.Name = "tb_dtb_hien_thi";
            this.tb_dtb_hien_thi.Size = new System.Drawing.Size(173, 31);
            this.tb_dtb_hien_thi.TabIndex = 2;
            // 
            // tb_malop_hien_thi
            // 
            this.tb_malop_hien_thi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_malop_hien_thi.Location = new System.Drawing.Point(176, 153);
            this.tb_malop_hien_thi.Multiline = true;
            this.tb_malop_hien_thi.Name = "tb_malop_hien_thi";
            this.tb_malop_hien_thi.Size = new System.Drawing.Size(272, 31);
            this.tb_malop_hien_thi.TabIndex = 2;
            // 
            // tb_hoten_hien_thi
            // 
            this.tb_hoten_hien_thi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hoten_hien_thi.Location = new System.Drawing.Point(176, 106);
            this.tb_hoten_hien_thi.Multiline = true;
            this.tb_hoten_hien_thi.Name = "tb_hoten_hien_thi";
            this.tb_hoten_hien_thi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_hoten_hien_thi.Size = new System.Drawing.Size(272, 31);
            this.tb_hoten_hien_thi.TabIndex = 2;
            // 
            // tb_mssv_hien_thi
            // 
            this.tb_mssv_hien_thi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mssv_hien_thi.Location = new System.Drawing.Point(176, 58);
            this.tb_mssv_hien_thi.Multiline = true;
            this.tb_mssv_hien_thi.Name = "tb_mssv_hien_thi";
            this.tb_mssv_hien_thi.Size = new System.Drawing.Size(272, 31);
            this.tb_mssv_hien_thi.TabIndex = 2;
            // 
            // lb_dtb_hien_thi
            // 
            this.lb_dtb_hien_thi.AutoSize = true;
            this.lb_dtb_hien_thi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dtb_hien_thi.Location = new System.Drawing.Point(21, 218);
            this.lb_dtb_hien_thi.Name = "lb_dtb_hien_thi";
            this.lb_dtb_hien_thi.Size = new System.Drawing.Size(146, 19);
            this.lb_dtb_hien_thi.TabIndex = 1;
            this.lb_dtb_hien_thi.Text = "Điểm trung bình:";
            // 
            // lb_ma_lop_hien_thi
            // 
            this.lb_ma_lop_hien_thi.AutoSize = true;
            this.lb_ma_lop_hien_thi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma_lop_hien_thi.Location = new System.Drawing.Point(21, 165);
            this.lb_ma_lop_hien_thi.Name = "lb_ma_lop_hien_thi";
            this.lb_ma_lop_hien_thi.Size = new System.Drawing.Size(69, 19);
            this.lb_ma_lop_hien_thi.TabIndex = 1;
            this.lb_ma_lop_hien_thi.Text = "Mã lớp:";
            // 
            // lb_ho_ten_hien_thi
            // 
            this.lb_ho_ten_hien_thi.AutoSize = true;
            this.lb_ho_ten_hien_thi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ho_ten_hien_thi.Location = new System.Drawing.Point(21, 118);
            this.lb_ho_ten_hien_thi.Name = "lb_ho_ten_hien_thi";
            this.lb_ho_ten_hien_thi.Size = new System.Drawing.Size(69, 19);
            this.lb_ho_ten_hien_thi.TabIndex = 1;
            this.lb_ho_ten_hien_thi.Text = "Họ tên:";
            // 
            // lb_mssv_hien_thi
            // 
            this.lb_mssv_hien_thi.AutoSize = true;
            this.lb_mssv_hien_thi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mssv_hien_thi.Location = new System.Drawing.Point(21, 70);
            this.lb_mssv_hien_thi.Name = "lb_mssv_hien_thi";
            this.lb_mssv_hien_thi.Size = new System.Drawing.Size(60, 19);
            this.lb_mssv_hien_thi.TabIndex = 1;
            this.lb_mssv_hien_thi.Text = "MSSV:";
            // 
            // lb_thong_tin_sinh_vien
            // 
            this.lb_thong_tin_sinh_vien.AutoSize = true;
            this.lb_thong_tin_sinh_vien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thong_tin_sinh_vien.Location = new System.Drawing.Point(126, 20);
            this.lb_thong_tin_sinh_vien.Name = "lb_thong_tin_sinh_vien";
            this.lb_thong_tin_sinh_vien.Size = new System.Drawing.Size(196, 19);
            this.lb_thong_tin_sinh_vien.TabIndex = 0;
            this.lb_thong_tin_sinh_vien.Text = "Sửa thông tin sinh viên";
            // 
            // lb_edit_nhap_mssv
            // 
            this.lb_edit_nhap_mssv.AutoSize = true;
            this.lb_edit_nhap_mssv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_edit_nhap_mssv.Location = new System.Drawing.Point(55, 77);
            this.lb_edit_nhap_mssv.Name = "lb_edit_nhap_mssv";
            this.lb_edit_nhap_mssv.Size = new System.Drawing.Size(284, 19);
            this.lb_edit_nhap_mssv.TabIndex = 19;
            this.lb_edit_nhap_mssv.Text = "Nhập MSSV của sinh viên cần sửa:";
            // 
            // tb_tim
            // 
            this.tb_tim.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tim.Location = new System.Drawing.Point(342, 64);
            this.tb_tim.Multiline = true;
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(287, 34);
            this.tb_tim.TabIndex = 18;
            this.tb_tim.TextChanged += new System.EventHandler(this.tb_tim_TextChanged);
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Location = new System.Drawing.Point(638, 64);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(79, 38);
            this.bt_tim.TabIndex = 17;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_back_to_menu
            // 
            this.bt_back_to_menu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back_to_menu.Location = new System.Drawing.Point(25, 18);
            this.bt_back_to_menu.Name = "bt_back_to_menu";
            this.bt_back_to_menu.Size = new System.Drawing.Size(94, 39);
            this.bt_back_to_menu.TabIndex = 16;
            this.bt_back_to_menu.Text = "Trở về";
            this.bt_back_to_menu.UseVisualStyleBackColor = true;
            this.bt_back_to_menu.Click += new System.EventHandler(this.bt_back_to_menu_Click);
            // 
            // bt_edit_luu
            // 
            this.bt_edit_luu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_luu.Location = new System.Drawing.Point(550, 246);
            this.bt_edit_luu.Name = "bt_edit_luu";
            this.bt_edit_luu.Size = new System.Drawing.Size(146, 49);
            this.bt_edit_luu.TabIndex = 21;
            this.bt_edit_luu.Text = "Lưu thông tin";
            this.bt_edit_luu.UseVisualStyleBackColor = true;
            this.bt_edit_luu.Click += new System.EventHandler(this.bt_edit_luu_Click);
            // 
            // lb_edit_thanhcong
            // 
            this.lb_edit_thanhcong.AutoSize = true;
            this.lb_edit_thanhcong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_edit_thanhcong.ForeColor = System.Drawing.Color.Green;
            this.lb_edit_thanhcong.Location = new System.Drawing.Point(301, 398);
            this.lb_edit_thanhcong.Name = "lb_edit_thanhcong";
            this.lb_edit_thanhcong.Size = new System.Drawing.Size(144, 23);
            this.lb_edit_thanhcong.TabIndex = 22;
            this.lb_edit_thanhcong.Text = "Lưu thành công";
            this.lb_edit_thanhcong.Visible = false;
            // 
            // lb_edit_ko_thanhcong
            // 
            this.lb_edit_ko_thanhcong.AutoSize = true;
            this.lb_edit_ko_thanhcong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_edit_ko_thanhcong.ForeColor = System.Drawing.Color.Red;
            this.lb_edit_ko_thanhcong.Location = new System.Drawing.Point(270, 398);
            this.lb_edit_ko_thanhcong.Name = "lb_edit_ko_thanhcong";
            this.lb_edit_ko_thanhcong.Size = new System.Drawing.Size(202, 23);
            this.lb_edit_ko_thanhcong.TabIndex = 22;
            this.lb_edit_ko_thanhcong.Text = "Lưu không thành công";
            this.lb_edit_ko_thanhcong.Visible = false;
            // 
            // edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 448);
            this.Controls.Add(this.lb_edit_ko_thanhcong);
            this.Controls.Add(this.lb_edit_thanhcong);
            this.Controls.Add(this.bt_edit_luu);
            this.Controls.Add(this.lb_khong_tim_thay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_edit_nhap_mssv);
            this.Controls.Add(this.tb_tim);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.bt_back_to_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_khong_tim_thay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_dtb_hien_thi;
        private System.Windows.Forms.TextBox tb_malop_hien_thi;
        private System.Windows.Forms.TextBox tb_hoten_hien_thi;
        private System.Windows.Forms.TextBox tb_mssv_hien_thi;
        private System.Windows.Forms.Label lb_dtb_hien_thi;
        private System.Windows.Forms.Label lb_ma_lop_hien_thi;
        private System.Windows.Forms.Label lb_ho_ten_hien_thi;
        private System.Windows.Forms.Label lb_mssv_hien_thi;
        private System.Windows.Forms.Label lb_thong_tin_sinh_vien;
        private System.Windows.Forms.Label lb_edit_nhap_mssv;
        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_back_to_menu;
        private System.Windows.Forms.Button bt_edit_luu;
        private System.Windows.Forms.Label lb_edit_thanhcong;
        private System.Windows.Forms.Label lb_edit_ko_thanhcong;
    }
}