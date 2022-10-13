using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai1
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*string[] str_data= File.ReadAllLines("data_sinh_vien.txt");
            List<SinhVien> DSSV = new List<SinhVien>();
            for(int i = 0; i < str_data.Length; i++)
            {
                SinhVien sv = new SinhVien();
                string[] str_split = str_data[i].Split('/');
                sv.MSSV = str_split[0];
                sv.HoTen = str_split[1];
                sv.MaLop = str_split[2];
                sv.DTB = double.Parse(str_split[3]);
                DSSV.Add(sv);
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_form());
            
            /*string[] str_join = new string[DSSV.Count];
            for(int i = 0; i < DSSV.Count; i++)
            {
                string[] str_temp = { DSSV[i].MSSV, DSSV[i].HoTen, DSSV[i].MaLop, DSSV[i].ToString() };
                str_join[i] = String.Join("/", str_temp);
            }*/
        }
    }
}
