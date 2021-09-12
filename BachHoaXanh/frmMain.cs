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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        NhanVienBLL nv = new NhanVienBLL();
        PhanQuyenBLL ql = new PhanQuyenBLL();
        public static string TenDN = string.Empty;
        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            f.ShowDialog();
        }

        private void mnuQLGia_Click(object sender, EventArgs e)
        {
            frmQLGia f = new frmQLGia();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuKhoHang_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuQLPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void mnuQLNhanVIen_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f = new frmQLNhanVien();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(TenDN);
            List<string> nhomND = nv.getLoaiNV(TenDN);
            foreach (string item in nhomND)
            {
                DataTable dsQuyen = ql.getManHinh(item);
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.menuStrip1.Items, mh[0].ToString(), Convert.ToBoolean(mh[2].ToString()));
                }
            }
        }
        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach (ToolStripItem menu in mnuItems)
            {
                if (menu is ToolStripMenuItem && ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {

                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems, pScreenName, pEnable);
                    menu.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName.TrimEnd(), menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }

        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }

        private void khoHủySảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPhamHuy f = new frmSanPhamHuy();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Maximized;
            f.Show();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }
    }
}
