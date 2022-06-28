using System.Collections.Generic;
using System.Linq;
using QuanLyKiTucXa.DAL;
using QuanLyKiTucXa.DTO;

namespace QuanLyKiTucXa.BUS
{
    public class NguoiThueBUS
    {
        private NguoiThueDAL _dal = new NguoiThueDAL();

        public List<NguoiThueDTO> GetList(string tuKhoa)
        {
            return _dal.GetList()
                .Where(x => x.HoTen.Contains(tuKhoa) || x.NgaySinh.Contains(tuKhoa) || x.DiaChi.Contains(tuKhoa))
                .ToList();
        }

        public string Add(NguoiThueDTO dto)
        {
            if (_dal.Add(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Update(NguoiThueDTO dto)
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