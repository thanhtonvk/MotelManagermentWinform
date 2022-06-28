using System.Collections.Generic;
using System.Linq;
using QuanLyKiTucXa.DAL;
using QuanLyKiTucXa.DTO;

namespace QuanLyKiTucXa.BUS
{
    public class PhongBUS
    {
        private PhongDAL _dal = new PhongDAL();

        public List<PhongDTO> GetPhongs(string tuKhoa)
        {
            return _dal.GetPhongs()
                .Where(x => x.Tang.ToString().Contains(tuKhoa) || x.Id.ToString().ToString().Contains(tuKhoa)).ToList();
        }

        public string Add(PhongDTO dto)
        {
            if (_dal.Add(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Update(PhongDTO dto)
        {
            if (_dal.Update(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int id)
        {
            if (_dal.Delete(id) > 0) return "Thành công";
            return "Thất bại";
        }
    }
}