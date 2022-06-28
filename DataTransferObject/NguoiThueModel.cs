namespace QuanLyKiTucXa.DTO
{
    public class NguoiThueDTO
    {
        private int id;
        private string hoTen, ngaySinh, diaChi, sDT;

        public NguoiThueDTO(int id, string hoTen, string ngaySinh, string diaChi, string sDt)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            sDT = sDt;
        }

        public NguoiThueDTO()
        {
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public string NgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public string SDt
        {
            get => sDT;
            set => sDT = value;
        }
    }
}