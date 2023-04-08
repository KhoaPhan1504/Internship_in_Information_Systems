using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiLieu
{
     class bao:TaiLieu
    {
        public int NgayPH { get; set; }

        public bao()
        {
            NgayPH = 0;

        }
        public bao( int ngayPH)
        {
            this.NgayPH = ngayPH;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("ngay ph : ");
            NgayPH = Convert.ToInt32(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("ngay ph: {0}", NgayPH);
        }
    }
}
