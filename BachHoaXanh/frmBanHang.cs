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
using ThuVien;

namespace BachHoaXanh
{
    public partial class frmBanHang : Form
    {
        List<DonBanHang> list;
        public frmBanHang()
        {
            InitializeComponent();
            list = new List<DonBanHang>();
        }
        TongTien tt = new TongTien();
        SanPhamBLL sp = new SanPhamBLL();
        BangGiaBLL bg = new BangGiaBLL();
        ChiTietSanPhamBLL ctsp = new ChiTietSanPhamBLL();
        HoaDonBLL hd = new HoaDonBLL();
        ChiTietHoaDonBLL cthd = new ChiTietHoaDonBLL();
        NhanVienBLL nv = new NhanVienBLL();
        SanPhamBiHuyBLL spbh = new SanPhamBiHuyBLL();
        public static string MaQL = string.Empty;
        public static string MaPN = string.Empty;
        public static string MaHuy = string.Empty;

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            txtTenNV.Text =nv.getTenNV(frmMain.TenDN);
            groupBox4.Visible = false;
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            txtTinhTrang.Text = "Chưa Thanh Toán";
            if (hd.LayMaHDMax() == string.Empty)
            {
                txtMaHD.Text = "HD01";
            }
            else
            {
                int hdmax = int.Parse(hd.LayMaHDMax().Trim());
                txtMaHD.Text = "HD0" + (hdmax + 1).ToString();
            }
            txtthoi.Text = txtKhachDua.Text = "";
            btnSua.Visible = btnXoa.Visible = false;
            txtMaSP.Text = txtDVT.Text = txtGiaBan.Text = txtSoLuong.Text = txtSoLuong.Text = txtThanhTien.Text = txtTenSanPham.Text = "";
            dem = 0;
            if (spbh.LayMaHuyMax() == null)
            {
                MaHuy = "HH01";
            }
            else
            {
                int hmax = int.Parse(spbh.LayMaHuyMax());
                MaHuy = "HH0" + (hmax + 1).ToString();
            }
            txtNgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            txtNgayGio.Enabled = false;
            txtMaSP.Select();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dr in bg.getGiaBanKM(txtMaSP.Text).Rows)
                {
                    if (dr["GiaKhuyenMai"].ToString() == string.Empty)
                    {
                        txtGiaBan.Text = dr["GiaBan"].ToString();
                    }
                    else
                    {
                        txtGiaBan.Text = dr["GiaKhuyenMai"].ToString();
                    }
                }
                foreach (DataRow dr in sp.GetSanPhamTheoMa(txtMaSP.Text).Rows)
                {
                    txtTenSanPham.Text = dr["TenSP"].ToString();
                    txtDVT.Text = dr["DVT"].ToString();
                }
                
            }
            catch
            {
                return;
            }
        }

        int index = -1;
        int slm = 0;
        int ttm = 0;
        public int kttrungdgv(string masp)
        {
            for (int i = 0; i < dgvBanHang.Rows.Count; i++)
            {
                if (masp == dgvBanHang.Rows[i].Cells[0].Value.ToString())
                {
                    index = i;
                    slm = int.Parse(dgvBanHang.Rows[i].Cells[3].Value.ToString());
                    ttm = int.Parse(dgvBanHang.Rows[i].Cells[5].Value.ToString());
                    return 1;
                }
            }
            return 0;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int slt = sp.LayTongSLT(txtMaSP.Text);
                int sln = int.Parse(txtSoLuong.Text);
                if (sln > slt)
                {
                    MessageBox.Show("Không đủ hàng rồi ạ!");
                }
                else
                {
                    float gb = float.Parse(txtGiaBan.Text);
                    txtThanhTien.Text = (gb * sln).ToString();
                }
            }
            catch
            {
                return;
            }

        }
        DataGridViewTextBoxColumn hd1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd5 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd6 = new DataGridViewTextBoxColumn();
        private void setupColumDGV()
        {
            dgvBanHang.Columns.Clear();
            // Column1
            // 
            dgvBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hd1.DataPropertyName = "msp";
            hd1.HeaderText = "Mã Sản Phẩm";
            hd1.Name = "Column1";
            hd1.DisplayIndex = 1;
            //hd1.Width = 100;
            hd1.ReadOnly = true;
            // 
            // Column2
            // 
            hd2.DataPropertyName = "tsp";
            hd2.HeaderText = "Tên Sản Phẩm";
            hd2.Name = "Column2";
            hd2.DisplayIndex = 2;
            // hd2.Width = 250;
            hd2.ReadOnly = true;
            // 
            // Column3
            // 
            hd3.DataPropertyName = "dvt";
            hd3.HeaderText = "Đơn Vị Tính";
            hd3.Name = "Column3";
            hd3.DisplayIndex = 3;
            hd3.ReadOnly = true;
            // 
            // Column4
            // 
            hd4.DataPropertyName = "sl";
            hd4.HeaderText = "Số Lượng";
            hd4.Name = "Column4";
            hd4.DisplayIndex = 4;
            hd4.ReadOnly = true;
            // hd3.Width = 100;
            // 
            // Column4
            // 
            hd5.DataPropertyName = "gb";
            hd5.HeaderText = "Giá Bán";
            hd5.Name = "Column5";
            hd5.DisplayIndex = 5;
            hd5.ReadOnly = true;
            //hd4.Width = 100;
            //
            // Column5
            // 
            hd6.DataPropertyName = "tt";
            hd6.HeaderText = "Thành Tiền";
            hd6.Name = "Column6";
            hd6.DisplayIndex = 6;
            hd6.ReadOnly = true;
            //hd5.Width = 100;
            //
            dgvBanHang.Columns.Add(hd1);
            dgvBanHang.Columns.Add(hd2);
            dgvBanHang.Columns.Add(hd3);
            dgvBanHang.Columns.Add(hd4);
            dgvBanHang.Columns.Add(hd5);
            dgvBanHang.Columns.Add(hd6);
            //
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == string.Empty)
            {
                MessageBox.Show("Mời nhập sản phẩm cần thanh toán!");
                return;
            }
            if (txtSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Mời nhập Số lượng Sản Phẩm!");
                return;
            }
            DonBanHang dbh = new DonBanHang();

            if (kttrungdgv(txtMaSP.Text) == 1)
            {
                list.RemoveAt(index);
                dbh.Msp = txtMaSP.Text;
                dbh.Tsp = txtTenSanPham.Text;
                dbh.Dvt = txtDVT.Text;
                dbh.Sl = int.Parse(txtSoLuong.Text) + slm;
                dbh.Gb = float.Parse(txtGiaBan.Text);
                dbh.Tt = float.Parse(txtThanhTien.Text) + ttm;
                list.Add(dbh);
                dgvBanHang.DataSource = null;
                setupColumDGV();
                dgvBanHang.DataSource = list;
                txtTongTien.Text = tt.tinhTongTien(dgvBanHang, 5).ToString();
                txtMaSP.Text = txtDVT.Text = txtGiaBan.Text = txtSoLuong.Text = txtSoLuong.Text = txtThanhTien.Text = txtTenSanPham.Text = "";
            }
            else
            {
                dbh.Msp = txtMaSP.Text;
                dbh.Tsp = txtTenSanPham.Text;
                dbh.Dvt = txtDVT.Text;
                dbh.Sl = int.Parse(txtSoLuong.Text);
                dbh.Gb = float.Parse(txtGiaBan.Text);
                dbh.Tt = float.Parse(txtThanhTien.Text);
                list.Add(dbh);
                dgvBanHang.DataSource = null;
                setupColumDGV();
                dgvBanHang.DataSource = list;
                txtTongTien.Text = tt.tinhTongTien(dgvBanHang, 5).ToString();
                txtMaSP.Text = txtDVT.Text = txtGiaBan.Text = txtSoLuong.Text = txtSoLuong.Text = txtThanhTien.Text = txtTenSanPham.Text = "";
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            if (hd.insert(txtMaHD.Text, DateTime.Now, float.Parse(txtTongTien.Text), "Đã thanh Toán", frmMain.TenDN))
            {
                string Mahd = txtMaHD.Text;
                txtTinhTrang.Text = "Đã thanh Toán";
                int flag = 0;
                for (int i = 0; i < dgvBanHang.RowCount; i++)
                {
                    string MaSP = dgvBanHang.Rows[i].Cells[0].Value.ToString();
                    int sl = int.Parse(dgvBanHang.Rows[i].Cells[3].Value.ToString());
                    float gb = float.Parse(dgvBanHang.Rows[i].Cells[4].Value.ToString());
                    float tt = float.Parse(dgvBanHang.Rows[i].Cells[5].Value.ToString());
                    if (cthd.insert(Mahd, MaSP, sl, gb, tt))
                    {
                        flag = 1;
                        string mapn = "";
                        int slt = 0;
                        foreach (DataRow dr in ctsp.LoadCTSPPN(MaSP).Rows)
                        {
                            mapn = dr["Expr1"].ToString();
                            slt = int.Parse(dr["SLTon"].ToString());
                        }
                        if (sl < slt)
                        {
                            if (ctsp.UpdateSLT(MaSP, mapn, sl))
                            {
                                flag = 1;
                            }
                            else
                            {
                                MessageBox.Show("Cập Nhật Thất Bại");
                            }
                        }
                        else if (sl == slt)
                        {

                            if (ctsp.UpdateSLT(MaSP, mapn, slt))
                            {

                                flag = 1;
                                if (ctsp.getSLT(MaSP, mapn) == 0)
                                {
                                    if (ctsp.Delete(MaSP, mapn))
                                    {
                                        flag = 1;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Xóa Thất Bại");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ahihi");
                                }
                            }
                        }
                        else
                        {
                            if (ctsp.UpdateSLT(MaSP, mapn, slt))
                            {
                                flag = 1;
                                if (ctsp.getSLT(MaSP, mapn) == 0)
                                {
                                    if (ctsp.Delete(MaSP, mapn))
                                    {
                                        flag = 1;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Xóa Thất Bại");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ahihi");
                                }
                                foreach (DataRow dr in ctsp.LoadCTSPPN(MaSP).Rows)
                                {
                                    mapn = dr["Expr1"].ToString();
                                }
                                if (ctsp.UpdateSLT(MaSP, mapn, sl - slt))
                                {
                                    flag = 1;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cập Nhật Thất Bại");
                            }
                        }
                        MaSP = "";
                        sl = 0;
                        gb = 0;
                        tt = 0;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
                if (flag == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    frmInHoaDon.MaHD = txtMaHD.Text;
                    frmInHoaDon frm = new frmInHoaDon();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thêm HD Thất Bại");
            }

        }

        int dem = 0;
        private void btnDoiTra_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem % 2 != 0)
            {
                frmDangNhapQL frm = new frmDangNhapQL();
                frm.ShowDialog();
            }
            if (MaQL != string.Empty)
            {
                if (dem % 2 != 0)
                {
                    groupBox4.Visible = true;
                    btnSua.Visible = btnXoa.Visible = true;
                }
                else
                {
                    groupBox4.Visible = false;
                    frmBanHang_Load(sender, e);
                }
            }
            else
            {
                frmBanHang_Load(sender, e);
                return;
            }
        }

        private void cbbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bthTaoMoi_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.Enabled)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn thanh toán không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                {
                    list.Clear();
                    dgvBanHang.DataSource = null;
                    setupColumDGV();
                    btnThanhToan.Enabled = true;
                    btnThem.Enabled = true;
                    //dgvBanHang.DataSource = list;
                    frmBanHang_Load(sender, e);
                    txtTongTien.ResetText();
                }
                else
                {
                    return;
                }

            }
            else
            {
                dgvBanHang.DataSource = null;
                setupColumDGV();
                btnThanhToan.Enabled = true;
                btnThem.Enabled = true;
                //dgvBanHang.DataSource = list;
                frmBanHang_Load(sender, e);
                txtTongTien.ResetText();
            }

        }
        public static int slc = 0;
        public static int slm2 = 0;
        public static string masp = string.Empty;
        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Text = dgvBanHang.CurrentRow.Cells[0].Value.ToString();
                txtTenSanPham.Text = dgvBanHang.CurrentRow.Cells[1].Value.ToString();
                txtDVT.Text = dgvBanHang.CurrentRow.Cells[2].Value.ToString();
                txtSoLuong.Text = dgvBanHang.CurrentRow.Cells[3].Value.ToString();
                txtGiaBan.Text = dgvBanHang.CurrentRow.Cells[4].Value.ToString();
                txtThanhTien.Text = dgvBanHang.CurrentRow.Cells[5].Value.ToString();
                slc = int.Parse(txtSoLuong.Text);
            }
            catch
            {
                return;
            }
            

        }
     
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                if (txttk.Text == string.Empty)
                {
                    MessageBox.Show("Mời bạn chọn hóa đơn cần xóa!");
                    return;
                }
                if (dgvBanHang.SelectedRows == null)
                {
                    MessageBox.Show("Mời bạn chọn dòng cần xóa!");
                    return;
                }
                int flag = 0;
                masp = txtMaSP.Text;
                if (cthd.Delete(txtMaHD.Text, txtMaSP.Text))
                {
                    if (hd.UpdateHD(txtMaHD.Text, MaQL, DateTime.Now))
                    {
                        DialogResult rr;
                        rr = MessageBox.Show("Bạn có muốn hủy sản phẩm " + txtTenSanPham.Text + " không?", "Xóa", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (rr == DialogResult.Yes)
                        {
                            frmLayMaPN frm = new frmLayMaPN();
                            frm.ShowDialog();
                            string Mapn = MaPN;
                            string mahuy = "";
                            if (spbh.LayMaHuyMax() == null)
                            {
                                mahuy = "HH01";
                            }
                            else
                            {
                                int hmax = int.Parse(spbh.LayMaHuyMax());
                                mahuy = "HH0" + (hmax + 1).ToString();
                            }
                            if (spbh.insertSP(mahuy, masp, Mapn, MaQL, DateTime.Now, "Sản Phẩm Lỗi", slc))
                            {
                                flag = 1;
                            }
                            else
                            {
                                MessageBox.Show("Hủy hàng thất bại");
                            }
                        }
                        else
                        {
                            frmLayMaPN frm = new frmLayMaPN();
                            frm.ShowDialog();
                            string Mapn = MaPN;
                            if (ctsp.UpdateSLTXaoSua(txtMaSP.Text, Mapn, slc))
                            {
                                flag = 1;
                            }
                            else
                            {
                                MessageBox.Show("Cập nhất số lượng thất bại");
                            }

                        }
                        if (flag == 1)
                        {
                            MessageBox.Show("Xóa thành công");
                            cthd.getCTHD(dgvBanHang, txtMaHD.Text);
                            txtTongTien.Text = tt.tinhTongTien(dgvBanHang, 5).ToString();
                            txtMaSP.Text = txtDVT.Text = txtGiaBan.Text = txtSoLuong.Text = txtSoLuong.Text = txtThanhTien.Text = txtTenSanPham.Text = "";
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                return;
            }
        }

        public void btnSua_Click(object sender, EventArgs e)
        {

            masp = txtMaSP.Text;
            if (txttk.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn hóa đơn cần xóa!");
                return;
            }
            if (dgvBanHang.SelectedRows == null)
            {
                MessageBox.Show("Mời bạn chọn dòng cần xóa!");
                return;
            }
            int flag = 0;
            if (cthd.Update(txtMaHD.Text, txtMaSP.Text, int.Parse(txtSoLuong.Text), float.Parse(txtThanhTien.Text)))
            {
                
                if (hd.UpdateHD(txtMaHD.Text, MaQL, DateTime.Now))
                {
                    flag = 1;
                    slm2 = int.Parse(txtSoLuong.Text);
                    DialogResult r;
                    r = MessageBox.Show("Bạn có muốn hủy sản phẩm " + txtTenSanPham.Text + " không?", "Xóa", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (r == DialogResult.Yes)
                    {
                        frmLayMaPN frm = new frmLayMaPN();
                        frm.ShowDialog();
                        string Mapn = MaPN;
                        string mahuy = "";
                        if (spbh.LayMaHuyMax() == null)
                        {
                            mahuy = "HH01";
                        }
                        else
                        {
                            int hmax = int.Parse(spbh.LayMaHuyMax());
                            mahuy = "HH0" + (hmax + 1).ToString();
                        }
                        if (spbh.insertSP(mahuy, masp, Mapn, MaQL, DateTime.Now, "Sản Phẩm Lỗi", slc - slm2))
                        {
                            flag = 1;
                        }
                        else
                        {
                            MessageBox.Show("Hủy hàng thất bại");
                        }
                    }
                    else
                    {
                        frmLayMaPN frm = new frmLayMaPN();
                        frm.ShowDialog();
                        string Mapn = MaPN;
                        if (ctsp.UpdateSLTXaoSua(txtMaSP.Text, Mapn, slc - slm2))
                        {
                            flag = 1;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhất số lượng thất bại");
                        }

                    }
                    if (flag == 1)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        cthd.getCTHD(dgvBanHang, txtMaHD.Text);
                        txtTongTien.Text = tt.tinhTongTien(dgvBanHang, 5).ToString();
                        txtMaSP.Text = txtDVT.Text = txtGiaBan.Text = txtSoLuong.Text = txtSoLuong.Text = txtThanhTien.Text = txtTenSanPham.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thất Bại");
                    }

                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        } 

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float kq = 0;
                kq = (float.Parse(txtKhachDua.Text) - float.Parse(txtTongTien.Text));
                if (kq < 0)
                {
                    txtthoi.Text = "";
                }
                else
                {
                    txtthoi.Text = kq.ToString();
                }
            }
            catch
            {
                return;
            }
        }
        

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnThanhToan.Enabled = false;
                cthd.getCTHD(dgvBanHang, txttk.Text.Trim());
                foreach (DataRow dr in hd.getHoaDontheoMa(txttk.Text.Trim()).Rows)
                {
                    txtMaHD.Text = dr["MaHD"].ToString();
                    txtNgayLap.Text = DateTime.Parse(dr["NgayLap"].ToString()).ToString("dd/MM/yyyy hh:mm");
                    txtTinhTrang.Text = dr["TrinhTrangTT"].ToString();
                }

                txtTongTien.Text = tt.tinhTongTien(dgvBanHang, 5).ToString();
                btnThem.Enabled = false;
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.FormBorderStyle = FormBorderStyle.Sizable;
            f.ShowDialog();

            
        }

        private void frmBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.F1)
            {
                btnDoiTra.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnThanhToan.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                bthTaoMoi.PerformClick();
            }
            else if (e.KeyCode == Keys.F11)
            {
                btnSua.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnXoa.PerformClick();
            }
            else
                return;
        }


    }
}
