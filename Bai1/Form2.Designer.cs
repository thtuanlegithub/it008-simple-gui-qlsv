namespace Bai1
{
    partial class add_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_form));
            this.picBox_main = new System.Windows.Forms.PictureBox();
            this.tb_mssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_malop = new System.Windows.Forms.TextBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dtb = new System.Windows.Forms.TextBox();
            this.bt_back_to_menu = new System.Windows.Forms.Button();
            this.lb_luu_thanh_cong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_main
            // 
            this.picBox_main.Image = ((System.Drawing.Image)(resources.GetObject("picBox_main.Image")));
            this.picBox_main.Location = new System.Drawing.Point(29, 368);
            this.picBox_main.Name = "picBox_main";
            this.picBox_main.Size = new System.Drawing.Size(73, 68);
            this.picBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_main.TabIndex = 2;
            this.picBox_main.TabStop = false;
            // 
            // tb_mssv
            // 
            this.tb_mssv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mssv.Location = new System.Drawing.Point(363, 100);
            this.tb_mssv.Multiline = true;
            this.tb_mssv.Name = "tb_mssv";
            this.tb_mssv.Size = new System.Drawing.Size(242, 31);
            this.tb_mssv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã số sinh viên:";
            // 
            // tb_hoten
            // 
            this.tb_hoten.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hoten.Location = new System.Drawing.Point(363, 171);
            this.tb_hoten.Multiline = true;
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(242, 31);
            this.tb_hoten.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã lớp:";
            // 
            // tb_malop
            // 
            this.tb_malop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_malop.Location = new System.Drawing.Point(363, 236);
            this.tb_malop.Multiline = true;
            this.tb_malop.Name = "tb_malop";
            this.tb_malop.Size = new System.Drawing.Size(242, 31);
            this.tb_malop.TabIndex = 5;
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(312, 399);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(112, 37);
            this.bt_luu.TabIndex = 7;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập thông tin sinh viên cần thêm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điểm trung bình:";
            // 
            // tb_dtb
            // 
            this.tb_dtb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dtb.Location = new System.Drawing.Point(363, 306);
            this.tb_dtb.Multiline = true;
            this.tb_dtb.Name = "tb_dtb";
            this.tb_dtb.Size = new System.Drawing.Size(242, 31);
            this.tb_dtb.TabIndex = 6;
            // 
            // bt_back_to_menu
            // 
            this.bt_back_to_menu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back_to_menu.Location = new System.Drawing.Point(12, 12);
            this.bt_back_to_menu.Name = "bt_back_to_menu";
            this.bt_back_to_menu.Size = new System.Drawing.Size(94, 39);
            this.bt_back_to_menu.TabIndex = 9;
            this.bt_back_to_menu.Text = "Trở về";
            this.bt_back_to_menu.UseVisualStyleBackColor = true;
            this.bt_back_to_menu.Click += new System.EventHandler(this.bt_back_to_menu_Click);
            // 
            // lb_luu_thanh_cong
            // 
            this.lb_luu_thanh_cong.AutoSize = true;
            this.lb_luu_thanh_cong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luu_thanh_cong.ForeColor = System.Drawing.Color.Green;
            this.lb_luu_thanh_cong.Location = new System.Drawing.Point(295, 368);
            this.lb_luu_thanh_cong.Name = "lb_luu_thanh_cong";
            this.lb_luu_thanh_cong.Size = new System.Drawing.Size(159, 23);
            this.lb_luu_thanh_cong.TabIndex = 10;
            this.lb_luu_thanh_cong.Text = "Lưu thành công";
            this.lb_luu_thanh_cong.Visible = false;
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 448);
            this.Controls.Add(this.lb_luu_thanh_cong);
            this.Controls.Add(this.bt_back_to_menu);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dtb);
            this.Controls.Add(this.tb_malop);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.tb_mssv);
            this.Controls.Add(this.picBox_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_main;
        private System.Windows.Forms.TextBox tb_mssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_malop;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dtb;
        private System.Windows.Forms.Button bt_back_to_menu;
        private System.Windows.Forms.Label lb_luu_thanh_cong;
    }
}