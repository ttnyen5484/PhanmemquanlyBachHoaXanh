using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hd = new HoaDonDAL();
        public HoaDonBLL()
        {

        }
        public DataTable getHoaDon()
        {
            return hd.getHD();
        }
        public string LayMaHDMax()
        {
            return hd.layMaHD();
        }
        public bool insert(string MaHD, DateTime NgayLap, float TongTien, string tTrang, string MaNV)
        {
            return hd.ThemHD(MaHD, NgayLap, TongTien, tTrang, MaNV);
        }
        public DataTable getHoaDontheoMa(string MaHD)
        {
            return hd.getHoaDontheoMaHD(MaHD);
        }
        public bool UpdateHD(string MaHD, string Manv, DateTime NgayLap)
        {
            return hd.CapNhat(MaHD, Manv, NgayLap);
        }
        public DataTable timHDNgay(DateTime ngayLap)
        {
            return hd.GetDataNgay(ngayLap);
        }
        public DataTable timHDThang(DateTime ngayLap)
        {
            return hd.GetDatThang(ngayLap);
        }
        public double? tinhDTNgay(DateTime ngaylap)
        {
            return hd.tinhDoanhThuNgay(ngaylap);
        }
        public double? tinhDTThang(DateTime ngaylap)
        {
            return hd.tinhDoanhThuThang(ngaylap);
        }
    }
}
