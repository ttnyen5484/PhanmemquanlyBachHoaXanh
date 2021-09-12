using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataBachHoaXanhTableAdapters;

namespace DAL
{
    public class BangGiaDAL
    {
        BangGiaTableAdapter bg = new BangGiaTableAdapter();
        public BangGiaDAL()
        {

        }
        public DataTable GetGiaBanKM(string MaSP)
        {
            return bg.GetDataByGia(MaSP);
        }

        public DataTable loadBangGia()
        {
            return bg.GetData();
        }

        public DataTable loadSPGiamGia(string masp)
        {
            return bg.GetDataByNgayAD(masp);
        }

        public int getGiaBan(string ma)
        {
            return int.Parse(bg.selectGiaBan(ma).ToString());
        }

        public bool giamGia(string masp, float giaban, float giaKM, DateTime ngayAD, string manv)
        {
            if (bg.Insert(masp, giaban, giaKM, ngayAD, manv) > 0)
                return true;
            return false;
        }

    }
}
