namespace BachHoaXanh
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNhanVIen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.khoHủySảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuQLNhanVIen,
            this.mnuQLSanPham,
            this.mnuQLPhieuNhap,
            this.mnuBanHang,
            this.doanhThuToolStripMenuItem,
            this.đĂNGXUẤTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(208, 750);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.AutoSize = false;
            this.mnuNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNhanVien.ForeColor = System.Drawing.Color.White;
            this.mnuNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuNhanVien.Image")));
            this.mnuNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(201, 50);
            this.mnuNhanVien.Tag = "MH001";
            this.mnuNhanVien.Text = "THÔNG TIN NHÂN VIÊN";
            this.mnuNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuQLNhanVIen
            // 
            this.mnuQLNhanVIen.AutoSize = false;
            this.mnuQLNhanVIen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQLNhanVIen.ForeColor = System.Drawing.Color.White;
            this.mnuQLNhanVIen.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLNhanVIen.Image")));
            this.mnuQLNhanVIen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuQLNhanVIen.Name = "mnuQLNhanVIen";
            this.mnuQLNhanVIen.Size = new System.Drawing.Size(201, 50);
            this.mnuQLNhanVIen.Tag = "MH002";
            this.mnuQLNhanVIen.Text = "QUẢN LÝ NHÂN VIÊN";
            this.mnuQLNhanVIen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuQLNhanVIen.Click += new System.EventHandler(this.mnuQLNhanVIen_Click);
            // 
            // mnuQLSanPham
            // 
            this.mnuQLSanPham.AutoSize = false;
            this.mnuQLSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLGia,
            this.mnuKhoHang,
            this.khoHủySảnPhẩmToolStripMenuItem});
            this.mnuQLSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQLSanPham.ForeColor = System.Drawing.Color.White;
            this.mnuQLSanPham.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSanPham.Image")));
            this.mnuQLSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuQLSanPham.Name = "mnuQLSanPham";
            this.mnuQLSanPham.Size = new System.Drawing.Size(201, 50);
            this.mnuQLSanPham.Tag = "MH003";
            this.mnuQLSanPham.Text = "QUẢN LÝ SẢN PHẨM";
            this.mnuQLSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuQLGia
            // 
            this.mnuQLGia.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLGia.Image")));
            this.mnuQLGia.Name = "mnuQLGia";
            this.mnuQLGia.Size = new System.Drawing.Size(180, 26);
            this.mnuQLGia.Tag = "MH004";
            this.mnuQLGia.Text = "Quản lý giá";
            this.mnuQLGia.Click += new System.EventHandler(this.mnuQLGia_Click);
            // 
            // mnuKhoHang
            // 
            this.mnuKhoHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuKhoHang.Image")));
            this.mnuKhoHang.Name = "mnuKhoHang";
            this.mnuKhoHang.Size = new System.Drawing.Size(180, 26);
            this.mnuKhoHang.Tag = "MH005";
            this.mnuKhoHang.Text = "Kho hàng";
            this.mnuKhoHang.Click += new System.EventHandler(this.mnuKhoHang_Click);
            // 
            // khoHủySảnPhẩmToolStripMenuItem
            // 
            this.khoHủySảnPhẩmToolStripMenuItem.Image = global::BachHoaXanh.Properties.Resources.out_of_stock;
            this.khoHủySảnPhẩmToolStripMenuItem.Name = "khoHủySảnPhẩmToolStripMenuItem";
            this.khoHủySảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.khoHủySảnPhẩmToolStripMenuItem.Tag = "MH006";
            this.khoHủySảnPhẩmToolStripMenuItem.Text = "Kho hàng hủy";
            this.khoHủySảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.khoHủySảnPhẩmToolStripMenuItem_Click);
            // 
            // mnuQLPhieuNhap
            // 
            this.mnuQLPhieuNhap.AutoSize = false;
            this.mnuQLPhieuNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQLPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.mnuQLPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhieuNhap.Image")));
            this.mnuQLPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuQLPhieuNhap.Name = "mnuQLPhieuNhap";
            this.mnuQLPhieuNhap.Size = new System.Drawing.Size(201, 50);
            this.mnuQLPhieuNhap.Tag = "MH007";
            this.mnuQLPhieuNhap.Text = "QUẢN LÝ PHIẾU NHẬP";
            this.mnuQLPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuQLPhieuNhap.Click += new System.EventHandler(this.mnuQLPhieuNhap_Click);
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.AutoSize = false;
            this.mnuBanHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBanHang.ForeColor = System.Drawing.Color.White;
            this.mnuBanHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuBanHang.Image")));
            this.mnuBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(201, 50);
            this.mnuBanHang.Tag = "MH008";
            this.mnuBanHang.Text = "BÁN HÀNG";
            this.mnuBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuBanHang.Click += new System.EventHandler(this.mnuBanHang_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.AutoSize = false;
            this.doanhThuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.doanhThuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.doanhThuToolStripMenuItem.Image = global::BachHoaXanh.Properties.Resources.artboard_123056;
            this.doanhThuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(201, 50);
            this.doanhThuToolStripMenuItem.Tag = "MH009";
            this.doanhThuToolStripMenuItem.Text = "DOANH THU";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            this.đĂNGXUẤTToolStripMenuItem.AutoSize = false;
            this.đĂNGXUẤTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.đĂNGXUẤTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.đĂNGXUẤTToolStripMenuItem.Image = global::BachHoaXanh.Properties.Resources.iconfinder_gnome_session_logout_28390;
            this.đĂNGXUẤTToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            this.đĂNGXUẤTToolStripMenuItem.Size = new System.Drawing.Size(195, 50);
            this.đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG XUẤT";
            this.đĂNGXUẤTToolStripMenuItem.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNhanVIen;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuQLGia;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoHang;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem khoHủySảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
    }
}