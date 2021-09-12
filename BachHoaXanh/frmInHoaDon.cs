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
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
            
        }
        public static string MaHD = string.Empty;

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            ReportHoaDon rpt = new ReportHoaDon();
            rpt.SetDatabaseLogon("sa", "sa2012", "DESKTOP-S1N3U42\\SQLEXPRESS", "BachHoaXanhKi6");
            rpt.SetParameterValue("HD", MaHD);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Height = 700;
            crystalReportViewer1.Width = 1200;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Refresh();
        }
    }
}
