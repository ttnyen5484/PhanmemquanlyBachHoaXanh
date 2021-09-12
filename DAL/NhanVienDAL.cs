using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataBachHoaXanhTableAdapters;

namespace DAL
{
    public class NhanVienDAL
    {
        NhanVienTableAdapter nv = new NhanVienTableAdapter();
        public NhanVienDAL()
        {

        }
        public DataTable getNhanVien()
        {
            return nv.GetData();
        }

        public DataTable getNhanVienTheoMa(string ma)
        {
            return nv.GetDataByOnly(ma);
        }

        public DataTable getDN(string MaNV,string MK)
        {
            return nv.GetDataByKTDN(MaNV,MK);
        }
        public List<string> GetMaNhomNguoiDung(string MaNV)
        {
            List<string> kqMNND = new List<string>();
            DataTable dtkq = nv.GetDataByDSNND(MaNV);

            for (int i = 0; i < dtkq.Rows.Count; i++)
            {
                kqMNND.Add(dtkq.Rows[i].ItemArray[9].ToString());
            }

            return kqMNND;
        }
        public string getTenNV(string manv)
        {
            return nv.getTenNV(manv);
        }
    }
}
