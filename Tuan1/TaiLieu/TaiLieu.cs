using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaiLieu
{
         class TaiLieu
        {
            public string MaTL { get; set; }
            public string TenNXB { get; set; }
            public int SoBPH { get; set; }

        public TaiLieu()
        {
            MaTL = TenNXB = "";
            SoBPH = 0;

        }
        public TaiLieu(string maTL, string tenNXB, int soBPH)
            {
                this.MaTL = maTL;
                this.TenNXB = tenNXB;
                this.SoBPH = soBPH;
            }
            public virtual void Input()
            {
                Console.Write("Nhap Ma Tai Lieu : ");
                MaTL = Console.ReadLine();
                Console.Write("Nhap Ten NXB : ");
                TenNXB = Console.ReadLine();
                Console.Write("Nhap  So Ban PH : ");
                SoBPH = Convert.ToInt32(Console.ReadLine());
            }
            public virtual void Output()
            {
                Console.WriteLine("Ma tai lieu: {0}", MaTL);
                Console.WriteLine("Ten NXB: {0}", TenNXB);
                Console.WriteLine("So BPH {0}:", SoBPH);
            }
        }
    }

