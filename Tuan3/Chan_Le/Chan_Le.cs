using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan3 { 
    class Chan_Le
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("So nguyen vua nhap la: " + n);
            if (n % 2 == 0)
            {
                if (n > 0)
                    Console.WriteLine("=> n la so chan khong am");
                else
                    Console.WriteLine("=> n la so chan am");
            }
            else
            {
                if (n > 0)
                    Console.WriteLine("=> n la so le khong am");
                else
                    Console.WriteLine("=> n la so le am");
            }

        }

    }

}