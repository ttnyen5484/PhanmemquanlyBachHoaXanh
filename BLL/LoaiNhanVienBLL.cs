using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LoaiNhanVienBLL
    {
        LoaiNhanVienDAL lnv = new LoaiNhanVienDAL();
        public DataTable GetData()
        {
            return lnv.getLoaiNV();
        }
        public string layTenLoaiNV(string maLoaiNV)
        {
            return lnv.layTenLoaiNV(maLoaiNV);
        }
    }
}
