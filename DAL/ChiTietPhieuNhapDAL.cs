using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataBachHoaXanhTableAdapters;

namespace DAL
{
    public class ChiTietPhieuNhapDAL
    {
        public ChiTietPhieuNhapDAL()
        {

        }
        ChiTietPhieuNhapTableAdapter ct = new ChiTietPhieuNhapTableAdapter();
        CTPNTamTableAdapter ctt = new CTPNTamTableAdapter();

        public bool Them(string MaPN,string MaSP,int sl,double gianhap,double tt,string gc,DateTime nsx,DateTime hsd)
        {
            try
            {
                if (ct.Insert(MaPN, MaSP, sl, gianhap, tt, gc, nsx, hsd) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
      
        public DataTable GetCTPN(string mapn)
        {
            return ct.GetDataByMaPN(mapn);
        }

        public DataTable getSanPhamGiam()
        {
            return ct.GetDataByHSD();
        }
        public string layMaPN(string masp, DateTime nsx, DateTime hsd)
        { 
            return ct.GetDataByTimPN(masp, nsx.ToString().Substring(0, 10), hsd.ToString().Substring(0, 10)).ToString();
        }
        public string LayMaPn(string Masp, string nsx, string hsd)
        {
            try
            {
                return ct.LayMaPN(Masp, nsx, hsd).ToString();
            }
            catch
            {
                return null;
            }
        }
    }
}

