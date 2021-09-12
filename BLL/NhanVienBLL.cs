using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        public NhanVienBLL()
        {

        }
        NhanVienDAL nv = new NhanVienDAL();
        public DataTable getNhanVien()
        {
            return nv.getNhanVien();
        }

        public DataTable getNhanVienTheoMa(string ma)
        {
            return nv.getNhanVienTheoMa(ma);
        }
        public DataTable getDN(string manv,string mk)
        {
            return nv.getDN(manv, mk);
        }
        public List<string> getLoaiNV(string MaNV)
        {
            return nv.GetMaNhomNguoiDung(MaNV);
        }
        public string getTenNV(string manv)
        {
            return nv.getTenNV(manv);
        }
        
    }
}
