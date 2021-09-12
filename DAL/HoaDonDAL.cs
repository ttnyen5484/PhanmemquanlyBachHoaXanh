using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataBachHoaXanhTableAdapters;

namespace DAL
{
    public class HoaDonDAL
    {
        HoaDonTableAdapter hd = new HoaDonTableAdapter();
        public HoaDonDAL()
        {

        }
        public string layMaHD()
        {
            try
            {
                return hd.LayMaHDMax().ToString();
            }
            catch
            {
                return null;
            }
        }
        public DataTable getHD()
        {
            return hd.GetData();
        }
        public bool ThemHD(string MaHD,DateTime NgayLap,float TongTien,string tTrang,string MaNV)
        {
            try
            {
                if (hd.Insert(MaHD, NgayLap, TongTien, tTrang, MaNV) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }

        }
        public DataTable getHoaDontheoMaHD(string MaHD)
        {
            return hd.GetDataBydk(MaHD);
        }
        public bool CapNhat(string MaHD,string Manv,DateTime NgayLap)
        {
            try
            {
                if (hd.UpdateSuaXoa(NgayLap, Manv, MaHD) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public DataTable GetDataNgay(DateTime ngaylap)
        {
            return hd.GetDataByNgay(ngaylap);
        }
        public DataTable GetDatThang(DateTime ngaylap)
        {
            return hd.GetDataByThang(ngaylap);
        }
        public double? tinhDoanhThuNgay(DateTime ngaylap)
        {
            string nl = ngaylap.ToShortDateString();
            return hd.tinhTongTienNgay(DateTime.Parse(nl));
        }
        public double? tinhDoanhThuThang(DateTime ngaylap)
        {
            string nl = ngaylap.ToShortDateString();
            return hd.tinhTongTienThang(DateTime.Parse(nl));
        }



    }
}
