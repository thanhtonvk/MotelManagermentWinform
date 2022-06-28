using System.Collections.Generic;
using System.Linq;
using QuanLyKiTucXa.DAL;
using QuanLyKiTucXa.DTO;

namespace QuanLyKiTucXa.BUS
{
    public class HoaDonDongDienBUS
    {
        private HoaDonDongTienDAL _dal = new HoaDonDongTienDAL();

        public List<HoaDonDongTienDTO> GetList(string tuKhoa)
        {
            return _dal.GetList().Where(x => x.NgayDong.Contains(tuKhoa)).ToList();
        }

        public string Add(HoaDonDongTienDTO dto)
        {
            if (_dal.Add(dto) > 0) return "Thành công";
            return "Thất bại";
        }

        public string Update(HoaDonDongTienDTO dto)
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