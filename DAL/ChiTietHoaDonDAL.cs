using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataBachHoaXanhTableAdapters;
using System.Windows.Forms;


namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        ChiTietHoaDonTableAdapter cthd = new ChiTietHoaDonTableAdapter();
        BachHoaXanhLinQDataContext bhx = new BachHoaXanhLinQDataContext();
        public ChiTietHoaDonDAL()
        {

        }
        public void GetCTHDTheoMaHD(DataGridView dgv,string MaHD)
        {
            var cthds = from cthd in bhx.ChiTietHoaDons join k in bhx.SanPhams on cthd.MaSP equals k.MaSP where cthd.MaHD == MaHD select new { msp = cthd.MaSP, tsp = k.TenSP,dvt=k.DVT, sl = cthd.SoLuong, gb = cthd.GiaBan, tt = cthd.ThanhTien };
            dgv.DataSource = cthds;
        }
        
        public bool themCTHD(string MaHD,string MaSP,int sl,float gb,float tt)
        {
            if (cthd.Insert(MaHD, MaSP, sl, gb, tt) > 0)
                return true;
            return false;
        }
        public bool xoa(string mahd,string masp)
        {
            if (cthd.DeleteQuery(mahd, masp) > 0)
                return true;
            return false;
        }
        public bool Sua(string Mahd, string masp, int sl, float tt)
        {
            if (cthd.UpdateQuery(sl, tt, Mahd, masp) > 0)
                return true;
            return false;
        }
        public int LaySL(string mahd, string masp)
        {
            return int.Parse( cthd.LaySLCu(mahd, masp).ToString());
        }
    }
}
