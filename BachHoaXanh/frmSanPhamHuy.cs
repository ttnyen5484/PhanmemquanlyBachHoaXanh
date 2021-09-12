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
    public partial class frmSanPhamHuy : Form
    {
        public frmSanPhamHuy()
        {
            InitializeComponent();
        }
        SanPhamBiHuyBLL spbh = new SanPhamBiHuyBLL();
        ChiTietSanPhamBLL ctsp = new ChiTietSanPhamBLL();
        NhanVienBLL nv = new NhanVienBLL();
        SanPhamBLL sp = new SanPhamBLL();
        public static string maql;
        private void frmSanPhamHuy_Load(object sender, EventArgs e)
        {
            dgvDSSPHetHan.DataSource = spbh.GetDataHuyTam();
            dgvDSSPDaHuy.DataSource = spbh.GetData();


            if (spbh.LayMaHuyMax() == null)
            {
                txtMaHuy.Text = "HH01";
            }
            else
            {
                string kq = spbh.LayMaHuyMax().Trim();
                int hmax = int.Parse(kq);
                txtMaHuy.Text = "HH0" + (hmax + 1).ToString();
            }
            maql = frmMain.TenDN;

        }

        
        


       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (maql != null)
            {
                for (int i = 0; i < dgvDSSPHetHan.RowCount; i++)
                {
                    string mahuy = txtMaHuy.Text;
                    string tenNV = nv.getTenNV(maql);
                    string masp = dgvDSSPHetHan.Rows[i].Cells[2].Value.ToString();
                    string mapn = dgvDSSPHetHan.Rows[i].Cells[0].Value.ToString();
                    int slh = int.Parse(dgvDSSPHetHan.Rows[i].Cells[3].Value.ToString());
                    if (spbh.insertSP(mahuy, masp, mapn, frmMain.TenDN, DateTime.Now, "Hết hạn", slh))
                    {
                        if (ctsp.Delete(masp, mapn))
                        {
                            flag = 1;
                            masp = "";
                            mapn = "";
                            if (spbh.LayMaHuyMax() == null)
                            {
                                txtMaHuy.Text = "HH01";
                            }
                            else
                            {
                                int hmax = int.Parse(spbh.LayMaHuyMax());
                                txtMaHuy.Text = "HH0" + (hmax + 1).ToString();
                            }
                        }
                    }
                    else
                    {
                        flag = 0;
                    }
                }

            }
            else
            {
                flag = 0;
                MessageBox.Show("Chỉ quản lý mới được phép hủy hàng");
            }
            if (flag == 1)
            {
                MessageBox.Show("Hủy thành công");
                dgvDSSPDaHuy.DataSource = spbh.GetData();
                dgvDSSPHetHan.DataSource = spbh.GetDataHuyTam();
            }
            else
            {
                MessageBox.Show("Hủy Thất Bại");                              

            }
        }

        private void dgvDSSPHetHan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaSPHH.Text = sp.layTenSanPham(dgvDSSPHetHan.CurrentRow.Cells[2].Value.ToString());
                txtMaPNHH.Text = dgvDSSPHetHan.CurrentRow.Cells[0].Value.ToString();
                txtHSD.Text = DateTime.Parse(dgvDSSPHetHan.CurrentRow.Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
                txtSLTon.Text = dgvDSSPHetHan.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvDSSPDaHuy_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaHuy2.Text = dgvDSSPDaHuy.CurrentRow.Cells[6].Value.ToString();
                txtMaSPH.Text = sp.layTenSanPham(dgvDSSPDaHuy.CurrentRow.Cells[0].Value.ToString());
                txtMaPNH.Text = dgvDSSPDaHuy.CurrentRow.Cells[1].Value.ToString();

                txtTenNV.Text = nv.getTenNV(dgvDSSPDaHuy.CurrentRow.Cells[2].Value.ToString());
                txtNgayHuy.Text = DateTime.Parse(dgvDSSPDaHuy.CurrentRow.Cells[3].Value.ToString()).ToString("dd/MM/yyyy");
                txtLyDo.Text = dgvDSSPDaHuy.CurrentRow.Cells[4].Value.ToString();
                txtSLHuy.Text = dgvDSSPDaHuy.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}