using System;

namespace PTB1
{
    class PTB1
    {
        //kiểu không chứa tham số
        /*double a, b;

        //constructor khong co tham so
        public PTB1()
        {
            a = 0; b = 0;
        }

        //phuong thuc nhap he so
        public void Nhapheso()
        {
            Console.Write("Nhap he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            b = double.Parse(Console.ReadLine());
        }

        //phuong thuc giai phuong trinh
        public string GiaiPT()
        {
            string kq;
            if (a != 0)
                kq = "X = " + (-b / a);
            else if (b == 0)
                kq = "PT vo so nghiem";
            else
                kq = "Pt vo nghiem";
            return (kq);
        }
        static void Main(string[] args)
        {
            PTB1 ptb1 = new PTB1();
            ptb1.Nhapheso();
            Console.Write("Nghiem cua phuong trinh la: " + ptb1.GiaiPT());
        }*/

        //kiểu chứa tham số
        double a1, b1;
        public PTB1()
        {
            a1 = 0; b1 = 0;
        }

        //Phuong thuc nhap he so
        public void Nhapheso1(out double a1, out double b1)
        {
            Console.Write("Nhapp he so a1: ");
            a1 = double.Parse(Console.ReadLine());
            Console.Write("Nhapp he so b1: ");
            b1 = double.Parse(Console.ReadLine());
        }

        //phuong thuc giai pt
        public string GiaiPT1(double a1, double b1)
        {
            string kq1;
            if (a1 != 0)
                kq1 = "X = " + (-b1 / a1);
            else if (b1 == 0)
                kq1 = "PT vo so nghiem";
            else
                kq1 = "Pt vo nghiem";
            return (kq1);
        }
        static void Main(string[] args)
        {
            double x = 0, y = 0;
            PTB1 ptb1 = new PTB1();
            ptb1.Nhapheso1(out x, out y);
            string nghiem = ptb1.GiaiPT1(x, y);
            Console.Write("Nghiem cua pt la: " + nghiem);
            Console.Read();
        }
    }
}
