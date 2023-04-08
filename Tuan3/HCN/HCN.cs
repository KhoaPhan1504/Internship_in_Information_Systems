using System;
using System.Collections.Generic;
using System.Text;

namespace HCN
{
    class HCN {
        static void Main(string[] args)
        {
            float d, r;
            do
            {
                Console.Write("Nhap chieu dai HCN: ");
                d = float.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong HCN: ");
                r = float.Parse(Console.ReadLine());
                if (d < 0 || r < 0)
                {
                    Console.WriteLine("Nhap lai cho dung!");
                }
            } while (d < 0 || r < 0);
            float CV = (d + r) * 2;
            float S = d * r;
            Console.WriteLine("Chu vi HCN: " + CV);
            Console.WriteLine("Dien tich HCN: " + S);
        }

    }

}

