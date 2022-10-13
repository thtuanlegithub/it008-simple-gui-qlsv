namespace Bai1
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.lb_QLSV = new System.Windows.Forms.Label();
            this.picBox_main = new System.Windows.Forms.PictureBox();
            this.bt_them_sinh_vien = new System.Windows.Forms.Button();
            this.bt_tim_kiem_sinh_vien = new System.Windows.Forms.Button();
            this.bt_sua_sinh_vien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_QLSV
            // 
            this.lb_QLSV.AutoSize = true;
            this.lb_QLSV.BackColor = System.Drawing.Color.Transparent;
            this.lb_QLSV.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QLSV.Location = new System.Drawing.Point(273, 40);
            this.lb_QLSV.Name = "lb_QLSV";
            this.lb_QLSV.Size = new System.Drawing.Size(216, 29);
            this.lb_QLSV.TabIndex = 0;
            this.lb_QLSV.Text = "Quản lý sinh viên";
            // 
            // picBox_main
            // 
            this.picBox_main.Image = ((System.Drawing.Image)(resources.GetObject("picBox_main.Image")));
            this.picBox_main.Location = new System.Drawing.Point(68, 114);
            this.picBox_main.Name = "picBox_main";
            this.picBox_main.Size = new System.Drawing.Size(274, 270);
            this.picBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_main.TabIndex = 1;
            this.picBox_main.TabStop = false;
            // 
            // bt_them_sinh_vien
            // 
            this.bt_them_sinh_vien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them_sinh_vien.Location = new System.Drawing.Point(447, 114);
            this.bt_them_sinh_vien.Name = "bt_them_sinh_vien";
            this.bt_them_sinh_vien.Size = new System.Drawing.Size(193, 51);
            this.bt_them_sinh_vien.TabIndex = 0;
            this.bt_them_sinh_vien.Text = "Thêm sinh viên";
            this.bt_them_sinh_vien.UseVisualStyleBackColor = true;
            this.bt_them_sinh_vien.Click += new System.EventHandler(this.bt_them_sinh_vien_Click);
            // 
            // bt_tim_kiem_sinh_vien
            // 
            this.bt_tim_kiem_sinh_vien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim_kiem_sinh_vien.Location = new System.Drawing.Point(447, 217);
            this.bt_tim_kiem_sinh_vien.Name = "bt_tim_kiem_sinh_vien";
            this.bt_tim_kiem_sinh_vien.Size = new System.Drawing.Size(193, 51);
            this.bt_tim_kiem_sinh_vien.TabIndex = 1;
            this.bt_tim_kiem_sinh_vien.Text = "Tìm kiếm sinh viên";
            this.bt_tim_kiem_sinh_vien.UseVisualStyleBackColor = true;
            this.bt_tim_kiem_sinh_vien.Click += new System.EventHandler(this.bt_tim_kiem_sinh_vien_Click);
            // 
            // bt_sua_sinh_vien
            // 
            this.bt_sua_sinh_vien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua_sinh_vien.Location = new System.Drawing.Point(447, 319);
            this.bt_sua_sinh_vien.Name = "bt_sua_sinh_vien";
            this.bt_sua_sinh_vien.Size = new System.Drawing.Size(193, 51);
            this.bt_sua_sinh_vien.TabIndex = 2;
            this.bt_sua_sinh_vien.Text = "Sửa thông tin";
            this.bt_sua_sinh_vien.UseVisualStyleBackColor = true;
            this.bt_sua_sinh_vien.Click += new System.EventHandler(this.bt_sua_sinh_vien_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 448);
            this.Controls.Add(this.bt_sua_sinh_vien);
            this.Controls.Add(this.bt_tim_kiem_sinh_vien);
            this.Controls.Add(this.bt_them_sinh_vien);
            this.Controls.Add(this.picBox_main);
            this.Controls.Add(this.lb_QLSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_QLSV;
        private System.Windows.Forms.PictureBox picBox_main;
        private System.Windows.Forms.Button bt_them_sinh_vien;
        private System.Windows.Forms.Button bt_tim_kiem_sinh_vien;
        private System.Windows.Forms.Button bt_sua_sinh_vien;
    }
}

