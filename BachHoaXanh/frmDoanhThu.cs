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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        HoaDonBLL hd = new HoaDonBLL();
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDoanhThuNgay_Click(object sender, EventArgs e)
        {
            string ngayLap = txtNgay.Text;
            dgvHoaDonNgay.DataSource = hd.timHDNgay(DateTime.Parse(ngayLap.ToString()));
            txtDoanhThuNgay.Text = hd.tinhDTNgay(DateTime.Parse(ngayLap.ToString())).ToString();
            string ngayTrongNgayLap = ngayLap.Substring(3, 2);
            int tam = int.Parse(ngayTrongNgayLap);
            for (int i = 1; i <= tam; i++)
            {
                string ngaytruocdo = ngayLap.Substring(0, 3) + i.ToString() + ngayLap.Substring(5, 5);
                double? dt = hd.tinhDTNgay(DateTime.Parse(ngaytruocdo));

                CHARTDOANHTHUNGAY.Series["ChartDoanhThu"].Points.AddXY(ngaytruocdo, dt);

            }
        }

        private void btnDoanhThuThang_Click(object sender, EventArgs e)
        {
            string ngayLap = txtNgay.Text;
            dgvHoaDonThang.DataSource = hd.timHDThang(DateTime.Parse(ngayLap.ToString()));
            txtDoanhThuThang.Text = hd.tinhDTThang(DateTime.Parse(ngayLap.ToString())).ToString();
            string thangTrongNgayLap = ngayLap.Substring(0, 2);
            //MessageBox.Show(thangTrongNgayLap);
            int tam = int.Parse(thangTrongNgayLap);
            for (int i = 1; i <= tam; i++)
            {
                string ngaytruocdo = i.ToString() + ngayLap.Substring(2, 8);
                double? dt = hd.tinhDTThang(DateTime.Parse(ngaytruocdo));
                if (i < 10)
                {
                    CHARTDOANHTHU2.Series["ChartDoanhThu2"].Points.AddXY(ngaytruocdo.Substring(0, 1) + ngaytruocdo.Substring(4, 5), dt);
                }
                else
                {
                    CHARTDOANHTHU2.Series["ChartDoanhThu2"].Points.AddXY(ngaytruocdo.Substring(0, 2) + ngaytruocdo.Substring(5, 5), dt);

                }
            }
        }
    }
}
