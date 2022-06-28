using System.Collections.Generic;
using System.Data;
using QuanLyKiTucXa.DTO;
using QuanLyKiTucXa.Utils;

namespace QuanLyKiTucXa.DAL
{
    public class NguoiThueDAL
    {
        public int Add(NguoiThueDTO dto)
        {
            string query =
                $"insert into NguoiThue(HoTen,NgaySinh,DiaChi,SDT) values (N'{dto.HoTen}',N'{dto.NgaySinh}',N'{dto.DiaChi}',N'{dto.SDt}')";
            return DBHelper.NonQuery(query, null);
        }

        public int Delete(int id)
        {
            string query = $"delete from NguoiThue where id = {id}";
            return DBHelper.NonQuery(query, null);
        }

        public int Update(NguoiThueDTO dto)
        {
            string query =
                $"update NguoiThue set HoTen = N'{dto.HoTen}',NgaySinh = N'{dto.NgaySinh}', DiaChi = N'{dto.DiaChi}',SDT = '{dto.SDt}' where Id = {dto.Id}";
            return DBHelper.NonQuery(query, null);
        }

        public List<NguoiThueDTO> GetList()
        {
            string query = "select * from NguoiThue";
            List<NguoiThueDTO> nguoiThueDtos = new List<NguoiThueDTO>();
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                NguoiThueDTO dto = new NguoiThueDTO();
                dto.Id = int.Parse(row["Id"].ToString());
                dto.HoTen = row["HoTen"] as string;
                dto.DiaChi = row["DiaChi"] as string;
                dto.NgaySinh = row["NgaySinh"] as string;
                dto.SDt = row["SDT"] as string;
                nguoiThueDtos.Add(dto);
            }

            return nguoiThueDtos;
        }
    }
}