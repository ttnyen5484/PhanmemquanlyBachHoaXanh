using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BangGiaBLL
    {
        public BangGiaBLL()
        {

        }
        BangGiaDAL bg = new BangGiaDAL();
        public DataTable getGiaBanKM(string MaSP)
        {
            return bg.GetGiaBanKM(MaSP);
        }

        public DataTable loadBangGia()
        {
            return bg.loadBangGia();
        }

        public int GetGiaBan(string ma)
        {
            return bg.getGiaBan(ma);
        }

        public bool Insert(string masp, float giaban, float giaKM, DateTime ngayAD, string manv)
        {
            return bg.giamGia(masp, giaban, giaKM, ngayAD, manv);
        }
    }
}
