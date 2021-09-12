using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL sp = new SanPhamDAL();
        public SanPhamBLL()
        {

        }
        public DataTable GetData()
        {
            return sp.GetData();
        }
        public DataTable GetSanPhamTheoMa(string MaSP)
        {
            return sp.getSanPham(MaSP);
        }
        public int LayTongSLT(string MaSP)
        {
            return sp.LayTongSLT(MaSP);
        }
        public string layTenSanPham(string masp)
        {
            return sp.layTenSanPham(masp);
        }
    }
}
