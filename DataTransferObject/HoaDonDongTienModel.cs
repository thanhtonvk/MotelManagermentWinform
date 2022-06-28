namespace QuanLyKiTucXa.DTO
{
    public class HoaDonDongTienDTO
    {
        private int id;
        private int idPhong;
        private int soDien, soNuoc;
        private string ngayDong;
        private int tienDien, tienNuoc;
        public HoaDonDongTienDTO(int id, int idPhong, int soDien, int soNuoc, string ngayDong)
        {
            this.id = id;
            this.idPhong = idPhong;
            this.soDien = soDien;
            this.soNuoc = soNuoc;
            this.ngayDong = ngayDong;
        }

        public HoaDonDongTienDTO()
        {
        }

       

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int IdPhong
        {
            get => idPhong;
            set => idPhong = value;
        }

        public int SoDien
        {
            get => soDien;
            set => soDien = value;
        }

        public int SoNuoc
        {
            get => soNuoc;
            set => soNuoc = value;
        }

        public string NgayDong
        {
            get => ngayDong;
            set => ngayDong = value;
        }
        public int TienDien => soDien * 2500;

        public int TienNuoc => soNuoc * 3500;
    }
}