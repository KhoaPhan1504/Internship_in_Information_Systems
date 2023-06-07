using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so: ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            if (number < 2)
            {
                IsPrime = false;
            }
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write($"{number} la so nguyen to.");
            }
            else
            {
                Console.Write($"{number} khong phai so nguyen to.");
            }
            Console.ReadKey();

        }
    }
}
