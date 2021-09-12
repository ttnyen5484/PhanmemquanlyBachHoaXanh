using DAL;
using DAL.DataBachHoaXanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBiHuyBLL
    {
        BachHoaXanhLinQDataContext ds = new BachHoaXanhLinQDataContext();
        SanPhamBiHuyTableAdapter sp = new SanPhamBiHuyTableAdapter();
        HuyTamTableAdapter ht = new HuyTamTableAdapter();
        SanPhamBiHuyDAL spbh = new SanPhamBiHuyDAL();
        public DataTable GetData()
        {
            return sp.GetData();
        }
        public DataTable GetDataHuyTam()
        {
            return ht.GetData();
        }
        public bool insertSP(string mahuy, string maSP, string maPN, string maNV, DateTime ngayHuy, string lyDo, int slh)
        {
            return spbh.insertSP(mahuy, maSP, maPN, maNV, ngayHuy, lyDo, slh);
        }
        public string LayMaHuyMax()
        {           
                return spbh.layMaHuy();            
        }
        //public int deleteSPHetHan(string maSP, string maPN)
        //{
        //    SanPhamBiHuy spbh = ds.SanPhamBiHuys.Single(k => k.MaPN == maPN && k.MaSP == maSP);
        //    ds.SanPhamBiHuys.DeleteOnSubmit(spbh);
        //    ds.SubmitChanges();
        //    return 1;
        //}
    }
}
