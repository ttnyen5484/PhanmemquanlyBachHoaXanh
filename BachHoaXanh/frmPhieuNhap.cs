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
    public partial class frmPhieuNhap : Form
    {
        List<DonNhapHang> list;
        public frmPhieuNhap()
        {
            InitializeComponent();
            list = new List<DonNhapHang>();
        }
        NhanVienBLL nv = new NhanVienBLL();
        SanPhamBLL sp = new SanPhamBLL();
        PhieuNhapBLL pn = new PhieuNhapBLL();
        BangGiaBLL bg = new BangGiaBLL();
        ChiTietPhieuNhapBLL ctpn = new ChiTietPhieuNhapBLL();
        ChiTietSanPhamBLL ctsp = new ChiTietSanPhamBLL();
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            txtTenNV.Text = nv.getTenNV(frmMain.TenDN);
            txtngaynhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dgvphieunhap.DataSource = pn.GetDataChuaNhap();
            dgvctpn.DataSource = ctpn.GetCTPN(txtmapn.Text);
            if (dgvphieunhap.RowCount == 0)
            {
                txtmapn.Text = string.Empty;
                dgvctpn.DataSource = ctpn.GetCTPN(txtmapn.Text);
                txthsd.Text = txtsl.Text = txtTinhTrangNhap.Text = txtTenNV.Text = txtTenSP.Text = txtnsx.Text = string.Empty;
            }
        }
        
        public string chuyendoingay(string ngay)
        {
            string[] kq = ngay.Split('-');
            string day = kq[0];
            string month = kq[1];
            string year = kq[2];
            return year + "-" + month + "-" + day;
        }
        
        private void dgvphieunhap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtmapn.Text = dgvphieunhap.CurrentRow.Cells[0].Value.ToString();
                txtTinhTrangNhap.Text = dgvphieunhap.CurrentRow.Cells[4].Value.ToString();
                dgvctpn.DataSource = ctpn.GetCTPN(dgvphieunhap.CurrentRow.Cells[0].Value.ToString());
                txtTenSP.Text = sp.layTenSanPham(dgvctpn.CurrentRow.Cells[1].Value.ToString());
                txtsl.Text = dgvctpn.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                return;
            }
        }

       

        private void btnCapNhatPhieuNhap_Click(object sender, EventArgs e)
        {
            if (pn.UpdateNhap(txtmapn.Text, DateTime.Today, frmMain.TenDN, "Đã nhập"))
            {
                int flag = 0;
                for (int i = 0; i < dgvctpn.RowCount; i++)
                {
                    string masp = dgvctpn.Rows[i].Cells[1].Value.ToString();
                    int slt = int.Parse(dgvctpn.Rows[i].Cells[2].Value.ToString());
                    if (ctsp.Insert(masp, txtmapn.Text, slt))
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }

                }
                if (flag == 1)
                {
                    frmPhieuNhap_Load(sender, e);

                    MessageBox.Show("Cập Nhật Thành công");
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        
    }

        private void dgvctpn_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenSP.Text = sp.layTenSanPham(dgvctpn.CurrentRow.Cells[1].Value.ToString());
                txtsl.Text = dgvctpn.CurrentRow.Cells[2].Value.ToString();
                txtnsx.Text = dgvctpn.CurrentRow.Cells[4].Value.ToString();
                txthsd.Text = dgvctpn.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
