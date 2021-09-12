using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class PhanQuyenBLL
    {
        public PhanQuyenBLL()
        {

        }
        PhanQuyenDAL pq = new PhanQuyenDAL();
        public DataTable getManHinh(string MaBP)
        {
            return pq.GetMaManHinh(MaBP);
        }
    }
}
