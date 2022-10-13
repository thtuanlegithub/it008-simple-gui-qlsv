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

namespace Bai1
{
    public partial class edit_form : Form
    {
        public edit_form()
        {
            InitializeComponent();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string mssv_can_tim = tb_tim.Text;
            string[] str_data = File.ReadAllLines("data_sinh_vien.txt");
            List<SinhVien> DSSV = new List<SinhVien>();
            for (int i = 0; i < str_data.Length; i++)
            {
                SinhVien sv = new SinhVien();
                string[] str_split = str_data[i].Split('/');
                sv.MSSV = str_split[0];
                sv.HoTen = str_split[1];
                sv.MaLop = str_split[2];
                sv.DTB = double.Parse(str_split[3]);
                DSSV.Add(sv);
            }
            bool KhongTimThay = true;
            for (int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].MSSV == mssv_can_tim)
                {
                    panel1.Visible = true;
                    tb_mssv_hien_thi.Text = DSSV[i].MSSV;
                    tb_hoten_hien_thi.Text = DSSV[i].HoTen;
                    tb_malop_hien_thi.Text = DSSV[i].MaLop;
                    tb_dtb_hien_thi.Text = DSSV[i].DTB.ToString();
                    KhongTimThay = false;
                }
            }
            if (KhongTimThay)
            {
                lb_khong_tim_thay.Visible = true;
            }
        }

        private void bt_edit_luu_Click(object sender, EventArgs e)
        {
            string mssv_can_tim = tb_tim.Text;
            string[] str_data = File.ReadAllLines("data_sinh_vien.txt");
            List<SinhVien> DSSV = new List<SinhVien>();
            for (int i = 0; i < str_data.Length; i++)
            {
                SinhVien sv = new SinhVien();
                string[] str_split = str_data[i].Split('/');
                sv.MSSV = str_split[0];
                sv.HoTen = str_split[1];
                sv.MaLop = str_split[2];
                sv.DTB = double.Parse(str_split[3]);
                DSSV.Add(sv);
            }
            bool KhongTimThay = true;
            for (int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].MSSV == mssv_can_tim)
                {
                    panel1.Visible = true;
                    DSSV[i].MSSV = tb_mssv_hien_thi.Text;
                    DSSV[i].HoTen = tb_hoten_hien_thi.Text;
                    DSSV[i].MaLop = tb_malop_hien_thi.Text;
                    DSSV[i].DTB = double.Parse(tb_dtb_hien_thi.Text);
                    KhongTimThay = false;
                    lb_edit_thanhcong.Visible = true;
                }
            }
            if (!KhongTimThay)
            {
                string[] str_join = new string[DSSV.Count];
                for (int i = 0; i < DSSV.Count; i++)
                {
                    string[] str_temp = { DSSV[i].MSSV, DSSV[i].HoTen, DSSV[i].MaLop, DSSV[i].DTB.ToString() };
                    str_join[i] = String.Join("/", str_temp);
                }
                File.WriteAllLines("data_sinh_vien.txt", str_join);
            }
        }

        private void tb_tim_TextChanged(object sender, EventArgs e)
        {
            tb_dtb_hien_thi.Text = tb_hoten_hien_thi.Text = tb_malop_hien_thi.Text = tb_mssv_hien_thi.Text = "";
            lb_edit_ko_thanhcong.Visible = false;
            lb_edit_thanhcong.Visible = false;
        }

        private void bt_back_to_menu_Click(object sender, EventArgs e)
        {
            main_form f = new main_form();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
