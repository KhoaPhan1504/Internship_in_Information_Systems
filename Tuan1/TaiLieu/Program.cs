using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaiLieu
{
    class Program
    {

        static void nhapsach(List<sach> dsSach)
        {
            Console.WriteLine("Them sach ");
            Console.WriteLine("Nhap so luong nhap :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sach a = new sach();
                a.Input();
                dsSach.Add(a);
            }
        }
        static void nhapbao(List<bao> dsBao)
        {
            Console.WriteLine("Them bao ");
            Console.WriteLine("Nhap so luong nhap :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                bao a = new bao();
                a.Input();
                dsBao.Add(a);
            }
        }
        static void nhaptailieu(List<tapchi> dsTapChi)
        {
            Console.WriteLine("Them tap chi ");
            Console.WriteLine("Nhap so luong nhap :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                tapchi a = new tapchi();
                a.Input();
                dsTapChi.Add(a);
            }
        }
        static void Show(List<sach> dsSach, List<bao> dsBao, List<tapchi> dsTapChi)
        {
            foreach (sach a in dsSach)
            {
                Console.WriteLine("Sach : ");
                a.Output();
                Console.WriteLine("---------------------------");
            }
            foreach (bao a in dsBao)
            {
                Console.WriteLine("Bao : ");
                a.Output();
                Console.WriteLine("---------------------------");
            }
            foreach (tapchi a in dsTapChi)
            {
                Console.WriteLine("Tap chi : ");
                a.Output();
                Console.WriteLine("---------------------------");
            }
            Console.ReadLine();
        }
        //static void Xoa(List<TaiLieu> tailieu)
        //{
        //    Console.Write("ma tai lieu: ");
        //    string maTl = Console.ReadLine();
        //    foreach (TaiLieu a in tailieu)
        //    {
        //        if (String.Compare(a.MaTL, maTl, true) == 0)
        //            if (a != null)
        //            {
        //                tailieu.Remove(a);
        //                Console.WriteLine("Tai lieu da duoc xoa");
        //            }
        //            else
        //                Console.Write("Không tồn tại mã tai lieu {0}", maTl);
        //        Console.ReadLine();
        //    }
        //}
        static void TimKiemTaiLieu( List<sach> dsSach, List<bao> dsBao, List<tapchi> dsTapChi)
        {
            //Console.Write("Loai tai lieu: ");
            //string loai = Console.ReadLine();
            Console.Write("ma tai lieu: ");
            string maTl = Console.ReadLine();
            foreach (sach a in dsSach)
            {
                if (String.Compare(a.MaTL, maTl, true) == 0 /*|| loai == "sach"*/)
                {
                        if (a != null)
                        {
                            Console.WriteLine("THÔNG TIN tai lieu");
                            a.Output();
                        }
                        else
                            Console.Write("Không tồn tại mã tai lieu {0}", maTl);
                    Console.ReadLine();
                }
            }
            foreach (bao a  in dsBao)
            {
                if (String.Compare(a.MaTL, maTl, true) == 0 /*|| loai == "sach"*/)
                {
                    if (a != null)
                    {
                        Console.WriteLine("THÔNG TIN tai lieu");
                        a.Output();
                    }
                    else
                        Console.Write("Không tồn tại mã tai lieu {0}", maTl);
                    Console.ReadLine();
                }
            }
            foreach (tapchi a in dsTapChi)
            {
                if (String.Compare(a.MaTL, maTl, true) == 0 /*|| loai == "sach"*/)
                {
                    if (a != null)
                    {
                        Console.WriteLine("THÔNG TIN tai lieu");
                        a.Output();
                    }
                    else
                        Console.Write("Không tồn tại mã tai lieu {0}", maTl);
                    Console.ReadLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Nhap Thong Tin Tai Lieu");
            Console.WriteLine("2.Hien thi Tai Lieu");
            Console.WriteLine("3.Tim Kiem Theo Tai Lieu");
            Console.WriteLine("4.Xoa tai lieu");
            List<TaiLieu> tailieu = new List<TaiLieu>();
            List<sach> dsSach = new List<sach>();
            List<tapchi> dsTapChi = new List<tapchi>();
            List<bao> dsBao = new List<bao>();
            int key;

            while (true)
            {
                key = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1.Nhap sach");
                        Console.WriteLine("2.Nhap bao");
                        Console.WriteLine("3.Nhap tap chi");
                        int q = Convert.ToInt32(Console.ReadLine());
                        switch (q)
                        {
                            case 1:
                                nhapsach(dsSach);
                                break;
                            case 2:
                                nhapbao(dsBao);
                                break;
                            case 3:
                                nhaptailieu(dsTapChi);
                                break;
                        }
                        break;
                    case 2:
                        Show(dsSach,dsBao,dsTapChi);
                        break;
                    case 3:
                        TimKiemTaiLieu(dsSach,dsBao,dsTapChi);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
