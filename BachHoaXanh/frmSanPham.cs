using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace BachHoaXanh
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        SanPhamBLL sp = new SanPhamBLL();
        ChiTietSanPhamBLL ct = new ChiTietSanPhamBLL();
        LoaiSanPhamBLL lsp = new LoaiSanPhamBLL();
        QL_NguoiDung ql = new QL_NguoiDung();

        private void frmSanPham_Load(object sender, EventArgs e)
        {
           
            dgvDSSP.DataSource = sp.GetData();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == string.Empty)
            {
                dgvDSSP.DataSource = sp.GetData();
            }
            else
            {
                dgvDSSP.DataSource = ql.SearchSP(txtTimKiem.Text);

            }
        }

        private void dgvDSSP_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                string masp = dgvDSSP.CurrentRow.Cells[0].Value.ToString();
                dgvCTSP.DataSource = ct.GetSP(masp);
            }
            catch
            {
            }
        }
    }
}
