using System;
namespace Khoa.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap so nguyen duong a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen duong b = ");
            b = int.Parse(Console.ReadLine());
            // tinh USCLN cua a và b
            Console.WriteLine("USCLN cua {0} va {1} la: {2}", a, b, USCLN(a, b));
            // tinh BSCNN cua a và b
            Console.WriteLine("USCLN cua {0} va {1} la: {2}", a, b, BSCNN(a, b));

            Console.WriteLine();
            Console.ReadKey();
        }


        /**
        * Tim uoc so chung lon nhat (USCLN)
        */
        static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        /**
         * Tim boi so chung nho nhat (BSCNN)
         */
        static int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }
    }
}