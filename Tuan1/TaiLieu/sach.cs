using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiLieu
{
     class sach : TaiLieu
    {
        public string TenTG { get; set; }
        public int SoTrang { get; set; }

        public sach()
        {
            TenTG = " ";
            SoTrang = 0;

        }
        public sach(string tenTG, int soTrang)
        {
            this.TenTG = tenTG;
            this.SoTrang = soTrang;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap ten tac gia: ");
            TenTG = Console.ReadLine();
            Console.Write("Nhap so trang : ");
            SoTrang = Convert.ToInt32(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Ten tac gia: {0}", TenTG);
            Console.WriteLine("So trang: {0}",SoTrang);
        }
    }
}
