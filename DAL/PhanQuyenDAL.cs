using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataBachHoaXanhTableAdapters;
using System.Data;

namespace DAL
{
    public class PhanQuyenDAL
    {
        public PhanQuyenDAL()
        {

        }
        PhanQuyenTableAdapter pq = new PhanQuyenTableAdapter();
        public DataTable GetMaManHinh(string mabp)
        {
            return pq.GetDataByDSMH(mabp);
        }
    }
}
