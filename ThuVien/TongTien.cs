using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ThuVien
{
    public class TongTien
    {
        public float tinhTongTien(DataGridView dgv, int cell)
        {
            float tongtien = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                tongtien += float.Parse(dgv.Rows[i].Cells[cell].Value.ToString());
            }
            return tongtien;
        }
    }
}
