using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class PhieuNhapBLL
    {
        PhieuNhapDAL pn = new PhieuNhapDAL();
        public PhieuNhapBLL()
        {

        }
        public DataTable GetData()
        {
            return pn.GetData();
        }
        public DataTable GetDataChuaNhap()
        {
            return pn.GetDataChuaNhap();
        }
        public bool Insert(string MaPN, DateTime NgayNhap, double tongtien, string MaNV, string ttn)
        {
            return pn.Them(MaPN, NgayNhap, tongtien, MaNV, ttn);
        }
        public int LayMaMax()
        {
            return pn.LayMaMax();
        }
        public bool UpdateTongTien(string MaPN,double Tongtien)
        {
            return pn.SuaTongTien(MaPN, Tongtien);
        }
        public bool UpdateNhap(string MaPN, DateTime NgayNhap, string MaNV, string ttn)
        {
            return pn.UpdateNhap(MaPN,NgayNhap,MaNV, ttn);
        }
    }
}
