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
    public partial class find_Form : Form
    {
        public find_Form()
        {
            InitializeComponent();
        }

        private void bt_back_to_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form m_f = new main_form();
            m_f.ShowDialog();
            this.Close();
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
            for(int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].MSSV ==mssv_can_tim)
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

        private void tb_tim_TextChanged(object sender, EventArgs e)
        {
            tb_mssv_hien_thi.Text = tb_hoten_hien_thi.Text = tb_malop_hien_thi.Text = tb_dtb_hien_thi.Text = "";
            lb_khong_tim_thay.Visible = false;
        }
    }
}
