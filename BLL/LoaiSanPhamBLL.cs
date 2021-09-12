using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL lsp = new LoaiSanPhamDAL();
        public LoaiSanPhamBLL()
        {

        }
        public DataTable getLoaiSP()
        {
            return lsp.getLoaiSP();
        }
    }
}
