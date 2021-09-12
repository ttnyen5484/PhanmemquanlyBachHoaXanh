using BLL;
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
    public partial class frmLayMaPN : Form
    {
        public frmLayMaPN()
        {
            InitializeComponent();
        }
        SanPhamBLL sp = new SanPhamBLL();
        ChiTietPhieuNhapBLL ct = new ChiTietPhieuNhapBLL();
        private string chuyenDoiNgay(string Ngay)
        {
            string[] kq = Ngay.Split('/');
            string day = kq[0];
            string month = kq[1];
            string year = kq[2];
            return year + "/" + month + "/" + day;
        }
        private void btnCapNhatGia_Click(object sender, EventArgs e)
        {
            try
            {
                frmBanHang.MaPN = ct.LayMaPN(comboBox1.SelectedValue.ToString(), chuyenDoiNgay(txtnsx.Text), chuyenDoiNgay(txthsd.Text));
                this.Close();
            }
            catch
            {
                return;
            }
        }

        private void frmLayMaPN_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = sp.GetData();
            comboBox1.DisplayMember = "TenSP";
            comboBox1.ValueMember = "MaSP";
            comboBox1.SelectedValue = frmBanHang.masp;
        }

        private void frmLayMaPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn lưu không?", "Lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
