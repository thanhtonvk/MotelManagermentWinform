namespace QuanLyKiTucXa.DTO
{
    public class ThuePhongDTO
    {
        private int id;
        private string ngayThue;
        private int idNguoiThue;
        private int idPhongThue;
        private string hoTenNguoiThue;

        public ThuePhongDTO(int id, string ngayThue, int idNguoiThue, int idPhongThue, string hoTenNguoiThue)
        {
            this.id = id;
            this.ngayThue = ngayThue;
            this.idNguoiThue = idNguoiThue;
            this.idPhongThue = idPhongThue;
            this.hoTenNguoiThue = hoTenNguoiThue;
        }

        public ThuePhongDTO()
        {
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string NgayThue
        {
            get => ngayThue;
            set => ngayThue = value;
        }

        public int IdNguoiThue
        {
            get => idNguoiThue;
            set => idNguoiThue = value;
        }

        public int IdPhongThue
        {
            get => idPhongThue;
            set => idPhongThue = value;
        }

        public string HoTenNguoiThue
        {
            get => hoTenNguoiThue;
            set => hoTenNguoiThue = value;
        }
    }
}