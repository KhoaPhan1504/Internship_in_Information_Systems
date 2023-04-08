using System;

namespace tiendien

{
    class tiendien
    {
        float chisocu, chisomoi;
        double tongtien;
        /*public tiendien()
        {
            chisocu = 0; chisomoi = 0;
        }*/

        //Phuong thuc nhap 
        public void Nhap(out float chisocu, out float chisomoi)
        {
            Console.Write("Nhap he so chi so cu: ");
            chisocu = float.Parse(Console.ReadLine());
            Console.Write("Nhap he so chi so moi: ");
            chisomoi = float.Parse(Console.ReadLine());
        }

        //phuong thuc tinh tien
        public double TinhTien(float chisocu, float chisomoi)
        {
            float sodien = chisomoi - chisocu;
            if (sodien > 100)
                tongtien = 2000 * sodien;
            else if (100 < sodien && sodien <= 150)
                tongtien = 2500 * sodien;
            else if (150 < sodien && sodien <= 200)
                tongtien = 2800 * sodien;
            else
                tongtien = 3500 * sodien;
            return tongtien;
        }
        static void Main(string[] args)
        {
            float x = 0, y = 0;
            tiendien tt = new tiendien();
            tt.Nhap(out x, out y);
            double tongtien = tt.TinhTien(x, y);
            Console.Write("Tong tien phai tra la: " + tongtien);
            Console.Read();
        }
    }
}
