using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiLieu
{
     class tapchi:TaiLieu
    {
        public int SoPH { get; set; }
        public int ThangPH { get; set; }

        public tapchi()
        {
            SoPH = 0;
            ThangPH = 0;

        }
        public tapchi(int soPH, int thangPH)
        {
            this.SoPH = soPH;
            this.ThangPH = thangPH;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("So phat hanh : ");
            SoPH = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thang PH  : ");
            ThangPH= Convert.ToInt32(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("So phat hanh: {0}", SoPH);
            Console.WriteLine("Thang phat hanh: {0}", ThangPH);
        }
    }
}
