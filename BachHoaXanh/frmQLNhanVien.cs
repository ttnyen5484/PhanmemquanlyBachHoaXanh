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
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        LoaiNhanVienBLL lnv = new LoaiNhanVienBLL();
        NhanVienBLL nv = new NhanVienBLL();
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {            
            dgvNhanVien.DataSource = nv.getNhanVien();            
        }      

       
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtNgaySinh.Text = DateTime.Parse(dgvNhanVien.CurrentRow.Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
                txtGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                txtNgayVaoLam.Text = DateTime.Parse(dgvNhanVien.CurrentRow.Cells[10].Value.ToString()).ToString("dd/MM/yyyy");
                txtCMT.Text = dgvNhanVien.CurrentRow.Cells[11].Value.ToString();
                txtLoaiNhanVien.Text = lnv.layTenLoaiNV(dgvNhanVien.CurrentRow.Cells[9].Value.ToString());


                pictureBox1.ImageLocation = @"D:\HK6\CongNghePhanMem\FormBachHoaXanh\Image\" + dgvNhanVien.CurrentRow.Cells[8].Value.ToString();

            }
            catch
            {

            }
        }

      
    }
}
