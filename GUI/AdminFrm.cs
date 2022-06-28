using QuanLyPhongTro.BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.Presentation
{
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
        }
        TaiKhoanBLL bll = new TaiKhoanBLL();
      

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            dgv_taikhoan.DataSource = bll.GetAll("");
            dgv_taikhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_taikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                TenDangNhap = tb_tendangnhap.Text.Trim(),
                MatKhau = tb_matkhau.Text.Trim(),
                LoaiTK = tb_loaitk.Text.Trim()
            };
            string rs = bll.Add(taiKhoan);
            MessageBox.Show(rs);
            dgv_taikhoan.DataSource = bll.GetAll("");
        }

        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_taikhoan.SelectedRows)
            {
                tb_tendangnhap.Text = row.Cells[0].Value.ToString();
                tb_matkhau.Text = row.Cells[1].Value.ToString();
                tb_loaitk.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                TenDangNhap = tb_tendangnhap.Text.Trim(),
                MatKhau = tb_matkhau.Text.Trim(),
                LoaiTK = tb_loaitk.Text.Trim()
            };
            string rs = bll.Update(taiKhoan);
            MessageBox.Show(rs);
            dgv_taikhoan.DataSource = bll.GetAll("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rs = bll.Delete(tb_tendangnhap.Text.Trim());
            MessageBox.Show(rs);
            dgv_taikhoan.DataSource = bll.GetAll("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgv_taikhoan.DataSource = bll.GetAll(tb_tim_tk.Text.Trim());
        }

    
    }
}
