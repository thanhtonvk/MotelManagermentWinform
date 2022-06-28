using QuanLyPhongTro.BLL;
using QuanLyPhongTro.Presentation;
using QuanLyKiTucXa.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class DangNhapFrm : Form
    {
        public DangNhapFrm()
        {
            InitializeComponent();
        }
        TaiKhoanBLL bll = new TaiKhoanBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            string rs = bll.DangNhap(tb_tendangnhap.Text,tb_matkhau.Text);
            if (rs == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if (rs.Equals("admin"))
                {
                    //mở trang admin
                    this.Hide();
                    AdminFrm frm = new AdminFrm();
                    frm.ShowDialog();
                    this.Show();

                }
                else
                {
                    this.Hide();
                    FrmMenuChinh frm = new FrmMenuChinh();
                    frm.ShowDialog();
                    this.Show();
                    //mở trang nhân viên
                }
            }
        }
    }
}
