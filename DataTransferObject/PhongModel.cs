namespace QuanLyKiTucXa.DTO
{
    public class PhongDTO
    {
        private int id, tang, gia;

        public PhongDTO(int id, int tang, int gia)
        {
            this.id = id;
            this.tang = tang;
            this.gia = gia;
        }

        public PhongDTO()
        {
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int Tang
        {
            get => tang;
            set => tang = value;
        }

        public int Gia
        {
            get => gia;
            set => gia = value;
        }
    }
}