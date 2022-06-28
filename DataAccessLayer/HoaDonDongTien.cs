using System.Collections.Generic;
using System.Data;
using QuanLyKiTucXa.DTO;
using QuanLyKiTucXa.Utils;

namespace QuanLyKiTucXa.DAL
{
    public class HoaDonDongTienDAL
    {
        public int Add(HoaDonDongTienDTO dto)
        {
            string query =
                $"insert into HoaDonDongTien(IdPhong,SoDien,SoNuoc,NgayDong) values({dto.IdPhong},{dto.SoDien},{dto.SoNuoc},'{dto.NgayDong}')";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(HoaDonDongTienDTO dto)
        {
            string query =
                $"update HoaDonDongTien set IdPhong = {dto.IdPhong},SoDien = {dto.SoDien},SoNuoc = {dto.SoNuoc},NgayDong = '{dto.NgayDong}' where id = {dto.Id}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from HoaDonDongTien where id = '{id}'";
            return DBHelper.NonQuery(query, null);
        }

        public List<HoaDonDongTienDTO> GetList()
        {
            List<HoaDonDongTienDTO> dongTienDtos = new List<HoaDonDongTienDTO>();
            string query = "select * from HoaDonDongTien";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                HoaDonDongTienDTO dto = new HoaDonDongTienDTO();
                dto.Id = int.Parse(row["Id"].ToString());
                dto.IdPhong = int.Parse(row["IdPhong"].ToString());
                dto.NgayDong = row["NgayDong"].ToString();
                dto.SoDien = int.Parse(row["SoDien"].ToString());
                dto.SoNuoc = int.Parse(row["SoNuoc"].ToString());
                dongTienDtos.Add(dto);
            }

            return dongTienDtos;
        }
    }
}