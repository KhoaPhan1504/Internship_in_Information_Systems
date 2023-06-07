using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiền_điện
{
    class TinhTienDien
    {
        public double tinhTienDien(double chiSoCu, double chiSoMoi)
        {
            double chiSo = chiSoMoi - chiSoCu;
            double tongTien = 0;

            if (chiSo >= 50)
                tongTien = (chiSo - 50) * 1000 + 50 * 500;
            else
                tongTien = chiSo * 500;
            return tongTien;
        }
    }
}
