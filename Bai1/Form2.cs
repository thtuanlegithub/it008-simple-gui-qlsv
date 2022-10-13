using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Bai1
{
    public partial class add_form : Form
    {
        public add_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load data từ txt ra List
            string[] str_data = File.ReadAllLines("data_sinh_vien.txt");
            List<SinhVien> DSSV = new List<SinhVien>();
            for (int i = 0; i < str_data.Length; i++)
            {
                SinhVien _sv = new SinhVien();
                string[] str_split = str_data[i].Split('/');
                _sv.MSSV = str_split[0];
                _sv.HoTen = str_split[1];
                _sv.MaLop = str_split[2];
                _sv.DTB = double.Parse(str_split[3]);
                DSSV.Add(_sv);
            }
            // Kiểm tra trùng
            for(int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].MSSV == tb_mssv.Text)
                {
                    lb_luu_khong_thanh_cong.Visible = true;
                    return;
                }
            }
            // Không trùng, thêm sinh viên vào cuối file
            try
            {
                // Tạo string để lưu vào file
                SinhVien sv = new SinhVien();
                sv.MSSV = tb_mssv.Text.ToString();
                sv.HoTen = tb_hoten.Text.ToString();
                sv.MaLop = tb_malop.Text.ToString();
                sv.DTB = double.Parse(tb_dtb.Text.ToString());
                string[] str = { sv.MSSV, sv.HoTen, sv.MaLop, sv.DTB.ToString() };
                string temp_join = string.Join("/", str);
                string[] temp = { temp_join };
                File.AppendAllLines("data_sinh_vien.txt", temp);
                //Xử lý GUI
                lb_luu_thanh_cong.Visible = true;
                //tb_mssv.Text = tb_hoten.Text = tb_malop.Text = tb_dtb.Text = "";
            }
            catch (Exception ex)
            {
                lb_nhap_khong_hop_le.Visible = true;
                lb_nhap_khong_hop_le.Text = ex.Message;
            }
        }

        private void bt_back_to_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form m_f = new main_form();
            m_f.ShowDialog();
            this.Close();
        }

        private void tb_mssv_TextChanged(object sender, EventArgs e)
        {
            lb_luu_thanh_cong.Visible = false;
            lb_luu_khong_thanh_cong.Visible = false;
            tb_dtb.Text = tb_hoten.Text = tb_malop.Text = "";
        }

        private void tb_hoten_TextChanged(object sender, EventArgs e)
        {
            tb_mssv.Text = tb_malop.Text = tb_dtb.Text = "";
            lb_luu_thanh_cong.Visible = false;
            lb_luu_khong_thanh_cong.Visible = false;
        }

        private void tb_malop_TextChanged(object sender, EventArgs e)
        {
            tb_mssv.Text = tb_mssv.Text = tb_dtb.Text = "";
            lb_luu_thanh_cong.Visible = false;
            lb_luu_khong_thanh_cong.Visible = false;
        }

        private void tb_dtb_TextChanged(object sender, EventArgs e)
        {
            tb_mssv.Text = tb_malop.Text = tb_mssv.Text = "";
            lb_luu_thanh_cong.Visible = false;
            lb_luu_khong_thanh_cong.Visible = false;
        }
    }
}
