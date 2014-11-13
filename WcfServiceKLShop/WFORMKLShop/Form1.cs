using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFORMKLShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thànhViênNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTin ftn = new FormThongTin();
            ftn.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham fsp = new FormSanPham();
            fsp.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormQLNguoiDung fuser = new FormQLNguoiDung();
            fuser.Show();
        }

        private void xemĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDonHang qldh = new FormQLDonHang();
            qldh.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLNhapHang nh = new FormQLNhapHang();
            nh.Show();
        }

        private void xemTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXemTonKho fxtk = new FormXemTonKho();
            fxtk.Show();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormDanhMucSP fdm = new FormDanhMucSP();
            fdm.Show();
        }
    }
}
