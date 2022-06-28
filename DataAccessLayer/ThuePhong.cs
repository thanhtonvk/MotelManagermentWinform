using System.Collections.Generic;
using System.Data;
using QuanLyKiTucXa.DTO;
using QuanLyKiTucXa.Utils;

namespace QuanLyKiTucXa.DAL
{
    public class ThuePhongDAL
    {
        public List<ThuePhongDTO> GetList()
        {
            string query =
                "select ThuePhong.id, ngaythue, NguoiThue.HoTen, idphongthue,NguoiThue.Id[Id nguoi thue] from ThuePhong,NguoiThue,Phong where ThuePhong.IdNguoiThue= NguoiThue.Id and Phong.Id= ThuePhong.IdPhongThue and TrangThai =1";
            List<ThuePhongDTO> thuePhongDtos = new List<ThuePhongDTO>();
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                ThuePhongDTO dto = new ThuePhongDTO();
                dto.Id = int.Parse(row["Id"].ToString());
                dto.NgayThue = row["NgayThue"].ToString();
                dto.HoTenNguoiThue = row["HoTen"].ToString();
                dto.IdPhongThue = int.Parse(row["IDPhongThue"].ToString());
                dto.IdNguoiThue = int.Parse(row["Id nguoi thue"].ToString());
                thuePhongDtos.Add(dto);
            }

            return thuePhongDtos;
        }

        public int ThuePhong(ThuePhongDTO dto)
        {
            string query =
                $"insert into ThuePhong(NgayThue,IdNguoiThue,IdPhongThue,TrangThai) values('{dto.NgayThue}',{dto.IdNguoiThue},{dto.IdPhongThue},1)";
            return DBHelper.NonQuery(query, null);
        }

        public int TraPhong(int id)
        {
            string query = $"update ThuePhong set TrangThai = 0 where id = {id}";
            return DBHelper.NonQuery(query, null);
        }
    }
}