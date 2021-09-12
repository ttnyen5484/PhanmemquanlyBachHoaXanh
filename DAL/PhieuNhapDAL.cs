using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataBachHoaXanhTableAdapters;

namespace DAL
{
    public class PhieuNhapDAL
    {
        public PhieuNhapDAL()
        {

        }
        PhieuNhapTableAdapter pn = new PhieuNhapTableAdapter();
        public DataTable GetData()
        {
            return pn.GetData();
        }
        public DataTable GetDataChuaNhap()
        {
            return pn.GetDataByTTN();
        }
        public bool Them(string MaPN, DateTime NgayNhap, double tongtien, string MaNV, string ttn)
        {
            try
            {
                if (pn.Insert(MaPN, NgayNhap, tongtien, MaNV, ttn) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }   
        }
        public bool SuaTongTien(string MaPN,double TongTien)
        {
            try
            {
                if (pn.UpdateTT(TongTien, MaPN) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public int LayMaMax()
        {
            try
            {
                return Convert.ToInt32(pn.LayMaMax());
            }
            catch
            {
                return 0;
            }
        }
        public bool UpdateNhap(string MaPN,DateTime NgayNhap,string MaNV, string ttn)
        {
            try
            {
                if (pn.UpdateQuery(NgayNhap, MaNV, ttn, MaPN) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
