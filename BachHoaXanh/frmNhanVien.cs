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
    public partial class frmNhanVien : Form
    {
        
        NhanVienBLL nv = new NhanVienBLL();
        LoaiNhanVienBLL lnv = new LoaiNhanVienBLL();
        public static string MK = string.Empty;
        public frmNhanVien()
        {
            InitializeComponent();
            label2.BorderStyle = BorderStyle.Fixed3D;
        }

       

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = false;
            foreach (DataRow dr in nv.getNhanVienTheoMa(frmMain.TenDN).Rows)
            {
                txtMaNV.Text = dr["MaNV"].ToString();
                txtTenNV.Text = dr["TenNV"].ToString();
                txtNgaySinh.Text = DateTime.Parse(dr["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                txtGioiTinh.Text = dr["GioiTinh"].ToString();
                txtDiaChi.Text = dr["DiaChi"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                string tenLoaiNV = lnv.layTenLoaiNV(dr["MaLoaiNV"].ToString());
                txtMaLoaiNV.Text = tenLoaiNV;
                txtCMT.Text = dr["CMT"].ToString();
                txtNgayVaoLam.Text = DateTime.Parse(dr["NgayVL"].ToString()).ToString("dd/MM/yyyy");
                txtDienThoai.Text = dr["SDT"].ToString();
                txtMatKhau.Text = dr["MatKhau"].ToString();
                anhNV.ImageLocation = @"D:\HK6\CongNghePhanMem\FormBachHoaXanh\Image\" + dr["HinhNV"].ToString().Trim();
            }
        }

        private void btnPW_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                btnShowPass.Image = Image.FromFile(@"C:\Users\DELL\Pictures\ImageDoAnCNPM\blind1.png");
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                btnShowPass.Image = Image.FromFile(@"C:\Users\DELL\Pictures\ImageDoAnCNPM\view2.png");
            }
        }

        
    }
}
