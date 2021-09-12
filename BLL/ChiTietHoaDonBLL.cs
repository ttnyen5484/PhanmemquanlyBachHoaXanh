using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        public ChiTietHoaDonBLL()
        {

        }
        ChiTietHoaDonDAL cthd = new ChiTietHoaDonDAL();
        public bool insert(string MaHD, string MaSP, int sl, float gb, float tt)
        {
            return cthd.themCTHD(MaHD, MaSP, sl, gb, tt);
        }
        public void getCTHD(DataGridView dgv,string MaHD)
        {
            cthd.GetCTHDTheoMaHD(dgv, MaHD);
        }
        public bool Delete(string MaHD,string MaSP)
        {
            return cthd.xoa(MaHD, MaSP);
        }
        public bool Update(string MaHD,string MaSP,int sl,float tt)
        {
            return cthd.Sua(MaHD, MaSP, sl, tt);
        }
        public int LaySL(string mahd, string masp)
        {
            return cthd.LaySL(mahd, masp);
        }
           
    }
}

