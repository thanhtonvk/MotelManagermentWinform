using System.Collections.Generic;
using System.Linq;
using QuanLyKiTucXa.DAL;
using QuanLyKiTucXa.DTO;

namespace QuanLyKiTucXa.BUS
{
    public class ThuePhongBUS
    {
        private ThuePhongDAL _dal = new ThuePhongDAL();

        public List<ThuePhongDTO> GetList(string tuKhoa)
        {
            return _dal.GetList().Where(x => x.NgayThue.Contains(tuKhoa) || x.HoTenNguoiThue.Contains(tuKhoa)).ToList();
        }

        public string ThuePhong(ThuePhongDTO dto)
        {
            if (_dal.ThuePhong(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string TraPhong(int id)
        {
            if (_dal.TraPhong(id) > 0) return "Thành công";
            return "Thất bại";
        }
    }
}