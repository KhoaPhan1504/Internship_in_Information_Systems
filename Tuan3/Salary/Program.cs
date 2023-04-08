using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap bac luong: ");
            int bacLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay cong: ");
            int ngayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap phu cap: ");
            int phuCap = int.Parse(Console.ReadLine());
            int NCTL = 0;
            if (ngayCong < 25)
            {
                NCTL = ngayCong;
            }
            else
            {
                NCTL = 25 + (ngayCong - 25) * 2;
            }
            int tienLinh = bacLuong * 1490000 * NCTL + phuCap;
            Console.WriteLine("Tien thuc linh: " + tienLinh);

        }
    }
}
