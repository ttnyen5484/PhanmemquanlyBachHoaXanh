using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachHoaXanh
{
    public class DonNhapHang
    {
        string msp, tsp;
        int sl;
        double gn, tt;
        DateTime nsx, hsd;

        public DonNhapHang()
        {

        }

        public string Msp { get => msp; set => msp = value; }
        public string Tsp { get => tsp; set => tsp = value; }
        public int Sl { get => sl; set => sl = value; }
        public double Gn { get => gn; set => gn = value; }
        public double Tt { get => tt; set => tt = value; }
        public DateTime Nsx { get => nsx; set => nsx = value; }
        public DateTime Hsd { get => hsd; set => hsd = value; }
    }
}
