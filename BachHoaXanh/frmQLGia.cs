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
    public partial class frmQLGia : Form
    {
        //public static string MaQL = string.Empty;

        public frmQLGia()
        {
            InitializeComponent();
        }

        BangGiaBLL bg = new BangGiaBLL();
        ChiTietPhieuNhapBLL ctpn = new ChiTietPhieuNhapBLL();
        NhanVienBLL nv = new NhanVienBLL();

        private void frmQLGia_Load(object sender, EventArgs e)
        {
            dgvBangGia.DataSource = bg.loadBangGia();
            dgvDSSPGiamGia.DataSource = ctpn.GetDataByHSD();
            txtTenNV.Text = nv.getTenNV(frmMain.TenDN);
            txtNgayAD.Text = "";
            
        }

        private void dgvDSSPGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                string masp = dgvDSSPGiamGia.CurrentRow.Cells[1].Value.ToString();
                txtGiaBan.Text = bg.GetGiaBan(masp).ToString();
                DateTime hsd = DateTime.Parse(dgvDSSPGiamGia.CurrentRow.Cells[7].Value.ToString());
            }
            catch
            {
                return;
            }  
        }

     

        private void cboPercent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSSPGiamGia.SelectedRows != null || txtGiaBan.Text != null)
                {
                    float phantram = float.Parse(cboPercent.Text) / 100;
                    float giagiam = float.Parse(txtGiaBan.Text) - (float.Parse(txtGiaBan.Text) * phantram);
                    txtGiaSauKhiGiam.Text = giagiam.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 sản phẩm");
                }
            }
            catch
            {
                txtGiaSauKhiGiam.Text = "";
                return;
            }
        }

        private void cboPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSSPGiamGia.SelectedRows != null || txtGiaBan.Text != null)
                {
                    float phantram = float.Parse(cboPercent.Text) / 100;
                    float giagiam = float.Parse(txtGiaBan.Text) - (float.Parse(txtGiaBan.Text) * phantram);
                    txtGiaSauKhiGiam.Text = giagiam.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 sản phẩm");
                    return;
                }
            }
            catch
            {
                txtGiaSauKhiGiam.Text = "";
                return;
            }
        }

        private void btnCapNhatGia_Click(object sender, EventArgs e)
        {
            if (cboPercent.Text == string.Empty && txtNgayAD.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu đầy đủ");
                return;
            }
            if (txtNgayAD.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn ngày áp dụng");
                return;
            }
            if (cboPercent.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn mức phần trăm giảm");
                return;
            }
            if (txtGiaBan.Text == string.Empty || txtGiaSauKhiGiam.Text == string.Empty || txtTenNV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }
            if (int.Parse(cboPercent.Text) < 0)
            {
                MessageBox.Show("Phần trăm giảm phải lớn hơn 0!");
                return;
            }


            string masp = dgvDSSPGiamGia.CurrentRow.Cells[1].Value.ToString();
            float giaban = float.Parse(txtGiaBan.Text);
            float giaKM = float.Parse(txtGiaSauKhiGiam.Text);
            if (cboPercent.Text != null && dgvDSSPGiamGia.SelectedRows != null)
            {
                if (bg.Insert(masp, giaban, giaKM, DateTime.Parse(txtNgayAD.Text), frmMain.TenDN))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvDSSPGiamGia.Rows.RemoveAt(dgvDSSPGiamGia.CurrentRow.Index);
                    dgvBangGia.DataSource = bg.loadBangGia();
                }
                else
                {
                    MessageBox.Show("Thêm thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm để giảm giá");
            }
        }
    }
}
