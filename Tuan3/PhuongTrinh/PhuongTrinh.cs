using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinh
{
    internal class PhuongTrinh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong trinh: ax^2 + bx +c = 0");
            Console.Write("Nhap a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            float c = float.Parse(Console.ReadLine());
            float delta = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("Phuogn trinh bac nhat co 1 nghiem x = " + (float)-c / b);
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = " + (float)-b / (2 * a));
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: " + "x1 = " + x1 + " && " + "x2 = " + x2);

                }
            }


        }
    }
}
