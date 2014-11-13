using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFORMKLShop.ServiceReferenceUser;

namespace WFORMKLShop
{
    public partial class FormQLNguoiDung : Form
    {
        private ServiceUserClient svuser = new ServiceUserClient();
        public FormQLNguoiDung()
        {
            InitializeComponent();
            maskedtxtNgay.Mask = "00/00/0000";
        }

        private void FormQLNguoiDung_Load(object sender, EventArgs e)
        {
            btnxoa.Visible = false;
            btnsua.Visible = false;
            dvUser.AutoGenerateColumns = false;
            dvUser.DataSource = svuser.All();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            btnxoa.Visible = false;
            btnsua.Visible = false;
            btnthem.Visible = true;
            txtUser.ReadOnly = false;
            txtUser.Clear();
            txtPass.Clear();
            txtFullname.Clear();
            txtemail.Clear();
            txtDiaChi.Clear();
            txtsdt.Clear();
            //txtngay.Clear();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dvUser.SelectedRows.Count > 0)
            {
                btnxoa.Visible = true;
                btnsua.Visible = true;
                btnthem.Visible = false;
                txtUser.ReadOnly = true;

                User us = (User)dvUser.SelectedRows[0].DataBoundItem;
                txtUser.Text= us.IDUser;
                txtPass.Text = us.PassUser;
                txtFullname.Text = us.HoTenUser;
                txtemail.Text = us.Email;
                txtDiaChi.Text = us.DiaChi;
                txtsdt.Text = us.SoDienThoai;
                maskedtxtNgay.Text = us.Ngaysinh;
                //txtngay.Text = us.Ngaysinh;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa người dùng này !!!", "Sure?", MessageBoxButtons.YesNo)
          == DialogResult.Yes)
            {
                string id = txtUser.Text.ToString().Trim();
                svuser.XoaUser(id);
                dvUser.DataSource = null;
                dvUser.DataSource = svuser.All();
            }
            else
            { }
        }

        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static bool isValidSDT(string inputSDT)
        {
            string strRegex = @"^\d{10}$|^\d{11}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputSDT))
                return (true);
            else
                return (false);
        }

        private bool isValidNgaysinh()
        {
            if (maskedtxtNgay.MaskFull)
            {
                try
                {
                    DateTime.ParseExact(maskedtxtNgay.Text, "dd/MM/yyyy", null);
                    return (true);
                }
                catch
                {
                    //MessageBox.Show("Ngày không hợp lệ");
                    maskedtxtNgay.ResetText();
                    return (false);
                }
            }
            return false;
        }
        private bool IsDone()
        {

            if (this.txtUser.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập Username hợp lệ", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txtPass.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập Password hợp lệ", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txtFullname.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập Họ tên đầy đủ hợp lệ", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.txtDiaChi.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ hợp lệ", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!isValidSDT(this.txtsdt.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại hợp lệ", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!isValidNgaysinh())
            {
                MessageBox.Show("Vui lòng nhập Ngày sinh hợp lệ", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!isValidEmail(this.txtemail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email hợp lệ", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if (this.maskedtxtNgay.Text.ToString() == "  /  /")
            //{
            //    MessageBox.Show("Vui lòng nhập Ngày sinh", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!IsDone())
                return;
            string user = txtUser.Text.ToString();
            string pass = txtPass.Text.ToString();
            string fullname = txtFullname.Text.ToString();
            string email = txtemail.Text.ToString();
            string diachi = txtDiaChi.Text.ToString();
            string sdt = txtsdt.Text.ToString();
            //string ngaysinh = txtngay.Text.ToString();
            string ngaysinh = maskedtxtNgay.Text.ToString();
            int quyen = 1;
            svuser.AddUser(user,pass,fullname,email,diachi,sdt,ngaysinh,quyen);

            dvUser.DataSource = null;
            dvUser.DataSource = svuser.All();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToString();
            string pass = txtPass.Text.ToString();
            string fullname = txtFullname.Text.ToString();
            string email = txtemail.Text.ToString();
            string diachi = txtDiaChi.Text.ToString();
            string sdt = txtsdt.Text.ToString();
            string ngaysinh = maskedtxtNgay.Text.ToString();
            svuser.EditUser(user,user, pass, fullname, email, diachi, sdt, ngaysinh);
            MessageBox.Show("Sửa Thành Công");
            dvUser.DataSource = null;
            dvUser.DataSource = svuser.All();

        }
    }
}
