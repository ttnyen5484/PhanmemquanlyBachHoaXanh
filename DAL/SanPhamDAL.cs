using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataBachHoaXanhTableAdapters;

namespace DAL
{
    public class SanPhamDAL
    {
        SanPhamTableAdapter sp = new SanPhamTableAdapter();
        public SanPhamDAL()
        {

        }
        public DataTable GetData()
        {
            return sp.GetData();
        }
        public DataTable getSanPham(string MaSP)
        {
            return sp.GetDataBydk(MaSP);
        }
        public int LayTongSLT(string MaSP)
        {
            return int.Parse(sp.LayTongSLTon(MaSP).ToString());
        }
        public string layTenSanPham(string masp)
        {
            return sp.layTenSP(masp);
        }

    }
}
