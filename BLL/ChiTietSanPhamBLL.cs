using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class ChiTietSanPhamBLL
    {
        ChiTietSanPhamDAL ctsp = new ChiTietSanPhamDAL();
        public ChiTietSanPhamBLL()
        {

        }
        public int getSLT(string MaSP,string MaPN)
        {
            return ctsp.getSoLuongTon(MaSP,MaPN);
        }
        public bool Insert(string MaSP,string MaPN,int SLTon)
        {
            return ctsp.Them(MaSP, MaPN, SLTon);
        }
        public DataTable GetSP(String Masp)
        {
            return ctsp.GetSP(Masp);
        }
        public DataTable LoadCTSPPN(string MaSP)
        {
            return ctsp.getCTSPPN(MaSP);
        }
        public bool UpdateSLT(string MaSP,string MaPN,int slt)
        {
            return ctsp.UpdateSLT(MaSP,MaPN,slt);
        }
        public bool UpdateSLTXaoSua(string MaSP, string MaPN, int slt)
        {
            return ctsp.UpdateSLTXS(MaSP, MaPN, slt);
        }
        public bool Delete(string MaSP, string MaPN)
        {
            return ctsp.Xoa(MaSP, MaPN);
        }
    }
}
