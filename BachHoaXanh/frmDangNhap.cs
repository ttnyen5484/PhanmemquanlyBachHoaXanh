using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanh
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("không được bỏ trống" + label1.Text.ToLower());
                txtMaNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMK.Text))
            {
                MessageBox.Show("Không được bỏ trống" + label2.Text.ToLower());
                this.txtMK.Focus();
                return;
            }
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }

            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }
        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txtMaNV.Text, txtMK.Text);
            //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == 10)
            {
                MessageBox.Show("Sai " + label1.Text + " Hoặc " +
                label2.Text);
                txtMaNV.ResetText();
                txtMK.ResetText();
                txtMaNV.Select();
                return;
            }
            // Account had been disabled
            else if (result == 20)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            frmMain frm = new frmMain();
            frmMain.TenDN = txtMaNV.Text;
            frmNhanVien.MK = txtMK.Text;
            frm.Show();
            this.Hide();

        }
        public void ProcessConfig()
        {
            //frmConfig frm = new frmConfig();
            //frm.Show();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMaNV.Select();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Tab)
            {
                txtMK.Select();
            }
            if(e.KeyCode==Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
