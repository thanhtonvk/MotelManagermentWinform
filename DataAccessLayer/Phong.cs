using System.Collections.Generic;
using System.Data;
using QuanLyKiTucXa.DTO;
using QuanLyKiTucXa.Utils;

namespace QuanLyKiTucXa.DAL
{
    public class PhongDAL
    {
        public int Add(PhongDTO dto)
        {
            string query = $"insert into Phong(tang,gia) values({dto.Tang},{dto.Gia})";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(PhongDTO dto)
        {
            string query = $"update Phong set tang = {dto.Tang},gia = {dto.Gia} where id = {dto.Id}";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from Phong where id = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<PhongDTO> GetPhongs()
        {
            List<PhongDTO> phongDtos = new List<PhongDTO>();
            string query = "select * from Phong";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                PhongDTO dto = new PhongDTO();
                dto.Id = int.Parse(row["Id"].ToString());
                dto.Gia = int.Parse(row["Gia"].ToString());
                dto.Tang = int.Parse(row["Tang"].ToString());
                phongDtos.Add(dto);
            }

            return phongDtos;
        }
    }
}