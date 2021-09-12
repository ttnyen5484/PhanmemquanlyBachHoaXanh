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
    public partial class frmDangNhapQL : Form
    {
        public frmDangNhapQL()
        {
            InitializeComponent();
        }
        NhanVienBLL nv = new NhanVienBLL();
        public string MaQL;
         
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach(DataRow dr in nv.getDN(txtmaql.Text,txtmk.Text).Rows)
            {
                if(dr["MaLoaiNV"].ToString().Trim()=="LNV01")
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            if(flag==1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmBanHang.MaQL = txtmaql.Text;
                frmSanPhamHuy.maql = txtmaql.Text;
               
               
                frmDangNhapQL frm = new frmDangNhapQL();
                frm.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDangNhapQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

      
    }
}
