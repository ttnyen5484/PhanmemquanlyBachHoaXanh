using DAL.DataBachHoaXanhTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiNhanVienDAL
    {
        LoaiNhanVienTableAdapter lnv = new LoaiNhanVienTableAdapter();
        public DataTable getLoaiNV()
        {
            return lnv.GetData();
        }
        public string layTenLoaiNV(string maLoaiNV)
        {
            return lnv.layTenLoaiNV(maLoaiNV);
        }
    }
}
