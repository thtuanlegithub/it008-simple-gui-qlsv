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
    public partial class add_form : Form
    {
        public add_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = tb_mssv.Text.ToString();
            sv.HoTen = tb_hoten.Text.ToString();
            sv.MaLop = tb_malop.Text.ToString();
            sv.DTB = double.Parse(tb_dtb.Text.ToString());
            string[] str = {sv.MSSV,sv.HoTen,sv.MaLop,sv.DTB.ToString()};
            string temp_join = string.Join("/", str);
            string[] temp = { temp_join };
            File.AppendAllLines("data_sinh_vien.txt", temp);
            lb_luu_thanh_cong.Visible = true;
            tb_mssv.Text = tb_hoten.Text = tb_malop.Text = tb_dtb.Text = "";
        }

        private void bt_back_to_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form m_f = new main_form();
            m_f.ShowDialog();
            this.Close();
        }
    }
}
