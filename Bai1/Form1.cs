using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void bt_them_sinh_vien_Click(object sender, EventArgs e)
        {
            add_form f = new add_form();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void bt_tim_kiem_sinh_vien_Click(object sender, EventArgs e)
        {
            find_Form f = new find_Form();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void bt_sua_sinh_vien_Click(object sender, EventArgs e)
        {
            edit_form f = new edit_form();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
