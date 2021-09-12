using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataBachHoaXanhTableAdapters;

namespace DAL
{
    public class ChiTietSanPhamDAL
    {
        ChiTietSanPhamTableAdapter ctsp = new ChiTietSanPhamTableAdapter();
        BangTamCTSPTableAdapter bt = new BangTamCTSPTableAdapter();
        public ChiTietSanPhamDAL()
        {

        }
        public DataTable GetSP(string MaSP)
        {
            return bt.GetDataSP(MaSP);
        }
        public int getSoLuongTon(string MaSP, string MaPN)
        {
            return int.Parse(ctsp.LaySLT(MaSP, MaPN).ToString());
        }
        public bool Them(string Masp, string MaPN, int slt)
        {
            try
            {
                if (ctsp.Insert(Masp, MaPN, slt) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public DataTable getCTSPPN(string MaSP)
        {
            return bt.GetDataByDK(MaSP);
        }
        public bool UpdateSLT(string Masp, string MaPN, int slt)
        {
            try
            {
                if (ctsp.UpdateSLT(slt, Masp, MaPN) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateSLTXS(string Masp, string MaPN, int slt)
        {
            try
            {
                if (ctsp.UpdateSLTXoaSua(slt, Masp, MaPN) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Xoa(string MaSP, string MaPN)
        {
            try
            {
                if (ctsp.DeleteQuery(MaSP, MaPN) > 0)
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
