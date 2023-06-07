using System;

namespace nhanvien
{
    class NhanVien
    {
        int maso;
        string hoten;

        //phương thức khởi tạo
        public NhanVien()
        {
            maso = 0;
            hoten = " ";
        }

        //Phương thức nhập
        public void Input()
        {
            Console.Write("Nhập mã số: ");
            maso = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: ");
            hoten = Console.ReadLine();
        }

        //Phương thức Show
        public void Show()
        {
            Console.WriteLine("mã số:{0} ; họ tên:{1} ", maso, hoten);
        }

        static void Main(String[] args)
        {
            NhanVien N = new NhanVien();
            N.Input();
            N.Show();
            Console.ReadLine();
        }

    }
}
