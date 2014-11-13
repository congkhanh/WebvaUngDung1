using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WFORMKLShop.ServiceReferenceSanPham;
using WFORMKLShop.ServiceReferenceSanPhamCustom;
using WFORMKLShop.ServiceReferenceDanhMucSP;
using System.Text.RegularExpressions;
namespace WFORMKLShop
{
    public partial class FormSanPham : Form
    {
        private ServiceSanPhamClient svsp = new ServiceSanPhamClient();
        private ServiceSanPhamCustomClient svspc = new ServiceSanPhamCustomClient();
        private ServiceDanhMucSPClient svdm = new ServiceDanhMucSPClient();
        private string _hinh = "";
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
           
            btnsua.Visible = false;
            dvSanpham.AutoGenerateColumns = false;
            dvSanpham.DataSource = svspc.All();

            cboDanhmuc.DataSource = svdm.All();
            cboDanhmuc.DisplayMember = "TenDM";
            cboDanhmuc.ValueMember = "MaDM";

            var item = new[]
           {
                new { Text = "Còn Hiệu Lực", Value = "0" }, 
                new { Text = "Hết Hiệu Lực", Value = "1" },
                 
           };
            cboTrangthai.DataSource = item;
            cboTrangthai.DisplayMember = "Text";
            cboTrangthai.ValueMember = "value";
        }

        private void dvSanpham_SelectionChanged(object sender, EventArgs e)
        {
            if (dvSanpham.SelectedRows.Count > 0)
            {
                
                btnsua.Visible = true;
              
                btnthem.Visible = false;
                SanPhamCustom sp = (SanPhamCustom)dvSanpham.SelectedRows[0].DataBoundItem;
                txtmasp.Text = sp.MaSP.ToString();
                txtsoluong.Text = sp.SoLuong;
                txttensp.Text = sp.TenSP;
                txtMausac.Text = sp.MauSac;
                txtmota.Text = sp.MoTa;
                txtKichthuoc.Text = sp.KichThuoc;
                txtgia.Text = sp.Gia.ToString();
                txtha.Text = sp.HinhAnh.ToString();
                string urlHinh = "../../../MVCKLShop/Content/ImageSP/" + sp.HinhAnh;
                pichinhanh.Image = Image.FromFile(urlHinh);
                cboDanhmuc.Text = sp.TenDM;
                //int a = Int32.Parse(sp.TrangThai.ToString());
                //cboTrangthai.SelectedIndex = a;
               // int a = sp.TrangThai.Value;
                cboTrangthai.SelectedValue = sp.TrangThai.Value.ToString();
                
            }
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "file hinh|*.jpg|all file|*.*";
            dlg.InitialDirectory = @"E:\";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = dlg.FileNames;
                foreach (string i in tmp)
                {
                    FileInfo fi = new FileInfo(i);
                    string[] xxx = i.Split('\\');
                    string des = @"../../../MVCKLShop/Content/ImageSP/" + xxx[xxx.Length - 1];
                    File.Delete(des);

                    //over.
                    fi.CopyTo(des);
                    txtha.Text = "";
                    txtha.Text = des;
                    MessageBox.Show("Chọn hình ảnh thành công");
                    pichinhanh.Image = Image.FromFile(des);
                    _hinh = Path.GetFileName(des);
                }
            }
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
          
            btnsua.Visible = false;

            btnthem.Visible = true;
            txtha.Clear();
            txtKichthuoc.Clear();
            txtMausac.Clear();
            txtgia.Clear();
            txtmota.Clear();
            txttensp.Clear();
            pichinhanh.Image = null;
        }

        public static bool isValidSDT(string inputSDT)
        {
            string strRegex = @"^\d";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputSDT))
                return (true);
            else
                return (false);
        }
        private bool IsDone()
        {

            if (this.txttensp.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập Tên sản phẩm", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txtha.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txtKichthuoc.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập Kích thước", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txtMausac.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập Màu sắc", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!isValidSDT(this.txtgia.Text))
            {
                MessageBox.Show("Vui lòng nhập Giá tiền", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txtmota.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập Mô tả", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!IsDone())
                return;
            string tensp = txttensp.Text.ToString().Trim();
            string mota = txtmota.Text.ToString().Trim();
            string kichthuoc = txtKichthuoc.Text.ToString().Trim();
            string mausac = txtMausac.Text.ToString().Trim();
            string gia1 = txtgia.Text.ToString().Trim();
            decimal gia = decimal.Parse(gia1);
          //  decimal gia = decimal.Ceiling((decimal)gia2 + 0);
           
            string soluong = "0";
            string madm = cboDanhmuc.SelectedValue.ToString().Trim();
            string hinhanh = Path.GetFileName(txtha.Text);
            int trangthai = cboTrangthai.SelectedIndex;
            svsp.ThemSanPham(1,tensp,madm,gia,mota,kichthuoc,mausac,hinhanh,soluong, trangthai);

            dvSanpham.DataSource = null;
            dvSanpham.DataSource = svspc.All();
        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

   /*     private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này !!!", "Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
          
            {
                int masp = Int32.Parse(txtmasp.Text.ToString().Trim());
                svsp.XoaSanPham(masp);
                  dvSanpham.DataSource = null;
                   dvSanpham.DataSource = svspc.All();
            
            }
            else
            { }
            
        }*/

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(!IsDone())
            {
                return;
            }
            int masp = Int32.Parse( txtmasp.Text.Trim().ToString());
            string tensp = txttensp.Text.Trim().ToString();
            string mota = txtmota.Text.Trim().ToString();
            string kichthuoc = txtKichthuoc.Text.Trim().ToString();
            string mausac = txtMausac.Text.Trim().ToString();
            string gia1 = txtgia.Text.Trim().ToString();
            decimal gia = decimal.Parse(gia1);
          
            string soluong = txtsoluong.Text.ToString();
            string madm = cboDanhmuc.SelectedValue.ToString().Trim();
            
            string hinhanh = Path.GetFileName(txtha.Text);
            int trangthai = Int32.Parse( cboTrangthai.SelectedValue.ToString());
            svsp.SuaSanPham(masp,masp, tensp, madm, gia, mota, kichthuoc, mausac, hinhanh, soluong, trangthai);
            MessageBox.Show("Sửa Thành Công");
            dvSanpham.DataSource = null;
            dvSanpham.DataSource = svspc.All();
        }
    }
}
