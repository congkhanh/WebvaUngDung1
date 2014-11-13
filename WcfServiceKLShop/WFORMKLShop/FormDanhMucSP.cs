using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFORMKLShop.ServiceReferenceDanhMucSP;

namespace WFORMKLShop
{
    public partial class FormDanhMucSP : Form
    {
        private ServiceDanhMucSPClient svdm = new ServiceDanhMucSPClient();
        public FormDanhMucSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormDanhMucSP_Load(object sender, EventArgs e)
        {
            btnsua.Visible = false;
            btnXoa.Visible = false;
            
            dvDanhMuc.AutoGenerateColumns = false;
            dvDanhMuc.DataSource = svdm.All();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            btnsua.Visible = false;
            btnXoa.Visible = false;
            btnthem.Visible = true;
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            txtMaDM.ReadOnly = false;

        }

        private void dvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            if (dvDanhMuc.SelectedRows.Count > 0)
            {
                btnsua.Visible = true;
                btnXoa.Visible = true;
                btnthem.Visible = false;
                txtMaDM.ReadOnly = true;
                DanhMucSP dm = (DanhMucSP)dvDanhMuc.SelectedRows[0].DataBoundItem;
                txtMaDM.Text = dm.MaDM.ToString();
                txtTenDM.Text = dm.TenDM.ToString();
                
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string madm = txtMaDM.Text;
            string tendm = txtTenDM.Text;
            svdm.SuaDanhMuc(madm,tendm);
            dvDanhMuc.DataSource = null;
            dvDanhMuc.AutoGenerateColumns = false;
            dvDanhMuc.DataSource = svdm.All();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string madm = txtMaDM.Text;
            svdm.XoaDanhMuc(madm);
            dvDanhMuc.DataSource = null;
            dvDanhMuc.AutoGenerateColumns = false;
            dvDanhMuc.DataSource = svdm.All();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string madm = txtMaDM.Text;
            string tendm = txtTenDM.Text;
            svdm.ThemDanhMuc(madm,tendm);
            dvDanhMuc.DataSource = null;
            dvDanhMuc.AutoGenerateColumns = false;
            dvDanhMuc.DataSource = svdm.All();
        }

    }
}
