using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class ChiTietPhieuNhapBLL
    {
        public ChiTietPhieuNhapBLL()
        {

        }
        ChiTietPhieuNhapDAL ct = new ChiTietPhieuNhapDAL();
        public bool Insert(string MaPN, string MaSP, int sl, double gianhap, double tt, string gc, DateTime nsx, DateTime hsd)
        {
            return ct.Them(MaPN, MaSP, sl, gianhap, tt, gc, nsx, hsd);
        }

        public DataTable GetCTPN(string mapn)
        {
            return ct.GetCTPN(mapn);
        }

        public DataTable GetDataByHSD()
        {
            return ct.getSanPhamGiam();
        }
        public string layMaPhieuNhap(string masp, DateTime nsx, DateTime hsd)
        {           
            return ct.layMaPN(masp, nsx, hsd);
        }
        public string LayMaPN(string Masp, string nsx, string hsd)
        {
            return ct.LayMaPn(Masp, nsx, hsd);
        }
    }
}
