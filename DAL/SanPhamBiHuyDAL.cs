using DAL.DataBachHoaXanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamBiHuyDAL
    {
        BachHoaXanhLinQDataContext ds = new BachHoaXanhLinQDataContext();
        SanPhamBiHuyTableAdapter spbh = new SanPhamBiHuyTableAdapter();
        SanPhamTableAdapter sp = new SanPhamTableAdapter();

        HuyTamTableAdapter ht = new HuyTamTableAdapter();

        public DataTable GetData()
        {
            return spbh.GetData();
        }
        public DataTable GetDataHuyTam()
        {
            return ht.GetData();
        }
        public bool insertSP(string mahuy, string maSP, string maPN, string maNV, DateTime ngayHuy, string lyDo, int slh)
        {
            try
            {
                if (spbh.Insert(maSP, maPN, maNV, ngayHuy, lyDo, slh, mahuy) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }

        }
        public string layMaHuy()
        {
            try
            {
                return spbh.LayMaHuyMax().ToString();
            }
            catch
            {
                return null;
            }
        }
    }

}

