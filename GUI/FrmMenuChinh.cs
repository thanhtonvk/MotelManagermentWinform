using QuanLyKiTucXa.BUS;
using QuanLyKiTucXa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKiTucXa.GUI
{
    public partial class FrmMenuChinh : Form
    {
        public FrmMenuChinh()
        {
            InitializeComponent();
        }

        private void FrmMenuChinh_Load(object sender, EventArgs e)
        {

            loadData();
        }
        ThuePhongBUS thuePhongBUS = new ThuePhongBUS();
        PhongBUS phongBUS = new PhongBUS();
        NguoiThueBUS nguoiThueBUS = new NguoiThueBUS();
        HoaDonDongDienBUS hoaDonDongDienBUS = new HoaDonDongDienBUS();
        private void loadData()
        {
            dataGridView1.DataSource = phongBUS.GetPhongs("");
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = nguoiThueBUS.GetList("");
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = thuePhongBUS.GetList("");
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.DataSource = hoaDonDongDienBUS.GetList("");
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cb_phong.Items.Clear();
            cb_nguoi.Items.Clear();
            cb_phong_hd.Items.Clear();
            foreach (PhongDTO dto in phongBUS.GetPhongs(""))
            {
                cb_phong.Items.Add(dto);
                cb_phong_hd.Items.Add(dto);
            }
            cb_phong.DisplayMember = "Id";
            cb_phong.ValueMember = "Id";
            cb_phong_hd.DisplayMember = "Id";
            cb_phong_hd.ValueMember = "Id";
            foreach (NguoiThueDTO dto in nguoiThueBUS.GetList(""))
            {
                cb_nguoi.Items.Add(dto);
            }
            cb_nguoi.DisplayMember = "hoTen";
            cb_nguoi.ValueMember = "Id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tuKhoa = tb_timKiem.Text.Trim();
            dataGridView1.DataSource = phongBUS.GetPhongs(tuKhoa);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PhongDTO dto = new PhongDTO();
            dto.Tang = int.Parse(tb_tang.Text.Trim());
            dto.Gia = int.Parse(tb_gia.Text.Trim());
            MessageBox.Show(phongBUS.Add(dto));
            loadData();
        }
        int idPhong = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                tb_tang.Text = row.Cells[0].Value.ToString();
                tb_gia.Text = row.Cells[1].Value.ToString();
                idPhong = int.Parse(row.Cells[2].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idPhong != -1)
            {
                PhongDTO dto = new PhongDTO();
                dto.Tang = int.Parse(tb_tang.Text.Trim());
                dto.Gia = int.Parse(tb_gia.Text.Trim());
                dto.Id = idPhong;
                MessageBox.Show(phongBUS.Update(dto));
                loadData();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idPhong != null)
            {
                MessageBox.Show(phongBUS.Delete(idPhong));
                loadData();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = nguoiThueBUS.GetList(textBox5.Text.Trim());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NguoiThueDTO dTO = new NguoiThueDTO();
            dTO.HoTen = textBox1.Text;
            dTO.NgaySinh = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            dTO.DiaChi = textBox3.Text;
            dTO.SDt = textBox4.Text;
            MessageBox.Show(nguoiThueBUS.Add(dTO));
            loadData();
        }
        int idNguoithue = -1;

        private void button6_Click(object sender, EventArgs e)
        {
            if (idNguoithue != -1)
            {
                NguoiThueDTO dTO = new NguoiThueDTO();
                dTO.HoTen = textBox1.Text;
                dTO.NgaySinh = dateTimePicker2.Value.ToString("MM/dd/yyyy");
                dTO.DiaChi = textBox3.Text;
                dTO.SDt = textBox4.Text;
                MessageBox.Show(nguoiThueBUS.Update(dTO));
                loadData();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (idNguoithue != -1)
            {
                MessageBox.Show(nguoiThueBUS.Delete(idNguoithue));
                loadData();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                idNguoithue = int.Parse(row.Cells[0].Value.ToString());
                textBox1.Text = row.Cells[1].Value.ToString();

                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = thuePhongBUS.GetList(textBox2.Text.Trim());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NguoiThueDTO nguoiThueDTO = cb_nguoi.SelectedItem as NguoiThueDTO;
            PhongDTO phongDTO = cb_phong.SelectedItem as PhongDTO;
            if (nguoiThueDTO != null && phongDTO != null)
            {
                ThuePhongDTO dto = new ThuePhongDTO();
                dto.IdPhongThue = phongDTO.Id;
                dto.IdNguoiThue = nguoiThueDTO.Id;
                dto.NgayThue = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                MessageBox.Show(thuePhongBUS.ThuePhong(dto));
                loadData();

            }
        }
        int idThuePhong = -1;
        private void button10_Click(object sender, EventArgs e)
        {
            NguoiThueDTO nguoiThueDTO = cb_nguoi.SelectedItem as NguoiThueDTO;
            PhongDTO phongDTO = cb_phong.SelectedItem as PhongDTO;
            if (idThuePhong != -1)
            {

                MessageBox.Show(thuePhongBUS.TraPhong(idThuePhong));
                loadData();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                idThuePhong = int.Parse(row.Cells[0].Value.ToString());
                cb_nguoi.Text = row.Cells[4].Value.ToString();
                cb_phong.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = hoaDonDongDienBUS.GetList(textBox6.Text.Trim());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PhongDTO phongDTO = cb_phong_hd.SelectedItem as PhongDTO;
            if (phongDTO != null)
            {
                HoaDonDongTienDTO dto = new HoaDonDongTienDTO();
                dto.IdPhong = phongDTO.Id;
                dto.SoDien = int.Parse(sodien.Text.Trim());
                dto.SoNuoc = int.Parse(tb_sonuoc.Text.Trim());
                dto.NgayDong = dateTimePicker3.Value.ToString("MM/dd/yyyy");
                hoaDonDongDienBUS.Add(dto);
                loadData();
            }
        }
        int idHD = -1;
        private void button14_Click(object sender, EventArgs e)
        {
            PhongDTO phongDTO = cb_phong_hd.SelectedItem as PhongDTO;
            if (phongDTO != null && idHD != -1)
            {
                HoaDonDongTienDTO dto = new HoaDonDongTienDTO();
                dto.Id = idHD;
                dto.IdPhong = phongDTO.Id;
                dto.SoDien = int.Parse(sodien.Text.Trim());
                dto.SoNuoc = int.Parse(tb_sonuoc.Text.Trim());
                dto.NgayDong = dateTimePicker3.Value.ToString("MM/dd/yyyy");
                MessageBox.Show(hoaDonDongDienBUS.Update(dto));
                loadData();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (idHD != -1)
            {

                MessageBox.Show(hoaDonDongDienBUS.Delete(idHD));
                loadData();
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView4.SelectedRows)
            {
                sodien.Text = row.Cells[2].Value.ToString();
                tb_sonuoc.Text = row.Cells[3].Value.ToString();
                idHD= int.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}
