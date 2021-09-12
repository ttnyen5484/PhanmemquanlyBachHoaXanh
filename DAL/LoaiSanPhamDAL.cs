using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataBachHoaXanhTableAdapters;
using System.Data;

namespace DAL
{
    public class LoaiSanPhamDAL
    {
        LoaiSanPhamTableAdapter lsp = new LoaiSanPhamTableAdapter();
        public LoaiSanPhamDAL()
        {

        }
        public DataTable getLoaiSP()
        {
            return lsp.GetData();
        }
    }
}
